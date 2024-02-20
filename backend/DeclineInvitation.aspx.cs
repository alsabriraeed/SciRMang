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
public partial class DeclineInvitation : System.Web.UI.Page
{
    FunctionSumation ob = new FunctionSumation();
    SqlConnection connect;
    SqlCommand commands = new SqlCommand();
    SqlDataReader Read_Question;
    protected void Page_Load(object sender, EventArgs e)
    {
        connect = ob.connect;
    }
    protected void CmdSubmit_Click(object sender, EventArgs e)
    {
        int My_No = Convert.ToInt16(Session["Reviewer_No"]);

        int article_No = Convert.ToInt16(Session["Article_No"]);
        DateTime time = new DateTime();


        // Current Status 


        //    try
        //   {
        connect.Close();
        connect.Open();
        commands.Connection = connect;




        commands.CommandText = "select Family_Role_No from  Family_Role where  " +
                                       "  Family_Role_Name LIKE 'Reviewer'";
        Read_Question = commands.ExecuteReader();
        Read_Question.Read();
        int Role_No = (int)Read_Question[0];
        Read_Question.Close();
        commands.Parameters.Clear();

        commands.CommandText = "insert into Reasons_Decline_Table " +
            "( User_No,Article_No,Family_Role_No,Reason_For_Decline )" +
            "values(@User_No,@Article_No,@Family_Role_No,@Reason_For_Decline) ";

        commands.Parameters.Add("@Family_Role_No", System.Data.SqlDbType.Int);
        commands.Parameters["@Family_Role_No"].Value = Role_No;
        commands.Parameters.Add("@User_No", System.Data.SqlDbType.Int);
        commands.Parameters["@User_No"].Value = My_No;
        commands.Parameters.Add("@Reason_For_Decline", System.Data.SqlDbType.Text);
        commands.Parameters["@Reason_For_Decline"].Value = Reason_Decline.Text;
        commands.Parameters.Add("@Article_No", System.Data.SqlDbType.Int);
        commands.Parameters["@Article_No"].Value = article_No;
        commands.ExecuteNonQuery();
        commands.Parameters.Clear();

        //   }
        //  catch
        //   {

        //   }
        //   finally
        // {
        //         commands.Parameters.Clear();
        //    connect.Close();
        //   }
        Response.Redirect("Decline review confirmation.aspx");

    }
}
