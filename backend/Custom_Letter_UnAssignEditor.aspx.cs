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
public partial class Custom_Letter_UnAssignEditor : System.Web.UI.Page
{
    String Recieve_Name;
    String Recieve_Email_Address;
    String Message_Content;
    String Message_Address;
    String Sender_Name;
    String Sender_Email;
    // int User_order;
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
            int Editor_No = Convert.ToInt16(Session["Editor_No"]);
            int My_No = Convert.ToInt16(Session["User_No"]);
            int Messages_No = Convert.ToInt16(Session["Message_No"]);

            Response.Write(My_No + "" + Messages_No + "" + Editor_No);

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
    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlConnection connect = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=G:\المجله\Full_projects\Editor\App_Data\Database_Journal.mdf;Integrated Security=True;User Instance=True");
        SqlCommand commands = new SqlCommand();
        SqlDataReader Read_Question;


        String Message_Content;
        int My_No = Convert.ToInt16(Session["User_No"]);

        int Role_No = 1;
        int article_No = Convert.ToInt16(Session["Article_No"]);
        int Editor_No = Convert.ToInt16(Session["Editor_No"]);
        int Messages_No = Convert.ToInt16(Session["Message_No"]);
        try
        {
            connect.Close();
            connect.Open();
            commands.Connection = connect;
            commands.CommandText = "select  Family_Role_No from Family_Role where Family_Role_Name LIKE 'Editor' ";
            Read_Question = commands.ExecuteReader();
            Read_Question.Read();
            Role_No = (int)Read_Question[0];
            Read_Question.Close();
            commands.Parameters.Clear();
        }
        catch { }




        FunctionSumation obUnassign = new FunctionSumation();
        obUnassign.UnderUnassignEditorFun(My_No, Messages_No, article_No, Editor_No, Role_No, Txt_message_content.Text);

        Response.Redirect("Default.aspx");


    }
}
