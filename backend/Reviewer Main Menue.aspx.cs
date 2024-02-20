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
public partial class Reviewer_Main_Menue : System.Web.UI.Page
{
    FunctionSumation ob = new FunctionSumation();
    SqlConnection connect; 
    SqlCommand commands = new SqlCommand();
    SqlDataReader Read_Question;
    protected void Page_Load(object sender, EventArgs e)
    {
        connect = ob.connect;
        //^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^NEW INVITaTION 
        Session["Reviewer_No"] =3;

        int usr_NO = Convert.ToInt16(Session["Reviewer_No"]);
        //  try
        //  {
        connect.Close();
        connect.Open();
        commands.Connection = connect;


        commands.CommandText = " select  " +
            "  Users.User_Name  from Users  where Users.User_No  IN (select  User_Role.User_No from User_Role  " +
            "  where User_Role.Role_No IN (select Role.Role_No  from Role  where Family_Role_No IN (select Family_Role.Family_Role_No from Family_Role " +
            " where Family_Role.Family_Role_Name LIKE 'Reviewer' )  )) AND Users.User_No IN (select User_Permission.User_No from  User_Permission" +
            " where User_Permission.Permission_No IN (select Secondary_Permission.Permission_No  from  Secondary_Permission where Secondary_Permission.Permission_Type_No" +
            " IN( select Primary_Permission.Permission_Type_No from  Primary_Permission where  Primary_Permission.Permission_Type_Name LIKE 'Reviews')AND Secondary_Permission.Permission_Name LIKE 'Recieve Invitation') ) " +
            "AND Users.User_No =@User_No";
        commands.Parameters.Add("@User_No", System.Data.SqlDbType.Int);
        commands.Parameters["@User_No"].Value = usr_NO;

        Read_Question = commands.ExecuteReader();

        commands.Parameters.Clear();

        if (Read_Question.Read())
        {
            Read_Question.Close();
            commands.CommandText = " select count(Article_No) from Articles   " +
             " where Articles.Article_No  IN" +
       " ( select  Article_User.Article_No from Article_User where Article_User.Lower_User_No =@Lower_User_No " +
       " AND Article_User.Family_Role_No IN(select Family_Role.Family_Role_No from Family_Role where Family_Role.Family_Role_Name LIKE 'Reviewer'  ))    " +
                 " AND Articles.Article_No  IN " +
                 "( select Article_Status_Users.Article_No  from Article_Status_Users where Article_Status_Users.Status_No " +
                 " IN ( select  Status.Status_No  from Status where Status.Family_Role_No IN  " +
                 " ( select Family_Role.Family_Role_No from Family_Role where Family_Role.Family_Role_Name LIKE 'Reviewer' ) " +
                 " AND Status.Status_Name LIKE 'Reviewers Invite'  )AND Article_Status_Users.User_No=@User_No)  " +
                    "AND Articles.Article_No NOT IN " +
                 "( select Article_Status_Users.Article_No  from Article_Status_Users where Article_Status_Users.Status_No " +
                 " IN ( select  Status.Status_No  from Status where Status.Family_Role_No IN  " +
                 " ( select Family_Role.Family_Role_No from Family_Role where Family_Role.Family_Role_Name LIKE 'Reviewer' ) " +
                 " AND Status.Status_Name LIKE 'Reviewers Assign'  )AND Article_Status_Users.User_No=@User_No)   "+
                            "AND Articles.Article_No NOT IN " +
                 "( select Article_Status_Users.Article_No  from Article_Status_Users where Article_Status_Users.Status_No " +
                 " IN ( select  Status.Status_No  from Status where Status.Family_Role_No IN  " +
                 " ( select Family_Role.Family_Role_No from Family_Role where Family_Role.Family_Role_Name LIKE 'Reviewer' ) " +
                 " AND Status.Status_Name LIKE 'Reviewers Assign' OR Status.Status_Name LIKE 'Decline review'   )AND Article_Status_Users.User_No=@User_No)   "+
                           "AND Articles.Article_No NOT IN " +
                 "( select Article_Status_Users.Article_No  from Article_Status_Users where Article_Status_Users.Status_No " +
                 " IN ( select  Status.Status_No  from Status where Status.Family_Role_No IN  " +
                 " ( select Family_Role.Family_Role_No from Family_Role where Family_Role.Family_Role_Name LIKE 'Reviewer' ) " +
                 " AND  Status.Status_Name LIKE 'Complete Review'   )AND Article_Status_Users.User_No=@User_No)   " ;

            commands.Parameters.Add("@User_No", System.Data.SqlDbType.Int);
            commands.Parameters["@User_No"].Value = usr_NO;
            commands.Parameters.Add("@Lower_User_No", System.Data.SqlDbType.Int);
            commands.Parameters["@Lower_User_No"].Value = usr_NO;
            Read_Question = commands.ExecuteReader();
            Read_Question.Read();
            int New_Reviewer_Invitationss_Variable = (int)(Read_Question[0]);
            if (New_Reviewer_Invitationss_Variable > 0)
            {
                New_Reviewer_Invitation_Count.Text = "(" + New_Reviewer_Invitationss_Variable + ")";

                New_Reviewer_Invitationss.Enabled = true;
                Read_Question.Close();

                connect.Close();
            }
            else
            {
                New_Reviewer_Invitation_Count.Text = "(0)";
                New_Reviewer_Invitationss.Enabled = false;
                Read_Question.Close();

                connect.Close();
            }
        }
        else
        {
            New_Reviewer_Invitation_Count.Text = "(0)";
            Read_Question.Close();
            connect.Close();
        }

        // }
        //  catch
        //   {
        //   New_Reviewer_Invitation_Count .Text = "(0)";
        //   }
        //   finally
        //  {
        commands.Parameters.Clear();
        connect.Close();
        //   }
        //end^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^NEW INVITaTION 
        //^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^pending assignment

        //    try
        //     {
        connect.Close();
        connect.Open();
        commands.Connection = connect;

        commands.Parameters.Clear();
        commands.CommandText = " select  " +
            "  Users.User_Name  from Users  where Users.User_No  IN (select  User_Role.User_No from User_Role  " +
            "  where User_Role.Role_No IN (select Role.Role_No  from Role  where Family_Role_No IN (select Family_Role.Family_Role_No from Family_Role " +
            " where Family_Role.Family_Role_Name LIKE 'Reviewer' )  )) AND Users.User_No IN (select User_Permission.User_No from  User_Permission" +
            " where User_Permission.Permission_No IN (select Secondary_Permission.Permission_No  from  Secondary_Permission where Secondary_Permission.Permission_Type_No" +
            " IN( select Primary_Permission.Permission_Type_No from  Primary_Permission where  Primary_Permission.Permission_Type_Name LIKE 'Reviews')AND Secondary_Permission.Permission_Name LIKE 'Recieve Invitation') ) " +
            "AND Users.User_No =@User_No";
        commands.Parameters.Add("@User_No", System.Data.SqlDbType.Int);
        commands.Parameters["@User_No"].Value = usr_NO;

        Read_Question = commands.ExecuteReader();

        commands.Parameters.Clear();

        if (Read_Question.Read())
        {
            Read_Question.Close();
            commands.CommandText = " select count(Article_No) from Articles   " +
             " where Articles.Article_No  IN" +
       " ( select  Article_User.Article_No from Article_User where Article_User.Lower_User_No =@Lower_User_No " +
       " AND Article_User.Family_Role_No IN(select Family_Role.Family_Role_No from Family_Role where Family_Role.Family_Role_Name LIKE 'Reviewer'  ))    " +
                 " AND Articles.Article_No  IN " +
                 "( select Article_Status_Users.Article_No  from Article_Status_Users where Article_Status_Users.Status_No " +
                 " IN ( select  Status.Status_No  from Status where Status.Family_Role_No IN  " +
                 " ( select Family_Role.Family_Role_No from Family_Role where Family_Role.Family_Role_Name LIKE 'Reviewer' ) " +
                 " AND Status.Status_Name LIKE 'Reviewers Assign'  )AND Article_Status_Users.User_No=@User_No)  " +
            "AND Articles.Article_No NOT IN " +
                "( select Article_Status_Users.Article_No  from Article_Status_Users where Article_Status_Users.Status_No " +
                " IN ( select  Status.Status_No  from Status where Status.Family_Role_No IN  " +
                " ( select Family_Role.Family_Role_No from Family_Role where Family_Role.Family_Role_Name LIKE 'Reviewer' ) " +
                " AND    Status.Status_Name LIKE 'Complete Review'  )AND Article_Status_Users.User_No=@User_No)   ";
            commands.Parameters.Add("@User_No", System.Data.SqlDbType.Int);
            commands.Parameters["@User_No"].Value = usr_NO;
            commands.Parameters.Add("@Lower_User_No", System.Data.SqlDbType.Int);
            commands.Parameters["@Lower_User_No"].Value = usr_NO;
            Read_Question = commands.ExecuteReader();
            Read_Question.Read();
            int New_Reviewer_Pending_Variable = (int)(Read_Question[0]);
            if (New_Reviewer_Pending_Variable > 0)
            {
                Pending_Assignment_cont.Text = "(" + New_Reviewer_Pending_Variable + ")";

                Pending_Assignment.Enabled = true;
                Read_Question.Close();

                connect.Close();
            }
            else
            {
                Pending_Assignment_cont.Text = "(0)";
                Pending_Assignment.Enabled = false;
                Read_Question.Close();

                connect.Close();
            }
        }
        else
        {
            Pending_Assignment_cont.Text = "(0)";
            Read_Question.Close();
            connect.Close();
        }


        //   }
        //     catch
        //      {
        //     Pending_Assignment_cont.Text = "(0)";
        //   }
        //    finally
        //     {
        commands.Parameters.Clear();
        connect.Close();
        //    }
        //end^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^pending assignment


        //^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^Completed assignment

        //try
        // {
        connect.Close();
        connect.Open();
        commands.Connection = connect;

        commands.Parameters.Clear();
        commands.CommandText = " select  " +
            "  Users.User_Name  from Users  where Users.User_No  IN (select  User_Role.User_No from User_Role  " +
            "  where User_Role.Role_No IN (select Role.Role_No  from Role  where Family_Role_No IN (select Family_Role.Family_Role_No from Family_Role " +
            " where Family_Role.Family_Role_Name LIKE 'Reviewer' )  )) AND Users.User_No IN (select User_Permission.User_No from  User_Permission" +
            " where User_Permission.Permission_No IN (select Secondary_Permission.Permission_No  from  Secondary_Permission where Secondary_Permission.Permission_Type_No" +
            " IN( select Primary_Permission.Permission_Type_No from  Primary_Permission where  Primary_Permission.Permission_Type_Name LIKE 'Reviews')AND Secondary_Permission.Permission_Name LIKE 'Recieve Invitation') ) " +
            "AND Users.User_No =@User_No";
        commands.Parameters.Add("@User_No", System.Data.SqlDbType.Int);
        commands.Parameters["@User_No"].Value = usr_NO;

        Read_Question = commands.ExecuteReader();

        commands.Parameters.Clear();

        if (Read_Question.Read())
        {
            Read_Question.Close();
            commands.CommandText = " select count(Article_No) from Articles   " +
             " where Articles.Article_No  IN" +
       " ( select  Article_User.Article_No from Article_User where Article_User.Lower_User_No =@Lower_User_No " +
       " AND Article_User.Family_Role_No IN(select Family_Role.Family_Role_No from Family_Role where Family_Role.Family_Role_Name LIKE 'Reviewer'  ))    " +
                 " AND Articles.Article_No  IN " +
                 "( select Article_Status_Users.Article_No  from Article_Status_Users where Article_Status_Users.Status_No " +
                 " IN ( select  Status.Status_No  from Status where Status.Family_Role_No IN  " +
                 " ( select Family_Role.Family_Role_No from Family_Role where Family_Role.Family_Role_Name LIKE 'Reviewer' ) " +
                 " AND Status.Status_Name LIKE 'Complete Review'  )AND Article_Status_Users.User_No=@User_No)  ";

            commands.Parameters.Add("@User_No", System.Data.SqlDbType.Int);
            commands.Parameters["@User_No"].Value = usr_NO;
            commands.Parameters.Add("@Lower_User_No", System.Data.SqlDbType.Int);
            commands.Parameters["@Lower_User_No"].Value = usr_NO;
            Read_Question = commands.ExecuteReader();
            Read_Question.Read();
            int New_Reviewer_Complete_Variable = (int)(Read_Question[0]);
            if (New_Reviewer_Complete_Variable > 0)
            {
                Completed_Assignments_count.Text = "(" + New_Reviewer_Complete_Variable + ")";

                Completed_Assignments.Enabled = true;
                Read_Question.Close();

                connect.Close();
            }
            else
            {
                Completed_Assignments_count.Text = "(0)";
                Completed_Assignments.Enabled = false;
                Read_Question.Close();

                connect.Close();
            }
        }
        else
        {
            Completed_Assignments_count.Text = "(0)";
            Read_Question.Close();
            connect.Close();
        }


        // }
        // catch
        // {
        //  Completed_Assignments_count.Text = "(0)";
        //  }
        // finally
        //  {
        commands.Parameters.Clear();
        connect.Close();
        // }
        //end^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^Completed assignment
    }
    protected void New_Reviewer_Invitationss_Click(object sender, EventArgs e)
    {

    }
    protected void Pending_Assignment_Click(object sender, EventArgs e)
    {

    }
}
