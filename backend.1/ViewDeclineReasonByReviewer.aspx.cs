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
public partial class ViewDeclineReasonByReviewer : System.Web.UI.Page
{
    int usr_NO;
    int art;

    FunctionSumation ob = new FunctionSumation();
    SqlConnection connect;
    SqlCommand commands = new SqlCommand();
    SqlDataReader Read_Question;
    protected void Page_Load(object sender, EventArgs e)
    {
        connect = ob.connect;
        //  try
        //  {
        usr_NO = Convert.ToInt16(Session["Reviewer_No"]);
        art = Convert.ToInt16(Session["Article_No"]);
        connect.Close();
        connect.Open();
        commands.Connection = connect;
        commands.CommandText = "select  Reason_For_Decline from Reasons_Decline_Table where User_No=@User_No AND " +
            " Article_No=@Article_No AND Reasons_Decline_Table.Family_Role_No IN (select Family_Role.Family_Role_No from Family_Role " +
                " where Family_Role.Family_Role_Name LIKE 'Reviewer' )";
        commands.Parameters.Add("@User_No", System.Data.SqlDbType.Int);
        commands.Parameters["@User_No"].Value = usr_NO;
        commands.Parameters.Add("@Article_No", System.Data.SqlDbType.Int);
        commands.Parameters["@Article_No"].Value = art;
        Read_Question = commands.ExecuteReader();
        Read_Question.Read();
        Reason_Decline.Text = Read_Question["Reason_For_Decline"].ToString();



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
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("Decline_Reviewer_For_Submission.aspx");
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("Decline_Reviewer_For_Submission.aspx");
    }
}
