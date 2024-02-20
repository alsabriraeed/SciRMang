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
public partial class RollBacktoPreviousEditorConfirmSelectionsandCustomizeLetters : System.Web.UI.Page
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

            int Editor_No = Convert.ToInt16(Session["Editor_No"]);
            if (!IsPostBack)
            {

                int My_No = Convert.ToInt16(Session["User_No"]);

                // try
                //   {
                connect.Close();
                connect.Open();
                commands.Connection = connect;

                commands.CommandText = "select Messages.Message_No,Messages.Message_Name " +
                    "  from Messages where Messages.Message_Type_No IN( select Messages_Type.Message_Type_No from Messages_Type where" +
                    " Messages_Type.Message_Type_Name LIKE 'UNAssign Editor') ";
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
                commands.Parameters["@User_No"].Value = Editor_No;
                Read_Question = commands.ExecuteReader();
                Read_Question.Read();
                Editor_Name.Text = Read_Question["User_Name"].ToString();
                Editor_Name.CommandArgument = Read_Question["User_No"].ToString();
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
        String Message_Content;
        int My_No = Convert.ToInt16(Session["User_No"]);
        int Messages_No = Convert.ToInt16(dropAssignEditor.SelectedItem.Value);
        int Role_No = 1;
        int article_No = Convert.ToInt16(Session["Article_No"]);
        int Editor_No = Convert.ToInt16(Session["Editor_No"]);
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



        // try
        //   {
        commands.CommandText = "select Messages.Message_Content,Messages.Message_Name,Messages.Message_Address" +
        "  from Messages where Messages.Message_No=@Message_No";
        commands.Parameters.Add("@Message_No", System.Data.SqlDbType.Int);
        commands.Parameters["@Message_No"].Value = Messages_No;
        Read_Question = commands.ExecuteReader();
        Read_Question.Read();
        Message_Content = Read_Question["Message_Content"].ToString();

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

        FunctionSumation obUnassign = new FunctionSumation();
        obUnassign.UnderUnassignEditorFun(My_No, Messages_No, article_No, Editor_No, Role_No, Message_Content);
    }
    protected void Customize_Click(object sender, EventArgs e)
    {
        String Message_No = dropAssignEditor.SelectedItem.Value;
        Session["Message_No"] = Message_No;




        Response.Redirect("Custom_Letter_UNAssignEditor.aspx");
    }
}
