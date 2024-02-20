using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Data.SqlClient;
public partial class EditSubmition : System.Web.UI.Page
{


    FunctionSumation ob = new FunctionSumation();
    SqlConnection connect;
    SqlCommand commands = new SqlCommand();
    SqlDataReader Read_Question;
    protected void Page_Load(object sender, EventArgs e)
    {
        connect = ob.connect;
        if (!IsPostBack)
        {
            int art = Convert.ToInt16(Session["Article_No"]);

            // ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^NEW INVITATION^^^^^^^^^^^^^^^^^^^^^^
            try
            {
                connect.Close();
                connect.Open();
                commands.Connection = connect;
                commands.CommandText = "select Article_No ,Article_Full_Title,Article_Short_Title,Article_Keywords from Articles   " +
                     " where Articles.Article_No=@Article_No";

                commands.Parameters.Add("@Article_No", System.Data.SqlDbType.Int);
                commands.Parameters["@Article_No"].Value = art;
                Read_Question = commands.ExecuteReader();
                Read_Question.Read();


                Full_Title.Text = Convert.ToString(Read_Question[1]);
                Short_Title.Text = Convert.ToString(Read_Question[2]);
                key_Words.Text = Convert.ToString(Read_Question[3]);
                Read_Question.Close();
                commands.Parameters.Clear();
                // type
                commands.CommandText = "select Article_Types.Article_Type_Name  from Articles,Article_Types   " +
                              " where Articles.Article_No=@Article_No  AND Article_Types.Article_Type_No=Articles.                        Article_Type_No";
                commands.Parameters.Add("@Article_No", System.Data.SqlDbType.Int);
                commands.Parameters["@Article_No"].Value = art;
                Read_Question = commands.ExecuteReader();
                Read_Question.Read();
                String select = Read_Question[0].ToString();

                Read_Question.Close();
                commands.Parameters.Clear();

                commands.CommandText = "select Article_Type_No,Article_Type_Name  from Article_Types  ";
                Read_Question = commands.ExecuteReader();

                ArticleTypedrop.DataSource = Read_Question;
                ArticleTypedrop.DataValueField = "Article_Type_No";
                ArticleTypedrop.DataTextField = "Article_Type_Name";
                ArticleTypedrop.DataBind();
                Read_Question.Close();
                int select_Type = -1;
                foreach (ListItem gg in ArticleTypedrop.Items)
                {
                    Response.Write("rr"); select_Type = select_Type + 1;
                    if (gg.Text.Equals(select))
                    {

                        ArticleTypedrop.SelectedIndex = select_Type;

                    }
                }
                // end Type 
                // category
                commands.CommandText = "select Categories.Category_Name  from Articles,Categories   " +
                                       " where Articles.Article_No=@Article_No  AND Categories.Category_No=Articles.Article_Categories_No";
                commands.Parameters.Add("@Article_No", System.Data.SqlDbType.Int);
                commands.Parameters["@Article_No"].Value = art;
                Read_Question = commands.ExecuteReader();
                Read_Question.Read();
                String select_category = Read_Question[0].ToString();
                Read_Question.Close();
                commands.Parameters.Clear();

                commands.CommandText = "select Category_Name,Category_No  from Categories  ";
                Read_Question = commands.ExecuteReader();

                Section_Category.DataSource = Read_Question;
                Section_Category.DataValueField = "Category_No";
                Section_Category.DataTextField = "Category_Name";
                Section_Category.DataBind();
                Read_Question.Close();
                connect.Close();
                int select_Category = -1;
                foreach (ListItem item in Section_Category.Items)
                {
                    select_Category = select_Category + 1;
                    if (item.Text.Equals(select_category))
                    {

                        Section_Category.SelectedIndex = select_Type;

                    }
                }
                // end category


            }
            catch
            {

            }
            finally
            {
                commands.Parameters.Clear();
                connect.Close();
            }
            //END^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^NEW INVITATION^^^^^^^^^^^^^^^^^^^^^^
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        connect.Close();
        connect.Open();
        commands.Connection = connect;

        int art = Convert.ToInt16(Session["Article_No"]);
        Response.Write(art);

        commands.CommandText = " update Articles " +
            " set  Article_Full_Title =@Article_Full_Title,Article_Short_Title=@Article_Short_Title" +
            " , Article_Type_No=@Article_Type_No,Article_Categories_No=@Article_Categories_No  , Article_Keywords=@Article_Keywords  where Articles.Article_No=@Article_No";
        commands.Parameters.Add("@Article_No", System.Data.SqlDbType.Int);
        commands.Parameters["@Article_No"].Value = art;
        commands.Parameters.Add("@Article_Full_Title", System.Data.SqlDbType.Text);
        commands.Parameters["@Article_Full_Title"].Value = Full_Title.Text;
        commands.Parameters.Add("@Article_Short_Title", System.Data.SqlDbType.Text);
        commands.Parameters["@Article_Short_Title"].Value = Short_Title.Text;
        commands.Parameters.Add("@Article_Categories_No", System.Data.SqlDbType.Int);
        commands.Parameters["@Article_Categories_No"].Value = Section_Category.SelectedItem.Value;
        commands.Parameters.Add("@Article_Type_No", System.Data.SqlDbType.Int);
        commands.Parameters["@Article_Type_No"].Value = ArticleTypedrop.SelectedItem.Value;
        commands.Parameters.Add("@Article_Keywords", System.Data.SqlDbType.Text);
        commands.Parameters["@Article_Keywords"].Value = key_Words.Text;
        commands.ExecuteNonQuery();
        commands.Parameters.Clear();
        connect.Close();
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {


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
            " set Current_Status_Name ='Build PDF',Current_Status_Date=@Current_Status_Date " +
            " where Article_No=@Article_No ";

        commands.Parameters.Add("@Current_Status_Date", System.Data.SqlDbType.DateTime);
        commands.Parameters["@Current_Status_Date"].Value = time;
        commands.Parameters.Add("@Article_No", System.Data.SqlDbType.Int);
        commands.Parameters["@Article_No"].Value = article_No;
        commands.ExecuteNonQuery();

        commands.Parameters.Clear();


        // And status_Users



        commands.CommandText = "select Status.Status_No from  Status where  " +
                                 "  Status.Status_Name LIKE 'Build PDF'";
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
    protected void Next_Button_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Add_Edit_Remove_Author.aspx");
    }
}


