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
public partial class AssignReviewer_ConfirmSelectionandCustomizeLetters : System.Web.UI.Page
{
    String Recieve_Name;
    String Recieve_Email_Address;
    String Message_Content;
    String Message_Address;
    String Sender_Name;
    String Sender_Email;

    int User_order;
    FunctionSumation ob = new FunctionSumation();
    SqlConnection connect;
    SqlCommand commands = new SqlCommand();
    SqlDataReader Read_Question;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            connect = ob.connect;
            // Convert.ToInt16(Session["Reviewer_No"]) int v = Convert.ToInt16(Session["Reviewer_No"]);
            Response.Write(Convert.ToInt16(Session["Reviewer_No"]));
            int Reviewer_No = Convert.ToInt16(Session["Reviewer_No"]);
            if (!IsPostBack)
            {

                int art = Convert.ToInt16(Session["Article_No"]);
                int My_No = Convert.ToInt16(Session["User_No"]);
                Response.Write(art);
                // try
                //   {
                connect.Close();
                connect.Open();
                commands.Connection = connect;

                commands.CommandText = "select Messages.Message_No,Messages.Message_Name " +
                    "  from Messages where Messages.Message_Type_No IN( select Messages_Type.Message_Type_No from Messages_Type where" +
                    " Messages_Type.Message_Type_Name LIKE 'Assign Reviewer') ";
                Read_Question = commands.ExecuteReader();
                dropAssignEditor.DataSource = Read_Question;
                dropAssignEditor.DataValueField = "Message_No";
                dropAssignEditor.DataTextField = "Message_Name";
                dropAssignEditor.DataBind();

                Read_Question.Close();
                dropAssignEditor.SelectedIndex = 1;
                commands.CommandText = "select Users.User_No,Users.User_Name,Users.User_Email_Address from Users where " +
                    " Users.User_No=@User_No";
                commands.Parameters.Add("@User_No", System.Data.SqlDbType.Int);
                commands.Parameters["@User_No"].Value = Reviewer_No;
                Read_Question = commands.ExecuteReader();
                Read_Question.Read();
                Reviewer_Name.Text = Read_Question["User_Name"].ToString();
                Reviewer_Name.CommandArgument = Read_Question["User_No"].ToString();
                Recieve_Name = Read_Question["User_Name"].ToString();
                Recieve_Email_Address = Read_Question["User_Email_Address"].ToString();

                Read_Question.Close();
                connect.Close();




                // }
                //catch
                // {

                //}
                //finally
                //  {
                //  connect.Close();
                // }

            }
        }
    }


    protected void CmdClose0_Click(object sender, EventArgs e)
    {
        int My_No = Convert.ToInt16(Session["User_No"]);
        int Messages_No = Convert.ToInt16(dropAssignEditor.SelectedItem.Value);
        int Reciever_No = Convert.ToInt16(Reviewer_Name.CommandArgument);
        int article_No = Convert.ToInt16(Session["Article_No"]);
        int Reviewer_No = Convert.ToInt16(Session["Reviewer_No"]);

        // try
        //   {
        connect.Close();
        connect.Open();
        commands.Connection = connect;
        commands.CommandText = "select Messages.Message_Content,Messages.Message_Name,Messages.Message_Address" +
                "  from Messages where Messages.Message_No=@Message_No";
        commands.Parameters.Add("@Message_No", System.Data.SqlDbType.Int);
        commands.Parameters["@Message_No"].Value = dropAssignEditor.SelectedItem.Value;
        Read_Question = commands.ExecuteReader();
        Read_Question.Read();
        Message_Content = Read_Question["Message_Content"].ToString();
        Message_Address = Read_Question["Message_Address"].ToString();
        Read_Question.Close();
        //ــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــ

        commands.CommandText = "select Users.User_Name,Users.User_Email_Address from Users " +
            " where Users.User_No=@User_No";

        commands.Parameters.Add("@User_No", System.Data.SqlDbType.Int);
        commands.Parameters["@User_No"].Value = My_No;
        Read_Question = commands.ExecuteReader();
        Read_Question.Read();
        Sender_Name = Read_Question["User_Name"].ToString();
        Sender_Email = Read_Question["User_Email_Address"].ToString();

        Read_Question.Close();


        // }
        //catch
        // {

        //}
        //finally
        //  {
        //  connect.Close();
        // }

        //__________________send Email 

        /*        MailMessage send_letter_Mail = new MailMessage();
                send_letter_Mail.From = new MailAddress(Sender_Email, Sender_Name);
                send_letter_Mail.To.Add(Recieve_Email_Address);
                send_letter_Mail.Subject = Message_Address;
                AlternateView plainview = new AlternateView(Message_Content, System.Net.Mime.MediaTypeNames.Text.Plain);
                send_letter_Mail.AlternateViews.Add(plainview);
                send_letter_Mail.Priority = MailPriority.High;
                SmtpClient smtpclient = new SmtpClient();
                smtpclient.SendCompleted += new SendCompletedEventHandler();
                smtpclient.SendAsync(send_letter_Mail, null);
            */

        DateTime time = new DateTime();
        time = DateTime.Now;

        // Current Status 


        //    try
        //   {
        connect.Close();
        Read_Question.Close();
        connect.Open();
        /*       commands.CommandText = " update Current_Status " +
                   " set Current_Status_Name ='Need Aproval',Current_Status_Date=@Current_Status_Date " +
                   " where Article_No=@Article_No ";

               commands.Parameters.Add("@Current_Status_Date", System.Data.SqlDbType.DateTime);
               commands.Parameters["@Current_Status_Date"].Value = time;
               commands.Parameters.Add("@Article_No", System.Data.SqlDbType.Int);
               commands.Parameters["@Article_No"].Value = article_No;
               commands.ExecuteNonQuery();
               Read_Question.Close();
               commands.Parameters.Clear();*/


        // And status_Users



        commands.CommandText = "select Status.Status_No from  Status where  " +
                                 "  Status.Status_Name LIKE 'Reviewers Assign'";
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
        commands.Parameters["@User_No"].Value = Reviewer_No;
        commands.Parameters.Add("@Status_Date", System.Data.SqlDbType.DateTime);
        commands.Parameters["@Status_Date"].Value = time;
        commands.Parameters.Add("@Article_No", System.Data.SqlDbType.Int);
        commands.Parameters["@Article_No"].Value = article_No;
        commands.ExecuteNonQuery();
        commands.Parameters.Clear();

        // And status_invite



        commands.CommandText = "select Status.Status_No from  Status where  " +
                                 "  Status.Status_Name LIKE 'Reviewers Invite '";
        Read_Question = commands.ExecuteReader();
        Read_Question.Read();
        int Status_Nom_inv = (int)Read_Question[0];
        Read_Question.Close();
        commands.Parameters.Clear();

        commands.CommandText = "insert into Article_Status_Users ( Status_No ,User_No,Status_Date,Article_No )" +
            "values(@Status_No,@User_No,@Status_Date,@Article_No) ";

        commands.Parameters.Add("@Status_No", System.Data.SqlDbType.Int);
        commands.Parameters["@Status_No"].Value = Status_Nom_inv;
        commands.Parameters.Add("@User_No", System.Data.SqlDbType.Int);
        commands.Parameters["@User_No"].Value = Reviewer_No;
        commands.Parameters.Add("@Status_Date", System.Data.SqlDbType.DateTime);
        commands.Parameters["@Status_Date"].Value = time;
        commands.Parameters.Add("@Article_No", System.Data.SqlDbType.Int);
        commands.Parameters["@Article_No"].Value = article_No;
        commands.ExecuteNonQuery();
        commands.Parameters.Clear();

        //   Due_date
        Read_Question.Close();
        DateTime timeNow = new DateTime();
        timeNow = DateTime.Now;
        //connect.Open();
        commands.CommandText = "select Status.Status_No from  Status where  " +
                               "  Status.Status_Name LIKE 'Review Due'";
        Read_Question = commands.ExecuteReader();
        Read_Question.Read();
        int Status_Nomb = (int)Read_Question[0];
        Read_Question.Close();
        commands.Parameters.Clear();
        commands.CommandText = "select Article_Types.Number_Days_To_Review from  Article_Types,Articles where  " +
                             " Article_Types.Article_Type_No=Articles.Article_Type_No AND Articles.Article_No=@Article_No ";
        commands.Parameters.Add("@Article_No", System.Data.SqlDbType.Int);
        commands.Parameters["@Article_No"].Value = article_No;
        Read_Question = commands.ExecuteReader();
        Read_Question.Read();
        DateTime Due_Date = timeNow.AddDays((int)Read_Question[0]);
        Read_Question.Close();
        commands.Parameters.Clear();
        commands.CommandText = "insert into Article_Status_Users ( Status_No ,User_No,Status_Date,Article_No )" +
         "values(@Status_No,@User_No,@Status_Date,@Article_No) ";
        commands.Parameters.Add("@Status_No", System.Data.SqlDbType.Int);
        commands.Parameters["@Status_No"].Value = Status_Nomb;
        commands.Parameters.Add("@User_No", System.Data.SqlDbType.Int);
        commands.Parameters["@User_No"].Value = Reviewer_No;
        commands.Parameters.Add("@Status_Date", System.Data.SqlDbType.DateTime);
        commands.Parameters["@Status_Date"].Value = Due_Date;
        commands.Parameters.Add("@Article_No", System.Data.SqlDbType.Int);
        commands.Parameters["@Article_No"].Value = article_No;
        commands.ExecuteNonQuery();
        commands.Parameters.Clear();
        //  end  Due_date

        commands.CommandText = "select  Family_Role_No from Family_Role where Family_Role_Name LIKE 'Reviewer' ";
        Read_Question = commands.ExecuteReader();
        Read_Question.Read();
        int Role_No = (int)Read_Question[0];
        Read_Question.Close();
        commands.Parameters.Clear();
        // set message_User

        commands.CommandText = "insert into Message_User ( Message_No ,Sender_No,Reciever_No,Article_No,Message_Send_Date,Updated_Message_Content, Family_Role_No)" +
                       "values(@Message_No,@Sender_No,@Reciever_No,@Article_No,@Message_Send_Date,@Updated_Message_Content,@Family_Role_No) ";

        commands.Parameters.Add("@Message_No", System.Data.SqlDbType.Int);
        commands.Parameters["@Message_No"].Value = Messages_No;
        commands.Parameters.Add("@Sender_No", System.Data.SqlDbType.Int);
        commands.Parameters["@Sender_No"].Value = My_No;
        commands.Parameters.Add("@Reciever_No", System.Data.SqlDbType.Int);
        commands.Parameters["@Reciever_No"].Value = Reviewer_No;
        commands.Parameters.Add("@Message_Send_Date", System.Data.SqlDbType.DateTime);
        commands.Parameters["@Message_Send_Date"].Value = time;
        commands.Parameters.Add("@Family_Role_No", System.Data.SqlDbType.Int);
        commands.Parameters["@Family_Role_No"].Value = Role_No;
        commands.Parameters.Add("@Article_No", System.Data.SqlDbType.Int);
        commands.Parameters["@Article_No"].Value = article_No;
        commands.Parameters.Add("@Updated_Message_Content", System.Data.SqlDbType.Text);
        commands.Parameters["@Updated_Message_Content"].Value = Message_Content;
        commands.ExecuteNonQuery();
        commands.Parameters.Clear();
        connect.Close();
        //   }
        //  catch
        //  {

        //  }
        //  finally
        // {
        //   commands.Parameters.Clear();
        //   connect.Close();
        // }





        //    try
        //   {
        connect.Close();
        Read_Question.Close();
        connect.Open();



        // And status_Users



        commands.CommandText = "select Family_Role.Family_Role_No from  Family_Role where  " +
                                 "  Family_Role.Family_Role_Name  LIKE 'Reviewer'";
        Read_Question = commands.ExecuteReader();
        Read_Question.Read();
        int Role_Nom = (int)Read_Question[0];
        Read_Question.Close();
        commands.Parameters.Clear();

        commands.CommandText = "select max(User_Order)   from Article_User where Article_No=@Article_No AND " +
            " Article_User.Family_Role_No IN  ( select Family_Role.Family_Role_No from  Family_Role where  " +
                                 "  Family_Role.Family_Role_Name  LIKE 'Reviewer' ) GROUP BY Article_No ";
        commands.Parameters.Add("@Article_No", System.Data.SqlDbType.Int);
        commands.Parameters["@Article_No"].Value = article_No;
        Read_Question = commands.ExecuteReader();
        if (Read_Question.Read())
        {
            User_order = (int)Read_Question[0];
            User_order += 1;

        }
        else
        {
            User_order = 1;
        }

        Read_Question.Close();
        commands.Parameters.Clear();

        // set message_User

        commands.CommandText = "insert into Article_User (Lower_User_No ,Upper_User_no,Family_Role_No,Article_No,User_Order,Assign_Complete )" +
                       "values(@Lower_User_No ,@Upper_User_no,@Family_Role_No,@Article_No,@User_Order,@Assign_Complete) ";

        commands.Parameters.Add("@Lower_User_No", System.Data.SqlDbType.Int);
        commands.Parameters["@Lower_User_No"].Value = Reviewer_No;
        commands.Parameters.Add("@Upper_User_no", System.Data.SqlDbType.Int);
        commands.Parameters["@Upper_User_no"].Value = My_No;
        commands.Parameters.Add("@Family_Role_No", System.Data.SqlDbType.Int);
        commands.Parameters["@Family_Role_No"].Value = Role_Nom;
        commands.Parameters.Add("@Article_No", System.Data.SqlDbType.Int);
        commands.Parameters["@Article_No"].Value = article_No;
        commands.Parameters.Add("@User_Order", System.Data.SqlDbType.Int);
        commands.Parameters["@User_Order"].Value = User_order;
        commands.Parameters.Add("@Assign_Complete", System.Data.SqlDbType.Int);
        commands.Parameters["@Assign_Complete"].Value = 0;
        commands.ExecuteNonQuery();
        commands.Parameters.Clear();
        connect.Close();
        //   }
        //  catch
        //  {

        //  }
        //  finally
        // {
        //   commands.Parameters.Clear();
        //   connect.Close();
        // }








    }
    protected void Customize_Click(object sender, EventArgs e)
    {
        String Message_No = dropAssignEditor.SelectedItem.Value;
        Session["Message_No"] = Message_No;

        String Reviewer_No = Reviewer_Name.CommandArgument;
        Session["Reviewer_No"] = Reviewer_No;


        Response.Redirect("Custom_Letter_AssignReviewer.aspx");
    }
}
