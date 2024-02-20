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
using System.Net.Mail;
using System.Net;

using System.Net.Mime;
public partial class ViewLetter : System.Web.UI.Page
{
    String Recieve_Name;
    String Recieve_Email_Address;
    String Message_Content;
    String Message_Address;
    String Sender_Name;
    String Sender_Email;
    FunctionSumation ob = new FunctionSumation();
    SqlConnection connect; 
    SqlCommand commands = new SqlCommand();
    SqlDataReader Read_Question;
    protected void Page_Load(object sender, EventArgs e)
    {
        connect = ob.connect;
        DateTime date = new DateTime();

        date = DateTime.Now;
        String current_date1 = Convert.ToString(date);
        Now_Date.Text = current_date1;
        if (!IsPostBack)
        {
            int My_No = Convert.ToInt16(Session["User_No"]);
            int Messages_No = Convert.ToInt16(Session["Message_No"]);
            int Authors_No = Convert.ToInt16(Session["Author_No"]);
            Response.Write(My_No + "" + Messages_No + "" + Authors_No);

            // try
            //   {
            connect.Close();
            connect.Open();
            commands.Connection = connect;

            commands.CommandText = "select Users.User_Name,Users.User_Email_Address from Users where " +
              " Users.User_No =@User_No";
            commands.Parameters.Add("@User_No", System.Data.SqlDbType.Int);
            commands.Parameters["@User_No"].Value = My_No;
            Read_Question = commands.ExecuteReader();
            Read_Question.Read();
            Sender_Name = Read_Question["User_Name"].ToString();
            Sender_Email = Read_Question["User_Email_Address"].ToString();
            Read_Question.Close();
            commands.Parameters.Clear();
            // }
            //catch
            // {

            //}
            //finally
            //  {
            //  connect.Close();
            // }

            // try
            //   {
            commands.CommandText = "select Users.User_Name,Users.User_Email_Address from Users where " +
             " Users.User_No =@User_No";
            commands.Parameters.Add("@User_No", System.Data.SqlDbType.Int);
            commands.Parameters["@User_No"].Value = Authors_No;
            Read_Question = commands.ExecuteReader();
            Read_Question.Read();
            Recieve_Name = Read_Question["User_Name"].ToString();
            Recieve_Email_Address = Read_Question["User_Email_Address"].ToString();
            Read_Question.Close();
            commands.Parameters.Clear();
            // }
            //catch
            // {

            //}
            //finally
            //  {
            //  connect.Close();
            // }


            // try
            //   {
            commands.CommandText = "select Messages.Message_Content,Messages.Message_Name,Messages.Message_Address" +
            "  from Messages where Messages.Message_No=@Message_No";
            commands.Parameters.Add("@Message_No", System.Data.SqlDbType.Int);
            commands.Parameters["@Message_No"].Value = Messages_No;
            Read_Question = commands.ExecuteReader();
            Read_Question.Read();
            Message_Content = Read_Question["Message_Content"].ToString();
            Message_Address = Read_Question["Message_Address"].ToString();
            Read_Question.Close();
            commands.Parameters.Clear();

            // }
            //catch
            // {

            //}
            //finally
            //  {
            //  connect.Close();
            // }

            //________________________________________________________________________________________set letter Interface___

            recieve.Text += Recieve_Name + "" + Recieve_Email_Address;
            sendere.Text += Sender_Name + "" + Sender_Email;
            Subject.Text += Message_Address;
            Txt_message_content.Text = Message_Content;
            //----------------------------------------- END set letter Interface----------------------






        }

    }
    /* public static void MailSendCompleted(object sender, SendCompletedEventArgs e) 
     {
         if (e.Cancelled) { }
      }*/

    protected void CmdRecend_Click(object sender, EventArgs e)
    {
        int My_No = Convert.ToInt16(Session["User_No"]);
        int Messages_No = Convert.ToInt16(Session["Message_No"]);
        int Authors_No = Convert.ToInt16(Session["Author_No"]);
        int article_No = Convert.ToInt16(Session["Article_No"]);



        DateTime time = new DateTime();
        time = DateTime.Now;

        // Current Status 


        //  try
        //  {
        connect.Close();

        connect.Open();
        commands.Connection = connect;

        commands.CommandText = " update Current_Status " +
            " set Current_Status_Name ='Need Aproval',Current_Status_Date=@Current_Status_Date " +
            " where Article_No=@Article_No ";

        commands.Parameters.Add("@Current_Status_Date", System.Data.SqlDbType.DateTime);
        commands.Parameters["@Current_Status_Date"].Value = time;
        commands.Parameters.Add("@Article_No", System.Data.SqlDbType.Int);
        commands.Parameters["@Article_No"].Value = article_No;
        commands.ExecuteNonQuery();

        commands.Parameters.Clear();


        // And status_Users



        commands.CommandText = "select Status.Status_No from  Status where  " +
                                 "  Status.Status_Name LIKE 'Send Back To Author'";
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

        //Role
        commands.CommandText = "select  Family_Role_No from Family_Role where Family_Role_Name LIKE 'Editor' ";
        Read_Question = commands.ExecuteReader();
        Read_Question.Read();
        int Role_No = (int)Read_Question[0];
        Read_Question.Close();
        commands.Parameters.Clear();

        // set message_User

        commands.CommandText = "insert into Message_User ( Message_No ,Sender_No,Reciever_No,Article_No,Message_Send_Date,Updated_Message_Content,Family_Role_No )" +
                           "values(@Message_No,@Sender_No,@Reciever_No,@Article_No,@Message_Send_Date,@Updated_Message_Content,@Family_Role_No) ";

        commands.Parameters.Add("@Message_No", System.Data.SqlDbType.Int);
        commands.Parameters["@Message_No"].Value = Messages_No;
        commands.Parameters.Add("@Sender_No", System.Data.SqlDbType.Int);
        commands.Parameters["@Sender_No"].Value = My_No;
        commands.Parameters.Add("@Reciever_No", System.Data.SqlDbType.Int);
        commands.Parameters["@Reciever_No"].Value = Authors_No;
        commands.Parameters.Add("@Message_Send_Date", System.Data.SqlDbType.DateTime);
        commands.Parameters["@Message_Send_Date"].Value = time;
        commands.Parameters.Add("@Article_No", System.Data.SqlDbType.Int);
        commands.Parameters["@Article_No"].Value = article_No;
        commands.Parameters.Add("@Updated_Message_Content", System.Data.SqlDbType.Text);
        commands.Parameters["@Updated_Message_Content"].Value = Txt_message_content.Text;
        commands.Parameters.Add("@Family_Role_No", System.Data.SqlDbType.Int);
        commands.Parameters["@Family_Role_No"].Value = Role_No;
        commands.ExecuteNonQuery();
        commands.Parameters.Clear();
        connect.Close();
        //}
        //     catch
        //    {

        //   }
        // finally
        //{
        //   commands.Parameters.Clear();
        //   connect.Close();
        // }

        /*    MailMessage send_letter_Mail = new MailMessage();
            send_letter_Mail.From = new MailAddress(Sender_Email, Sender_Name);
            send_letter_Mail.To.Add(Recieve_Email_Address);
            send_letter_Mail.Subject = Message_Address;
            AlternateView plainview = new AlternateView(Txt_message_content.Text, MediaTypeNames.Text.Plain);
            send_letter_Mail.AlternateViews.Add(plainview);
            send_letter_Mail.Priority = MailPriority.High;
            SmtpClient smtpclient = new SmtpClient();
            smtpclient.SendCompleted += new SendCompletedEventHandler();
            smtpclient.SendAsync(send_letter_Mail, null);
           */

        Response.Redirect("New Submission Requering Assignments.aspx");
    }
    protected void CmdRecend0_Click(object sender, EventArgs e)
    {


    }
}
