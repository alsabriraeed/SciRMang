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
public partial class UnassignEditor : System.Web.UI.Page
{


    protected void Page_Load(object sender, EventArgs e)
    {



    }
    protected void CmdClose1_Click(object sender, EventArgs e)
    {
        Response.Redirect("RollBacktoPreviousEditorConfirmSelectionsandCustomizeLetters.aspx");
    }
    protected void CmdClose0_Click(object sender, EventArgs e)
    {
        FunctionSumation ob = new FunctionSumation();
        SqlConnection connect;
        connect = ob.connect;
        SqlCommand commands = new SqlCommand();
        SqlDataReader Read_Question;
        // try
        //   {
        connect.Close();
        connect.Open();
        commands.Connection = connect;

        commands.CommandText = "select Messages.Message_No " +
            "  from Messages where Messages.Message_Type_No IN( select Messages_Type.Message_Type_No from Messages_Type where" +
            " Messages_Type.Message_Type_Name LIKE 'UNAssign Editor') AND Messages.Message_Name LIKE 'UnassignOtherEditor'  ";
        Read_Question = commands.ExecuteReader();
        Read_Question.Read();

        int Messages_No = (int)Read_Question["Message_No"];
        // }
        //catch
        // {

        //}
        //finally
        //  {
        //  connect.Close();
        // }

        String Message_Content;
        int My_No = Convert.ToInt16(Session["User_No"]);

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

        Response.Redirect("AssignEditor.aspx");


    }
}
