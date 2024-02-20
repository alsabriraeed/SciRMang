using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.SessionState;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Data.SqlClient;
public partial class DetailForManuscriptNumber2 : System.Web.UI.Page
{
    FunctionSumation ob = new FunctionSumation();
    SqlConnection connect;
   SqlCommand comm1 = new SqlCommand();
    SqlDataReader Read_Question;
    protected void Page_Load(object sender, EventArgs e)
    {
        connect = ob.connect;
        int art = Convert.ToInt16(Session["Article_No"]);

        if (testEditorForArticle() == true)
        {
            LinkBEditor.Visible = false;
        }
        if (testReviewerForArticle() == true)
        {
            LinkBReviewer.Visible = false;
        }
        try
        {
            connect.Close();
            connect.Open();
            comm1.Connection = connect;

            comm1.CommandText = "select Users.User_Name,Users.User_Email_Address from " +
                "Users where Users.User_No IN (select  Articles.Article_Corresponding_Author_No from Articles where Articles.Article_No=@Article_No) ";
            comm1.Parameters.Add("@Article_No", System.Data.SqlDbType.Int);
            comm1.Parameters["@Article_No"].Value = art;
            Read_Question = comm1.ExecuteReader();
            Read_Question.Read();
            corresponding_Author.Text = Convert.ToString(Read_Question["User_Name"]);
            corresponding_Email.Text = Convert.ToString(Read_Question["User_Email_Address"]);
            Read_Question.Close();
            comm1.Parameters.Clear();



            comm1.CommandText = " select Additional_Author.Author_No, Additional_Author.Author_First_Name from" +
                " Additional_Author  where Additional_Author.Article_No=@Article_No ";
            comm1.Parameters.Add("@Article_No", System.Data.SqlDbType.Int);
            comm1.Parameters["@Article_No"].Value = art;
            Read_Question = comm1.ExecuteReader();
            ;
            while (Read_Question.Read())
            {
                other_Author.Text = other_Author.Text + "  <br> " + @"<a id= " + Convert.ToString(Read_Question[0]) + "  href=Default.aspx >" + Convert.ToString(Read_Question[1]) + "</a>";
            }
            Read_Question.Close();
            comm1.Parameters.Clear();
            comm1.CommandText = "select  Article_Full_Title ,Article_Comments,Article_Short_Title ," +
                " Article_Keywords,Article_Section_Category ,Article_Request_Editor ,Article_Abstract," +
                "  Article_Notes from Articles" +
                 "  where Articles.Article_No=@Article_No ";
            comm1.Parameters.Add("@Article_No", System.Data.SqlDbType.Int);
            comm1.Parameters["@Article_No"].Value = art;
            Read_Question = comm1.ExecuteReader();
            Read_Question.Read();

            Article_Full_Title.Text = Convert.ToString(Read_Question["Article_Full_Title"]);
            Auther_Comment.Text = Convert.ToString(Read_Question["Article_Comments"]);
            Short_Title.Text = Convert.ToString(Read_Question["Article_Short_Title"]);
            Article_keywords.Text = Convert.ToString(Read_Question["Article_Keywords"]);
            Section_Category.Text = Convert.ToString(Read_Question["Article_Section_Category"]);
            Request_Editor.Text = Convert.ToString(Read_Question["Article_Request_Editor"]);
            Article_Abstract.Text = Convert.ToString(Read_Question["Article_Abstract"]);
            Article_Notes.Text = Convert.ToString(Read_Question["Article_Notes"]);
            Read_Question.Close();
            comm1.Parameters.Clear();
            comm1.CommandText = "select Article_Types.Article_Type_Name from Article_Types,Articles " +
                      "  where Article_Types.Article_Type_No= Articles.Article_Type_No AND Articles.Article_No=@Article_No ";
            comm1.Parameters.Add("@Article_No", System.Data.SqlDbType.Int);
            comm1.Parameters["@Article_No"].Value = art;
            Read_Question = comm1.ExecuteReader();
            Read_Question.Read();
            Article_Type.Text = Convert.ToString(Read_Question["Article_Type_Name"]);
            Read_Question.Close();
            comm1.Parameters.Clear();
            comm1.CommandText = "select Sub_Classification.Sub_Classification_Name from  Sub_Classification where" +
                 " Sub_Classification_No IN( select Sub_Classification_No from Classification_Article where Article_No=@Article_No ) ";

            comm1.Parameters.Add("@Article_No", System.Data.SqlDbType.Int);
            comm1.Parameters["@Article_No"].Value = art;
            Read_Question = comm1.ExecuteReader();

            while (Read_Question.Read())
            {

                Article_Classifiction.Text = Article_Classifiction.Text + "," + Convert.ToString(Read_Question["Sub_Classification_Name"]);
            }
            Read_Question.Close();

            comm1.Parameters.Clear();

            comm1.CommandText = "select Article_Status_Users.Status_Date from Article_Status_Users where Article_Status_Users.Status_No " +
                " IN(Select Status.Status_No from Status where Status_Name LIKE'Submitted'  )AND Article_No=@Article_No ";
            comm1.Parameters.Add("@Article_No", System.Data.SqlDbType.Int);
            comm1.Parameters["@Article_No"].Value = art;
            Read_Question = comm1.ExecuteReader();

            Read_Question.Read();
            Initial_Status_Date.Text = Convert.ToString(Read_Question["Status_Date"]);
            Read_Question.Close();
            comm1.Parameters.Clear();
            /// set final 
            /// 

            comm1.CommandText = "select Status.Status_Name from Status where Status.Status_No " +
                " IN(Select Article_Status_Users.Status_No from Article_Status_Users where Article_No=@Article_No)AND" +
                " Status_Name LIKE'Accept' OR Status_Name LIKE'Withdrawen'  OR  Status_Name LIKE'Reject'" +
                "   ";
            comm1.Parameters.Add("@Article_No", System.Data.SqlDbType.Int);
            comm1.Parameters["@Article_No"].Value = art;
            Read_Question = comm1.ExecuteReader();

            Read_Question.Read();
            Set_Final_Decision.Text = Convert.ToString(Read_Question["Status_Name"]);
            Read_Question.Close();
            comm1.Parameters.Clear();




            comm1.CommandText = "select Current_Status.Current_Status_Date,Current_Status.Current_Status_Name " +
                " from Current_Status where Current_Status.Article_No=@Article_No ";
            comm1.Parameters.Add("@Article_No", System.Data.SqlDbType.Int);
            comm1.Parameters["@Article_No"].Value = art;
            Read_Question = comm1.ExecuteReader();
            Read_Question.Read();
            Current_Status.Text = Convert.ToString(Read_Question["Current_Status_Name"]);
            Status_Date.Text = Convert.ToString(Read_Question["Current_Status_Date"]);


            Read_Question.Close();
            comm1.Parameters.Clear();
        }


        catch { }
    }



    protected void Button1_Click(object sender, EventArgs e)
    {

    }
    protected void Reveiwer_db_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Response.Redirect("ReviewerForArticle.aspx");
    }
    protected void LinkButton2_Click(object sender, EventArgs e)
    {
        Response.Redirect("Editor For Article.aspx");
    }
    Boolean testEditorForArticle()
    {
        int art = Convert.ToInt16(Session["Article_No"]);
        //  try
        //  {


        connect.Close();
        connect.Open();
        comm1.Connection = connect;
        comm1.CommandText = "select Article_User.Article_No   from Article_User where Article_No=@Article_No AND " +
                " Article_User.Family_Role_No IN  ( select Family_Role.Family_Role_No from  Family_Role where  " +
                                     "  Family_Role.Family_Role_Name  LIKE 'Editor' ) ";

        comm1.Parameters.Add("@Article_No", System.Data.SqlDbType.Int);
        comm1.Parameters["@Article_No"].Value = art;
        Read_Question = comm1.ExecuteReader();
        comm1.Parameters.Clear();

        if (Read_Question.Read())
        {
            return false;
        }
        else
            return true;

        // }
        // catch
        //   {

        // }
        //   finally
        // {
        //   commands.Parameters.Clear();
        // connect.Close();
        // } 
    }
    Boolean testReviewerForArticle()
    {
        int art = Convert.ToInt16(Session["Article_No"]);
        //  try
        //  {


        connect.Close();
        connect.Open();
        comm1.Connection = connect;
        comm1.CommandText = "select Article_User.Article_No   from Article_User where Article_No=@Article_No AND " +
                " Article_User.Family_Role_No IN  ( select Family_Role.Family_Role_No from  Family_Role where  " +
                                     "  Family_Role.Family_Role_Name  LIKE 'Reviewer' ) ";

        comm1.Parameters.Add("@Article_No", System.Data.SqlDbType.Int);
        comm1.Parameters["@Article_No"].Value = art;
        Read_Question = comm1.ExecuteReader();
        comm1.Parameters.Clear();

        if (Read_Question.Read())
        {
            return false;
        }
        else
            return true;

        // }
        // catch
        //   {

        // }
        //   finally
        // {
        //   commands.Parameters.Clear();
        // connect.Close();
        // } 
    }
    protected void Button2_Click(object sender, EventArgs e)
    {

    }
}
