using System;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.SessionState;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Data.SqlClient;


public partial class Default : System.Web.UI.Page
{
    
 
    int usr_NO;
    FunctionSumation ob = new FunctionSumation();
    SqlConnection connect;
 
   SqlCommand commands = new SqlCommand();
    SqlDataReader Read_Question;
    protected void Page_Load(object sender, EventArgs e)
    {
         connect = ob.connect;
       
        Session["User_No"] = 1;

        usr_NO = Convert.ToInt16(Session["User_No"]);
        // ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^NEW SUBMISSIONS REQUIRING ASSIGNMENT^^^^^^^^^^
        try
        {
            connect.Close();
            connect.Open();
            commands.Connection = connect;


            commands.CommandText = " select  " +
                "  Users.User_Name  from Users  where Users.User_No  IN (select  User_Role.User_No from User_Role  " +
                "  where User_Role.Role_No IN (select Role.Role_No  from Role  where Family_Role_No IN (select Family_Role.Family_Role_No from Family_Role " +
                " where Family_Role.Family_Role_Name LIKE 'Editor' )AND Role.Role_Name LIKE 'Managing Editor')) AND Users.User_No IN (select User_Permission.User_No from  User_Permission" +
                " where User_Permission.Permission_No IN (select Secondary_Permission.Permission_No  from  Secondary_Permission where Secondary_Permission.Permission_Type_No" +
                " IN( select Primary_Permission.Permission_Type_No from  Primary_Permission where  Primary_Permission.Permission_Type_Name LIKE 'Manager')AND Secondary_Permission.Permission_Name LIKE 'New Submission Requiring Assignment'   ) ) " +
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
           " ( select Current_Status.Article_No from  Current_Status where  " +
                       "  Current_Status.Current_Status_Name LIKE 'Submitted'  ) AND Articles.Article_Revision LIKE '0'" +
                  "OR Articles.Article_No IN " +
                        "( select Article_Status_Users.Article_No  from Article_Status_Users where Article_Status_Users.Status_No " +
                       " IN ( select  Status.Status_No  from Status where Status.Family_Role_No IN  " +
                       " ( select Family_Role.Family_Role_No from Family_Role where Family_Role.Family_Role_Name LIKE 'Editor' ) " +
                       " AND Status.Status_Name LIKE 'Recieved'  )AND Article_Status_Users.User_No=@User_No )AND Articles.Article_Revision LIKE '0' " +

                       " AND Articles.Article_No NOT IN (select Article_User.Article_No   from Article_User where  " +
                " Article_User.Family_Role_No IN  ( select Family_Role.Family_Role_No from  Family_Role where  " +
                                     "  Family_Role.Family_Role_Name  LIKE 'Editor' ) AND  Upper_User_no=@Upper_User_no) " +
             "GROUP BY Article_Revision";
                commands.Parameters.Add("@User_No", System.Data.SqlDbType.Int);
                commands.Parameters["@User_No"].Value = usr_NO;
                commands.Parameters.Add("@Upper_User_no", System.Data.SqlDbType.Int);
                commands.Parameters["@Upper_User_no"].Value = usr_NO;
                Read_Question = commands.ExecuteReader();
                Read_Question.Read();
                int Number_of_Article_Requiring_Assignment = (int)(Read_Question[0]);
                if (Number_of_Article_Requiring_Assignment > 0)
                {
                    New_Submission_Requering_Assignment_Count.Text = "(" + Number_of_Article_Requiring_Assignment + ")";

                    New_Submission_Requering_Assignment.Enabled = true;
                    Read_Question.Close();

                    connect.Close();
                }
                else
                {
                    New_Submission_Requering_Assignment.Enabled = false;
                    Read_Question.Close();

                    connect.Close();
                }
            }
            else
            {
                Read_Question.Close();
                connect.Close();
            }


        }
        catch
        {
            New_Submission_Requering_Assignment_Count.Text = "(0)";
        }
        finally
        {
            commands.Parameters.Clear();
            connect.Close();
        }

        //END ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^NEW SUBMISSIONS REQUIRING ASSIGNMENT^^^^^^^^^^                                                     إختبار الصلاحيه direct_to_direct_NEW_Submission 

        // ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^Resived SUBMISSIONS REQUIRING ASSIGNMENT^^^^^^^^^^
        try
        {
            connect.Close();
            connect.Open();
            commands.Connection = connect;
            commands.CommandText = " select  " +
                "  Users.User_Name  from Users  where Users.User_No  IN (select  User_Role.User_No from User_Role  " +
                "  where User_Role.Role_No IN (select Role.Role_No  from Role  where Family_Role_No IN (select Family_Role.Family_Role_No from Family_Role " +
                " where Family_Role.Family_Role_Name LIKE 'Editor' )AND Role.Role_Name LIKE 'Managing Editor')) AND Users.User_No IN (select User_Permission.User_No from  User_Permission" +
                " where User_Permission.Permission_No IN (select Secondary_Permission.Permission_No  from  Secondary_Permission where Secondary_Permission.Permission_Type_No" +
                " IN( select Primary_Permission.Permission_Type_No from  Primary_Permission where  Primary_Permission.Permission_Type_Name LIKE 'Manager')AND Secondary_Permission.Permission_Name LIKE 'Resived Submissions Requiring Assignment'   ) ) " +
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
           " ( select Current_Status.Article_No from  Current_Status where  " +
                       "  Current_Status.Current_Status_Name LIKE 'Submitted' )AND Articles.Article_Revision NOT LIKE '0' " +
                       "OR Articles.Article_No IN " +
                       "( select Article_Status_Users.Article_No  from Article_Status_Users where Article_Status_Users.Status_No " +
                      " IN ( select  Status.Status_No  from Status where Status.Family_Role_No IN  " +
                      " ( select Family_Role.Family_Role_No from Family_Role where Family_Role.Family_Role_Name LIKE 'Editor' ) " +
                      " AND Status.Status_Name LIKE 'Recieved'  )AND Article_Status_Users.User_No=@User_No )AND Articles.Article_Revision NOT LIKE '0' " +
                          " AND Articles.Article_No NOT IN (select Article_User.Article_No   from Article_User where  " +
                " Article_User.Family_Role_No IN  ( select Family_Role.Family_Role_No from  Family_Role where  " +
                                     "  Family_Role.Family_Role_Name  LIKE 'Editor' ) AND  Upper_User_no=@Upper_User_no ) " +
                      "GROUP BY Article_Revision";
                commands.Parameters.Add("@User_No", System.Data.SqlDbType.Int);
                commands.Parameters["@User_No"].Value = usr_NO;
                commands.Parameters.Add("@Upper_User_no", System.Data.SqlDbType.Int);
                commands.Parameters["@Upper_User_no"].Value = usr_NO;

                Read_Question = commands.ExecuteReader();
                Read_Question.Read();
                int Number_of_Resived_Article_Requiring_Assignment = (int)(Read_Question[0]);
                if (Number_of_Resived_Article_Requiring_Assignment > 0)
                {
                    Revised_Submission_Requering_Assignment_Count.Text = "(" + Number_of_Resived_Article_Requiring_Assignment + ")";

                    Revised_Submission_Requering_Assignment.Enabled = true;
                    Read_Question.Close();

                    connect.Close();
                }
                else
                {
                    Revised_Submission_Requering_Assignment_Count.Text = "(0)";
                    Revised_Submission_Requering_Assignment.Enabled = false;
                    Read_Question.Close();

                    connect.Close();
                }
            }
            else
            {
                Revised_Submission_Requering_Assignment_Count.Text = "(0)";

                Read_Question.Close();
                connect.Close();
            }


        }
        catch
        {
            Revised_Submission_Requering_Assignment_Count.Text = "(0)";
        }
        finally
        {
            commands.Parameters.Clear();
            connect.Close();
        }
        //END ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^Resived SUBMISSIONS REQUIRING ASSIGNMENT^^^^^^^^^^  
        // ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^Direct_To_Direct_New_Submission^^^^^^^^^^
        try
        {

            connect.Close();
            connect.Open();
            commands.Connection = connect;
            commands.CommandText = " select  " +
                "  Users.User_Name  from Users  where Users.User_No  IN (select  User_Role.User_No from User_Role  " +
                "  where User_Role.Role_No IN (select Role.Role_No  from Role  where Family_Role_No IN (select Family_Role.Family_Role_No from Family_Role " +
                " where Family_Role.Family_Role_Name LIKE 'Editor' )AND Role.Role_Name LIKE 'Editor_in_Chief')) AND Users.User_No IN (select User_Permission.User_No from  User_Permission" +
                " where User_Permission.Permission_No IN (select Secondary_Permission.Permission_No  from  Secondary_Permission where Secondary_Permission.Permission_Type_No" +
                " IN( select Primary_Permission.Permission_Type_No from  Primary_Permission where  Primary_Permission.Permission_Type_Name LIKE 'Direct To Editor')AND Secondary_Permission.Permission_Name LIKE 'Direct To Editor New Submission'   ) ) " +
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
           " ( select Current_Status.Article_No from  Current_Status where  " +
                       "  Current_Status.Current_Status_Name LIKE 'Submitted' )  AND Articles.Article_Revision LIKE '0'" +
                       " OR Articles.Article_No IN " +
                       "( select Article_Status_Users.Article_No  from Article_Status_Users where Article_Status_Users.Status_No " +
                      " IN ( select  Status.Status_No  from Status where Status.Family_Role_No IN  " +
                      " ( select Family_Role.Family_Role_No from Family_Role where Family_Role.Family_Role_Name LIKE 'Editor' ) " +
                      " AND Status.Status_Name LIKE 'Recieved'  )AND Article_Status_Users.User_No=@User_No )" +
                        " AND Articles.Article_No NOT IN (select Article_User.Article_No   from Article_User where  " +
                " Article_User.Family_Role_No IN  ( select Family_Role.Family_Role_No from  Family_Role where  " +
                                     "  Family_Role.Family_Role_Name  LIKE 'Editor' ) AND  Upper_User_no=@Upper_User_no) " +
                      "    AND Articles.Article_Revision LIKE '0' " +
                       "GROUP BY Article_Revision";
                commands.Parameters.Add("@User_No", System.Data.SqlDbType.Int);
                commands.Parameters["@User_No"].Value = usr_NO;
                commands.Parameters.Add("@Upper_User_no", System.Data.SqlDbType.Int);
                commands.Parameters["@Upper_User_no"].Value = usr_NO;
                Read_Question = commands.ExecuteReader();
                Read_Question.Read();
                int Number_of_Article_Direct_To_Editor = (int)(Read_Question[0]);
                if (Number_of_Article_Direct_To_Editor > 0)
                {
                    number_of_article_Count.Text = "(" + Number_of_Article_Direct_To_Editor + ")";

                    Direct_To_Editor_Ne_Submissions.Enabled = true;
                    Read_Question.Close();

                    connect.Close();
                }
                else
                {
                    number_of_article_Count.Text = "(0)";
                    Direct_To_Editor_Ne_Submissions.Enabled = false;
                    Read_Question.Close();

                    connect.Close();
                }
            }
            else
            {
                number_of_article_Count.Text = "(0)";
                Read_Question.Close();
                connect.Close();
            }


        }
        catch
        {
            number_of_article_Count.Text = "(0)";
        }
        finally
        {
            commands.Parameters.Clear();
            connect.Close();
        }
        //END ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^Direct To Editor New Submission^^^^^^^^^^  
        // ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^Direct_To_Direct_Resived_Submission^^^^^^^^^^
        try
        {

            connect.Close();
            connect.Open();
            commands.Connection = connect;
            commands.CommandText = " select  " +
                "  Users.User_Name  from Users  where Users.User_No  IN (select  User_Role.User_No from User_Role  " +
                "  where User_Role.Role_No IN (select Role.Role_No  from Role  where Family_Role_No IN (select Family_Role.Family_Role_No from Family_Role " +
                " where Family_Role.Family_Role_Name LIKE 'Editor' )AND Role.Role_Name LIKE 'Editor_in_Chief')) AND Users.User_No IN (select User_Permission.User_No from  User_Permission" +
                " where User_Permission.Permission_No IN (select Secondary_Permission.Permission_No  from  Secondary_Permission where Secondary_Permission.Permission_Type_No" +
                " IN( select Primary_Permission.Permission_Type_No from  Primary_Permission where  Primary_Permission.Permission_Type_Name LIKE 'Direct To Editor')AND Secondary_Permission.Permission_Name LIKE 'Direct To Editor Resived Submission'   ) ) " +
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
           " ( select Current_Status.Article_No from  Current_Status where  " +
                       "  Current_Status.Current_Status_Name LIKE 'Submitted' )AND Articles.Article_Revision NOT LIKE '0' " +
                        "OR Articles.Article_No IN " +
                       "( select Article_Status_Users.Article_No  from Article_Status_Users where Article_Status_Users.Status_No " +
                      " IN ( select  Status.Status_No  from Status where Status.Family_Role_No IN  " +
                      " ( select Family_Role.Family_Role_No from Family_Role where Family_Role.Family_Role_Name LIKE 'Editor' ) " +
                      " AND Status.Status_Name LIKE 'Recieved'  )AND Article_Status_Users.User_No=@User_No )AND Articles.Article_Revision NOT LIKE '0' " +
                       " AND Articles.Article_No NOT IN (select Article_User.Article_No   from Article_User where  " +
                " Article_User.Family_Role_No IN  ( select Family_Role.Family_Role_No from  Family_Role where  " +
                                     "  Family_Role.Family_Role_Name  LIKE 'Editor' ) AND  Upper_User_no=@Upper_User_no) " +
                      "GROUP BY Article_Revision";
                commands.Parameters.Add("@User_No", System.Data.SqlDbType.Int);
                commands.Parameters["@User_No"].Value = usr_NO;
                commands.Parameters.Add("@Upper_User_no", System.Data.SqlDbType.Int);
                commands.Parameters["@Upper_User_no"].Value = usr_NO;

                Read_Question = commands.ExecuteReader();
                Read_Question.Read();
                int Number_of_Article_Direct_To_Editor = (int)(Read_Question[0]);
                if (Number_of_Article_Direct_To_Editor > 0)
                {
                    Number_Of_Revised_Submission.Text = "(" + Number_of_Article_Direct_To_Editor + ")";

                    Direct_To_Editor_Revised_Submission.Enabled = true;
                    Read_Question.Close();

                    connect.Close();
                }
                else
                {
                    Number_Of_Revised_Submission.Text = "(0)";
                    Direct_To_Editor_Revised_Submission.Enabled = false;
                    Read_Question.Close();

                    connect.Close();
                }
            }
            else
            {
                Number_Of_Revised_Submission.Text = "(0)";
                Read_Question.Close();
                connect.Close();
            }


        }
        catch
        {
            Number_Of_Revised_Submission.Text = "(0)";
        }
        finally
        {
            commands.Parameters.Clear();
            connect.Close();
        }
        //END ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^Direct To Editor resived Submission^^^^^^^^^^  

        /* try
         {
             connect.Close();
             connect.Open();
             commands.Connection = connect;


             comm1.CommandText = " select count(Article_No) from Article_User   " +
                 " where Article_User.User_No  IN (select Users.User_No from Users  where Users.User_No  IN (select  User_Role.User_No from User_Role  " +
                 "  where Role_No IN (select Role.Role_No  from Role  where Family_Role_No IN (select Family_Role.Family_Role_No from Family_Role " +
                 " where Family_Role.Family_Role_Name LIKE 'Editor' )  )) AND Users.User_No IN (select User_Permission.User_No from  User_Permission" +
                 " where User_Permission.Permission_No IN (select Secondary_Permission.Permission_No  from  Secondary_Permission where Secondary_Permission.Permission_Type_No1" +
                 " IN( select Primary_Permission.Permission_Type_No1 from  Primary_Permission where  Primary_Permission.Permission_Type_Name LIKE 'Direct_To_Direct')  ) ) " +
                       "AND  Users.User_No=1  )    AND Article_User.Article_No  IN (select Abstract.Article_No  from Abstract where Abstract.Article_No IN( select Current_Status.Article_No from  Current_Status where  " +
                       "  Current_Status.Current_Status_Name LIKE 'Submitted' )AND Abstract.Article_Revision LIKE '0') "+
                "group by  Article_User.User_No  ";
             Read_Question = comm1.ExecuteReader();
             Read_Question.Read();

             Response.Write(Convert.ToString(Read_Question[0] + "</br>"));
             int Number_of_Article = (int)(Read_Question[0]);
            if (Number_of_Article   >0  )
             {
                 number_of_article.Text = "("+ Number_of_Article+")";
               
                 Direct_To_Editor_Ne_Submissions.Enabled = true ;
                 Read_Question.Close();
           
             conf.Close();
             }
             else {
                 Direct_To_Editor_Ne_Submissions.Enabled = false;
                 Read_Question.Close();
           
             conf.Close();
             }
           

         }
       catch
        {
        }
       finally {
            conf.Close();
       }*/
        //^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^ Submissions Needing Aproval^^^^^^^^^^^^^^^^^^^^^^^^^^

        try
        {
            connect.Close();
            connect.Open();
            commands.Connection = connect;
            //                                                
            commands.CommandText = " select count(Article_No) from Articles where Articles.Article_No IN (select Article_User.Article_No  from Article_User  " +
                " where Article_User.Lower_User_No  IN (select Users.User_No from Users  where Users.User_No  IN (select  User_Role.User_No from User_Role  " +
                "  where Role_No IN (select Role.Role_No  from Role  where Family_Role_No IN (select Family_Role.Family_Role_No from Family_Role " +
                " where Family_Role.Family_Role_Name LIKE 'Editor' )AND Role.Role_Name LIKE 'Editor_in_Chief' OR  Role.Role_Name LIKE 'Associate Editor'  )) AND Users.User_No IN (select User_Permission.User_No from  User_Permission" +
                " where User_Permission.Permission_No IN (select Secondary_Permission.Permission_No  from  Secondary_Permission where Secondary_Permission.Permission_Type_No" +
                " IN( select Primary_Permission.Permission_Type_No from  Primary_Permission where  Primary_Permission.Permission_Type_Name LIKE 'New Submissions' ) AND" +
                "    Secondary_Permission.Permission_Name LIKE 'New Assignment'  ) ) " +
                      "AND  Users.User_No=@User_No  ) AND Article_User.Family_Role_No IN(select Family_Role.Family_Role_No from Family_Role " +
                " where Family_Role.Family_Role_Name LIKE 'Editor' )  )    AND Articles.Article_No  IN (select Current_Status.Article_No from  Current_Status where  " +
                      "  Current_Status.Current_Status_Name LIKE 'Build PDF' OR  Current_Status.Current_Status_Name LIKE 'Edit Submission'  ) " +

                      " AND Articles.Article_No IN(select Article_Status_Users.Article_No from Article_Status_Users where  Article_Status_Users.Status_No " +
                " IN(select  Status.Status_No  from Status where  Status.Family_Role_No IN(select Family_Role.Family_Role_No from Family_Role where  Family_Role.Family_Role_Name LIKE 'Editor' ) " +
                " AND Status.Status_Name LIKE 'Edit Submission')AND  Article_Status_Users.User_No=@User_No )" +

                      " AND Articles.Article_No IN(select Article_Status_Users.Article_No from Article_Status_Users where  Article_Status_Users.Status_No " +
                " IN(select  Status.Status_No  from Status where  Status.Family_Role_No IN(select Family_Role.Family_Role_No from Family_Role where  Family_Role.Family_Role_Name LIKE 'Editor' ) " +
                " AND Status.Status_Name LIKE 'Build PDF')AND  Article_Status_Users.User_No=@User_No )" +

                        " AND Articles.Article_No NOT IN(select Article_Status_Users.Article_No from Article_Status_Users where  Article_Status_Users.Status_No " +
                " IN(select  Status.Status_No  from Status where  Status.Family_Role_No IN(select Family_Role.Family_Role_No from Family_Role where  Family_Role.Family_Role_Name LIKE 'Editor' ) " +
                " AND Status.Status_Name LIKE 'Send Back To Author')AND  Article_Status_Users.User_No=@User_No )" +
                      "    ";
            commands.Parameters.Add("@User_No", System.Data.SqlDbType.Int);
            commands.Parameters["@User_No"].Value = usr_NO;
            Read_Question = commands.ExecuteReader();
            Read_Question.Read();

            int Number_of_Needing_Approval = (int)(Read_Question[0]);
            if (Number_of_Needing_Approval > 0)
            {
                SubmissionNeedingApproval.Text = "(" + Number_of_Needing_Approval + ")";

                SubmissionNeedingApprovalEdit.Enabled = true;
                Read_Question.Close();

                connect.Close();
            }
            else
            {
                SubmissionNeedingApprovalEdit.Enabled = false;
                Read_Question.Close();
                SubmissionNeedingApproval.Text = "(0)";
                connect.Close();
            }


        }
        catch
        {
            SubmissionNeedingApproval.Text = "(0)";
        }
        finally
        {
            commands.Parameters.Clear();
            connect.Close();
        }

        //END^^^^^^^^^^^^^^  ^^^^^^^^^^^^^^^^^^ Submissions Needing Aproval ^^^^^^^^^^^^^^^^^^^^^^^^^^^^
        //^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^ Submissions Send Back To Author Aproval^^^^^^^^^^^^^^^^^^^^^^^^^^

        try
        {
            connect.Close();
            connect.Open();
            commands.Connection = connect;
            //                                                
            commands.CommandText = " select count(Article_No) from Articles where Articles.Article_No IN (select Article_User.Article_No  from Article_User  " +
                " where Article_User.Lower_User_No  IN (select Users.User_No from Users  where Users.User_No  IN (select  User_Role.User_No from User_Role  " +
                "  where Role_No IN (select Role.Role_No  from Role  where Family_Role_No IN (select Family_Role.Family_Role_No from Family_Role " +
                " where Family_Role.Family_Role_Name LIKE 'Editor' )AND Role.Role_Name LIKE 'Editor_in_Chief' OR  Role.Role_Name LIKE 'Associate Editor'  )) AND Users.User_No IN (select User_Permission.User_No from  User_Permission" +
                " where User_Permission.Permission_No IN (select Secondary_Permission.Permission_No  from  Secondary_Permission where Secondary_Permission.Permission_Type_No" +
                " IN( select Primary_Permission.Permission_Type_No from  Primary_Permission where  Primary_Permission.Permission_Type_Name LIKE 'New Submissions' ) AND" +
                "    Secondary_Permission.Permission_Name LIKE 'New Assignment'  ) ) " +
                      "AND  Users.User_No=@User_No  ) AND Article_User.Family_Role_No IN(select Family_Role.Family_Role_No from Family_Role " +
                " where Family_Role.Family_Role_Name LIKE 'Editor' )  ) " +

                      " AND Articles.Article_No IN(select Article_Status_Users.Article_No from Article_Status_Users where  Article_Status_Users.Status_No " +
                  " IN(select  Status.Status_No  from Status where  Status.Family_Role_No IN(select Family_Role.Family_Role_No from Family_Role where  Family_Role.Family_Role_Name LIKE 'Editor' ) " +
                  " AND Status.Status_Name LIKE 'Edit Submission')AND  Article_Status_Users.User_No=@User_No )" +

                        " AND Articles.Article_No IN(select Article_Status_Users.Article_No from Article_Status_Users where  Article_Status_Users.Status_No " +
                  " IN(select  Status.Status_No  from Status where  Status.Family_Role_No IN(select Family_Role.Family_Role_No from Family_Role where  Family_Role.Family_Role_Name LIKE 'Editor' ) " +
                  " AND Status.Status_Name LIKE 'Build PDF')AND  Article_Status_Users.User_No=@User_No )" +

                       " AND Articles.Article_No IN(select Article_Status_Users.Article_No from Article_Status_Users where  Article_Status_Users.Status_No " +
                  " IN(select  Status.Status_No  from Status where  Status.Family_Role_No IN(select Family_Role.Family_Role_No from Family_Role where  Family_Role.Family_Role_Name LIKE 'Editor' ) " +
                  " AND Status.Status_Name LIKE 'Send Back To Author')AND  Article_Status_Users.User_No=@User_No )" +

                  " AND Articles.Article_No NOT IN(select Article_Status_Users.Article_No from Article_Status_Users where  Article_Status_Users.Status_No " +
                  " IN(select  Status.Status_No  from Status where  Status.Family_Role_No IN(select Family_Role.Family_Role_No from Family_Role where  Family_Role.Family_Role_Name LIKE 'Author' ) " +
                  " AND Status.Status_Name LIKE 'Approve By Author'))" +
                      "   ";
            commands.Parameters.Add("@User_No", System.Data.SqlDbType.Int);
            commands.Parameters["@User_No"].Value = usr_NO;
            Read_Question = commands.ExecuteReader();
            Read_Question.Read();

           int Submission_Send_back_to_Author_for_Approvall = (int)(Read_Question[0]);
            if (Submission_Send_back_to_Author_for_Approvall > 0)
            {
                Submission_Send_back_to_Author_for_Approval_count.Text = "(" + Submission_Send_back_to_Author_for_Approvall + ")";

                Submission_Send_back_to_Author_for_Approval.Enabled = true;
                Read_Question.Close();

                connect.Close();
            }
            else
            {
                Submission_Send_back_to_Author_for_Approval.Enabled = false;
                Read_Question.Close();
                Submission_Send_back_to_Author_for_Approval_count.Text = "(0)";
                connect.Close();
            }


        }
        catch
        {
            Submission_Send_back_to_Author_for_Approval_count.Text = "(0)";
        }
        finally
        {
            commands.Parameters.Clear();
            connect.Close();
        }//END^^^^^^^^^^^^^^  ^^^^^^^^^^^^^^^^^^ Submissions Send Back To Author Aproval ^^^^^^^^^^^^^^^^^^^^^^^^^^^^
        //^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^  Submissions   Author Aproval^^^^^^^^^^^^^^^^^^^^^^^^^^

        try
        {
            connect.Close();
            connect.Open();
            commands.Connection = connect;
            //                                                
            commands.CommandText = " select count(Article_No) from Articles where Articles.Article_No IN (select Article_User.Article_No  from Article_User  " +
                " where Article_User.Lower_User_No  IN (select Users.User_No from Users  where Users.User_No  IN (select  User_Role.User_No from User_Role  " +
                "  where Role_No IN (select Role.Role_No  from Role  where Family_Role_No IN (select Family_Role.Family_Role_No from Family_Role " +
                " where Family_Role.Family_Role_Name LIKE 'Editor' )AND Role.Role_Name LIKE 'Editor_in_Chief' OR  Role.Role_Name LIKE 'Associate Editor'  )) AND Users.User_No IN (select User_Permission.User_No from  User_Permission" +
                " where User_Permission.Permission_No IN (select Secondary_Permission.Permission_No  from  Secondary_Permission where Secondary_Permission.Permission_Type_No" +
                " IN( select Primary_Permission.Permission_Type_No from  Primary_Permission where  Primary_Permission.Permission_Type_Name LIKE 'New Submissions' ) AND" +
                "    Secondary_Permission.Permission_Name LIKE 'New Assignment'  ) ) " +
                      "AND  Users.User_No=@User_No  ) AND Article_User.Family_Role_No IN(select Family_Role.Family_Role_No from Family_Role " +
                " where Family_Role.Family_Role_Name LIKE 'Editor' )  ) " +

                      " AND Articles.Article_No IN(select Article_Status_Users.Article_No from Article_Status_Users where  Article_Status_Users.Status_No " +
                  " IN(select  Status.Status_No  from Status where  Status.Family_Role_No IN(select Family_Role.Family_Role_No from Family_Role where  Family_Role.Family_Role_Name LIKE 'Editor' ) " +
                  " AND Status.Status_Name LIKE 'Edit Submission')AND  Article_Status_Users.User_No=@User_No )" +

                        " AND Articles.Article_No IN(select Article_Status_Users.Article_No from Article_Status_Users where  Article_Status_Users.Status_No " +
                  " IN(select  Status.Status_No  from Status where  Status.Family_Role_No IN(select Family_Role.Family_Role_No from Family_Role where  Family_Role.Family_Role_Name LIKE 'Editor' ) " +
                  " AND Status.Status_Name LIKE 'Build PDF')AND  Article_Status_Users.User_No=@User_No )" +

                       " AND Articles.Article_No IN(select Article_Status_Users.Article_No from Article_Status_Users where  Article_Status_Users.Status_No " +
                  " IN(select  Status.Status_No  from Status where  Status.Family_Role_No IN(select Family_Role.Family_Role_No from Family_Role where  Family_Role.Family_Role_Name LIKE 'Editor' ) " +
                  " AND Status.Status_Name LIKE 'Send Back To Author')AND  Article_Status_Users.User_No=@User_No )" +

                       " AND Articles.Article_No IN(select Article_Status_Users.Article_No from Article_Status_Users where  Article_Status_Users.Status_No " +
                  " IN(select  Status.Status_No  from Status where  Status.Family_Role_No IN(select Family_Role.Family_Role_No from Family_Role where  Family_Role.Family_Role_Name LIKE 'Author' ) " +
                  " AND Status.Status_Name LIKE 'Approve By Author'))" +
                   "AND Articles.Article_No NOT IN " +
                  "( select Article_Status_Users.Article_No  from Article_Status_Users where Article_Status_Users.Status_No " +
                  " IN ( select  Status.Status_No  from Status where Status.Family_Role_No IN  " +
                  " ( select Family_Role.Family_Role_No from Family_Role where Family_Role.Family_Role_Name LIKE 'Editor' ) " +
                  " AND   Status.Status_Name LIKE 'Complete Edit'  )AND Article_Status_Users.User_No=@User_No)" +

                      "   ";
            commands.Parameters.Add("@User_No", System.Data.SqlDbType.Int);
            commands.Parameters["@User_No"].Value = usr_NO;
            Read_Question = commands.ExecuteReader();
            Read_Question.Read();

           int Submission_Approval_By_Author_Variable = (int)(Read_Question[0]);
            if (Submission_Approval_By_Author_Variable > 0)
            {
                Submission_Approval_By_Author_Count.Text = "(" + Submission_Approval_By_Author_Variable + ")";

                Submission_Approval_By_Author.Enabled = true;
                Read_Question.Close();

                connect.Close();
            }
            else
            {
                Submission_Approval_By_Author.Enabled = false;
                Read_Question.Close();
                Submission_Approval_By_Author_Count.Text = "(0)";
                connect.Close();
            }


        }
        catch
        {
            Submission_Approval_By_Author_Count.Text = "(0)";
        }
        finally
        {
            commands.Parameters.Clear();
            connect.Close();
        }//END^^^^^^^^^^^^^^  ^^^^^^^^^^^^^^^^^^ Submissions   Author Aproval ^^^^^^^^^^^^^^^^^^^^^^^^^^^^



        //^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^ Incomplete Submissin^^^^^^^^^^^^^^^^^^^^^^^^^^

        try
        {
            connect.Close();
            connect.Open();
            commands.Connection = connect;

            commands.CommandText = " select count(Article_No) from Articles where Articles.Article_No IN (select Article_User.Article_No  from Article_User  " +
                " where Article_User.Lower_User_No  IN (select Users.User_No from Users  where Users.User_No  IN (select  User_Role.User_No from User_Role  " +
                "  where Role_No IN (select Role.Role_No  from Role  where Family_Role_No IN (select Family_Role.Family_Role_No from Family_Role " +
                " where Family_Role.Family_Role_Name LIKE 'Editor' )AND Role.Role_Name LIKE 'Editor_in_Chief' OR  Role.Role_Name LIKE 'Associate Editor'  )) AND Users.User_No IN (select User_Permission.User_No from  User_Permission" +
                " where User_Permission.Permission_No IN (select Secondary_Permission.Permission_No  from  Secondary_Permission where Secondary_Permission.Permission_Type_No" +
                " IN( select Primary_Permission.Permission_Type_No from  Primary_Permission where  Primary_Permission.Permission_Type_Name LIKE 'New Submissions' ) AND" +
                "    Secondary_Permission.Permission_Name LIKE 'New Assignment'  ) ) " +
                      "AND  Users.User_No=@User_No  ) AND Article_User.Family_Role_No IN(select Family_Role.Family_Role_No from Family_Role " +
                " where Family_Role.Family_Role_Name LIKE 'Editor' )  )    AND Articles.Article_No  IN (select Current_Status.Article_No from  Current_Status where  " +
                      "  Current_Status.Current_Status_Name LIKE 'Edit Submission' )  " +

                      " AND Articles.Article_No IN(select Article_Status_Users.Article_No from Article_Status_Users where  Article_Status_Users.Status_No " +
                  " IN(select  Status.Status_No  from Status where  Status.Family_Role_No IN(select Family_Role.Family_Role_No from Family_Role where  Family_Role.Family_Role_Name LIKE 'Editor' ) " +
                  " AND Status.Status_Name LIKE 'Edit Submission')AND  Article_Status_Users.User_No=@User_No )" +

                        " AND  Articles.Article_No NOT IN(select Article_Status_Users.Article_No from Article_Status_Users where  Article_Status_Users.Status_No " +
                  " IN(select  Status.Status_No  from Status where  Status.Family_Role_No IN(select Family_Role.Family_Role_No from Family_Role where  Family_Role.Family_Role_Name LIKE 'Editor' ) " +
                  " AND Status.Status_Name LIKE 'Build PDF')AND  Article_Status_Users.User_No=@User_No )" +
                      "  ";
            commands.Parameters.Add("@User_No", System.Data.SqlDbType.Int);
            commands.Parameters["@User_No"].Value = usr_NO;
            Read_Question = commands.ExecuteReader();
            Read_Question.Read();

           int Incomplete_Submissions_Variable = (int)(Read_Question[0]);
            if (Incomplete_Submissions_Variable > 0)
            {
                Incomplete_Submissions_Count.Text = "(" + Incomplete_Submissions_Variable + ")";

                Incomplete_Submissions.Enabled = true;
                Read_Question.Close();

                connect.Close();
            }
            else
            {
                Incomplete_Submissions.Enabled = false;
                Incomplete_Submissions_Count.Text = "(0)";
                Read_Question.Close();
                connect.Close();
            }
        }
        catch
        {
            Incomplete_Submissions_Count.Text = "(0)";
        }
        finally
        {
            commands.Parameters.Clear();
            connect.Close();
        }
        //END^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^  Incomplete Submissin^ ^^^^^^^^^^^^^^^^^^^^^^^^^^^^


        //^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^ New Invitation^^^^^^^^^^^^^^^^^^^^^^^^^^

        try
        {
            connect.Close();
            connect.Open();
            commands.Connection = connect;
            commands.CommandText = " select count(Article_No) from Articles where Articles.Article_No IN ( select Article_User.Article_No  from Article_User  " +
                " where Article_User.Lower_User_No  IN (select Users.User_No from Users  where Users.User_No  IN ( select  User_Role.User_No from User_Role  " +
                "  where Role_No IN ( select Role.Role_No  from Role  where Family_Role_No IN ( select  Family_Role.Family_Role_No from Family_Role " +
                " where Family_Role.Family_Role_Name LIKE 'Editor' )AND   Role.Role_Name LIKE 'Associate Editor'  )) " +
                " AND Users.User_No IN ( select User_Permission.User_No from  User_Permission" +
                " where User_Permission.Permission_No IN ( select Secondary_Permission.Permission_No  from " +
                " Secondary_Permission where Secondary_Permission.Permission_Type_No" +
                " IN( select Primary_Permission.Permission_Type_No from  Primary_Permission where " +
                " Primary_Permission.Permission_Type_Name LIKE 'New Submissions' ) AND " +
                "Secondary_Permission.Permission_Name LIKE 'Recive Assignment With Invitation'  ) ) " +
                " AND  Users.User_No=@User_No  ) AND Article_User.Family_Role_No IN(select Family_Role.Family_Role_No from Family_Role " +
                " where Family_Role.Family_Role_Name LIKE 'Editor' )) " +
                           "AND Articles.Article_No  IN " +
                      "( select Article_Status_Users.Article_No  from Article_Status_Users where Article_Status_Users.Status_No " +
                      " IN ( select  Status.Status_No  from Status where Status.Family_Role_No IN  " +
                      " ( select Family_Role.Family_Role_No from Family_Role where Family_Role.Family_Role_Name LIKE 'Editor' ) " +
                      " AND Status.Status_Name LIKE 'Editor Invite'  ) AND Article_Status_Users.User_No=@User_No )  " +
                      "AND Articles.Article_No NOT IN " +
                      "( select Article_Status_Users.Article_No  from Article_Status_Users where Article_Status_Users.Status_No " +
                      " IN ( select  Status.Status_No  from Status where Status.Family_Role_No IN  " +
                      " ( select Family_Role.Family_Role_No from Family_Role where Family_Role.Family_Role_Name LIKE 'Editor' ) " +
                      " AND Status.Status_Name LIKE 'Editor Assign' OR Status.Status_Name LIKE 'Decline Edit'OR Status.Status_Name LIKE 'Complete Edit' ) AND Article_Status_Users.User_No=@User_No ) ";
            commands.Parameters.Add("@User_No", System.Data.SqlDbType.Int);
            commands.Parameters["@User_No"].Value = usr_NO;
            Read_Question = commands.ExecuteReader();
            Read_Question.Read();
            commands.Parameters.Clear();

            int New_Invitation_Variable = (int)(Read_Question[0]);
            if (New_Invitation_Variable > 0)
            {
                New_Invitation_Count.Text = "(" + New_Invitation_Variable + ")";

                New_Invitation.Enabled = true;
                Read_Question.Close();
                connect.Close();
            }
            else
            {
                New_Invitation.Enabled = false;
                New_Invitation_Count.Text = "(0)";
                Read_Question.Close();
                connect.Close();
            }


        }
        catch
        {
            New_Invitation_Count.Text = "(0)";
        }
        finally
        {
            commands.Parameters.Clear();
            connect.Close();
        }

        //END^^^^^^^^^^^^^^  ^^^^^^^^^^^^^^^^^^  New Invitation ^^^^^^^^^^^^^^^^^^^^^^^^^^^^

        //^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^ New Assignment^^^^^^^^^^^^^^^^^^^^^^^^^^

        try
        {

            connect.Close();
            connect.Open();
            commands.Connection = connect;
            commands.CommandText = " select count(Article_No) from Articles where Articles.Article_No IN ( select Article_User.Article_No  from Article_User  " +
                " where Article_User.Assign_Complete=0 AND " +
                "  Article_User.Lower_User_No  IN (select Users.User_No from Users  where Users.User_No  IN ( select  User_Role.User_No from User_Role  " +
                "  where Role_No IN ( select Role.Role_No  from Role  where Family_Role_No IN ( select  Family_Role.Family_Role_No from Family_Role " +
                " where Family_Role.Family_Role_Name LIKE 'Editor' )AND Role.Role_Name LIKE 'Editor_in_Chief' OR  Role.Role_Name LIKE 'Associate Editor'  )) " +
                " AND Users.User_No IN ( select User_Permission.User_No from  User_Permission" +
                " where User_Permission.Permission_No IN ( select Secondary_Permission.Permission_No  from " +
                            " Secondary_Permission where Secondary_Permission.Permission_Type_No" +
                " IN( select Primary_Permission.Permission_Type_No from  Primary_Permission where " +
                " Primary_Permission.Permission_Type_Name LIKE 'New Submissions' ) AND " +
                "    Secondary_Permission.Permission_Name LIKE 'Recive Assignment Without Invitation' OR " +
                " Secondary_Permission.Permission_Name LIKE 'Recive Assignment With Invitation' ) ) " +
                      " AND  Users.User_No=@User_No  ) AND Article_User.Family_Role_No IN(select Family_Role.Family_Role_No from Family_Role " +
                " where Family_Role.Family_Role_Name LIKE 'Editor' ))" +
                "AND Articles.Article_No  IN " +
                      "( select Article_Status_Users.Article_No  from Article_Status_Users where Article_Status_Users.Status_No " +
                      " IN ( select  Status.Status_No  from Status where Status.Family_Role_No IN  " +
                      " ( select Family_Role.Family_Role_No from Family_Role where Family_Role.Family_Role_Name LIKE 'Editor' ) " +
                      " AND Status.Status_Name LIKE 'Editor Assign'  ) AND Article_Status_Users.User_No=@User_No )   " +
            "AND Articles.Article_No NOT IN " +
                   "( select Article_Status_Users.Article_No  from Article_Status_Users where Article_Status_Users.Status_No " +
                   " IN ( select  Status.Status_No  from Status where Status.Family_Role_No IN  " +
                   " ( select Family_Role.Family_Role_No from Family_Role where Family_Role.Family_Role_Name LIKE 'Editor' ) " +
                   " AND   Status.Status_Name LIKE 'Complete Edit' OR Status.Status_Name LIKE 'Decline Edit' OR Status.Status_Name LIKE 'Edit Submission'  )AND Article_Status_Users.User_No=@User_No) " +

                   " AND Articles.Article_No NOT IN (select Article_User.Article_No   from Article_User where  " +
                    " Article_User.Family_Role_No IN  ( select Family_Role.Family_Role_No from  Family_Role where  " +
                                         "  Family_Role.Family_Role_Name  LIKE 'Editor' ) AND  Upper_User_no=@Upper_User_no  AND Article_User.Lower_User_No!=Article_User.Upper_User_no ) ";
            commands.Parameters.Add("@User_No", System.Data.SqlDbType.Int);
            commands.Parameters["@User_No"].Value = usr_NO;
            commands.Parameters.Add("@Upper_User_no", System.Data.SqlDbType.Int);
            commands.Parameters["@Upper_User_no"].Value = usr_NO;
            Read_Question = commands.ExecuteReader();
            Read_Question.Read();
           int New_Assignment_Variable = (int)(Read_Question[0]);
            if (New_Assignment_Variable > 0)
            {
                New_Assignment_Count.Text = "(" + New_Assignment_Variable + ")";

                New_Assignment.Enabled = true;
                Read_Question.Close();
                connect.Close();
            }
            else
            {
                New_Assignment.Enabled = false;
                New_Assignment_Count.Text = "(0)";
                Read_Question.Close();
                connect.Close();
            }


        }
        catch
        {
            New_Assignment_Count.Text = "(0)";
        }
        finally
        {
            commands.Parameters.Clear();
            connect.Close();
        }

        //END^^^^^^^^^^^^^^  ^^^^^^^^^^^^^^^^^^  New Assignment ^^^^^^^^^^^^^^^^^^^^^^^^^^^^

        //^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^Submission With Required Reviews Complete^^^^^^^^^^^^^^^^^^^^^^^^^^

        try
        {

            connect.Close();
            connect.Open();
            commands.Connection = connect;
            commands.CommandText = " select count(Article_No) from Articles where Articles.Article_No IN(" +
                 "select Article_User.Article_No  from Article_User  " +
                 " where Article_User.Upper_User_no  IN(select Users.User_No from Users  where Users.User_No  IN( select  User_Role.User_No from User_Role  " +
             "  where Role_No IN ( select Role.Role_No  from Role  where Family_Role_No IN (select  Family_Role.Family_Role_No from Family_Role " +
             " where Family_Role.Family_Role_Name LIKE 'Editor'  )  AND Role.Role_Name LIKE 'Editor_in_Chief' OR  Role.Role_Name LIKE 'Associate Editor'   )" +
             "  )   AND Users.User_No IN ( select User_Permission.User_No from  User_Permission" +
             " where User_Permission.Permission_No IN ( select Secondary_Permission.Permission_No  from " +
                         " Secondary_Permission where Secondary_Permission.Permission_Type_No" +
             " IN( select Primary_Permission.Permission_Type_No from  Primary_Permission where " +
             " Primary_Permission.Permission_Type_Name LIKE 'New Submissions' ) AND " +
             "    Secondary_Permission.Permission_Name LIKE 'New Assignment'  ) ) " +

                   " AND  Users.User_No=@User_No  ) )  AND  Articles.Article_No NOT IN (select DISTINCT Article_User.Article_No from Article_User " +
             "   where Article_User.Assign_Complete=0  AND Article_User.Upper_User_no=@Upper_User_no  AND Article_User.Upper_User_no !=Article_User.Lower_User_No " +
             "  ) " +
                  " AND Articles.Article_No IN( select Article_Status_Users.Article_No from Article_Status_Users,Family_Role,Status where Article_Status_Users.Status_No " +
                 " = Status.Status_No AND Status.Family_Role_No =Family_Role.Family_Role_No AND Family_Role.Family_Role_Name LIKE 'Editor'  " +
                 " AND Status.Status_Name LIKE 'Build PDF')" +

                 " AND Articles.Article_No IN( select Article_Status_Users.Article_No  from Article_Status_Users,Family_Role,Status where Article_Status_Users.Status_No " +
                 " = Status.Status_No AND Status.Family_Role_No =Family_Role.Family_Role_No AND Family_Role.Family_Role_Name LIKE 'Editor'  " +
                 " AND Status.Status_Name LIKE 'Edit Submission' ) " +

             "AND Articles.Article_No NOT IN " +
                 "( select Article_Status_Users.Article_No  from Article_Status_Users where Article_Status_Users.Status_No " +
                 " IN ( select  Status.Status_No  from Status where Status.Family_Role_No IN  " +
                 " ( select Family_Role.Family_Role_No from Family_Role where Family_Role.Family_Role_Name LIKE 'Editor' ) " +
                 " AND   Status.Status_Name LIKE 'Complete Edit'  )AND Article_Status_Users.User_No=@User_No)  ";

            commands.Parameters.Add("@User_No", System.Data.SqlDbType.Int);
            commands.Parameters["@User_No"].Value = usr_NO;
            commands.Parameters.Add("@Upper_User_no", System.Data.SqlDbType.Int);
            commands.Parameters["@Upper_User_no"].Value = usr_NO;
            Read_Question = commands.ExecuteReader();
            Read_Question.Read();
           int Submission_With_Required_Reviews_Complete_Variable = (int)(Read_Question[0]);
            if (Submission_With_Required_Reviews_Complete_Variable > 0)
            {
                Submission_With_Required_Reviews_Complete_Count.Text = "(" + Submission_With_Required_Reviews_Complete_Variable + ")";

                Submission_With_Required_Reviews_Complete.Enabled = true;
                Read_Question.Close();
                connect.Close();
            }
            else
            {
                Submission_With_Required_Reviews_Complete.Enabled = false;
                Submission_With_Required_Reviews_Complete_Count.Text = "(0)";
                Read_Question.Close();
                connect.Close();
            }
        }
        catch
        {
            Submission_With_Required_Reviews_Complete_Count.Text = "(0)";
        }
        finally
        {
            commands.Parameters.Clear();
            connect.Close();
        }

        //END^^^^^^^^^^^^^^  ^^^^^^^^^^^^^^^^^^Submission With Required Reviews Complete ^^^^^^^^^^^^^^^^^^^^^^^^^^^^


        //^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^Editor Invited-No Response^^^^^^^^^^^^^^^^^^^^^^^^^

        //  try
        //{
        connect.Close();
        connect.Open();
        commands.Connection = connect;
        commands.CommandText = " select Users.User_Name from Users  where Users.User_No  IN ( select  User_Role.User_No from User_Role  " +
            "  where Role_No IN ( select Role.Role_No  from Role  where Family_Role_No IN ( select  Family_Role.Family_Role_No from Family_Role " +
            " where Family_Role.Family_Role_Name LIKE 'Editor' )AND Role.Role_Name LIKE 'Editor_in_Chief' OR  Role.Role_Name LIKE 'Associate Editor'  )) " +
            " AND Users.User_No IN (select User_Permission.User_No from  User_Permission" +
            " where User_Permission.Permission_No IN ( select Secondary_Permission.Permission_No  from " +
                        " Secondary_Permission where Secondary_Permission.Permission_Type_No" +
            " IN( select Primary_Permission.Permission_Type_No from  Primary_Permission where " +
            " Primary_Permission.Permission_Type_Name LIKE 'New Submissions' ) AND " +
            "    Secondary_Permission.Permission_Name LIKE 'New Assignment'  ) ) " +
                  " AND  Users.User_No=@User_No  ";


        commands.Parameters.Add("@User_No", System.Data.SqlDbType.Int);
        commands.Parameters["@User_No"].Value = usr_NO;
        Read_Question = commands.ExecuteReader();
        int Editor_Invited_No_Response_Variable = 0;
        if (Read_Question.Read())
        {
            commands.Parameters.Clear();
            Read_Question.Close();
            String quer = "select Article_User.Lower_User_No,Article_User.Article_No  from Article_User where  Article_User.Family_Role_No IN" +
                    "( select Family_Role.Family_Role_No from Family_Role where Family_Role.Family_Role_Name LIKE 'Editor') AND " +
                    "Article_User.Upper_User_no=@Upper_User_no  AND Assign_Complete =0 ";


            SqlCommand comm_Que_Type = new SqlCommand(quer, connect);
            SqlDataAdapter adapter = new SqlDataAdapter(comm_Que_Type);
            comm_Que_Type.Parameters.Add("@Upper_User_no", System.Data.SqlDbType.Int);
            comm_Que_Type.Parameters["@Upper_User_no"].Value = usr_NO;
            DataTable table = new DataTable();
            adapter.Fill(table);
            foreach (DataRow datarow in table.Select())
            {
                int Article_no = (int)datarow["Article_No"];
                int Editor_no = (int)datarow["Lower_User_No"];

                commands.Parameters.Clear();
                Read_Question.Close();
                commands.CommandText = " select Articles.Article_No from Articles   " +

                    " where Articles.Article_No IN( select Article_Status_Users.Article_No from Article_Status_Users where Article_Status_Users.Status_No " +
                      " IN ( select  Status.Status_No  from Status where Status.Family_Role_No IN  " +
                      " ( select Family_Role.Family_Role_No from Family_Role where Family_Role.Family_Role_Name LIKE 'Editor' ) " +
                     " AND Status.Status_Name LIKE 'Editor Invite ') AND Article_Status_Users.Article_No=@Article_No AND " +
                   "  Article_Status_Users.User_No=@User_No  )  " +

                   " AND Articles.Article_No NOT IN( select Article_Status_Users.Article_No from Article_Status_Users where Article_Status_Users.Status_No " +
                      " IN ( select  Status.Status_No  from Status where Status.Family_Role_No IN  " +
                      " ( select Family_Role.Family_Role_No from Family_Role where Family_Role.Family_Role_Name LIKE 'Editor' ) " +
                     " AND Status.Status_Name LIKE 'Editor Assign') AND Article_Status_Users.Article_No=@Article_No AND " +
                   "  Article_Status_Users.User_No=@User_No  )  " +
                   "AND Articles.Article_No  NOT IN( select Article_Status_Users.Article_No from Article_Status_Users where Article_Status_Users.Status_No " +
                          " IN ( select  Status.Status_No  from Status where Status.Family_Role_No IN  " +
                          " ( select Family_Role.Family_Role_No from Family_Role where Family_Role.Family_Role_Name LIKE 'Editor' ) " +
                         " AND Status.Status_Name LIKE 'Decline Edit') AND Article_Status_Users.Article_No=@Article_No AND " +
                       "  Article_Status_Users.User_No=@User_No  )  ";
                commands.Parameters.Add("@User_No", System.Data.SqlDbType.Int);
                commands.Parameters["@User_No"].Value = Editor_no;
                commands.Parameters.Add("@Article_No", System.Data.SqlDbType.Int);
                commands.Parameters["@Article_No"].Value = Article_no;
                Read_Question = commands.ExecuteReader();

                if (Read_Question.Read())
                {

                    Editor_Invited_No_Response_Variable = Editor_Invited_No_Response_Variable + 1;


                }
            }



            if (Editor_Invited_No_Response_Variable > 0)
            {
                Editor_Invited_No_Response_Count.Text = "(" + Editor_Invited_No_Response_Variable + ")";

                Editor_Invited_No_Response.Enabled = true;
                Read_Question.Close();
                connect.Close();
            }
            else
            {
                Editor_Invited_No_Response.Enabled = false;
                Editor_Invited_No_Response_Count.Text = "(0)";
                Read_Question.Close();
                connect.Close();
            }
        }

        // }
        // catch
        //  {
        //    Editor_Invited_No_Response_Count.Text = "(0)";
        //  }
        //finally
        // {
        commands.Parameters.Clear();
        //   connect.Close();
        // }
        //------------------end------------------------------Editor Assign-No Response


        //^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^Editor Invited-No Complete^^^^^^^^^^^^^^^^^^^^^^^^^

        //  try
        //{
        connect.Close();
        connect.Open();
        commands.Connection = connect;
        commands.CommandText = " select Users.User_Name from Users  where Users.User_No  IN ( select  User_Role.User_No from User_Role  " +
            "  where Role_No IN ( select Role.Role_No  from Role  where Family_Role_No IN ( select  Family_Role.Family_Role_No from Family_Role " +
            " where Family_Role.Family_Role_Name LIKE 'Editor' )AND Role.Role_Name LIKE 'Editor_in_Chief' OR  Role.Role_Name LIKE 'Associate Editor'  )) " +
            " AND Users.User_No IN (select User_Permission.User_No from  User_Permission" +
            " where User_Permission.Permission_No IN ( select Secondary_Permission.Permission_No  from " +
                        " Secondary_Permission where Secondary_Permission.Permission_Type_No" +
            " IN( select Primary_Permission.Permission_Type_No from  Primary_Permission where " +
            " Primary_Permission.Permission_Type_Name LIKE 'New Submissions' ) AND " +
            "    Secondary_Permission.Permission_Name LIKE 'New Assignment'  ) ) " +
                  " AND  Users.User_No=@User_No  ";


        commands.Parameters.Add("@User_No", System.Data.SqlDbType.Int);
        commands.Parameters["@User_No"].Value = usr_NO;
        Read_Question = commands.ExecuteReader();
        int Editor_Assign_No_Complete_variable = 0;
        if (Read_Question.Read())
        {
            commands.Parameters.Clear();
            Read_Question.Close();
            String quer = "select Article_User.Lower_User_No,Article_User.Article_No  from Article_User where  Article_User.Family_Role_No IN" +
                    "( select Family_Role.Family_Role_No from Family_Role where Family_Role.Family_Role_Name LIKE 'Editor') AND " +
                    "Article_User.Upper_User_no=@Upper_User_no  AND Assign_Complete =0 ";


            SqlCommand comm_Que_Type = new SqlCommand(quer, connect);
            SqlDataAdapter adapter = new SqlDataAdapter(comm_Que_Type);
            comm_Que_Type.Parameters.Add("@Upper_User_no", System.Data.SqlDbType.Int);
            comm_Que_Type.Parameters["@Upper_User_no"].Value = usr_NO;
            DataTable table = new DataTable();
            adapter.Fill(table);
            foreach (DataRow datarow in table.Select())
            {
                int Article_no = (int)datarow["Article_No"];
                int Editor_no = (int)datarow["Lower_User_No"];

                commands.Parameters.Clear();
                Read_Question.Close();
                commands.CommandText = " select Articles.Article_No from Articles   " +

                    " where Articles.Article_No IN( select Article_Status_Users.Article_No from Article_Status_Users where Article_Status_Users.Status_No " +
                      " IN ( select  Status.Status_No  from Status where Status.Family_Role_No IN  " +
                      " ( select Family_Role.Family_Role_No from Family_Role where Family_Role.Family_Role_Name LIKE 'Editor' ) " +
                     " AND Status.Status_Name LIKE 'Editor Assign') AND Article_Status_Users.Article_No=@Article_No AND " +
                   "  Article_Status_Users.User_No=@User_No  )  " +

                   " AND Articles.Article_No NOT IN( select Article_Status_Users.Article_No from Article_Status_Users where Article_Status_Users.Status_No " +
                      " IN ( select  Status.Status_No  from Status where Status.Family_Role_No IN  " +
                      " ( select Family_Role.Family_Role_No from Family_Role where Family_Role.Family_Role_Name LIKE 'Editor' ) " +
                     " AND Status.Status_Name LIKE 'Complete Edit') AND Article_Status_Users.Article_No=@Article_No AND " +
                   "  Article_Status_Users.User_No=@User_No  )  ";
                commands.Parameters.Add("@User_No", System.Data.SqlDbType.Int);
                commands.Parameters["@User_No"].Value = Editor_no;
                commands.Parameters.Add("@Article_No", System.Data.SqlDbType.Int);
                commands.Parameters["@Article_No"].Value = Article_no;
                Read_Question = commands.ExecuteReader();

                if (Read_Question.Read())
                {

                    Editor_Assign_No_Complete_variable = Editor_Assign_No_Complete_variable + 1;


                }
            }



            if (Editor_Assign_No_Complete_variable > 0)
            {
                Editor_Assign_No_Complete_Count.Text = "(" + Editor_Assign_No_Complete_variable + ")";

                Editor_Assign_No_Complete.Enabled = true;
                Read_Question.Close();
                connect.Close();
            }
            else
            {
                Editor_Assign_No_Complete.Enabled = false;
                Editor_Assign_No_Complete_Count.Text = "(0)";
                Read_Question.Close();
                connect.Close();
            }
        }

        // }
        // catch
        //  {
        //    Editor_Assign_No_Complete_Count.Text = "(0)";
        //  }
        //finally
        // {
        commands.Parameters.Clear();
        //   connect.Close();
        // }
        //------------------end------------------------------Editor Assign-No Complete
        //^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^Editor Decline-for submission ^^^^^^^^^^^^^^^^^^^^^^^^

        //  try
        //{
        connect.Close();
        connect.Open();
        commands.Connection = connect;
        commands.CommandText = " select Users.User_Name from Users  where Users.User_No  IN ( select  User_Role.User_No from User_Role  " +
            "  where Role_No IN ( select Role.Role_No  from Role  where Family_Role_No IN ( select  Family_Role.Family_Role_No from Family_Role " +
            " where Family_Role.Family_Role_Name LIKE 'Editor' )AND Role.Role_Name LIKE 'Editor_in_Chief' OR  Role.Role_Name LIKE 'Associate Editor'  )) " +
            " AND Users.User_No IN (select User_Permission.User_No from  User_Permission" +
            " where User_Permission.Permission_No IN ( select Secondary_Permission.Permission_No  from " +
                        " Secondary_Permission where Secondary_Permission.Permission_Type_No" +
            " IN( select Primary_Permission.Permission_Type_No from  Primary_Permission where " +
            " Primary_Permission.Permission_Type_Name LIKE 'New Submissions' ) AND " +
            "    Secondary_Permission.Permission_Name LIKE 'New Assignment'  ) ) " +
                  " AND  Users.User_No=@User_No  ";


        commands.Parameters.Add("@User_No", System.Data.SqlDbType.Int);
        commands.Parameters["@User_No"].Value = usr_NO;
        Read_Question = commands.ExecuteReader();
        int Decline_Editor_For_Submissions_Variable = 0;
        if (Read_Question.Read())
        {
            commands.Parameters.Clear();
            Read_Question.Close();
            String quer = "select Article_User.Lower_User_No,Article_User.Article_No  from Article_User where  Article_User.Family_Role_No IN" +
                    "( select Family_Role.Family_Role_No from Family_Role where Family_Role.Family_Role_Name LIKE 'Editor') AND " +
                    "Article_User.Upper_User_no=@Upper_User_no  AND Assign_Complete =0 ";


            SqlCommand comm_Que_Type = new SqlCommand(quer, connect);
            SqlDataAdapter adapter = new SqlDataAdapter(comm_Que_Type);
            comm_Que_Type.Parameters.Add("@Upper_User_no", System.Data.SqlDbType.Int);
            comm_Que_Type.Parameters["@Upper_User_no"].Value = usr_NO;
            DataTable table = new DataTable();
            adapter.Fill(table);
            foreach (DataRow datarow in table.Select())
            {
                int Article_no = (int)datarow["Article_No"];
                int Editor_no = (int)datarow["Lower_User_No"];

                commands.Parameters.Clear();
                Read_Question.Close();
                commands.CommandText = " select Articles.Article_No from Articles   " +

                    " where Articles.Article_No IN( select Article_Status_Users.Article_No from Article_Status_Users where Article_Status_Users.Status_No " +
                      " IN ( select  Status.Status_No  from Status where Status.Family_Role_No IN  " +
                      " ( select Family_Role.Family_Role_No from Family_Role where Family_Role.Family_Role_Name LIKE 'Editor' ) " +
                     " AND Status.Status_Name LIKE 'Decline Edit') AND Article_Status_Users.Article_No=@Article_No AND " +
                   "  Article_Status_Users.User_No=@User_No  )  ";
                commands.Parameters.Add("@User_No", System.Data.SqlDbType.Int);
                commands.Parameters["@User_No"].Value = Editor_no;
                commands.Parameters.Add("@Article_No", System.Data.SqlDbType.Int);
                commands.Parameters["@Article_No"].Value = Article_no;
                Read_Question = commands.ExecuteReader();

                if (Read_Question.Read())
                {

                    Decline_Editor_For_Submissions_Variable = Decline_Editor_For_Submissions_Variable + 1;


                }
            }



            if (Decline_Editor_For_Submissions_Variable > 0)
            {
                Decline_Editor_For_Submissions_Count.Text = "(" + Decline_Editor_For_Submissions_Variable + ")";

                Decline_Editor_For_Submissions.Enabled = true;
                Read_Question.Close();
                connect.Close();
            }
            else
            {
                Decline_Editor_For_Submissions.Enabled = false;
                Decline_Editor_For_Submissions_Count.Text = "(0)";
                Read_Question.Close();
                connect.Close();
            }
        }

        // }
        // catch
        //  {
        //    Decline_Editor_For_Submissions_Count.Text = "(0)";
        //  }
        //finally
        // {
        commands.Parameters.Clear();
        //   connect.Close();
        // }
        //------------------end------------------------------Editor Decline-for submission 

        //^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^Reviewer Invited-No Complete^^^^^^^^^^^^^^^^^^^^^^^^^

        //  try
        //{
        connect.Close();
        connect.Open();
        commands.Connection = connect;
        commands.CommandText = " select Users.User_Name from Users  where Users.User_No  IN ( select  User_Role.User_No from User_Role  " +
            "  where Role_No IN ( select Role.Role_No  from Role  where Family_Role_No IN ( select  Family_Role.Family_Role_No from Family_Role " +
            " where Family_Role.Family_Role_Name LIKE 'Editor' )AND Role.Role_Name LIKE 'Editor_in_Chief' OR  Role.Role_Name LIKE 'Associate Editor'  )) " +
            " AND Users.User_No IN (select User_Permission.User_No from  User_Permission" +
            " where User_Permission.Permission_No IN ( select Secondary_Permission.Permission_No  from " +
                        " Secondary_Permission where Secondary_Permission.Permission_Type_No" +
            " IN( select Primary_Permission.Permission_Type_No from  Primary_Permission where " +
            " Primary_Permission.Permission_Type_Name LIKE 'New Submissions' ) AND " +
            "    Secondary_Permission.Permission_Name LIKE 'New Assignment'  ) ) " +
                  " AND  Users.User_No=@User_No  ";


        commands.Parameters.Add("@User_No", System.Data.SqlDbType.Int);
        commands.Parameters["@User_No"].Value = usr_NO;
        Read_Question = commands.ExecuteReader();
        int Reviewers_Invited_No_Response_Variable = 0;
        if (Read_Question.Read())
        {
            commands.Parameters.Clear();
            Read_Question.Close();
            String quer = "select Article_User.Lower_User_No,Article_User.Article_No  from Article_User where  Article_User.Family_Role_No IN" +
                    "( select Family_Role.Family_Role_No from Family_Role where Family_Role.Family_Role_Name LIKE 'Reviewer') AND " +
                    "Article_User.Upper_User_no=@Upper_User_no  AND Assign_Complete =0 ";


            SqlCommand comm_Que_Type = new SqlCommand(quer, connect);
            SqlDataAdapter adapter = new SqlDataAdapter(comm_Que_Type);
            comm_Que_Type.Parameters.Add("@Upper_User_no", System.Data.SqlDbType.Int);
            comm_Que_Type.Parameters["@Upper_User_no"].Value = usr_NO;
            DataTable table = new DataTable();
            adapter.Fill(table);
            foreach (DataRow datarow in table.Select())
            {
                int Article_no = (int)datarow["Article_No"];
                int Editor_no = (int)datarow["Lower_User_No"];

                commands.Parameters.Clear();
                Read_Question.Close();
                commands.CommandText = " select Articles.Article_No from Articles   " +

                    " where Articles.Article_No IN( select Article_Status_Users.Article_No from Article_Status_Users where Article_Status_Users.Status_No " +
                      " IN ( select  Status.Status_No  from Status where Status.Family_Role_No IN  " +
                      " ( select Family_Role.Family_Role_No from Family_Role where Family_Role.Family_Role_Name LIKE 'Reviewer' ) " +
                     " AND Status.Status_Name LIKE 'Reviewers Invite') AND Article_Status_Users.Article_No=@Article_No AND " +
                   "  Article_Status_Users.User_No=@User_No  )  " +

                   " AND Articles.Article_No NOT IN( select Article_Status_Users.Article_No from Article_Status_Users where Article_Status_Users.Status_No " +
                      " IN ( select  Status.Status_No  from Status where Status.Family_Role_No IN  " +
                      " ( select Family_Role.Family_Role_No from Family_Role where Family_Role.Family_Role_Name LIKE 'Reviewer' ) " +
                     " AND Status.Status_Name LIKE 'Reviewers Assign') AND Article_Status_Users.Article_No=@Article_No AND " +
                   "  Article_Status_Users.User_No=@User_No  )  " +

                   "  AND Articles.Article_No NOT IN( select Article_Status_Users.Article_No from Article_Status_Users where Article_Status_Users.Status_No " +
                      " IN ( select  Status.Status_No  from Status where Status.Family_Role_No IN  " +
                      " ( select Family_Role.Family_Role_No from Family_Role where Family_Role.Family_Role_Name LIKE 'Reviewer' ) " +
                     " AND Status.Status_Name LIKE 'Decline review') AND Article_Status_Users.Article_No=@Article_No AND " +
                   "  Article_Status_Users.User_No=@User_No  )  ";
                commands.Parameters.Add("@User_No", System.Data.SqlDbType.Int);
                commands.Parameters["@User_No"].Value = Editor_no;
                commands.Parameters.Add("@Article_No", System.Data.SqlDbType.Int);
                commands.Parameters["@Article_No"].Value = Article_no;
                Read_Question = commands.ExecuteReader();

                if (Read_Question.Read())
                {

                    Reviewers_Invited_No_Response_Variable = Reviewers_Invited_No_Response_Variable + 1;


                }
            }



            if (Reviewers_Invited_No_Response_Variable > 0)
            {
                Reviewers_Invited_No_Response_Count.Text = "(" + Reviewers_Invited_No_Response_Variable + ")";

                Reviewers_Invited_No_Response.Enabled = true;
                Read_Question.Close();
                connect.Close();
            }
            else
            {
                Reviewers_Invited_No_Response.Enabled = false;
                Reviewers_Invited_No_Response_Count.Text = "(0)";
                Read_Question.Close();
                connect.Close();
            }
        }

        // }
        // catch
        //  {
        //    Reviewers_Invited_No_Response_Count.Text = "(0)";
        //  }
        //finally
        // {
        commands.Parameters.Clear();
        //   connect.Close();
        // }
        //------------------end------------------------------Reviewer No Response
        //^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^INVITE Reviewer No Respons^^^^^^^^^^^^^^^^^^^^^^^^

        //  try
        //{
        connect.Close();
        connect.Open();
        commands.Connection = connect;
        commands.CommandText = " select Users.User_Name from Users  where Users.User_No  IN ( select  User_Role.User_No from User_Role  " +
            "  where Role_No IN ( select Role.Role_No  from Role  where Family_Role_No IN ( select  Family_Role.Family_Role_No from Family_Role " +
            " where Family_Role.Family_Role_Name LIKE 'Editor' )AND Role.Role_Name LIKE 'Editor_in_Chief' OR  Role.Role_Name LIKE 'Associate Editor'  )) " +
            " AND Users.User_No IN (select User_Permission.User_No from  User_Permission" +
            " where User_Permission.Permission_No IN ( select Secondary_Permission.Permission_No  from " +
                        " Secondary_Permission where Secondary_Permission.Permission_Type_No" +
            " IN( select Primary_Permission.Permission_Type_No from  Primary_Permission where " +
            " Primary_Permission.Permission_Type_Name LIKE 'New Submissions' ) AND " +
            "    Secondary_Permission.Permission_Name LIKE 'New Assignment'  ) ) " +
                  " AND  Users.User_No=@User_No  ";


        commands.Parameters.Add("@User_No", System.Data.SqlDbType.Int);
        commands.Parameters["@User_No"].Value = usr_NO;
        Read_Question = commands.ExecuteReader();
        int Submissions_Under_Review_cont_Variable = 0;
        if (Read_Question.Read())
        {
            commands.Parameters.Clear();
            Read_Question.Close();
            String quer = "select Article_User.Lower_User_No,Article_User.Article_No  from Article_User where  Article_User.Family_Role_No IN" +
                    "( select Family_Role.Family_Role_No from Family_Role where Family_Role.Family_Role_Name LIKE 'Reviewer') AND " +
                    "Article_User.Upper_User_no=@Upper_User_no  AND Assign_Complete =0 ";


            SqlCommand comm_Que_Type = new SqlCommand(quer, connect);
            SqlDataAdapter adapter = new SqlDataAdapter(comm_Que_Type);
            comm_Que_Type.Parameters.Add("@Upper_User_no", System.Data.SqlDbType.Int);
            comm_Que_Type.Parameters["@Upper_User_no"].Value = usr_NO;
            DataTable table = new DataTable();
            adapter.Fill(table);
            foreach (DataRow datarow in table.Select())
            {
                int Article_no = (int)datarow["Article_No"];
                int Editor_no = (int)datarow["Lower_User_No"];

                commands.Parameters.Clear();
                Read_Question.Close();
                commands.CommandText = " select Articles.Article_No from Articles   " +

                    " where Articles.Article_No IN( select Article_Status_Users.Article_No from Article_Status_Users where Article_Status_Users.Status_No " +
                      " IN ( select  Status.Status_No  from Status where Status.Family_Role_No IN  " +
                      " ( select Family_Role.Family_Role_No from Family_Role where Family_Role.Family_Role_Name LIKE 'Reviewer' ) " +
                     " AND Status.Status_Name LIKE 'Reviewers Assign') AND Article_Status_Users.Article_No=@Article_No AND " +
                   "  Article_Status_Users.User_No=@User_No  )  " +

                   " AND Articles.Article_No NOT IN( select Article_Status_Users.Article_No from Article_Status_Users where Article_Status_Users.Status_No " +
                      " IN ( select  Status.Status_No  from Status where Status.Family_Role_No IN  " +
                      " ( select Family_Role.Family_Role_No from Family_Role where Family_Role.Family_Role_Name LIKE 'Reviewer' ) " +
                     " AND Status.Status_Name LIKE 'Complete Review') AND Article_Status_Users.Article_No=@Article_No AND " +
                   "  Article_Status_Users.User_No=@User_No  )  ";
                commands.Parameters.Add("@User_No", System.Data.SqlDbType.Int);
                commands.Parameters["@User_No"].Value = Editor_no;
                commands.Parameters.Add("@Article_No", System.Data.SqlDbType.Int);
                commands.Parameters["@Article_No"].Value = Article_no;
                Read_Question = commands.ExecuteReader();

                if (Read_Question.Read())
                {

                    Submissions_Under_Review_cont_Variable = Submissions_Under_Review_cont_Variable + 1;


                }
            }



            if (Submissions_Under_Review_cont_Variable > 0)
            {
                Submissions_Under_Review_cont.Text = "(" + Submissions_Under_Review_cont_Variable + ")";

                Submissions_Under_Review.Enabled = true;
                Read_Question.Close();
                connect.Close();
            }
            else
            {
                Submissions_Under_Review.Enabled = false;
                Submissions_Under_Review_cont.Text = "(0)";
                Read_Question.Close();
                connect.Close();
            }
        }

        // }
        // catch
        //  {
        //    Submissions_Under_Review_cont.Text = "(0)";
        //  }
        //finally
        // {
        commands.Parameters.Clear();
        //   connect.Close();
        // }
        //------------------end------------------------------ INVITE Reviewer No Respons
        //^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^Decline Reviewer ^^^^^^^^^^^^^^^^^^^^^^^^

        //  try
        //{
        connect.Close();
        connect.Open();
        commands.Connection = connect;
        commands.CommandText = " select Users.User_Name from Users  where Users.User_No  IN ( select  User_Role.User_No from User_Role  " +
            "  where Role_No IN ( select Role.Role_No  from Role  where Family_Role_No IN ( select  Family_Role.Family_Role_No from Family_Role " +
            " where Family_Role.Family_Role_Name LIKE 'Editor' )AND Role.Role_Name LIKE 'Editor_in_Chief' OR  Role.Role_Name LIKE 'Associate Editor'  )) " +
            " AND Users.User_No IN (select User_Permission.User_No from  User_Permission" +
            " where User_Permission.Permission_No IN ( select Secondary_Permission.Permission_No  from " +
                        " Secondary_Permission where Secondary_Permission.Permission_Type_No" +
            " IN( select Primary_Permission.Permission_Type_No from  Primary_Permission where " +
            " Primary_Permission.Permission_Type_Name LIKE 'New Submissions' ) AND " +
            "    Secondary_Permission.Permission_Name LIKE 'New Assignment'  ) ) " +
                  " AND  Users.User_No=@User_No  ";


        commands.Parameters.Add("@User_No", System.Data.SqlDbType.Int);
        commands.Parameters["@User_No"].Value = usr_NO;
        Read_Question = commands.ExecuteReader();
        int Decline_Reviewer_For_Submissins_Variable = 0;
        if (Read_Question.Read())
        {
            commands.Parameters.Clear();
            Read_Question.Close();
            String quer = "select Article_User.Lower_User_No,Article_User.Article_No  from Article_User where  Article_User.Family_Role_No IN" +
                    "( select Family_Role.Family_Role_No from Family_Role where Family_Role.Family_Role_Name LIKE 'Reviewer') AND " +
                    "Article_User.Upper_User_no=@Upper_User_no  AND Assign_Complete =0 ";


            SqlCommand comm_Que_Type = new SqlCommand(quer, connect);
            SqlDataAdapter adapter = new SqlDataAdapter(comm_Que_Type);
            comm_Que_Type.Parameters.Add("@Upper_User_no", System.Data.SqlDbType.Int);
            comm_Que_Type.Parameters["@Upper_User_no"].Value = usr_NO;
            DataTable table = new DataTable();
            adapter.Fill(table);
            foreach (DataRow datarow in table.Select())
            {
                int Article_no = (int)datarow["Article_No"];
                int Editor_no = (int)datarow["Lower_User_No"];

                commands.Parameters.Clear();
                Read_Question.Close();
                commands.CommandText = " select Articles.Article_No from Articles   " +

                    " where Articles.Article_No IN( select Article_Status_Users.Article_No from Article_Status_Users where Article_Status_Users.Status_No " +
                      " IN ( select  Status.Status_No  from Status where Status.Family_Role_No IN  " +
                      " ( select Family_Role.Family_Role_No from Family_Role where Family_Role.Family_Role_Name LIKE 'Reviewer' ) " +
                     " AND Status.Status_Name LIKE 'Decline review') AND Article_Status_Users.Article_No=@Article_No AND " +
                   "  Article_Status_Users.User_No=@User_No  )  ";
                commands.Parameters.Add("@User_No", System.Data.SqlDbType.Int);
                commands.Parameters["@User_No"].Value = Editor_no;
                commands.Parameters.Add("@Article_No", System.Data.SqlDbType.Int);
                commands.Parameters["@Article_No"].Value = Article_no;
                Read_Question = commands.ExecuteReader();

                if (Read_Question.Read())
                {

                    Decline_Reviewer_For_Submissins_Variable = Decline_Reviewer_For_Submissins_Variable + 1;


                }
            }



            if (Decline_Reviewer_For_Submissins_Variable > 0)
            {
                Decline_Reviewer_For_Submissins_Count.Text = "(" + Decline_Reviewer_For_Submissins_Variable + ")";

                Decline_Reviewer_For_Submissins.Enabled = true;
                Read_Question.Close();
                connect.Close();
            }
            else
            {
                Decline_Reviewer_For_Submissins.Enabled = false;
                Decline_Reviewer_For_Submissins_Count.Text = "(0)";
                Read_Question.Close();
                connect.Close();
            }
        }

        // }
        // catch
        //  {
        //    Decline_Reviewer_For_Submissins_Count.Text = "(0)";
        //  }
        //finally
        // {
        commands.Parameters.Clear();
        //   connect.Close();
        // }
        //------------------end------------------------------ Decline Reviewer 



        // ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^View All Assigned Submmisssion Being Edited^^^^^^^^^^
        //   try
        //   {
        commands.Parameters.Clear();
        connect.Close();
        connect.Open();
        commands.Connection = connect;
        commands.CommandText = " select  " +
            "  Users.User_Name  from Users  where Users.User_No  IN (select  User_Role.User_No from User_Role  " +
            "  where User_Role.Role_No IN (select Role.Role_No  from Role  where Family_Role_No IN (select Family_Role.Family_Role_No from Family_Role " +
            " where Family_Role.Family_Role_Name LIKE 'Editor' )AND Role.Role_Name LIKE 'Editor_in_Chief' OR  Role.Role_Name LIKE 'Managing Editor' OR  Role.Role_Name LIKE 'Associate Editor' )) AND Users.User_No IN (select User_Permission.User_No from  User_Permission" +
            " where User_Permission.Permission_No IN (select Secondary_Permission.Permission_No  from  Secondary_Permission where Secondary_Permission.Permission_Type_No" +
            " IN( select Primary_Permission.Permission_Type_No from  Primary_Permission where  Primary_Permission.Permission_Type_Name LIKE 'Manager')AND Secondary_Permission.Permission_Name LIKE 'View All Assigned Submmisssion Being Edited'   ) ) " +
            "AND Users.User_No =@User_No";
        commands.Parameters.Add("@User_No", System.Data.SqlDbType.Int);
        commands.Parameters["@User_No"].Value = usr_NO;
        Read_Question = commands.ExecuteReader();

        if (Read_Question.Read())
        {
            Read_Question.Close();
            commands.CommandText = " select count(Article_No) from Articles   " +
             " where Articles.Article_No  IN" +
       " ( select Article_Status_Users.Article_No from  Article_Status_Users where  " +
                   "  Article_Status_Users.Status_No IN(select Status.Status_No from Status where  Status.Status_Name LIKE 'Edit Submission' )) " +
                   " AND Articles.Article_No NOT  IN" +
       " ( select Article_Status_Users.Article_No from  Article_Status_Users where  " +
                   "  Article_Status_Users.Status_No IN(select Status.Status_No from Status where  Status.Status_Name LIKE 'Build PDF' )) ";

            Read_Question = commands.ExecuteReader();
            Read_Question.Read();
            int View_All_Assigned_Submmisssion_Being_Edited_Variable = (int)(Read_Question[0]);
            if (View_All_Assigned_Submmisssion_Being_Edited_Variable > 0)
            {
                View_All_Assigned_Submission_count.Text = "(" + View_All_Assigned_Submmisssion_Being_Edited_Variable + ")";

                View_All_Assigned_Submission.Enabled = true;
                Read_Question.Close();
                connect.Close();
            }
            else
            {
                View_All_Assigned_Submission.Enabled = false;
                Read_Question.Close();
                View_All_Assigned_Submission_count.Text = "(0)";
                connect.Close();
            }
        }
        else
        {
            Read_Question.Close();
            connect.Close();
        }


        // }
        // catch
        // {
        //     View_All_Assigned_Submission_count .Text = "(0)";
        // }
        /// finally
        // {
        //     commands.Parameters.Clear();
        //     connect.Close();
        //  }
        //END ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^View all Assigned Submmisssion Being Edited^^^^^^^^^^  

        // ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^View All Assigned Submmisssions^^^^^^^^^^
        //  try
        //   {
        commands.Parameters.Clear();
        connect.Close();
        connect.Open();
        commands.Connection = connect;
        commands.CommandText = " select  " +
            "  Users.User_Name  from Users  where Users.User_No  IN (select  User_Role.User_No from User_Role  " +
            "  where User_Role.Role_No IN (select Role.Role_No  from Role  where Family_Role_No IN (select Family_Role.Family_Role_No from Family_Role " +
            " where Family_Role.Family_Role_Name LIKE 'Editor' )AND Role.Role_Name LIKE 'Editor_in_Chief' OR  Role.Role_Name LIKE 'Associate Editor')) AND Users.User_No IN (select User_Permission.User_No from  User_Permission" +
            " where User_Permission.Permission_No IN (select Secondary_Permission.Permission_No  from  Secondary_Permission where Secondary_Permission.Permission_Type_No" +
            " IN( select Primary_Permission.Permission_Type_No from  Primary_Permission where  Primary_Permission.Permission_Type_Name LIKE 'Manager')AND Secondary_Permission.Permission_Name LIKE 'View All Assigned Submmisssions'   ) ) " +
            "AND Users.User_No =@User_No";
        commands.Parameters.Add("@User_No", System.Data.SqlDbType.Int);
        commands.Parameters["@User_No"].Value = usr_NO;
        Read_Question = commands.ExecuteReader();

        if (Read_Question.Read())
        {
            Read_Question.Close();
            commands.CommandText = " select count(Article_No) from Articles   " +
             " where  Articles.Article_No IN(select DISTINCT Article_User.Article_No  from Article_User)  " +

              " AND Articles.Article_No IN (select Article_Status_Users.Article_No  from Article_Status_Users where  Article_Status_Users.Status_No " +
                 " IN(select  Status.Status_No  from Status where  Status.Family_Role_No IN(select Family_Role.Family_Role_No from Family_Role where  Family_Role.Family_Role_Name LIKE 'Editor' ) " +
                 " AND Status.Status_Name LIKE 'Editor Assign') )" +

    " AND Articles.Article_No NOT  IN" +
          " ( select Article_Status_Users.Article_No from  Article_Status_Users where  " +
                      "  Article_Status_Users.Status_No IN(select Status.Status_No from Status where  Status.Status_Name LIKE 'Accept' )) " +

                       " AND Articles.Article_No NOT  IN" +
          " ( select Article_Status_Users.Article_No from  Article_Status_Users where  " +
                      "  Article_Status_Users.Status_No IN(select Status.Status_No from Status where  Status.Status_Name LIKE 'Reject' )) " +

                       " AND Articles.Article_No NOT  IN" +
          " ( select Article_Status_Users.Article_No from  Article_Status_Users where  " +
                      "  Article_Status_Users.Status_No IN(select Status.Status_No from Status where  Status.Status_Name LIKE 'Withdrawen' )) ";
            Read_Question = commands.ExecuteReader();
            Read_Question.Read();
            int View_All_Assigned_Submissions_Variable = (int)(Read_Question[0]);
            if (View_All_Assigned_Submissions_Variable > 0)
            {
                View_All_Assigned_Submissions_count.Text = "(" + View_All_Assigned_Submissions_Variable + ")";

                View_All_Assigned_Submissions.Enabled = true;
                Read_Question.Close();

                connect.Close();
            }
            else
            {
                View_All_Assigned_Submissions.Enabled = false;
                Read_Question.Close();
                View_All_Assigned_Submissions_count.Text = "(0)";
                connect.Close();
            }
        }
        else
        {
            Read_Question.Close();
            connect.Close();
        }


        //  }
        //  catch
        //  {
        //       View_All_Assigned_Submissions_count .Text = "(0)";
        //  }
        //   finally
        // {
        //      commands.Parameters.Clear();
        //      connect.Close();
        //  }
        //END ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^View all Assigned Submmisssion ^^^^^^^^^^  

        // ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^Submmisssions out for Revision ^^^^^^^^^^
        try
        {
            connect.Close();
            connect.Open();
            commands.Connection = connect;
            commands.CommandText = " select  " +
                "  Users.User_Name  from Users  where Users.User_No  IN (select  User_Role.User_No from User_Role  " +
                "  where User_Role.Role_No IN (select Role.Role_No  from Role  where Family_Role_No IN (select Family_Role.Family_Role_No from Family_Role " +
                " where Family_Role.Family_Role_Name LIKE 'Editor' )AND Role.Role_Name LIKE 'Editor_in_Chief' OR  Role.Role_Name LIKE 'Associate Editor')) AND Users.User_No IN (select User_Permission.User_No from  User_Permission" +
                " where User_Permission.Permission_No IN (select Secondary_Permission.Permission_No  from  Secondary_Permission where Secondary_Permission.Permission_Type_No" +
                " IN( select Primary_Permission.Permission_Type_No from  Primary_Permission where  Primary_Permission.Permission_Type_Name LIKE 'Manager')AND Secondary_Permission.Permission_Name LIKE 'View Submmisssions out For Revision'   ) ) " +
                "AND Users.User_No =@User_No";
            commands.Parameters.Add("@User_No", System.Data.SqlDbType.Int);
            commands.Parameters["@User_No"].Value = usr_NO;
            Read_Question = commands.ExecuteReader();

            if (Read_Question.Read())
            {
                Read_Question.Close();
                commands.CommandText = " select count(Article_No) from Articles   " +
               " where    Articles.Article_No IN (select Article_Status_Users.Article_No  from Article_Status_Users where  Article_Status_Users.Status_No " +
                 " IN(select  Status.Status_No  from Status where  Status.Family_Role_No IN(select Family_Role.Family_Role_No from Family_Role where  Family_Role.Family_Role_Name LIKE 'Editor' ) " +
                 " AND Status.Status_Name LIKE 'Revise Decision') )" +



                      "AND Articles.Article_No NOT IN " +
                  "( select Article_Status_Users.Article_No  from Article_Status_Users where Article_Status_Users.Status_No " +
                  " IN ( select  Status.Status_No  from Status where Status.Family_Role_No IN  " +
                  " ( select Family_Role.Family_Role_No from Family_Role where Family_Role.Family_Role_Name LIKE 'Editor' ) " +
                  " AND   Status.Status_Name LIKE 'Revise Submission By Author'  ))";



                Read_Question = commands.ExecuteReader();
                Read_Question.Read();
                int Submissions_Out_For_Revisions_Variable = (int)(Read_Question[0]);
                if (Submissions_Out_For_Revisions_Variable > 0)
                {
                    Submissions_Out_For_Revisions_count.Text = "(" + Submissions_Out_For_Revisions_Variable + ")";

                    Submissions_Out_For_Revisions.Enabled = true;
                    Read_Question.Close();

                    connect.Close();
                }
                else
                {
                    Submissions_Out_For_Revisions.Enabled = false;
                    Read_Question.Close();
                    Submissions_Out_For_Revisions_count.Text = "(0)";
                    connect.Close();
                }
            }
            else
            {
                Read_Question.Close();
                connect.Close();
            }


        }
        catch
        {
            Submissions_Out_For_Revisions_count.Text = "(0)";
        }
        finally
        {
            commands.Parameters.Clear();
            connect.Close();
        }
        //END ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^Submmisssions out for Revision ^^^^^^^^^^  

        // ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^All_Submissions_With_Editors_Decision ^^^^^^^^^^
        try
        {
            connect.Close();
            connect.Open();
            commands.Connection = connect;
            commands.CommandText = " select  " +
                "  Users.User_Name  from Users  where Users.User_No  IN (select  User_Role.User_No from User_Role  " +
                "  where User_Role.Role_No IN (select Role.Role_No  from Role  where Family_Role_No IN (select Family_Role.Family_Role_No from Family_Role " +
                " where Family_Role.Family_Role_Name LIKE 'Editor' )AND Role.Role_Name LIKE 'Managing Editor' OR  Role.Role_Name LIKE 'Editor_in_Chief')) AND Users.User_No IN (select User_Permission.User_No from  User_Permission" +
                " where User_Permission.Permission_No IN (select Secondary_Permission.Permission_No  from  Secondary_Permission where Secondary_Permission.Permission_Type_No" +
                " IN( select Primary_Permission.Permission_Type_No from  Primary_Permission where  Primary_Permission.Permission_Type_Name LIKE 'Manager')AND Secondary_Permission.Permission_Name LIKE 'All Submissions With Editors Decision'   ) ) " +
                "AND Users.User_No =@User_No";
            commands.Parameters.Add("@User_No", System.Data.SqlDbType.Int);
            commands.Parameters["@User_No"].Value = usr_NO;
            Read_Question = commands.ExecuteReader();

            if (Read_Question.Read())
            {
                Read_Question.Close();
                commands.CommandText = " select count(Article_No) from Articles   " +
               " where Articles.Article_No NOT IN(select Article_User.Article_No  from Article_User where  Article_User.Assign_Complete =0 )  " +
                    " AND  Articles.Article_No  IN(select Article_User.Article_No  from Article_User " +
                     ")" +
                     " AND Articles.Article_No NOT  IN" +
          " ( select Article_Status_Users.Article_No from  Article_Status_Users where  " +
                      "  Article_Status_Users.Status_No IN(select Status.Status_No from Status where  Status.Status_Name LIKE 'Accept' )) " +

                       " AND Articles.Article_No NOT  IN" +
          " ( select Article_Status_Users.Article_No from  Article_Status_Users where  " +
                      "  Article_Status_Users.Status_No IN(select Status.Status_No from Status where  Status.Status_Name LIKE 'Reject' )) " +

                       " AND Articles.Article_No NOT  IN" +
          " ( select Article_Status_Users.Article_No from  Article_Status_Users where  " +
                      "  Article_Status_Users.Status_No IN(select Status.Status_No from Status where  Status.Status_Name LIKE 'Withdrawen' )) ";//  كل المراجعات editor or reviewer
                Read_Question = commands.ExecuteReader();
                Read_Question.Read();
                int All_Submissions_With_Editors_Decision_Variable = (int)(Read_Question[0]);
                if (All_Submissions_With_Editors_Decision_Variable > 0)
                {
                    All_Submissions_With_Editors_Decision_count.Text = "(" + All_Submissions_With_Editors_Decision_Variable + ")";

                    All_Submissions_With_Editors_Decision.Enabled = true;
                    Read_Question.Close();

                    connect.Close();
                }
                else
                {
                    All_Submissions_With_Editors_Decision.Enabled = false;
                    Read_Question.Close();
                    All_Submissions_With_Editors_Decision_count.Text = "(0)";
                    connect.Close();
                }
            }
            else
            {
                Read_Question.Close();
                connect.Close();
            }


        }
        catch
        {
            View_All_Assigned_Submissions_count.Text = "(0)";
        }
        finally
        {
            commands.Parameters.Clear();
            connect.Close();
        }
        //END ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^All_Submissions_With_Editors_Decision ^^^^^^^^^^ 

        //^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^1 Reviews complete^^^^^^^^^^^^^^^^^^^^^^^^^

        //  try
        // {
        connect.Close();
        connect.Open();
        commands.Connection = connect;
        commands.CommandText = " select Users.User_Name from Users  where Users.User_No  IN ( select  User_Role.User_No from User_Role  " +
            "  where Role_No IN ( select Role.Role_No  from Role  where Family_Role_No IN ( select  Family_Role.Family_Role_No from Family_Role " +
            " where Family_Role.Family_Role_Name LIKE 'Editor' )AND Role.Role_Name LIKE 'Editor_in_Chief' OR  Role.Role_Name LIKE 'Associate Editor'  )) " +
            " AND Users.User_No IN (select User_Permission.User_No from  User_Permission" +
            " where User_Permission.Permission_No IN ( select Secondary_Permission.Permission_No  from " +
                        " Secondary_Permission where Secondary_Permission.Permission_Type_No" +
            " IN( select Primary_Permission.Permission_Type_No from  Primary_Permission where " +
            " Primary_Permission.Permission_Type_Name LIKE 'New Submissions' ) AND " +
            "    Secondary_Permission.Permission_Name LIKE 'New Assignment'  ) ) " +
                  " AND  Users.User_No=@User_No  ";


        commands.Parameters.Add("@User_No", System.Data.SqlDbType.Int);
        commands.Parameters["@User_No"].Value = usr_NO;
        Read_Question = commands.ExecuteReader();


        if (Read_Question.Read())
        {

            commands.Parameters.Clear();
            Read_Question.Close();
            commands.CommandText = " select count(Articles.Article_No) from Articles   " +

            " ,(select Article_User.Lower_User_No,Article_User.Article_No  from Article_User where  Article_User.Family_Role_No IN" +
                "( select Family_Role.Family_Role_No from Family_Role where Family_Role.Family_Role_Name LIKE 'Reviewer') AND " +
                " Article_User.Upper_User_no=@Upper_User_no  AND Article_User.User_Order=1)Reviewer_No_And_Order " +

            " ,( select Article_Status_Users.Article_No,Article_Status_Users.User_No  from Article_Status_Users where Article_Status_Users.Status_No " +
                  " IN ( select  Status.Status_No  from Status where Status.Family_Role_No IN  " +
                  " ( select Family_Role.Family_Role_No from Family_Role where Family_Role.Family_Role_Name LIKE 'Reviewer' ) " +
                 " AND Status.Status_Name LIKE 'Complete Review')) Reviewer_No " +
                "  where  Articles.Article_No=Reviewer_No_And_Order.Article_No " +
              " AND Reviewer_No.User_No=Reviewer_No_And_Order.Lower_User_No  " +
               "AND Articles.Article_No NOT IN " +
             "( select Article_Status_Users.Article_No  from Article_Status_Users where Article_Status_Users.Status_No " +
             " IN ( select  Status.Status_No  from Status where Status.Family_Role_No IN  " +
             " ( select Family_Role.Family_Role_No from Family_Role where Family_Role.Family_Role_Name LIKE 'Editor' ) " +
             " AND   Status.Status_Name LIKE 'Complete Edit'  )AND Article_Status_Users.User_No=@User_No) ";
            commands.Parameters.Add("@User_No", System.Data.SqlDbType.Int);
            commands.Parameters["@User_No"].Value = usr_NO;
            commands.Parameters.Add("@Upper_User_no", System.Data.SqlDbType.Int);
            commands.Parameters["@Upper_User_no"].Value = usr_NO;

            Read_Question = commands.ExecuteReader();
            Read_Question.Read();
            int One_Reviews_Complete_Variable = (int)(Read_Question[0]);
            if (One_Reviews_Complete_Variable > 0)
            {
                One_Reviews_Complete_Count.Text = "(" + One_Reviews_Complete_Variable + ")";

                One_Reviews_Complete.Enabled = true;
                Read_Question.Close();
                connect.Close();
            }
            else
            {
                One_Reviews_Complete.Enabled = false;
                One_Reviews_Complete_Count.Text = "(0)";
                Read_Question.Close();
                connect.Close();
            }
        }

        //  }
        //   catch
        //     {
        //     Submissions_Under_Review_cont.Text = "(0)";
        //    }
        //      finally
        //  {
        //    commands.Parameters.Clear();
        //  connect.Close();
        //  }

        //END^^^^^^^^^^^^^^  ^^^^^^^^^^^^^^^^^^1 Reviews complete ^^^^^^^^^^^^^^^^^^^^^^^^^^^^
        //^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^2 Reviews complete^^^^^^^^^^^^^^^^^^^^^^^^^

        try
        {
            connect.Close();
            connect.Open();
            commands.Connection = connect;
            commands.CommandText = " select Users.User_Name from Users  where Users.User_No  IN ( select  User_Role.User_No from User_Role  " +
                "  where Role_No IN ( select Role.Role_No  from Role  where Family_Role_No IN ( select  Family_Role.Family_Role_No from Family_Role " +
                " where Family_Role.Family_Role_Name LIKE 'Editor' )AND Role.Role_Name LIKE 'Editor_in_Chief' OR  Role.Role_Name LIKE 'Associate Editor'  )) " +
                " AND Users.User_No IN (select User_Permission.User_No from  User_Permission" +
                " where User_Permission.Permission_No IN ( select Secondary_Permission.Permission_No  from " +
                            " Secondary_Permission where Secondary_Permission.Permission_Type_No" +
                " IN( select Primary_Permission.Permission_Type_No from  Primary_Permission where " +
                " Primary_Permission.Permission_Type_Name LIKE 'New Submissions' ) AND " +
                "    Secondary_Permission.Permission_Name LIKE 'New Assignment'  ) ) " +
                      " AND  Users.User_No=@User_No  ";


            commands.Parameters.Add("@User_No", System.Data.SqlDbType.Int);
            commands.Parameters["@User_No"].Value = usr_NO;
            Read_Question = commands.ExecuteReader();

            if (Read_Question.Read())
            {
                commands.Parameters.Clear();
                Read_Question.Close();
                commands.CommandText = " select count(Articles.Article_No) from Articles   " +

                " ,(select Article_User.Lower_User_No,Article_User.Article_No  from Article_User where  Article_User.Family_Role_No IN" +
                    "( select Family_Role.Family_Role_No from Family_Role where Family_Role.Family_Role_Name LIKE 'Reviewer') AND " +
                    "Article_User.Upper_User_no=@Upper_User_no  AND Article_User.User_Order=2)Reviewer_No_And_Order " +

                " ,( select Article_Status_Users.Article_No,Article_Status_Users.User_No  from Article_Status_Users where Article_Status_Users.Status_No " +
                      " IN ( select  Status.Status_No  from Status where Status.Family_Role_No IN  " +
                      " ( select Family_Role.Family_Role_No from Family_Role where Family_Role.Family_Role_Name LIKE 'Reviewer' ) " +
                     " AND Status.Status_Name LIKE 'Complete Review')) Reviewer_No " +
                    "  where  Articles.Article_No=Reviewer_No_And_Order.Article_No " +
                  " AND Reviewer_No.User_No=Reviewer_No_And_Order.Lower_User_No  " +
                   "AND Articles.Article_No NOT IN " +
                 "( select Article_Status_Users.Article_No  from Article_Status_Users where Article_Status_Users.Status_No " +
                 " IN ( select  Status.Status_No  from Status where Status.Family_Role_No IN  " +
                 " ( select Family_Role.Family_Role_No from Family_Role where Family_Role.Family_Role_Name LIKE 'Editor' ) " +
                 " AND   Status.Status_Name LIKE 'Complete Edit'  )AND Article_Status_Users.User_No=@User_No) ";
                commands.Parameters.Add("@User_No", System.Data.SqlDbType.Int);
                commands.Parameters["@User_No"].Value = usr_NO;
                commands.Parameters.Add("@Upper_User_no", System.Data.SqlDbType.Int);
                commands.Parameters["@Upper_User_no"].Value = usr_NO;
                Read_Question = commands.ExecuteReader();
                Read_Question.Read();
                int two_Reviews_Complete_Variable = (int)(Read_Question[0]);
                if (two_Reviews_Complete_Variable > 0)
                {
                    Two_Reviews_Complete_Count.Text = "(" + two_Reviews_Complete_Variable + ")";

                    Two_Reviews_Complete.Enabled = true;
                    Read_Question.Close();
                    connect.Close();
                }
                else
                {
                    Two_Reviews_Complete.Enabled = false;
                    Two_Reviews_Complete_Count.Text = "(0)";
                    Read_Question.Close();
                    connect.Close();
                }
            }

        }
        catch
        {
            Two_Reviews_Complete_Count.Text = "(0)";
        }
        finally
        {
            commands.Parameters.Clear();
            connect.Close();
        }

        //END^^^^^^^^^^^^^^  ^^^^^^^^^^^^^^^^^^2 Reviews complete ^^^^^^^^^^^^^^^^^^^^^^^^^^^^*/
        //^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^3 Reviews complete^^^^^^^^^^^^^^^^^^^^^^^^^

        try
        {
            connect.Close();
            connect.Open();
            commands.Connection = connect;
            commands.CommandText = " select Users.User_Name from Users  where Users.User_No  IN ( select  User_Role.User_No from User_Role  " +
                "  where Role_No IN ( select Role.Role_No  from Role  where Family_Role_No IN ( select  Family_Role.Family_Role_No from Family_Role " +
                " where Family_Role.Family_Role_Name LIKE 'Editor' )AND Role.Role_Name LIKE 'Editor_in_Chief' OR  Role.Role_Name LIKE 'Associate Editor'  )) " +
                " AND Users.User_No IN (select User_Permission.User_No from  User_Permission" +
                " where User_Permission.Permission_No IN ( select Secondary_Permission.Permission_No  from " +
                            " Secondary_Permission where Secondary_Permission.Permission_Type_No" +
                " IN( select Primary_Permission.Permission_Type_No from  Primary_Permission where " +
                " Primary_Permission.Permission_Type_Name LIKE 'New Submissions' ) AND " +
                "    Secondary_Permission.Permission_Name LIKE 'New Assignment'  ) ) " +
                      " AND  Users.User_No=@User_No  ";


            commands.Parameters.Add("@User_No", System.Data.SqlDbType.Int);
            commands.Parameters["@User_No"].Value = usr_NO;
            Read_Question = commands.ExecuteReader();

            if (Read_Question.Read())
            {
                commands.Parameters.Clear();
                Read_Question.Close();
                commands.CommandText = " select count(Articles.Article_No) from Articles   " +

                " ,(select Article_User.Lower_User_No,Article_User.Article_No  from Article_User where  Article_User.Family_Role_No IN" +
                    "( select Family_Role.Family_Role_No from Family_Role where Family_Role.Family_Role_Name LIKE 'Reviewer') AND " +
                    "Article_User.Upper_User_no=@Upper_User_no  AND Article_User.User_Order=3)Reviewer_No_And_Order " +

                " ,( select Article_Status_Users.Article_No,Article_Status_Users.User_No  from Article_Status_Users where Article_Status_Users.Status_No " +
                      " IN ( select  Status.Status_No  from Status where Status.Family_Role_No IN  " +
                      " ( select Family_Role.Family_Role_No from Family_Role where Family_Role.Family_Role_Name LIKE 'Reviewer' ) " +
                     " AND Status.Status_Name LIKE 'Complete Review')) Reviewer_No " +
                    "  where  Articles.Article_No=Reviewer_No_And_Order.Article_No " +
                  " AND Reviewer_No.User_No=Reviewer_No_And_Order.Lower_User_No  " +
                   "AND Articles.Article_No NOT IN " +
                 "( select Article_Status_Users.Article_No  from Article_Status_Users where Article_Status_Users.Status_No " +
                 " IN ( select  Status.Status_No  from Status where Status.Family_Role_No IN  " +
                 " ( select Family_Role.Family_Role_No from Family_Role where Family_Role.Family_Role_Name LIKE 'Editor' ) " +
                 " AND   Status.Status_Name LIKE 'Complete Edit'  )AND Article_Status_Users.User_No=@User_No) ";
                commands.Parameters.Add("@User_No", System.Data.SqlDbType.Int);
                commands.Parameters["@User_No"].Value = usr_NO;
                commands.Parameters.Add("@Upper_User_no", System.Data.SqlDbType.Int);
                commands.Parameters["@Upper_User_no"].Value = usr_NO;
                Read_Question = commands.ExecuteReader();
                Read_Question.Read();
                int three_Reviews_Complete_Variable = (int)(Read_Question[0]);
                if (three_Reviews_Complete_Variable > 0)
                {
                    Three_Reviews_Complete_Count.Text = "(" + three_Reviews_Complete_Variable + ")";

                    Tree_Reviews_Complete.Enabled = true;
                    Read_Question.Close();
                    connect.Close();
                }
                else
                {
                    Tree_Reviews_Complete.Enabled = false;
                    Three_Reviews_Complete_Count.Text = "(0)";
                    Read_Question.Close();
                    connect.Close();
                }
            }

        }
        catch
        {
            Three_Reviews_Complete_Count.Text = "(0)";
        }
        finally
        {
            commands.Parameters.Clear();
            connect.Close();
        }

        //END^^^^^^^^^^^^^^  ^^^^^^^^^^^^^^^^^^3 Reviews complete ^^^^^^^^^^^^^^^^^^^^^^^^^^^^*/
        //^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^4 Reviews complete^^^^^^^^^^^^^^^^^^^^^^^^^

        try
        {
            connect.Close();
            connect.Open();
            commands.Connection = connect;
            commands.CommandText = " select Users.User_Name from Users  where Users.User_No  IN ( select  User_Role.User_No from User_Role  " +
                "  where Role_No IN ( select Role.Role_No  from Role  where Family_Role_No IN ( select  Family_Role.Family_Role_No from Family_Role " +
                " where Family_Role.Family_Role_Name LIKE 'Editor' )AND Role.Role_Name LIKE 'Editor_in_Chief' OR  Role.Role_Name LIKE 'Associate Editor'  )) " +
                " AND Users.User_No IN (select User_Permission.User_No from  User_Permission" +
                " where User_Permission.Permission_No IN ( select Secondary_Permission.Permission_No  from " +
                            " Secondary_Permission where Secondary_Permission.Permission_Type_No" +
                " IN( select Primary_Permission.Permission_Type_No from  Primary_Permission where " +
                " Primary_Permission.Permission_Type_Name LIKE 'New Submissions' ) AND " +
                "    Secondary_Permission.Permission_Name LIKE 'New Assignment'  ) ) " +
                      " AND  Users.User_No=@User_No  ";


            commands.Parameters.Add("@User_No", System.Data.SqlDbType.Int);
            commands.Parameters["@User_No"].Value = usr_NO;
            Read_Question = commands.ExecuteReader();

            if (Read_Question.Read())
            {
                commands.Parameters.Clear();
                Read_Question.Close();
                commands.CommandText = " select count(Articles.Article_No) from Articles   " +

                " ,(select Article_User.Lower_User_No,Article_User.Article_No  from Article_User where  Article_User.Family_Role_No IN" +
                    "( select Family_Role.Family_Role_No from Family_Role where Family_Role.Family_Role_Name LIKE 'Reviewer') AND " +
                    "Article_User.Upper_User_no=@Upper_User_no  AND Article_User.User_Order>3)Reviewer_No_And_Order " +

                " ,( select Article_Status_Users.Article_No,Article_Status_Users.User_No  from Article_Status_Users where Article_Status_Users.Status_No " +
                      " IN ( select  Status.Status_No  from Status where Status.Family_Role_No IN  " +
                      " ( select Family_Role.Family_Role_No from Family_Role where Family_Role.Family_Role_Name LIKE 'Reviewer' ) " +
                     " AND Status.Status_Name LIKE 'Complete Review')) Reviewer_No " +
                    "  where  Articles.Article_No=Reviewer_No_And_Order.Article_No " +
                  " AND Reviewer_No.User_No=Reviewer_No_And_Order.Lower_User_No  " +
                   "AND Articles.Article_No NOT IN " +
                 "( select Article_Status_Users.Article_No  from Article_Status_Users where Article_Status_Users.Status_No " +
                 " IN ( select  Status.Status_No  from Status where Status.Family_Role_No IN  " +
                 " ( select Family_Role.Family_Role_No from Family_Role where Family_Role.Family_Role_Name LIKE 'Editor' ) " +
                 " AND   Status.Status_Name LIKE 'Complete Edit'  )AND Article_Status_Users.User_No=@User_No) ";
                commands.Parameters.Add("@User_No", System.Data.SqlDbType.Int);
                commands.Parameters["@User_No"].Value = usr_NO;
                commands.Parameters.Add("@Upper_User_no", System.Data.SqlDbType.Int);
                commands.Parameters["@Upper_User_no"].Value = usr_NO;
                Read_Question = commands.ExecuteReader();
                Read_Question.Read();
                int Four_Reviews_Complete_Variable = (int)(Read_Question[0]);
                if (Four_Reviews_Complete_Variable > 0)
                {
                    Four_Reviews_Complete_Count.Text = "(" + Four_Reviews_Complete_Variable + ")";

                    Four_Reviews_Complete.Enabled = true;
                    Read_Question.Close();
                    connect.Close();
                }
                else
                {
                    Four_Reviews_Complete.Enabled = false;
                    Four_Reviews_Complete_Count.Text = "(0)";
                    Read_Question.Close();
                    connect.Close();
                }
            }

        }
        catch
        {
            Four_Reviews_Complete_Count.Text = "(0)";
        }
        finally
        {
            commands.Parameters.Clear();
            connect.Close();
        }

        //END^^^^^^^^^^^^^^  ^^^^^^^^^^^^^^^^^^4 Reviews complete ^^^^^^^^^^^^^^^^^^^^^^^^^^^^*/
        // ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^Group By I Editor ^^^^^^^^^^
        try
        {
            commands.Parameters.Clear();
            connect.Close();
            connect.Open();
            commands.Connection = connect;
            commands.CommandText = " select  " +
                "  Users.User_Name  from Users  where Users.User_No  IN (select  User_Role.User_No from User_Role  " +
                "  where User_Role.Role_No IN (select Role.Role_No  from Role  where Family_Role_No IN (select Family_Role.Family_Role_No from Family_Role " +
                " where Family_Role.Family_Role_Name LIKE 'Editor' )AND Role.Role_Name LIKE 'Editor_in_Chief' OR  Role.Role_Name LIKE 'Associate Editor')) AND Users.User_No IN (select User_Permission.User_No from  User_Permission" +
                " where User_Permission.Permission_No IN (select Secondary_Permission.Permission_No  from  Secondary_Permission where Secondary_Permission.Permission_Type_No" +
                " IN( select Primary_Permission.Permission_Type_No from  Primary_Permission where  Primary_Permission.Permission_Type_Name LIKE 'Manager')AND Secondary_Permission.Permission_Name LIKE 'Group By Editor Assigned'   ) ) " +
                "AND Users.User_No =@User_No";
            commands.Parameters.Add("@User_No", System.Data.SqlDbType.Int);
            commands.Parameters["@User_No"].Value = usr_NO;
            Read_Question = commands.ExecuteReader();

            if (Read_Question.Read())
            {
                Read_Question.Close();
                commands.CommandText = " select count(Article_No) from Articles   " +
                 " where  Articles.Article_No IN(select  Article_User.Article_No  from Article_User)  " +

                  " AND Articles.Article_No IN (select Article_Status_Users.Article_No  from Article_Status_Users where  Article_Status_Users.Status_No " +
                     " IN(select  Status.Status_No  from Status where  Status.Family_Role_No IN(select Family_Role.Family_Role_No from Family_Role where  Family_Role.Family_Role_Name LIKE 'Editor' ) " +
                     " AND Status.Status_Name LIKE 'Editor Assign') )" +

        " AND Articles.Article_No NOT  IN" +
              " ( select Article_Status_Users.Article_No from  Article_Status_Users where  " +
                          "  Article_Status_Users.Status_No IN(select Status.Status_No from Status where  Status.Status_Name LIKE 'Accept' )) " +

                           " AND Articles.Article_No NOT  IN" +
              " ( select Article_Status_Users.Article_No from  Article_Status_Users where  " +
                          "  Article_Status_Users.Status_No IN(select Status.Status_No from Status where  Status.Status_Name LIKE 'Reject' )) " +

                           " AND Articles.Article_No NOT  IN" +
              " ( select Article_Status_Users.Article_No from  Article_Status_Users where  " +
                          "  Article_Status_Users.Status_No IN(select Status.Status_No from Status where  Status.Status_Name LIKE 'Withdrawen' )) ";
                Read_Question = commands.ExecuteReader();
                Read_Question.Read();
                int Group_By_Editor_Assigned_Variable = (int)(Read_Question[0]);
                if (Group_By_Editor_Assigned_Variable > 0)
                {
                    Group_By_Editor_Assigned_Count.Text = "(" + Group_By_Editor_Assigned_Variable + ")";

                    Group_By_Editor_Assigned.Enabled = true;
                    Read_Question.Close();

                    connect.Close();
                }
                else
                {
                    Group_By_Editor_Assigned.Enabled = false;
                    Read_Question.Close();
                    Group_By_Editor_Assigned_Count.Text = "(0)";
                    connect.Close();
                }
            }
            else
            {
                Read_Question.Close();
                connect.Close();
            }


        }
        catch
        {
            Group_By_Editor_Assigned_Count.Text = "(0)";
        }
        finally
        {
            commands.Parameters.Clear();
            connect.Close();
        }
        //END ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^Group By I Editor  ^^^^^^^^^^  
        // ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^Group By With Current Editor^^^^^^^^^^
        try
        {
            commands.Parameters.Clear();
            connect.Close();
            connect.Open();
            commands.Connection = connect;
            commands.CommandText = " select  " +
                "  Users.User_Name  from Users  where Users.User_No  IN (select  User_Role.User_No from User_Role  " +
                "  where User_Role.Role_No IN (select Role.Role_No  from Role  where Family_Role_No IN (select Family_Role.Family_Role_No from Family_Role " +
                " where Family_Role.Family_Role_Name LIKE 'Editor' )AND Role.Role_Name LIKE 'Editor_in_Chief' OR  Role.Role_Name LIKE 'Associate Editor')) AND Users.User_No IN (select User_Permission.User_No from  User_Permission" +
                " where User_Permission.Permission_No IN (select Secondary_Permission.Permission_No  from  Secondary_Permission where Secondary_Permission.Permission_Type_No" +
                " IN( select Primary_Permission.Permission_Type_No from  Primary_Permission where  Primary_Permission.Permission_Type_Name LIKE 'Manager')AND Secondary_Permission.Permission_Name LIKE 'Group By Editor With current Responsibility'   ) ) " +
                "AND Users.User_No =@User_No";
            commands.Parameters.Add("@User_No", System.Data.SqlDbType.Int);
            commands.Parameters["@User_No"].Value = usr_NO;
            Read_Question = commands.ExecuteReader();

            if (Read_Question.Read())
            {
                Read_Question.Close();
                commands.CommandText = " select count(Article_No) from Articles   " +
                 " where  Articles.Article_No IN(select  Article_User.Article_No  from Article_User)  " +


                  " AND Articles.Article_No IN (select Article_Status_Users.Article_No  from Article_Status_Users where  Article_Status_Users.Status_No " +
               " IN(select  Status.Status_No  from Status where  Status.Family_Role_No IN(select Family_Role.Family_Role_No from Family_Role where  Family_Role.Family_Role_Name LIKE 'Editor' ) " +
               " AND Status.Status_Name LIKE 'Editor Assign') )" +

        " AND Articles.Article_No NOT  IN" +
              " ( select Article_Status_Users.Article_No from  Article_Status_Users where  " +
                          "  Article_Status_Users.Status_No IN(select Status.Status_No from Status where  Status.Status_Name LIKE 'Accept' )) " +

                           " AND Articles.Article_No NOT  IN" +
              " ( select Article_Status_Users.Article_No from  Article_Status_Users where  " +
                          "  Article_Status_Users.Status_No IN(select Status.Status_No from Status where  Status.Status_Name LIKE 'Reject' )) " +

                           " AND Articles.Article_No NOT  IN" +
              " ( select Article_Status_Users.Article_No from  Article_Status_Users where  " +
                          "  Article_Status_Users.Status_No IN(select Status.Status_No from Status where  Status.Status_Name LIKE 'Withdrawen' )) ";
                Read_Question = commands.ExecuteReader();
                Read_Question.Read();
                int Group_By_Editor_With_current_Responsibility_Variable = (int)(Read_Question[0]);
                if (Group_By_Editor_With_current_Responsibility_Variable > 0)
                {
                    Group_By_Editor_With_current_Responsibility_Count.Text = "(" + Group_By_Editor_With_current_Responsibility_Variable + ")";

                    Group_By_Editor_With_current_Responsibility.Enabled = true;
                    Read_Question.Close();

                    connect.Close();
                }
                else
                {
                    Group_By_Editor_With_current_Responsibility.Enabled = false;
                    Read_Question.Close();
                    Group_By_Editor_With_current_Responsibility_Count.Text = "(0)";
                    connect.Close();
                }
            }
            else
            {
                Read_Question.Close();
                connect.Close();
            }


        }
        catch
        {
            Group_By_Editor_With_current_Responsibility_Count.Text = "(0)";
        }
        finally
        {
            commands.Parameters.Clear();
            connect.Close();
        }
        //END ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^Group By With Current Editor  ^^^^^^^^^^  
        // ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^Group By With Current Status^^^^^^^^^^
        try
        {
            commands.Parameters.Clear();
            connect.Close();
            connect.Open();
            commands.Connection = connect;
            commands.CommandText = " select  " +
                "  Users.User_Name  from Users  where Users.User_No  IN (select  User_Role.User_No from User_Role  " +
                "  where User_Role.Role_No IN (select Role.Role_No  from Role  where Family_Role_No IN (select Family_Role.Family_Role_No from Family_Role " +
                " where Family_Role.Family_Role_Name LIKE 'Editor' )AND Role.Role_Name LIKE 'Editor_in_Chief' OR  Role.Role_Name LIKE 'Associate Editor')) AND Users.User_No IN (select User_Permission.User_No from  User_Permission" +
                " where User_Permission.Permission_No IN (select Secondary_Permission.Permission_No  from  Secondary_Permission where Secondary_Permission.Permission_Type_No" +
                " IN( select Primary_Permission.Permission_Type_No from  Primary_Permission where  Primary_Permission.Permission_Type_Name LIKE 'Manager')AND Secondary_Permission.Permission_Name LIKE 'Group By Submission With  Current Status'   ) ) " +
                "AND Users.User_No =@User_No";
            commands.Parameters.Add("@User_No", System.Data.SqlDbType.Int);
            commands.Parameters["@User_No"].Value = usr_NO;
            Read_Question = commands.ExecuteReader();

            if (Read_Question.Read())
            {
                Read_Question.Close();
                commands.CommandText = " select count(Article_No) from Articles   " +
                 " where  Articles.Article_No NOT  IN" +
              " ( select Article_Status_Users.Article_No from  Article_Status_Users where  " +
                          "  Article_Status_Users.Status_No IN(select Status.Status_No from Status where  Status.Status_Name LIKE 'Accept' )) " +

                           " AND Articles.Article_No NOT  IN" +
              " ( select Article_Status_Users.Article_No from  Article_Status_Users where  " +
                          "  Article_Status_Users.Status_No IN(select Status.Status_No from Status where  Status.Status_Name LIKE 'Reject' )) " +

                           " AND Articles.Article_No NOT  IN" +
              " ( select Article_Status_Users.Article_No from  Article_Status_Users where  " +
                          "  Article_Status_Users.Status_No IN(select Status.Status_No from Status where  Status.Status_Name LIKE 'Withdrawen' )) ";
                Read_Question = commands.ExecuteReader();
                Read_Question.Read();
                int Group_By_Manuscript_Status_Variable = (int)(Read_Question[0]);
                if (Group_By_Manuscript_Status_Variable > 0)
                {
                    Group_By_Manuscript_Status_Count.Text = "(" + Group_By_Manuscript_Status_Variable + ")";

                    Group_By_Manuscript_Status.Enabled = true;
                    Read_Question.Close();

                    connect.Close();
                }
                else
                {
                    Group_By_Manuscript_Status.Enabled = false;
                    Read_Question.Close();
                    Group_By_Manuscript_Status_Count.Text = "(0)";
                    connect.Close();
                }
            }
            else
            {
                Group_By_Manuscript_Status_Count.Text = "(0)";
                Read_Question.Close();
                connect.Close();
            }


        }
        catch
        {
            Group_By_Manuscript_Status_Count.Text = "(0)";
        }
        finally
        {
            commands.Parameters.Clear();
            connect.Close();
        }
        //END ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^Group By With Current Status ^^^^^^^^^^  

        // ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^Accept^^^^^^^^^^
        try
        {
            commands.Parameters.Clear();
            connect.Close();
            connect.Open();
            commands.Connection = connect;
            commands.CommandText = " select  " +
                "  Users.User_Name  from Users  where Users.User_No  IN (select  User_Role.User_No from User_Role  " +
                "  where User_Role.Role_No IN (select Role.Role_No  from Role  where Family_Role_No IN (select Family_Role.Family_Role_No from Family_Role " +
                " where Family_Role.Family_Role_Name LIKE 'Editor' )AND Role.Role_Name LIKE 'Editor_in_Chief' OR  Role.Role_Name LIKE 'Associate Editor')) AND Users.User_No IN (select User_Permission.User_No from  User_Permission" +
                " where User_Permission.Permission_No IN (select Secondary_Permission.Permission_No  from  Secondary_Permission where Secondary_Permission.Permission_Type_No" +
                " IN( select Primary_Permission.Permission_Type_No from  Primary_Permission where  Primary_Permission.Permission_Type_Name LIKE 'Manager')AND Secondary_Permission.Permission_Name LIKE 'Accept'   ) ) " +
                "AND Users.User_No =@User_No";
            commands.Parameters.Add("@User_No", System.Data.SqlDbType.Int);
            commands.Parameters["@User_No"].Value = usr_NO;
            Read_Question = commands.ExecuteReader();

            if (Read_Question.Read())
            {
                Read_Question.Close();
                commands.CommandText = " select count(Article_No) from Articles   " +
                 " where   Articles.Article_No   IN" +
              " ( select Article_Status_Users.Article_No from  Article_Status_Users where  " +
                          "  Article_Status_Users.Status_No IN(select Status.Status_No from Status where  Status.Status_Name LIKE 'Accept' )) ";
                Read_Question = commands.ExecuteReader();
                Read_Question.Read();
                int Accept_Variable = (int)(Read_Question[0]);
                if (Accept_Variable > 0)
                {
                    Accept_Count.Text = "(" + Accept_Variable + ")";

                    Accept.Enabled = true;
                    Read_Question.Close();

                    connect.Close();
                }
                else
                {
                    Accept.Enabled = false;
                    Read_Question.Close();
                    Accept_Count.Text = "(0)";
                    connect.Close();
                }
            }
            else
            {
                Accept_Count.Text = "(0)";
                Read_Question.Close();
                connect.Close();
            }


        }
        catch
        {
            Accept_Count.Text = "(0)";
        }
        finally
        {
            commands.Parameters.Clear();
            connect.Close();
        }
        //END ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^Accept ^^^^^^^^^^ 

        // ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^Reject^^^^^^^^^^
        try
        {
            commands.Parameters.Clear();
            connect.Close();
            connect.Open();
            commands.Connection = connect;
            commands.CommandText = " select  " +
                "  Users.User_Name  from Users  where Users.User_No  IN (select  User_Role.User_No from User_Role  " +
                "  where User_Role.Role_No IN (select Role.Role_No  from Role  where Family_Role_No IN (select Family_Role.Family_Role_No from Family_Role " +
                " where Family_Role.Family_Role_Name LIKE 'Editor' )AND Role.Role_Name LIKE 'Editor_in_Chief' OR  Role.Role_Name LIKE 'Associate Editor')) AND Users.User_No IN (select User_Permission.User_No from  User_Permission" +
                " where User_Permission.Permission_No IN (select Secondary_Permission.Permission_No  from  Secondary_Permission where Secondary_Permission.Permission_Type_No" +
                " IN( select Primary_Permission.Permission_Type_No from  Primary_Permission where  Primary_Permission.Permission_Type_Name LIKE 'Manager')AND Secondary_Permission.Permission_Name LIKE 'Reject'   ) ) " +
                "AND Users.User_No =@User_No";
            commands.Parameters.Add("@User_No", System.Data.SqlDbType.Int);
            commands.Parameters["@User_No"].Value = usr_NO;
            Read_Question = commands.ExecuteReader();

            if (Read_Question.Read())
            {
                Read_Question.Close();
                commands.CommandText = " select count(Article_No) from Articles   " +
                 " where   Articles.Article_No   IN" +
              " ( select Article_Status_Users.Article_No from  Article_Status_Users where  " +
                          "  Article_Status_Users.Status_No IN(select Status.Status_No from Status where  Status.Status_Name LIKE 'Reject' )) ";
                Read_Question = commands.ExecuteReader();
                Read_Question.Read();
                int Reject_Variable = (int)(Read_Question[0]);
                if (Reject_Variable > 0)
                {
                    Reject_Count.Text = "(" + Reject_Variable + ")";

                    Reject.Enabled = true;
                    Read_Question.Close();

                    connect.Close();
                }
                else
                {
                    Reject.Enabled = false;
                    Read_Question.Close();
                    Reject_Count.Text = "(0)";
                    connect.Close();
                }
            }
            else
            {
                Reject_Count.Text = "(0)";
                Read_Question.Close();
                connect.Close();
            }


        }
        catch
        {
            Reject_Count.Text = "(0)";
        }
        finally
        {
            commands.Parameters.Clear();
            connect.Close();
        }
        //END ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^Reject ^^^^^^^^^^ 
        // ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^withsrawen^^^^^^^^^^
        try
        {
            commands.Parameters.Clear();
            connect.Close();
            connect.Open();
            commands.Connection = connect;
            commands.CommandText = " select  " +
                "  Users.User_Name  from Users  where Users.User_No  IN (select  User_Role.User_No from User_Role  " +
                "  where User_Role.Role_No IN (select Role.Role_No  from Role  where Family_Role_No IN (select Family_Role.Family_Role_No from Family_Role " +
                " where Family_Role.Family_Role_Name LIKE 'Editor' )AND Role.Role_Name LIKE 'Editor_in_Chief' OR  Role.Role_Name LIKE 'Associate Editor')) AND Users.User_No IN (select User_Permission.User_No from  User_Permission" +
                " where User_Permission.Permission_No IN (select Secondary_Permission.Permission_No  from  Secondary_Permission where Secondary_Permission.Permission_Type_No" +
                " IN( select Primary_Permission.Permission_Type_No from  Primary_Permission where  Primary_Permission.Permission_Type_Name LIKE 'Manager')AND Secondary_Permission.Permission_Name LIKE 'Withdrawen'   ) ) " +
                "AND Users.User_No =@User_No";
            commands.Parameters.Add("@User_No", System.Data.SqlDbType.Int);
            commands.Parameters["@User_No"].Value = usr_NO;
            Read_Question = commands.ExecuteReader();

            if (Read_Question.Read())
            {
                Read_Question.Close();
                commands.CommandText = " select count(Article_No) from Articles   " +
                 " where   Articles.Article_No   IN" +
              " ( select Article_Status_Users.Article_No from  Article_Status_Users where  " +
                          "  Article_Status_Users.Status_No IN(select Status.Status_No from Status where  Status.Status_Name LIKE 'Withdrawen' )) ";
                Read_Question = commands.ExecuteReader();
                Read_Question.Read();
                int Reject_Variable = (int)(Read_Question[0]);
                if (Reject_Variable > 0)
                {
                    Withdrawen_Count.Text = "(" + Reject_Variable + ")";

                    Withdrawen.Enabled = true;
                    Read_Question.Close();

                    connect.Close();
                }
                else
                {
                    Withdrawen.Enabled = false;
                    Read_Question.Close();
                    Withdrawen_Count.Text = "(0)";
                    connect.Close();
                }
            }
            else
            {
                Withdrawen_Count.Text = "(0)";
                Read_Question.Close();
                connect.Close();
            }


        }
        catch
        {
            Withdrawen_Count.Text = "(0)";
        }
        finally
        {
            commands.Parameters.Clear();
            connect.Close();
        }
        //END ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^withsrawen ^^^^^^^^^^ 
        // ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^LINKED group inactive^^^^^^^^^^
        //    try
        //  {
        commands.Parameters.Clear();
        connect.Close();
        connect.Open();
        commands.Connection = connect;
        commands.CommandText = " select  " +
            "  Users.User_Name  from Users  where Users.User_No  IN (select  User_Role.User_No from User_Role  " +
            "  where User_Role.Role_No IN (select Role.Role_No  from Role  where Family_Role_No IN (select Family_Role.Family_Role_No from Family_Role " +
            " where Family_Role.Family_Role_Name LIKE 'Editor' )AND Role.Role_Name LIKE 'Editor_in_Chief' OR  Role.Role_Name LIKE 'Associate Editor')) AND Users.User_No IN (select User_Permission.User_No from  User_Permission" +
            " where User_Permission.Permission_No IN (select Secondary_Permission.Permission_No  from  Secondary_Permission where Secondary_Permission.Permission_Type_No" +
            " IN( select Primary_Permission.Permission_Type_No from  Primary_Permission where  Primary_Permission.Permission_Type_Name LIKE 'Manager')AND Secondary_Permission.Permission_Name LIKE 'Active Linked Submision Groups'   ) ) " +
            "AND Users.User_No =@User_No";
        commands.Parameters.Add("@User_No", System.Data.SqlDbType.Int);
        commands.Parameters["@User_No"].Value = usr_NO;
        Read_Question = commands.ExecuteReader();

        if (Read_Question.Read())
        {
            Read_Question.Close();
            commands.CommandText = " select count(Article_No) from Articles   " +
             " where  Articles.Article_No IN(select  Linked_submission_Article.Article_No  from Linked_submission_Article where Linked_submission_Article.Linked_Submission_Group_No " +
      " IN(select  Linked_Submission_Group.Linked_Submission_Group_No from Linked_Submission_Group  where Linked_Submission_Group.Linked_Submission_Group_Status=1 ))     ";
            Read_Question = commands.ExecuteReader();
            Read_Question.Read();
            int Active_Linked_Submision_Groups_Variable = (int)(Read_Question[0]);
            if (Active_Linked_Submision_Groups_Variable > 0)
            {
                Active_Linked_Submision_Groups_Count.Text = "(" + Active_Linked_Submision_Groups_Variable + ")";

                Active_Linked_Submision_Groups.Enabled = true;
                Read_Question.Close();

                connect.Close();
            }
            else
            {
                Active_Linked_Submision_Groups.Enabled = false;
                Read_Question.Close();
                Active_Linked_Submision_Groups_Count.Text = "(0)";
                connect.Close();
            }
        }
        else
        {
            Active_Linked_Submision_Groups_Count.Text = "(0)";
            Read_Question.Close();
            connect.Close();
        }


        //}
        //  catch
        //{
        //  Active_Linked_Submision_Groups_Count.Text = "(0)";
        //   }
        // finally
        //  {
        //    commands.Parameters.Clear();
        //  connect.Close();
        //    }
        //END ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^LINKED group inactive^^^^^^^^^^
        // ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^LINKED group inactive^^^^^^^^^^
        try
        {
            commands.Parameters.Clear();
            connect.Close();
            connect.Open();
            commands.Connection = connect;
            commands.CommandText = " select  " +
                "  Users.User_Name  from Users  where Users.User_No  IN (select  User_Role.User_No from User_Role  " +
                "  where User_Role.Role_No IN (select Role.Role_No  from Role  where Family_Role_No IN (select Family_Role.Family_Role_No from Family_Role " +
                " where Family_Role.Family_Role_Name LIKE 'Editor' )AND Role.Role_Name LIKE 'Editor_in_Chief' OR  Role.Role_Name LIKE 'Associate Editor')) AND Users.User_No IN (select User_Permission.User_No from  User_Permission" +
                " where User_Permission.Permission_No IN (select Secondary_Permission.Permission_No  from  Secondary_Permission where Secondary_Permission.Permission_Type_No" +
                " IN( select Primary_Permission.Permission_Type_No from  Primary_Permission where  Primary_Permission.Permission_Type_Name LIKE 'Manager')AND Secondary_Permission.Permission_Name LIKE 'Inactive Linked Submision Groups'   ) ) " +
                "AND Users.User_No =@User_No";
            commands.Parameters.Add("@User_No", System.Data.SqlDbType.Int);
            commands.Parameters["@User_No"].Value = usr_NO;
            Read_Question = commands.ExecuteReader();

            if (Read_Question.Read())
            {
                Read_Question.Close();
                commands.CommandText = " select count(Article_No) from Articles   " +
                 " where  Articles.Article_No IN(select  Linked_submission_Article.Article_No  from Linked_submission_Article where Linked_submission_Article.Linked_Submission_Group_No " +
          " IN(select  Linked_Submission_Group.Linked_Submission_Group_No from Linked_Submission_Group  where Linked_Submission_Group.Linked_Submission_Group_Status=0 ))     ";
                Read_Question = commands.ExecuteReader();
                Read_Question.Read();
                int Inactive_Linked_Submision_Groups_Variable = (int)(Read_Question[0]);
                if (Inactive_Linked_Submision_Groups_Variable > 0)
                {
                    Inactive_Linked_Submision_Groups_Count.Text = "(" + Inactive_Linked_Submision_Groups_Variable + ")";

                    Inactive_Linked_Submision_Groups.Enabled = true;
                    Read_Question.Close();

                    connect.Close();
                }
                else
                {
                    Inactive_Linked_Submision_Groups.Enabled = false;
                    Read_Question.Close();
                    Inactive_Linked_Submision_Groups_Count.Text = "(0)";
                    connect.Close();
                }
            }
            else
            {
                Inactive_Linked_Submision_Groups_Count.Text = "(0)";
                Read_Question.Close();
                connect.Close();
            }


        }
        catch
        {
            Inactive_Linked_Submision_Groups_Count.Text = "(0)";
        }
        finally
        {
            commands.Parameters.Clear();
            connect.Close();
        }
        //END ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^LINKED group inactive^^^^^^^^^^
        // ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^My Assignment^^^^^^^^^^
        //  try
        //       {
        commands.Parameters.Clear();
        connect.Close();
        connect.Open();
        commands.Connection = connect;
        commands.CommandText = " select Users.User_Name from Users  where Users.User_No  IN ( select  User_Role.User_No from User_Role  " +
             "  where Role_No IN ( select Role.Role_No  from Role  where Family_Role_No IN ( select  Family_Role.Family_Role_No from Family_Role " +
             " where Family_Role.Family_Role_Name LIKE 'Editor' )AND Role.Role_Name LIKE 'Editor_in_Chief' OR  Role.Role_Name LIKE 'Associate Editor'  )) " +
             " AND Users.User_No IN (select User_Permission.User_No from  User_Permission" +
             " where User_Permission.Permission_No IN ( select Secondary_Permission.Permission_No  from " +
                         " Secondary_Permission where Secondary_Permission.Permission_Type_No" +
             " IN( select Primary_Permission.Permission_Type_No from  Primary_Permission where " +
             " Primary_Permission.Permission_Type_Name LIKE 'New Submissions' ) AND " +
             "    Secondary_Permission.Permission_Name LIKE 'New Assignment'  ) ) " +
                   " AND  Users.User_No=@User_No  ";
        commands.Parameters.Add("@User_No", System.Data.SqlDbType.Int);
        commands.Parameters["@User_No"].Value = usr_NO;
        Read_Question = commands.ExecuteReader();

        commands.Parameters.Clear();
        if (Read_Question.Read())
        {
            Read_Question.Close();
            commands.CommandText = " select count(Article_No) from Articles   " +
             " where  Articles.Article_No IN(select Article_Status_Users.Article_No from Article_Status_Users where  Article_Status_Users.Status_No " +
               " IN(select  Status.Status_No  from Status where  Status.Family_Role_No IN(select Family_Role.Family_Role_No from Family_Role where  Family_Role.Family_Role_Name LIKE 'Editor' ) " +
               " AND Status.Status_Name LIKE 'Complete Edit')AND  Article_Status_Users.User_No=@User_No )";
            commands.Parameters.Add("@User_No", System.Data.SqlDbType.Int);
            commands.Parameters["@User_No"].Value = usr_NO;
            Read_Question = commands.ExecuteReader();
            Read_Question.Read();
            int My_Assignments_With_Decision_Count_Variable = (int)(Read_Question[0]);
            if (My_Assignments_With_Decision_Count_Variable > 0)
            {
                My_Assignments_With_Decision_Count.Text = "(" + My_Assignments_With_Decision_Count_Variable + ")";

                My_Assignments_With_Decision.Enabled = true;
                Read_Question.Close();
                connect.Close();
            }
            else
            {
                My_Assignments_With_Decision.Enabled = false;
                Read_Question.Close();
                My_Assignments_With_Decision_Count.Text = "(0)";
                connect.Close();
            }
        }
        else
        {
            Read_Question.Close();
            connect.Close();
        }


        // }
        //    catch
        //      {
        //    My_Assignments_With_Decision_Count .Text = "(0)";
        //  }
        //    finally
        //      {
        // commands.Parameters.Clear();
        //   connect.Close();
        // }
        //END ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^My Assignment^^^^^^^^^^ 

    }
    protected void MultiView1_ActiveViewChanged(object sender, EventArgs e)
    {

    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {

    }
    protected void Direct_To_Editor_New_Submission_Click(object sender, EventArgs e)
    {


    }
    protected void LinkButton1_Click1(object sender, EventArgs e)
    {

    }
    protected void Direct_To_Editor_Ne_Submissions_Click(object sender, EventArgs e)
    {
        DateTime time = new DateTime();
        time = DateTime.Now;
        try
        {
            Read_Question.Close();
            connect.Open();
            commands.CommandText = " update Current_Status " +
                " set Current_Status_Name ='Recieved',Current_Status_Date=@Current_Status_Date " +
                " where Current_Status_Name='Submitted'  AND  Current_Status.Article_No IN " +
            "   ( select  Article_No  from Articles   " +
        " where  Articles.Article_Revision LIKE '0') ";
            commands.Parameters.Add("@Current_Status_Date", System.Data.SqlDbType.DateTime);
            commands.Parameters["@Current_Status_Date"].Value = time;
            commands.ExecuteNonQuery();
            Read_Question.Close();

            commands.CommandText = "select Status.Status_No from  Status where  " +
                                   "  Status.Status_Name LIKE 'Recieved'";
            Read_Question = commands.ExecuteReader();
            Read_Question.Read();
            int Status_Nom = (int)Read_Question[0];
            Read_Question.Close();
            commands.Parameters.Clear();

            String quer = " select Article_No from Articles   " +
                  " where Articles.Article_No  IN" +
            " ( select Current_Status.Article_No from  Current_Status where  " +
                        "  Current_Status.Current_Status_Name LIKE 'Recieved' )AND Articles.Article_Revision LIKE '0' ";
            SqlCommand comm_Que_Type = new SqlCommand(quer, connect);
            SqlDataAdapter adapter = new SqlDataAdapter(comm_Que_Type);
            DataTable table = new DataTable();
            adapter.Fill(table);
            foreach (DataRow datarow in table.Select())
            {

                int Article_no = (int)datarow["Article_No"];
                commands.CommandText = " select Article_No from Article_Status_Users where" +
                    " Article_Status_Users.Status_No  IN( select Status.Status_No from  Status where  " +
                                 "  Status.Status_Name LIKE 'Recieved') AND Article_Status_Users.Article_No=@Article_No";
                commands.Parameters.Add("@Article_No", System.Data.SqlDbType.Int);
                commands.Parameters["@Article_No"].Value = Article_no;
                Read_Question = commands.ExecuteReader();
                commands.Parameters.Clear();
                if (Read_Question.Read())
                {


                    Read_Question.Close();

                }

                else
                {
                    Read_Question.Close();
                    commands.Parameters.Clear();




                    commands.CommandText = "insert into Article_Status_Users ( Status_No ,User_No,Status_Date,Article_No )" +
                        "values(@Status_No,@User_No,@Status_Date,@Article_No)  ";

                    commands.Parameters.Add("@Status_No", System.Data.SqlDbType.Int);
                    commands.Parameters["@Status_No"].Value = Status_Nom;
                    commands.Parameters.Add("@User_No", System.Data.SqlDbType.Int);
                    commands.Parameters["@User_No"].Value = usr_NO;
                    commands.Parameters.Add("@Status_Date", System.Data.SqlDbType.DateTime);
                    commands.Parameters["@Status_Date"].Value = time;
                    commands.Parameters.Add("@Article_No", System.Data.SqlDbType.Int);
                    commands.Parameters["@Article_No"].Value = Article_no;
                    commands.ExecuteNonQuery();
                    commands.Parameters.Clear();
                }

            }

            Read_Question.Close();
            Response.Redirect("Direct to Editor New Submissions.aspx");
        }
        catch
        {
        }
        finally
        {
            connect.Close();
        }

    }
    protected void Direct_To_Editor_Revised_Submission_Click(object sender, EventArgs e)
    {
        DateTime time = new DateTime();
        time = DateTime.Now;
        //  try
        //  {
        Read_Question.Close();
        connect.Open();
        commands.CommandText = " update Current_Status " +
            " set Current_Status_Name ='Recieved',Current_Status_Date=@Current_Status_Date " +
            " where Current_Status_Name='Submitted'  AND  Current_Status.Article_No IN " +
        "   ( select  Article_No  from Articles   " +
    " where  Articles.Article_Revision NOT LIKE '0') ";
        commands.Parameters.Add("@Current_Status_Date", System.Data.SqlDbType.DateTime);
        commands.Parameters["@Current_Status_Date"].Value = time;
        commands.ExecuteNonQuery();
        Read_Question.Close();

        commands.CommandText = "select Status.Status_No from  Status where  " +
                               "  Status.Status_Name LIKE 'Recieved'";
        Read_Question = commands.ExecuteReader();
        Read_Question.Read();
        int Status_Nom = (int)Read_Question[0];
        Read_Question.Close();
        commands.Parameters.Clear();

        String quer = " select Article_No from Articles   " +
              " where Articles.Article_No  IN" +
        " ( select Current_Status.Article_No from  Current_Status where  " +
                    "  Current_Status.Current_Status_Name LIKE 'Recieved' )AND Articles.Article_Revision NOT LIKE '0' ";
        SqlCommand comm_Que_Type = new SqlCommand(quer, connect);
        SqlDataAdapter adapter = new SqlDataAdapter(comm_Que_Type);
        DataTable table = new DataTable();
        adapter.Fill(table);
        foreach (DataRow datarow in table.Select())
        {
            int Article_no = (int)datarow["Article_No"];
            commands.CommandText = " select Article_No from Article_Status_Users where" +
                " Article_Status_Users.Status_No  IN( select Status.Status_No from  Status where  " +
                             "  Status.Status_Name LIKE 'Recieved') AND Article_Status_Users.Article_No=@Article_No";
            commands.Parameters.Add("@Article_No", System.Data.SqlDbType.Int);
            commands.Parameters["@Article_No"].Value = Article_no;
            Read_Question = commands.ExecuteReader();

            commands.Parameters.Clear();
            if (Read_Question.Read())
            {

                Read_Question.Close();


            }

            else
            {
                Read_Question.Close();
                commands.Parameters.Clear();




                commands.CommandText = "insert into Article_Status_Users ( Status_No ,User_No,Status_Date,Article_No )" +
                    "values(@Status_No,@User_No,@Status_Date,@Article_No)  ";

                commands.Parameters.Add("@Status_No", System.Data.SqlDbType.Int);
                commands.Parameters["@Status_No"].Value = Status_Nom;
                commands.Parameters.Add("@User_No", System.Data.SqlDbType.Int);
                commands.Parameters["@User_No"].Value = usr_NO;
                commands.Parameters.Add("@Status_Date", System.Data.SqlDbType.DateTime);
                commands.Parameters["@Status_Date"].Value = time;
                commands.Parameters.Add("@Article_No", System.Data.SqlDbType.Int);
                commands.Parameters["@Article_No"].Value = Article_no;
                commands.ExecuteNonQuery();
                commands.Parameters.Clear();
            }

        }

        Read_Question.Close();
        Response.Redirect("Direct  to Editor Revised Submissions .aspx");
        //    }
        //   catch
        //   {
        //  }
        //   finally
        //  {
        //      connect.Close();
        // }

    }
    protected void Submission_Send_back_to_Author_for_Approval_Click(object sender, EventArgs e)
    {

    }
    protected void New_Submission_Requering_Assignment_Click(object sender, EventArgs e)
    {
        DateTime time = new DateTime();
        time = DateTime.Now;
        //   try
        //   {
        Read_Question.Close();
        connect.Open();
        commands.CommandText = " update Current_Status " +
            " set Current_Status_Name ='Recieved',Current_Status_Date=@Current_Status_Date " +
            " where Current_Status_Name='Submitted'  AND  Current_Status.Article_No IN " +
        "   ( select  Article_No  from Articles   " +
    " where  Articles.Article_Revision LIKE '0') ";
        commands.Parameters.Add("@Current_Status_Date", System.Data.SqlDbType.DateTime);
        commands.Parameters["@Current_Status_Date"].Value = time;
        commands.ExecuteNonQuery();
        Read_Question.Close();

        commands.CommandText = "select Status.Status_No from  Status where  " +
                               "  Status.Status_Name LIKE 'Recieved'";
        Read_Question = commands.ExecuteReader();
        Read_Question.Read();
        int Status_Nom = (int)Read_Question[0];
        Read_Question.Close();
        commands.Parameters.Clear();

        String quer = " select Article_No from Articles   " +
              " where Articles.Article_No  IN" +
        " ( select Current_Status.Article_No from  Current_Status where  " +
                    "  Current_Status.Current_Status_Name LIKE 'Recieved' )AND Articles.Article_Revision LIKE '0' ";
        SqlCommand comm_Que_Type = new SqlCommand(quer, connect);
        SqlDataAdapter adapter = new SqlDataAdapter(comm_Que_Type);
        DataTable table = new DataTable();
        adapter.Fill(table);
        foreach (DataRow datarow in table.Select())
        {
            int Article_no = (int)datarow["Article_No"];
            commands.CommandText = " select Article_No from Article_Status_Users where" +
                " Article_Status_Users.Status_No  IN( select Status.Status_No from  Status where  " +
                             "  Status.Status_Name LIKE 'Recieved') AND Article_Status_Users.Article_No=@Article_No";
            commands.Parameters.Add("@Article_No", System.Data.SqlDbType.Int);
            commands.Parameters["@Article_No"].Value = Article_no;
            Read_Question = commands.ExecuteReader();
            commands.Parameters.Clear();
            if (Read_Question.Read())
            {

                Read_Question.Close();


            }

            else
            {
                Read_Question.Close();
                commands.Parameters.Clear();




                commands.CommandText = "insert into Article_Status_Users ( Status_No ,User_No,Status_Date,Article_No )" +
                    "values(@Status_No,@User_No,@Status_Date,@Article_No)  ";

                commands.Parameters.Add("@Status_No", System.Data.SqlDbType.Int);
                commands.Parameters["@Status_No"].Value = Status_Nom;
                commands.Parameters.Add("@User_No", System.Data.SqlDbType.Int);
                commands.Parameters["@User_No"].Value = usr_NO;
                commands.Parameters.Add("@Status_Date", System.Data.SqlDbType.DateTime);
                commands.Parameters["@Status_Date"].Value = time;
                commands.Parameters.Add("@Article_No", System.Data.SqlDbType.Int);
                commands.Parameters["@Article_No"].Value = Article_no;
                commands.ExecuteNonQuery();
                commands.Parameters.Clear();
            }
        }

        Read_Question.Close();
        Response.Redirect("~/New Submission Requering Assignments.aspx");
        //    }
        //  catch
        //  {
        //   }
        //    finally {
        //        connect .Close();
        //  }


    }
    protected void LinkButton1_Click2(object sender, EventArgs e)
    {
        Response.Redirect("View All Assigned Submissions Being Edited.aspx");
    }

    protected void Four_Reviews_Complete_Click(object sender, EventArgs e)
    {
        Response.Redirect("CompleteReviewMoreThree.aspx");
    }
    protected void Tree_Reviews_Complete_Click(object sender, EventArgs e)
    {
        Response.Redirect("CompleteReviewThree.aspx");
    }
    protected void Revised_Submission_Requering_Assignment_Click(object sender, EventArgs e)
    {
        DateTime time = new DateTime();
        time = DateTime.Now;
        //  try
        // {
        Read_Question.Close();
        connect.Open();
        commands.CommandText = " update Current_Status " +
            " set Current_Status_Name ='Recieved',Current_Status_Date=@Current_Status_Date " +
            " where Current_Status_Name='Submitted'  AND  Current_Status.Article_No IN " +
        "   ( select  Article_No  from Articles   " +
          " where  Articles.Article_Revision NOT LIKE '0') ";
        commands.Parameters.Add("@Current_Status_Date", System.Data.SqlDbType.DateTime);
        commands.Parameters["@Current_Status_Date"].Value = time;
        commands.ExecuteNonQuery();
        Read_Question.Close();

        commands.CommandText = "select Status.Status_No from  Status where  " +
                               "  Status.Status_Name LIKE 'Recieved'";
        Read_Question = commands.ExecuteReader();
        Read_Question.Read();
        int Status_Nom = (int)Read_Question[0];

        commands.Parameters.Clear();
        Read_Question.Close();
        String quer = " select Article_No from Articles   " +
              " where Articles.Article_No  IN" +
        " ( select Current_Status.Article_No from  Current_Status where  " +
                    "  Current_Status.Current_Status_Name LIKE 'Recieved' )AND Articles.Article_Revision NOT LIKE '0' ";
        SqlCommand comm_Que_Type = new SqlCommand(quer, connect);
        SqlDataAdapter adapter = new SqlDataAdapter(comm_Que_Type);
        DataTable table = new DataTable();
        adapter.Fill(table);
        foreach (DataRow datarow in table.Select())
        {
            int Article_no = (int)datarow["Article_No"];
            commands.CommandText = " select Article_No from Article_Status_Users where" +
                " Article_Status_Users.Status_No  IN( select Status.Status_No from  Status where  " +
                             "  Status.Status_Name LIKE 'Recieved') AND Article_Status_Users.Article_No=@Article_No";
            commands.Parameters.Add("@Article_No", System.Data.SqlDbType.Int);
            commands.Parameters["@Article_No"].Value = Article_no;
            Read_Question = commands.ExecuteReader();
            commands.Parameters.Clear();
            if (Read_Question.Read())
            {
                Read_Question.Close();



            }

            else
            {
                Read_Question.Close();
                commands.Parameters.Clear();




                commands.CommandText = "insert into Article_Status_Users ( Status_No ,User_No,Status_Date,Article_No )" +
                    "values(@Status_No,@User_No,@Status_Date,@Article_No)  ";

                commands.Parameters.Add("@Status_No", System.Data.SqlDbType.Int);
                commands.Parameters["@Status_No"].Value = Status_Nom;
                commands.Parameters.Add("@User_No", System.Data.SqlDbType.Int);
                commands.Parameters["@User_No"].Value = usr_NO;
                commands.Parameters.Add("@Status_Date", System.Data.SqlDbType.DateTime);
                commands.Parameters["@Status_Date"].Value = time;
                commands.Parameters.Add("@Article_No", System.Data.SqlDbType.Int);
                commands.Parameters["@Article_No"].Value = Article_no;
                commands.ExecuteNonQuery();
                commands.Parameters.Clear();
                Read_Question.Close();
                Response.Redirect("Revised  Submissions Requering Assignments.aspx");
            }
        }


        // }
        // catch
        // {
        //  }
        //  finally
        //  {
        //      connect.Close();

        //  }
        Response.Redirect("Revised  Submissions Requering Assignments.aspx");
    }
    protected void SubmissionNeedingApprovalEdit_Click(object sender, EventArgs e)
    {
        Response.Redirect("Submission Needing Approval by  Eidtor.aspx");
    }
    protected void Incomplete_Submissions_Click(object sender, EventArgs e)
    {
        Response.Redirect("Incomplete Submissions.aspx");

    }
    protected void Two_Reviews_Complete_Click(object sender, EventArgs e)
    {
        Response.Redirect("CompleteReview2.aspx");
    }
    protected void One_Reviews_Complete_Click(object sender, EventArgs e)
    {
        Response.Redirect("CompleteReview1.aspx");
    }
    protected void Submission_With_Required_Reviews_Complete_Click(object sender, EventArgs e)
    {
        Response.Redirect("Submission With Required Reviews Complete.aspx");
    }
    protected void Editor_Invited_No_Response_Click(object sender, EventArgs e)
    {
        Response.Redirect("Editor_Invite_NoResponse.aspx");
    }
    protected void Reviewers_Invited_No_Response_Click(object sender, EventArgs e)
    {
        Response.Redirect("Group By Editor I Assigned.aspx");
    }
    protected void Group_By_Editor_Assigned_Click(object sender, EventArgs e)
    {
        Response.Redirect("Group By Editor I Assigned.aspx");
    }
    protected void Group_By_Editor_With_current_Responsibility_Click(object sender, EventArgs e)
    {
        Response.Redirect("Group By Editor With Current Responsibility .aspx");
    }
    protected void Group_By_Manuscript_Status_Click(object sender, EventArgs e)
    {

        Response.Redirect("Group By Manuscript Status.aspx");
    }
    protected void Submissions_Out_For_Revisions_Click(object sender, EventArgs e)
    {

    }
    protected void All_Submissions_With_Editors_Decision_Click(object sender, EventArgs e)
    {
        Response.Redirect("All Submission with Editor's Decision.aspx");
    }
    protected void Accept_Click(object sender, EventArgs e)
    {
        Response.Redirect("AcceptSubmission.aspx");
    }
    protected void Reject_Click1(object sender, EventArgs e)
    {
        Response.Redirect("RejectSubmission.aspx");
    }
    protected void My_Assignments_With_Decision_Click(object sender, EventArgs e)
    {
        Response.Redirect("My Assignments With Decision.aspx");
    }
    protected void Withdrawen_Click1(object sender, EventArgs e)
    {
        Response.Redirect("WithDrawen.aspx");
    }
    protected void LinkButton1_Click4(object sender, EventArgs e)
    {
        Response.Redirect("Default1.aspx");
    }
    protected void Editor_Assign_No_Complete_Click(object sender, EventArgs e)
    {
        Response.Redirect("AssignEditorNoComplete.aspx");
    }
    protected void Submissions_Under_Review_Click(object sender, EventArgs e)
    {
        Response.Redirect("AssignReviewerNoComplete.aspx");
    }
    protected void Reviewers_Invited_No_Response_Click1(object sender, EventArgs e)
    {
        Response.Redirect("InviteReviewerNotresponse.aspx");
    }
    protected void View_All_Assigned_Submission_Click(object sender, EventArgs e)
    {
        Response.Redirect("View All Assigned Submissions Being Edited.aspx");
    }

    protected void View_All_Assigned_Submissions_Click(object sender, EventArgs e)
    {
        Response.Redirect("View All Assigned Submissions.aspx");
    }
    protected void Inactive_Linked_Submision_Groups_Click(object sender, EventArgs e)
    {
        Response.Redirect("Inactive Linked Submission Group.aspx");
    }
    protected void Active_Linked_Submision_Groups_Click(object sender, EventArgs e)
    {
        Response.Redirect("Active Linked Submission Group.aspx");
    }
    protected void LinkButton2_Click(object sender, EventArgs e)
    {
        Response.Redirect("PermissionManagement.aspx");
    }
    protected void Decline_Editor_For_Submissions_Click(object sender, EventArgs e)
    {
        Response.Redirect("Decline_Editor_For_Submissions.aspx");
    }
    protected void LinkButton3_Click(object sender, EventArgs e)
    {
        Response.Redirect("Searsh People.aspx");

    }
    protected void LinkButton4_Click(object sender, EventArgs e)
    {
        Response.Redirect("Linked Group.aspx");
    }
    protected void Decline_Reviewer_For_Submissins_Click(object sender, EventArgs e)
    {

        Response.Redirect("Decline_Reviewer_For_Submission.aspx");

    }
}
