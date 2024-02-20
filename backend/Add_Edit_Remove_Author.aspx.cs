using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Windows.Forms;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Data.SqlClient;
public partial class Add_Edit_Remove_Author : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        int session_article_no = Convert.ToInt16(Session["article_no1"]);

        session_article_no = 6;

        // int session_article_no = Convert.ToInt16(Session["article_no1"]);
        SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=G:\المجله\Full_projects\Editor\App_Data\Database_Journal.mdf;Integrated Security=True;User Instance=True");
        SqlCommand com = new SqlCommand("select Author_No,Author_First_Name,Author_Middle_Name,Author_Last_Name,Author_Acadimic_Degree,Author_Afilication,Author_Email_Address from Additional_Author where Article_No=@Article_No ", conn);
        com.Parameters.Add("@Article_No", System.Data.SqlDbType.Int);
        com.Parameters["@Article_No"].Value = session_article_no;
        try
        {
            conn.Close();
            conn.Open();
            SqlDataReader reader = com.ExecuteReader();
            GrdAuthor.DataSource = reader;
            GrdAuthor.DataBind();
            reader.Close();
            conn.Close();
        }
        catch { }



    }
    protected void txt_author_first_name_TextChanged(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        int session_article_no = 6;
        Class1 ob = new Class1();
        // int session_article_no = Convert.ToInt16(Session["article_no1"]);// رقم المقاله الحاليه
        // SqlDataReader reader;
        SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=G:\المجله\Full_projects\Editor\App_Data\Database_Journal.mdf;Integrated Security=True;User Instance=True");
        int article_corresponding_author1 = 3;// 


        // if (is_coresponding == 0)
        // {
        if (chcorrespondingauthor.Checked)
        {
            DialogResult msgbox = MessageBox.Show("There are corresponding Author is selected for this Article. Would you chinge him? ", "Confirm Corresponding chinge", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (msgbox == DialogResult.Yes)
            {
                //  is_coresponding = 1;
                ob.add_edit_remove_author(session_article_no, article_corresponding_author1, txt_author_first_name.Text, txt_author_middle_name.Text, txt_author_last_name.Text, txt_academic_degree.Text, txt_author_affiliation.Text, txt_author_E_mail_address.Text);
                ////Author_No,Author_First_Name,Author_Middle_Name,Author_Last_Name,Author_Acadimic_Degree,Author_Afilication,Author_Email_Address from Additional_Author where Article_No
                SqlCommand com = new SqlCommand("select Author_No,Author_First_Name,Author_Middle_Name,Author_Last_Name,Author_Acadimic_Degree,Author_Afilication,Author_Email_Address from Additional_Author where Article_No=@Article_No ", conn);
                com.Parameters.Add("@article_no", System.Data.SqlDbType.Int);
                com.Parameters["@article_no"].Value = session_article_no;
                conn.Close();
                conn.Open();
                SqlDataReader reader = com.ExecuteReader();
                // reader.Read();
                //ppp.Text = Convert.ToString(reader["author_first_name"]);
                GrdAuthor.DataSource = reader;
                GrdAuthor.DataBind();
                reader.Close();
                conn.Close();

                SqlCommand author_no1 = new SqlCommand("select Author_First_Name,Author_Email_Address from Additional_Author where  Author_First_Name=@Author_First_Name and Author_Email_Address=@Author_Email_Address", conn);

                author_no1.Parameters.Add("@Author_First_Name", System.Data.SqlDbType.NVarChar, 50);
                author_no1.Parameters["@Author_First_Name"].Value = txt_author_first_name.Text;
                author_no1.Parameters.Add("@Author_Email_Address", System.Data.SqlDbType.NVarChar, 50);
                author_no1.Parameters["@Author_Email_Address"].Value = txt_author_E_mail_address.Text;
                conn.Close();
                conn.Open();
                SqlDataReader author_no2 = author_no1.ExecuteReader();
                author_no2.Read();
                string author_no3 = Convert.ToString(author_no2["Author_First_Name"]);
                string author_no4 = Convert.ToString(author_no2["Author_Email_Address"]);
                author_no2.Close();
                conn.Close();

                //******************************************
                SqlCommand user_no1 = new SqlCommand("select User_No,User_First_Name,User_Email_Address from Users where  User_First_Name=@User_First_Name and User_Email_Address=@User_Email_Address", conn);
                user_no1.Parameters.Add("@User_First_Name", System.Data.SqlDbType.NVarChar, 50);
                user_no1.Parameters["@User_First_Name"].Value = author_no3;
                user_no1.Parameters.Add("@User_Email_Address", System.Data.SqlDbType.NVarChar, 50);
                user_no1.Parameters["@User_Email_Address"].Value = author_no4;
                int user_no31;
                string user_no4;
                string user_no3;
                conn.Close();
                conn.Open();
                SqlDataReader user_no2 = user_no1.ExecuteReader();

                if (user_no2.Read())
                {
                    user_no31 = Convert.ToInt16(user_no2["User_No"]);
                    user_no3 = Convert.ToString(user_no2["User_First_Name"]);
                    user_no4 = Convert.ToString(user_no2["User_Email_Address"]);
                    user_no2.Close();
                    conn.Close();
                    //string y = Convert.ToString(user_no31);
                    lpl.Text = author_no3 + "         " + author_no4 + "  " + user_no31 + "   " + user_no3 + "   " + user_no4;
                    // if ((author_no3 == user_no3) && (author_no4 == user_no4))
                    //{
                    SqlCommand author_corresponding = new SqlCommand("update Articles set Article_Corresponding_Author_No=@Article_Corresponding_Author_No where Article_No=@Article_No ", conn);

                    author_corresponding.Parameters.Add("@Article_Corresponding_Author_No", System.Data.SqlDbType.Int);
                    author_corresponding.Parameters["@Article_Corresponding_Author_No"].Value = user_no31;
                    author_corresponding.Parameters.Add("@Article_No", System.Data.SqlDbType.Int);
                    author_corresponding.Parameters["@Article_No"].Value = session_article_no;
                    conn.Close();
                    conn.Open();
                    author_corresponding.ExecuteNonQuery();
                    conn.Close();


                }


                else
                {
                    // MessageBox.Show("");
                    //  Response.Write(" the Author that selected can't register in this journal");

                    MessageBox.Show("the Author that selected can't register in this journal", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Question);

                }

            }
            else
            {
            }
        }//2

        else
        {
            ob.add_edit_remove_author(session_article_no, article_corresponding_author1, txt_author_first_name.Text, txt_author_middle_name.Text, txt_author_last_name.Text, txt_academic_degree.Text, txt_author_affiliation.Text, txt_author_E_mail_address.Text);
            SqlCommand com = new SqlCommand("select Author_No,Author_First_Name,Author_Middle_Name,Author_Last_Name,Author_Acadimic_Degree,Author_Afilication,Author_Email_Address from Additional_Author where article_no=@article_no ", conn);
            com.Parameters.Add("@article_no", System.Data.SqlDbType.Int);
            com.Parameters["@article_no"].Value = session_article_no;
            conn.Close();
            conn.Open();
            SqlDataReader reader = com.ExecuteReader();
            GrdAuthor.DataSource = reader;
            GrdAuthor.DataBind();
            reader.Close();
            conn.Close();

        }

        txt_author_first_name.Text = "";
        txt_author_last_name.Text = "";
        txt_author_middle_name.Text = "";
        txt_author_E_mail_address.Text = "";
        txt_author_affiliation.Text = "";
        txt_academic_degree.Text = "";
        chcorrespondingauthor.Checked = false;
    }
    protected void GrdAuthor_RowCommand(object sender, GridViewCommandEventArgs e)
    {

        if (e.CommandName == "Remove_Author")
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
        }
        //Edit_Author 
        if (e.CommandName == "Edit_Author")
        {
            DialogResult masseg1 = MessageBox.Show("Confirm Edit Author ", "Are you sure you want to Edit This Author ", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
            if (masseg1 == DialogResult.Yes)
                Session["Author_No"] = Convert.ToString(e.CommandArgument);
            int author_no = Convert.ToInt16(Session["Author_No"]);
            SqlConnection connect = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=G:\المجله\Full_projects\Editor\App_Data\Database_Journal.mdf;Integrated Security=True;User Instance=True");
            SqlCommand commands = new SqlCommand("select * from Additional_Author where Author_No=@Author_No", connect);
            commands.Parameters.Add("@Author_No", System.Data.SqlDbType.Int);
            commands.Parameters["@Author_No"].Value = author_no;
            connect.Close();
            connect.Open();
            SqlDataReader sql_reader = commands.ExecuteReader();
            sql_reader.Read();
            txt_author_first_name.Text = Convert.ToString(sql_reader["Author_First_Name"]);
            txt_author_middle_name.Text = Convert.ToString(sql_reader["Author_Middle_Name"]);
            txt_author_E_mail_address.Text = Convert.ToString(sql_reader["Author_Email_Address"]);
            txt_academic_degree.Text = Convert.ToString(sql_reader["Author_Acadimic_Degree"]);
            txt_author_last_name.Text = Convert.ToString(sql_reader["author_last_name"]);
            txt_author_affiliation.Text = Convert.ToString(sql_reader["Author_Afilication"]);
            sql_reader.Close();
            connect.Close();

        }

    }


    protected void Button4_Click(object sender, EventArgs e)
    {
        int author_no = Convert.ToInt16(Session["Author_No"]);
        Response.Write(author_no);
        int session_article_no = 6;
        Class1 ob = new Class1();
        // int session_article_no = Convert.ToInt16(Session["article_no1"]);// رقم المقاله الحاليه
        // SqlDataReader reader;
        SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=G:\المجله\Full_projects\Editor\App_Data\Database_Journal.mdf;Integrated Security=True;User Instance=True");



        // if (is_coresponding == 0)
        // {
        if (chcorrespondingauthor.Checked)
        {
            DialogResult msgbox = MessageBox.Show("There are corresponding Author is selected for this Article. Would you change him? ", "Confirm Corresponding chinge", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (msgbox == DialogResult.Yes)
            {

                ob.update_edit_remove_author(author_no, session_article_no, txt_author_first_name.Text, txt_author_middle_name.Text, txt_author_last_name.Text, txt_academic_degree.Text, txt_author_affiliation.Text, txt_author_E_mail_address.Text);
                ////Author_No,Author_First_Name,Author_Middle_Name,Author_Last_Name,Author_Acadimic_Degree,Author_Afilication,Author_Email_Address from Additional_Author where Article_No
                SqlCommand com = new SqlCommand("select Author_No,Author_First_Name,Author_Middle_Name,Author_Last_Name,Author_Acadimic_Degree,Author_Afilication,Author_Email_Address from Additional_Author where Article_No=@Article_No ", conn);
                com.Parameters.Add("@article_no", System.Data.SqlDbType.Int);
                com.Parameters["@article_no"].Value = session_article_no;
                conn.Close();
                conn.Open();
                SqlDataReader reader = com.ExecuteReader();
                // reader.Read();
                //ppp.Text = Convert.ToString(reader["author_first_name"]);
                GrdAuthor.DataSource = reader;
                GrdAuthor.DataBind();
                reader.Close();
                conn.Close();

                SqlCommand author_no1 = new SqlCommand("select Author_First_Name,Author_Email_Address from Additional_Author where  Author_First_Name=@Author_First_Name and Author_Email_Address=@Author_Email_Address", conn);

                author_no1.Parameters.Add("@Author_First_Name", System.Data.SqlDbType.NVarChar, 50);
                author_no1.Parameters["@Author_First_Name"].Value = txt_author_first_name.Text;
                author_no1.Parameters.Add("@Author_Email_Address", System.Data.SqlDbType.NVarChar, 50);
                author_no1.Parameters["@Author_Email_Address"].Value = txt_author_E_mail_address.Text;
                conn.Close();
                conn.Open();
                SqlDataReader author_no2 = author_no1.ExecuteReader();
                author_no2.Read();
                string author_no3 = Convert.ToString(author_no2["Author_First_Name"]);
                string author_no4 = Convert.ToString(author_no2["Author_Email_Address"]);
                author_no2.Close();
                conn.Close();

                //******************************************
                SqlCommand user_no1 = new SqlCommand("select User_No,User_First_Name,User_Email_Address from Users where  User_First_Name=@User_First_Name and User_Email_Address=@User_Email_Address", conn);
                user_no1.Parameters.Add("@User_First_Name", System.Data.SqlDbType.NVarChar, 50);
                user_no1.Parameters["@User_First_Name"].Value = author_no3;
                user_no1.Parameters.Add("@User_Email_Address", System.Data.SqlDbType.NVarChar, 50);
                user_no1.Parameters["@User_Email_Address"].Value = author_no4;
                int user_no31;
                string user_no4;
                string user_no3;
                conn.Close();
                conn.Open();
                SqlDataReader user_no2 = user_no1.ExecuteReader();

                if (user_no2.Read())
                {
                    user_no31 = Convert.ToInt16(user_no2["User_No"]);
                    user_no3 = Convert.ToString(user_no2["User_First_Name"]);
                    user_no4 = Convert.ToString(user_no2["User_Email_Address"]);
                    user_no2.Close();
                    conn.Close();
                    //string y = Convert.ToString(user_no31);
                    lpl.Text = author_no3 + "         " + author_no4 + "  " + user_no31 + "   " + user_no3 + "   " + user_no4;
                    //  if ((author_no3.Equals( user_no3)) && (author_no4.Equals(user_no4)))
                    //  {
                    SqlCommand author_corresponding = new SqlCommand("update Articles set Article_Corresponding_Author_No=@Article_Corresponding_Author_No where Article_No=@Article_No ", conn);

                    author_corresponding.Parameters.Add("@Article_Corresponding_Author_No", System.Data.SqlDbType.Int);
                    author_corresponding.Parameters["@Article_Corresponding_Author_No"].Value = user_no31;
                    author_corresponding.Parameters.Add("@Article_No", System.Data.SqlDbType.Int);
                    author_corresponding.Parameters["@Article_No"].Value = session_article_no;
                    conn.Close();
                    conn.Open();
                    author_corresponding.ExecuteNonQuery();
                    conn.Close();


                    // }
                }

                else
                {
                    // MessageBox.Show("");
                    //  Response.Write(" the Author that selected can't register in this journal");

                    MessageBox.Show("the Author that selected can't register in this journal", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Question);

                }

            }
            else
            {
                ob.update_edit_remove_author(author_no, session_article_no, txt_author_first_name.Text, txt_author_middle_name.Text, txt_author_last_name.Text, txt_academic_degree.Text, txt_author_affiliation.Text, txt_author_E_mail_address.Text);
                SqlCommand com = new SqlCommand("select Author_No,Author_First_Name,Author_Middle_Name,Author_Last_Name,Author_Acadimic_Degree,Author_Afilication,Author_Email_Address from Additional_Author where article_no=@article_no ", conn);
                com.Parameters.Add("@article_no", System.Data.SqlDbType.Int);
                com.Parameters["@article_no"].Value = session_article_no;
                conn.Close();
                conn.Open();
                SqlDataReader reader = com.ExecuteReader();
                GrdAuthor.DataSource = reader;
                GrdAuthor.DataBind();
                reader.Close();
                conn.Close();


            }

        }//2

        else
        {
            ob.update_edit_remove_author(author_no, session_article_no, txt_author_first_name.Text, txt_author_middle_name.Text, txt_author_last_name.Text, txt_academic_degree.Text, txt_author_affiliation.Text, txt_author_E_mail_address.Text);
            SqlCommand com = new SqlCommand("select Author_No,Author_First_Name,Author_Middle_Name,Author_Last_Name,Author_Acadimic_Degree,Author_Afilication,Author_Email_Address from Additional_Author where article_no=@article_no ", conn);
            com.Parameters.Add("@article_no", System.Data.SqlDbType.Int);
            com.Parameters["@article_no"].Value = session_article_no;
            conn.Close();
            conn.Open();
            SqlDataReader reader = com.ExecuteReader();
            GrdAuthor.DataSource = reader;
            GrdAuthor.DataBind();
            reader.Close();
            conn.Close();

        }

        txt_author_first_name.Text = "";
        txt_author_last_name.Text = "";
        txt_author_middle_name.Text = "";
        txt_author_E_mail_address.Text = "";
        txt_author_affiliation.Text = "";
        txt_academic_degree.Text = "";
        chcorrespondingauthor.Checked = false;

    }
}
