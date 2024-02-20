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
public partial class Redirect_other_Editor : System.Web.UI.Page
{
    String classifcation_Article;
    String user_Classification;
    FunctionSumation ob = new FunctionSumation();
    SqlConnection connect; 
    SqlCommand commands = new SqlCommand();
    SqlDataReader Read_Question;
    protected void Page_Load(object sender, EventArgs e)
    {
        connect = ob.connect;
        int My_No = Convert.ToInt16(Session["User_No"]);
        if (!IsPostBack)
        {

            int article_No = Convert.ToInt16(Session["Article_No"]);
               try
             {
            commands.Connection = connect;
            connect.Close();
            connect.Open();

            commands.CommandText = " select DISTINCT Classification_Article.Sub_Classification_No,Sub_classification.Sub_Classification_Name" +
                 " from Classification_Article,Sub_Classification where  Classification_Article.Sub_Classification_No = " +
                 "  Sub_Classification.Sub_Classification_No AND  Classification_Article.Article_No=@Article_No ";

            commands.Parameters.Add("@Article_No", System.Data.SqlDbType.Int);
            commands.Parameters["@Article_No"].Value = article_No;
            Read_Question = commands.ExecuteReader();
            commands.Parameters.Clear();
            while (Read_Question.Read())
            {
                classifcation_Article = classifcation_Article + " ,  " + Read_Question[1].ToString();

            }

            Article_Classification.Text = classifcation_Article;


              }
           catch
               {

             }
             finally
             {
                    commands.Parameters.Clear();
               connect.Close();
           }



           //    try
             //    {




            commands.Connection = connect;
            connect.Close();
            connect.Open();



            commands.CommandText = "select DISTINCT Users.User_No,Users.User_Name,Role_Table.Role_Name from Users,Articles, " +
              "(select DISTINCT User_Role.User_No,Role.Role_Name from User_Role,Role " +
                  " where User_Role.Role_No=Role.Role_No AND Role.Family_Role_No IN(select Family_Role.Family_Role_No" +
                  " from Family_Role where Family_Role.Family_Role_Name LIKE 'Editor'))Role_Table " +
               " where Users.User_No=Role_Table.User_No  AND Users.User_No !=" + My_No +

               " AND     Users.User_No  IN (select  User_Role.User_No from User_Role  " +
                "  where User_Role.Role_No IN (select Role.Role_No  from Role  where Family_Role_No IN (select Family_Role.Family_Role_No from Family_Role " +
                " where Family_Role.Family_Role_Name LIKE 'Editor' )AND Role.Role_Name LIKE 'Managing Editor')) AND Users.User_No IN (select User_Permission.User_No from  User_Permission" +
                " where User_Permission.Permission_No IN (select Secondary_Permission.Permission_No  from  Secondary_Permission where Secondary_Permission.Permission_Type_No" +
                " IN( select Primary_Permission.Permission_Type_No from  Primary_Permission where  Primary_Permission.Permission_Type_Name LIKE 'Manager')AND Secondary_Permission.Permission_Name LIKE 'New Submission Requiring Assignment'   ) ) "+
              " AND Users.User_No !=" + My_No +
                " AND Articles.Article_No  IN(select  Article_No from Articles where  Articles.Article_Revision  LIKE '0' AND Article_No=@Article_No )" +


                " OR  Users.User_No  IN (select  User_Role.User_No from User_Role  " +
                "  where User_Role.Role_No IN (select Role.Role_No  from Role  where Family_Role_No IN (select Family_Role.Family_Role_No from Family_Role " +
                " where Family_Role.Family_Role_Name LIKE 'Editor' )AND Role.Role_Name LIKE 'Managing Editor')) AND Users.User_No IN (select User_Permission.User_No from  User_Permission" +
                " where User_Permission.Permission_No IN (select Secondary_Permission.Permission_No  from  Secondary_Permission where Secondary_Permission.Permission_Type_No" +
                " IN( select Primary_Permission.Permission_Type_No from  Primary_Permission where  Primary_Permission.Permission_Type_Name LIKE 'Manager')AND Secondary_Permission.Permission_Name LIKE 'Resived Submissions Requiring Assignment'   ) ) " +
                " AND Users.User_No !=" + My_No +
             " AND Articles.Article_No  IN(select  Article_No from Articles where  Articles.Article_Revision NOT LIKE '0' AND Article_No=@Article_No )" +
              

               " OR Users.User_No  IN (select  User_Role.User_No from User_Role  " +
                "  where User_Role.Role_No IN (select Role.Role_No  from Role  where Family_Role_No IN (select Family_Role.Family_Role_No from Family_Role " +
                " where Family_Role.Family_Role_Name LIKE 'Editor' )AND Role.Role_Name LIKE 'Editor_in_Chief')) AND Users.User_No IN (select User_Permission.User_No from  User_Permission" +
                " where User_Permission.Permission_No IN (select Secondary_Permission.Permission_No  from  Secondary_Permission where Secondary_Permission.Permission_Type_No" +
                " IN( select Primary_Permission.Permission_Type_No from  Primary_Permission where  Primary_Permission.Permission_Type_Name LIKE 'Direct To Editor')AND Secondary_Permission.Permission_Name LIKE 'Direct To Editor New Submission'   ) ) " +
            " AND Users.User_No !=" + My_No +
                " AND Articles.Article_No  IN(select  Article_No from Articles where  Articles.Article_Revision  LIKE '0' AND Article_No=@Article_No) " +
   
              " OR  Users.User_No  IN (select  User_Role.User_No from User_Role  " +
                "  where User_Role.Role_No IN (select Role.Role_No  from Role  where Family_Role_No IN (select Family_Role.Family_Role_No from Family_Role " +
                " where Family_Role.Family_Role_Name LIKE 'Editor' )AND Role.Role_Name LIKE 'Editor_in_Chief')) AND Users.User_No IN (select User_Permission.User_No from  User_Permission" +
                " where User_Permission.Permission_No IN (select Secondary_Permission.Permission_No  from  Secondary_Permission where Secondary_Permission.Permission_Type_No" +
                " IN( select Primary_Permission.Permission_Type_No from  Primary_Permission where  Primary_Permission.Permission_Type_Name LIKE 'Direct To Editor')AND Secondary_Permission.Permission_Name LIKE 'Direct To Editor Resived Submission'   ) ) " +
                " AND Users.User_No !=" + My_No +
                " AND Articles.Article_No  IN(select  Article_No from Articles where  Articles.Article_Revision NOT LIKE '0' AND Articles.Article_No=@Article_No )" +

                "";
            commands.Parameters.Add("@Article_No", System.Data.SqlDbType.Int);
            commands.Parameters["@Article_No"].Value = article_No;

            Read_Question = commands.ExecuteReader();
            GridView1.DataSource = Read_Question;
            GridView1.DataBind();

    //          }
      //       catch
        //      {
            //
    //         }
      //       finally
        //   {
            //        commands.Parameters.Clear();
          //    connect.Close();
  //           }
    }
    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (GridView1.SelectedIndex != -1)
        {

            String selectedValue;

            ViewState["user_No"] = GridView1.SelectedValue.ToString();
            selectedValue = Convert.ToString(ViewState["user_No"]);

            Session["Editor_No"] = selectedValue;
            int User_No = Convert.ToInt16(Session["Editor_No"]);

        }
    }
    protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        int article_No = Convert.ToInt16(Session["Article_No"]);
        if (e.CommandName == "More_Information")
        {

            Session["Editor_No"] = e.CommandArgument;
            int Editor_No = Convert.ToInt16(Session["Editor_No"]);
               try
               {
            commands.Connection = connect;
            connect.Close();
            connect.Open();
            user_Classification = "";
            commands.CommandText = "  select DISTINCT  Classification_User.User_No,Classification_User.Sub_Classification_No,Sub_Classification.Sub_Classification_Name" +
                 " from Classification_User,Sub_Classification where  Classification_User.Sub_Classification_No = " +
                 " Sub_Classification.Sub_Classification_No AND  Classification_User.User_No=@User_No ";

            commands.Parameters.Add("@User_No", System.Data.SqlDbType.Int);
            commands.Parameters["@User_No"].Value = Editor_No;
            Read_Question = commands.ExecuteReader();
            commands.Parameters.Clear();
            while (Read_Question.Read())
            {
                user_Classification = user_Classification + " ,  " + Read_Question[2].ToString();

            }

            User_Classification.Text = user_Classification;
            Read_Question.Close();
            commands.CommandText = "  select Users.User_Name from Users where  User_No=@User_No ";
            commands.Parameters.Add("@User_No", System.Data.SqlDbType.Int);
            commands.Parameters["@User_No"].Value = Editor_No;
            Read_Question = commands.ExecuteReader();
            Read_Question.Read();
            Editor_Name.Text = Read_Question[0].ToString();
            commands.Parameters.Clear();

               }
             catch
              {

            }
              finally
             {
                     commands.Parameters.Clear();
               connect.Close();
               }
                try
                {
            commands.Connection = connect;
            connect.Close();
            connect.Open();
            user_Classification = "";
            commands.CommandText = "  select DISTINCT count(Sub_Classification_No) matches_count  from " +
             " ( select DISTINCT   Classification_Users.Sub_Classification_No,Classifications_Article.Sub_Classification_Name " +
              " from  " +
              "(select DISTINCT Classification_Article.Sub_Classification_No,Sub_classification.Sub_Classification_Name" +
              " from Classification_Article,Sub_Classification where  Classification_Article.Sub_Classification_No = " +
              "  Sub_Classification.Sub_Classification_No AND  Classification_Article.Article_No=@Article_No ) Classifications_Article, " +


               " ( select DISTINCT  Classification_User.User_No,Classification_User.Sub_Classification_No,Sub_Classification.Sub_Classification_Name" +
                 " from Classification_User,Sub_Classification where  Classification_User.Sub_Classification_No = " +
                 " Sub_Classification.Sub_Classification_No AND Classification_User.User_No=@User_No  ) Classification_Users    " +
               "   where  Classifications_Article.Sub_Classification_No= Classification_Users.Sub_Classification_No ) Classifications_Article_users  " +
               " ";

            commands.Parameters.Add("@User_No", System.Data.SqlDbType.Int);
            commands.Parameters["@User_No"].Value = Editor_No;
            commands.Parameters.Add("@Article_No", System.Data.SqlDbType.Int);
            commands.Parameters["@Article_No"].Value = article_No;
            Read_Question = commands.ExecuteReader();
            commands.Parameters.Clear();
            Read_Question.Read();
            ClassificationMatches.Text = Read_Question[0].ToString(); ;
            Read_Question.Close();
            commands.Parameters.Clear();

              }
              catch
               {

              }
              finally
             {
                    commands.Parameters.Clear();
              connect.Close();
               }
            //______________________________________
                try
                 {
            commands.Connection = connect;
            connect.Close();
            connect.Open();
            user_Classification = "";
            commands.CommandText = " select  DISTINCT  Count(Article_No) count  from Article_User where Assign_Complete=0 " +
                " AND  Article_User.Lower_User_No=@Lower_User_No" +
             " AND Article_User.Family_Role_No IN(select Family_Role.Family_Role_No" +
              " from Family_Role where Family_Role.Family_Role_Name LIKE 'Editor') " +
             " ";

            commands.Parameters.Add("@Lower_User_No", System.Data.SqlDbType.Int);
            commands.Parameters["@Lower_User_No"].Value = Editor_No;

            Read_Question = commands.ExecuteReader();
            commands.Parameters.Clear();
            Read_Question.Read();
            Current_Argument.Text = Read_Question[0].ToString(); ;
            Read_Question.Close();
            commands.Parameters.Clear();

               }
             catch
               {

             }
               finally
             {
                   commands.Parameters.Clear();
               connect.Close();
               }


        }
    }
    protected void CmdCancel0_Click1(object sender, EventArgs e)
    {

        Response.Redirect("~/About");
    }
}
