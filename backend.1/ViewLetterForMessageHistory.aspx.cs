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
public partial class ViewLetterForMessageHistory : System.Web.UI.Page
{
    FunctionSumation ob = new FunctionSumation();
    SqlConnection connect; 
    SqlCommand commands = new SqlCommand();
    SqlDataReader Read_Question;
    protected void Page_Load(object sender, EventArgs e)
    {
        String Message_Content;
        connect = ob.connect;
        int art = Convert.ToInt16(Session["Article_No"]);
        int Messages_No = Convert.ToInt16(Session["Message_No"]);
        // try
        //   {

        connect.Close();
        connect.Open();
        commands.Connection = connect;
        commands.CommandText = "select Message_User.Updated_Message_Content" +
        "  from Message_User where Message_User.Message_No=@Message_No AND Article_No=@Article_No ";
        commands.Parameters.Add("@Message_No", System.Data.SqlDbType.Int);
        commands.Parameters["@Message_No"].Value = Messages_No;
        commands.Parameters.Add("@Article_No", System.Data.SqlDbType.Int);
        commands.Parameters["@Article_No"].Value = art;
        Read_Question = commands.ExecuteReader();
        Read_Question.Read();
        Message_Content = Read_Question["Updated_Message_Content"].ToString();

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
        Txt_message_content.Text = Message_Content;
    }
    protected void CmdClose_Click(object sender, EventArgs e)
    {
        Response.Redirect("HistoryForSubmission.aspx");
    }
    protected void CmdClose0_Click(object sender, EventArgs e)
    {
        Response.Redirect("HistoryForSubmission.aspx");
    }
}
