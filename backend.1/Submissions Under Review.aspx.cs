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
public partial class Submissions_Under_Review : System.Web.UI.Page
{

    FunctionSumation ob = new FunctionSumation();
    SqlConnection connect; 
    SqlCommand commands = new SqlCommand();
    SqlDataReader Read_Question;
    protected void Page_Load(object sender, EventArgs e)
    {
        connect = ob.connect;
        int usr_NO = 1;

        //^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^NEW INVITATION^^^^^^^^^^^^^^^^^^^^^^
        //  try
        //  {
        connect.Close();
        connect.Open();
        commands.Connection = connect;
        commands.CommandText = " select  Reviewer_Name.User_Name,Article_Information.Article_No,Reviewer_Order.User_Order,Assign_date.Status_Date AS assign_date," +
                           "Due_date.Status_Date AS due_date,complet_date.Status_Date,Article_Information.Article_Full_Title,Article_Information.Article_Keywords " +
                " , Current_Status.Current_Status_Date ,Current_Status.Current_Status_Name , invite_date.Status_Date AS invit_date,Article_Type_Name from  Current_Status,  " +


                 "( select DISTINCT  Article_Status_Users.Article_No,Article_Status_Users.User_No,Article_Status_Users.Status_Date  from Article_Status_Users,Family_Role,Status where Article_Status_Users.Status_No " +
                " = Status.Status_No AND Status.Family_Role_No =Family_Role.Family_Role_No AND Family_Role.Family_Role_Name LIKE 'Reviewer'  " +
                 " AND Status.Status_Name LIKE 'Reviewers Assign' )Assign_date , " +

                    "( select DISTINCT Article_Status_Users.Article_No,Article_Status_Users.User_No,Article_Status_Users.Status_Date  from Article_Status_Users,Family_Role,Status where Article_Status_Users.Status_No " +
                " = Status.Status_No AND Status.Family_Role_No =Family_Role.Family_Role_No AND Family_Role.Family_Role_Name LIKE 'Reviewer'  " +
                 " AND Status.Status_Name NOT LIKE 'Complete Review' )complet_date , " +

                 "(select DISTINCT Users.User_Name,Users.User_No,Article_User.Article_No  from Users,Article_User,Family_Role where Users.User_No=Article_User.Lower_User_No AND " +
                 " Article_User.Upper_User_no=@Upper_User_no AND  Article_User.Family_Role_No=Family_Role.Family_Role_No AND Family_Role.Family_Role_Name LIKE 'Reviewer' )Reviewer_Name ," +

                 "( select DISTINCT Article_Status_Users.Article_No,Article_Status_Users.User_No,Article_Status_Users.Status_Date  from Article_Status_Users,Family_Role,Status where Article_Status_Users.Status_No " +
                 " =  Status.Status_No  AND  Status.Family_Role_No=Family_Role.Family_Role_No AND Family_Role.Family_Role_Name LIKE 'Reviewer'  " +
                 " AND Status.Status_Name LIKE 'Review Due' )  Due_date , " +

                 "(select DISTINCT Article_User.Article_No, Article_User.Lower_User_No,Article_User.User_Order from Article_User,Family_Role where  Article_User.Upper_User_no=@Upper_User_no  AND Article_User.Family_Role_No=Family_Role.Family_Role_No AND Family_Role.Family_Role_Name LIKE 'Reviewer'   ) Reviewer_Order ," +

                " ( select DISTINCT Article_Status_Users.Article_No,Article_Status_Users.User_No,Article_Status_Users.Status_Date   from Article_Status_Users,Status,Family_Role where Article_Status_Users.Status_No " +
                         " = Status.Status_No AND Status.Family_Role_No = Family_Role.Family_Role_No AND  Family_Role.Family_Role_Name LIKE 'Reviewer'  " +
                         " AND Status.Status_Name LIKE 'Reviewers Invite'  ) invite_date , " +

            "( select    Article_No,Articles.Article_Full_Title,Articles.Article_Keywords from Articles where Articles.Article_No IN ( select Article_User.Article_No  from Article_User  " +
               " where Article_User.Upper_User_no  IN (select Users.User_No from Users  where Users.User_No  IN ( select  User_Role.User_No from User_Role  " +
               "  where Role_No IN ( select Role.Role_No  from Role  where Family_Role_No IN ( select  Family_Role.Family_Role_No from Family_Role " +
               " where Family_Role.Family_Role_Name LIKE 'Editor' )AND Role.Role_Name LIKE 'Editor_in_Chief' OR  Role.Role_Name LIKE 'Associate Editor'  )) " +
               " AND Users.User_No IN ( select User_Permission.User_No from  User_Permission" +
               " where User_Permission.Permission_No IN ( select Secondary_Permission.Permission_No  from " +
                           " Secondary_Permission where Secondary_Permission.Permission_Type_No" +
               " IN( select Primary_Permission.Permission_Type_No from  Primary_Permission where " +
               " Primary_Permission.Permission_Type_Name LIKE 'New Submissions' ) AND " +
               "    Secondary_Permission.Permission_Name LIKE 'New Assignment'  ) ) " +
                     " AND  Users.User_No=@User_No  ) AND Article_User.Family_Role_No IN(select Family_Role.Family_Role_No from Family_Role " +
               " where Family_Role.Family_Role_Name LIKE 'Reviewer' ) " +
               "  )" +
                          "AND Articles.Article_No  IN " +
                     "( select Article_Status_Users.Article_No  from Article_Status_Users where Article_Status_Users.Status_No " +
                     " IN ( select  Status.Status_No  from Status where Status.Family_Role_No IN  " +
                     " ( select Family_Role.Family_Role_No from Family_Role where Family_Role.Family_Role_Name LIKE 'Reviewer' ) " +
                     " AND Status.Status_Name LIKE 'Reviewers Assign'  ))" +
                    "  AND Articles.Article_No NOT IN " +
                     "( select Article_Status_Users.Article_No  from Article_Status_Users where Article_Status_Users.Status_No " +
                     " IN ( select  Status.Status_No  from Status where Status.Family_Role_No IN  " +
                     " ( select Family_Role.Family_Role_No from Family_Role where Family_Role.Family_Role_Name LIKE 'Reviewer' ) " +
                     " AND Status.Status_Name LIKE 'Complete Review'   ))  " +
               "     AND Articles.Article_No NOT IN " +
               "( select Article_Status_Users.Article_No  from Article_Status_Users where Article_Status_Users.Status_No " +
               " IN ( select  Status.Status_No  from Status where Status.Family_Role_No IN  " +
               " ( select Family_Role.Family_Role_No from Family_Role where Family_Role.Family_Role_Name LIKE 'Reviewer' ) " +
               " AND Status.Status_Name LIKE 'Decline review'   )) )Article_Information," +

                 "(select   Article_Types.Article_Type_Name,Articles.Article_No from  Article_Types,Articles " +
                 "  where   Article_Types.Article_Type_No = Articles.Article_Type_No   ) article_type " +
                 " where Current_Status.Article_No=Article_Information.Article_No AND Article_Information.Article_No=article_type.Article_No " +
                 "  AND Article_Information.Article_No=invite_date.Article_No  AND invite_date.Article_No=Reviewer_Order.Article_No " +
                 " AND Due_date.Article_No=Article_Information.Article_No " +
                 " AND Assign_date.Article_No=Article_Information.Article_No  " +
                 " AND Reviewer_Name.Article_No = Article_Information.Article_No  AND Reviewer_Name.Article_No=Reviewer_Order.Article_No " +
               "   AND   invite_date.Article_No=Article_Information.Article_No  AND Due_date.Article_No=Article_Information.Article_No" +
               " AND Reviewer_Order.Article_No=Article_Information.Article_No " +
                 " AND Article_Information.Article_No =Article_Information.Article_No " +
                " AND Reviewer_Name.User_No =Due_date.User_No" +
                " AND Reviewer_Name.User_No =invite_date.User_No" +
                 " AND Reviewer_Name.User_No =Assign_date.User_No" +
                 " AND Reviewer_Name.User_No =Reviewer_Order.Lower_User_No" +
                  " AND Reviewer_Order.Lower_User_No =Assign_date.User_No" +
                 " AND invite_date.User_No =Reviewer_Order.Lower_User_No" +
                    " AND Assign_date.User_No =invite_date.User_No" +
                    " AND Assign_date.User_No =Due_date.User_No" +
                     " AND Assign_date.User_No = complet_date.User_No" +
                     " AND Article_Information.Article_No =complet_date.Article_No" +
                 "  ";


        commands.Parameters.Add("@User_No", System.Data.SqlDbType.Int);
        commands.Parameters["@User_No"].Value = usr_NO;
        commands.Parameters.Add("@Upper_User_no", System.Data.SqlDbType.Int);
        commands.Parameters["@Upper_User_no"].Value = usr_NO;
        Read_Question = commands.ExecuteReader();
        db_Under.DataSource = Read_Question;
        db_Under.DataBind();



        // }
        // catch
        // {

        //  }
        //  finally
        // {
        //     commands.Parameters.Clear();
        //     connect.Close();
        //   }
    }
    protected void db_Under_RowCommand(object sender, GridViewCommandEventArgs e)
    {

    }
    protected void db_Under_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}
