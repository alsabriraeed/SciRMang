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
public partial class SendAdHocEmail : System.Web.UI.Page
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
            // try
            //   {

            connect.Close();
            connect.Open();
            commands.Connection = connect;
            commands.CommandText = "select Family_Role.Family_Role_Name,Family_Role.Family_Role_No " +
                "  from Family_Role";
            Read_Question = commands.ExecuteReader();

            dropRole.DataSource = Read_Question;
            dropRole.DataValueField = "Family_Role_No";
            dropRole.DataTextField = "Family_Role_Name";
            dropRole.DataBind();
            Read_Question.Close();
            dropRole.SelectedIndex = 1;


            // }
            //catch
            // {

            //}
            //finally
            //  {
            //  connect.Close();
            // }


            //message Type


            // try
            //   {

            connect.Close();
            connect.Open();
            commands.Connection = connect;
            commands.CommandText = "select Messages_Type.Message_Type_No,Messages_Type.Message_Type_Name " +
                "  from Messages_Type";
            Read_Question = commands.ExecuteReader();
            dropMessageType.DataSource = Read_Question;
            dropMessageType.DataValueField = "Message_Type_No";
            dropMessageType.DataTextField = "Message_Type_Name";
            dropMessageType.DataBind();
            Read_Question.Close();
            dropMessageType.SelectedIndex = 1;


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
    protected void CmdCancel_Click(object sender, EventArgs e)
    {
        String Message_No = DropSendEmail0.SelectedItem.Value;
        Session["Message_No"] = Message_No;
        string select = dropRole.SelectedItem.Text;
        if (select.Equals("Author"))
        {
            String Author_No = Lbl_Author_Name.CommandArgument;
            Session["Author_No"] = Author_No;
        }
        else
        {
            String Author_No = DropUser.SelectedItem.Value;
            Session["Author_No"] = Author_No;
        }
        Response.Redirect("~/CustomizeLetterAdhocfromeditor.aspx");
    }
    protected void dropMessageType_SelectedIndexChanged(object sender, EventArgs e)
    {


    }
    protected void dropRole_SelectedIndexChanged(object sender, EventArgs e)
    {
    }
    protected void Button1_Click(object sender, EventArgs e)
    {

        int art = Convert.ToInt16(Session["Article_No"]);
        int My_No = Convert.ToInt16(Session["User_No"]);
        string select = dropRole.SelectedItem.Text;
        if (select.Equals("Author"))
        {

            DropUser.Visible = false;
            Lbl_Author_Name.Visible = true;

            // try
            //   {
            connect.Close();
            connect.Open();
            commands.Connection = connect;
            commands.CommandText = "select Users.User_No,Users.User_Name,Users.User_Email_Address from Users where " +
             " Users.User_No IN (select Articles.Article_Corresponding_Author_No from Articles where Articles.Article_No=@Article_No)";
            commands.Parameters.Add("@Article_No", System.Data.SqlDbType.Int);
            commands.Parameters["@Article_No"].Value = art;
            Read_Question = commands.ExecuteReader();
            Read_Question.Read();
            Lbl_Author_Name.Text = Read_Question["User_Name"].ToString();
            Lbl_Author_Name.CommandArgument = Read_Question["User_No"].ToString();

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
        else
        {
            Lbl_Author_Name.Visible = false;
            DropUser.Visible = true;
            // try
            //   {
            connect.Close();
            connect.Open();
            commands.Connection = connect;
            commands.CommandText = "select Users.User_No,Users.User_Name,Users.User_Email_Address from Users where " +
                  " Users.User_No IN (select Article_User.Lower_User_No from Article_User where Article_User.Article_No=@Article_No" +
                    " AND Article_User.Family_Role_No =@Family_Role_No AND Article_User.Upper_User_no=@Upper_User_no )";
            commands.Parameters.Add("@Article_No", System.Data.SqlDbType.Int);
            commands.Parameters["@Article_No"].Value = art;
            commands.Parameters.Add("@Upper_User_no", System.Data.SqlDbType.Int);
            commands.Parameters["@Upper_User_no"].Value = My_No;
            commands.Parameters.Add("@Family_Role_No", System.Data.SqlDbType.Int);
            commands.Parameters["@Family_Role_No"].Value = dropRole.SelectedItem.Value;
            Read_Question = commands.ExecuteReader();
            DropUser.DataSource = Read_Question;
            DropUser.DataValueField = "User_No";
            DropUser.DataTextField = "User_Name";
            DropUser.DataBind();

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

        DropSendEmail0.Visible = true;

        // try
        //   {

        connect.Close();
        connect.Open();
        commands.Connection = connect;

        commands.CommandText = "select Messages.Message_No,Messages.Message_Name " +
            "  from Messages where Messages.Message_Type_No=@Message_Type_No  ";
        commands.Parameters.Add("@Message_Type_No", System.Data.SqlDbType.Int);
        commands.Parameters["@Message_Type_No"].Value = dropMessageType.SelectedItem.Value;
        Read_Question = commands.ExecuteReader();
        DropSendEmail0.DataSource = Read_Question;
        DropSendEmail0.DataValueField = "Message_No";
        DropSendEmail0.DataTextField = "Message_Name";
        DropSendEmail0.DataBind();
        Read_Question.Close();



        // }
        //catch
        // {

        //}
        //finally
        //  {
        //  connect.Close();
        // }  

        ////////
    }
    protected void dropMessageType_TextChanged(object sender, EventArgs e)
    {

    }
}
