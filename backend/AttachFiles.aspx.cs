using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Data.SqlClient;
public partial class AttachFiles : System.Web.UI.Page
{
    public static int Order = 0;
    string File_type_Item;
    int radio_online1;
    int radio_offline1;
    protected void Page_Load(object sender, EventArgs e)
    {
        int session_article_no = Convert.ToInt16(Session["Article_No"]);


        //___________________________________________________selectDroupdown______________________
        SqlConnection coonn = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=G:\المجله\Full_projects\Editor\App_Data\Database_Journal.mdf;Integrated Security=True;User Instance=True");
        SqlCommand Attach_file_type = new SqlCommand("select * from File_Type", coonn);
        coonn.Close();
        coonn.Open();
        SqlDataReader reader_File_type = Attach_file_type.ExecuteReader();
        reader_File_type.Read();
        Dbl_File_Type.DataSource = reader_File_type;
        Dbl_File_Type.DataValueField = "File_Type_No";
        Dbl_File_Type.DataTextField = "File_Type_Name";
        Dbl_File_Type.DataBind();
        reader_File_type.Close();
        coonn.Close();





        SqlCommand Attach_file_comm = new SqlCommand("select File_No,File_Order,File_Description,File_Name,File_Size,File_Last_Modified,File_Links_Dowenload from Attach_Files where Article_No=@Article_No", coonn);
        Attach_file_comm.Parameters.Add("@Article_No", System.Data.SqlDbType.Int);
        Attach_file_comm.Parameters["@Article_No"].Value = session_article_no;
        coonn.Close();
        coonn.Open();
        SqlDataReader reader = Attach_file_comm.ExecuteReader();
        GridView_File.DataSource = reader;
        GridView_File.DataBind();
        coonn.Close();
        //______________________________selected____________________________ 
        SqlCommand Select_Attach_file_type = new SqlCommand("select File_Type_No from Attach_Files where Article_No=@Article_No ", coonn);
        Select_Attach_file_type.Parameters.Add("@Article_No", System.Data.SqlDbType.Int);
        Select_Attach_file_type.Parameters["@Article_No"].Value = session_article_no;
        coonn.Close();
        coonn.Open();
        SqlDataReader reader_Select_File_type = Select_Attach_file_type.ExecuteReader();
        if (reader_Select_File_type.Read())
        {
            File_type_Item = Convert.ToString(reader_Select_File_type["File_Type_No"]);
        }
        reader_Select_File_type.Close();
        coonn.Close();
        int select_index = -1;
        foreach (ListItem r in Dbl_File_Type.Items)
        {
            select_index = select_index + 1;
            if (r.Text.Equals(File_type_Item))
            {
                Dbl_File_Type.SelectedIndex = select_index;
            }



        }
    }
    protected void GridView_File_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        /*  if (e.CommandName == "File_Remove")
          {
              Session["Author_No"] = Convert.ToString(e.CommandArgument);
              int author_no13 = Convert.ToInt16(Session["Author_No"]);
              SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=G:\المجله\Full_projects\Editor\App_Data\Database_Journal.mdf;Integrated Security=True;User Instance=True");
              SqlCommand com = new SqlCommand("select * from Additional_Author where Author_No=@Author_No", conn);
              com.Parameters.Add("@Author_No", System.Data.SqlDbType.Int);
              com.Parameters["@Author_No"].Value = author_no13;
              conn.Close();
              conn.Open();
              SqlDataReader reader = com.ExecuteReader();
              reader.Read();
              txt_author_first_name.Text = Convert.ToString(reader["Author_First_Name"]);
              txt_author_middle_name.Text = Convert.ToString(reader["Author_Middle_Name"]);
              txt_author_E_mail_address.Text = Convert.ToString(reader["Author_Email_Address"]);
              txt_academic_degree.Text = Convert.ToString(reader["Author_Acadimic_Degree"]);
              txt_author_last_name.Text = Convert.ToString(reader["author_last_name"]);
              txt_author_affiliation.Text = Convert.ToString(reader["Author_Afilication"]);
              reader.Close();
              conn.Close();
              DialogResult masseg = MessageBox.Show("Confirm Author Delete", "Are you sure you want to remove this Author ", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
              if (masseg == DialogResult.Yes)
              {
                  SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=G:\المجله\Full_projects\Editor\App_Data\Database_Journal.mdf;Integrated Security=True;User Instance=True");
                  SqlCommand Author_comm = new SqlCommand("delete " +
                              "from Additional_Author where Author_No=@Author_No", con);
                  Author_comm.Parameters.Add("@Author_No", System.Data.SqlDbType.Int);
                  Author_comm.Parameters["@Author_No"].Value = author_no13;


                  con.Open();
                  Author_comm.ExecuteNonQuery();
                  con.Close();

              }
          }*/

    }
    protected void GridFile_Click(object sender, EventArgs e)
    {
        SqlConnection coonn = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=G:\المجله\Full_projects\Editor\App_Data\Database_Journal.mdf;Integrated Security=True;User Instance=True");
        Class1 ob = new Class1();

        int session_article_no = Convert.ToInt16(Session["article_no1"]);
        string fileName = "";
        string dowenload = "";
        Order++;

        //rrrrr.Text =Convert .ToString ( Path.GetFullPath(Uploader));
        string filetype = Dbl_File_Type.SelectedValue;
        int file_size = (int)Uploader.PostedFile.ContentLength;
        DateTime modify_date = DateTime.Now;


        if (Uploader.PostedFile.ContentLength != 0)
        {
            try
            {
                if (Uploader.PostedFile.ContentLength > 1048576)
                {
                    lblStatus.Text = "Too large. This file is not allowed";
                }
                else
                {
                    string destDir = Server.MapPath("./Upload");
                    fileName = Path.GetFileName(Uploader.PostedFile.FileName);
                    dowenload = MapPath(fileName);
                    string destPath = Path.Combine(destDir, fileName);
                    Uploader.PostedFile.SaveAs(destPath);
                    lblStatus.Text = "Thanks for submitting your file.";
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(Convert.ToString(err), "ERoRR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            if (radio_online.Checked == true)
            {
                radio_online1 = 1;
            }
            else
            {
                radio_online1 = 0;
            } if (radio_offline.Checked == true)
            {
                radio_offline1 = 1;
            }
            else
            {
                radio_offline1 = 0;
            }
            session_article_no = 6;
            String filetypeno = Dbl_File_Type.SelectedItem.Value;

            ob.attach_file(session_article_no, filetypeno, fileName, txt_description.Text, radio_online1, radio_offline1, file_size, modify_date, dowenload, Order);

            SqlDataReader reader;

            SqlCommand Attach_file_comm = new SqlCommand("select File_No ,File_Order,File_Description,File_Name,File_Size,File_Last_Modified,File_Links_Dowenload from Attach_Files where Article_No=@Article_No", coonn);
            Attach_file_comm.Parameters.Add("@Article_No", System.Data.SqlDbType.Int);
            Attach_file_comm.Parameters["@Article_No"].Value = session_article_no;
            coonn.Close();
            coonn.Open();
            reader = Attach_file_comm.ExecuteReader();

            GridView_File.DataSource = reader;
            GridView_File.DataBind();

            coonn.Close();
        }
        txt_description.Text = "";
        Dbl_File_Type.SelectedIndex.Equals(0);
    }
    protected void mdNext_Click(object sender, EventArgs e)
    {
        FunctionSumation ob = new FunctionSumation();
        SqlConnection connect;
        SqlCommand commands = new SqlCommand();
        SqlDataReader Read_Question;
        connect = ob.connect;
        int My_No = Convert.ToInt16(Session["User_No"]);

        int article_No = Convert.ToInt16(Session["Article_No"]);

        DateTime time = new DateTime();
        time = DateTime.Now;

        // Current Status 


        //    try
        //   {
        connect.Close();

        connect.Open();
        commands.Connection = connect;
        commands.CommandText = " update Current_Status " +
            " set Current_Status_Name ='Edit Submission',Current_Status_Date=@Current_Status_Date " +
            " where Article_No=@Article_No ";

        commands.Parameters.Add("@Current_Status_Date", System.Data.SqlDbType.DateTime);
        commands.Parameters["@Current_Status_Date"].Value = time;
        commands.Parameters.Add("@Article_No", System.Data.SqlDbType.Int);
        commands.Parameters["@Article_No"].Value = article_No;
        commands.ExecuteNonQuery();

        commands.Parameters.Clear();


        // And status_Users



        commands.CommandText = "select Status.Status_No from  Status where  " +
                                 "  Status.Status_Name LIKE 'Edit Submission'";
        Read_Question = commands.ExecuteReader();
        Read_Question.Read();
        int Status_Nom = (int)Read_Question[0];
        Read_Question.Close();
        commands.Parameters.Clear();

        commands.CommandText = "insert into Article_Status_Users ( Status_No ,User_No,Status_Date,Article_No )" +
            "values(@Status_No,@User_No,@Status_Date,@Article_No) ";

        commands.Parameters.Add("@Status_No", System.Data.SqlDbType.Int);
        commands.Parameters["@Status_No"].Value = Status_Nom;
        commands.Parameters.Add("@User_No", System.Data.SqlDbType.Int);
        commands.Parameters["@User_No"].Value = My_No;
        commands.Parameters.Add("@Status_Date", System.Data.SqlDbType.DateTime);
        commands.Parameters["@Status_Date"].Value = time;
        commands.Parameters.Add("@Article_No", System.Data.SqlDbType.Int);
        commands.Parameters["@Article_No"].Value = article_No;
        commands.ExecuteNonQuery();
        commands.Parameters.Clear();

    }
}
