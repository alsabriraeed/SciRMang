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
public partial class EditorinCilfDecisionandCommentsforManuscript : System.Web.UI.Page
{
    FunctionSumation ob = new FunctionSumation();
    SqlConnection connect; 
    SqlCommand commands = new SqlCommand();
    SqlDataReader Read_Question;
    protected void Page_Load(object sender, EventArgs e)
    {
        connect = ob.connect;
    }
    protected void CmdClose0_Click(object sender, EventArgs e)
    {

        //    try
        //   {
        connect.Close();
        connect.Open();
        commands.Connection = connect;
        int usr_NO = Convert.ToInt16(Session["User_No"]);
        int Article_no = Convert.ToInt16(Session["Article_No"]);
        Article_Notxt.Text = Article_no.ToString();
        DateTime time = new DateTime();
        time = DateTime.Now;
        //   Complete_date


        commands.CommandText = "select Status.Status_No from  Status where  " +
                               "  Status.Status_Name LIKE 'Complete Edit'";
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
        commands.Parameters["@User_No"].Value = usr_NO;
        commands.Parameters.Add("@Status_Date", System.Data.SqlDbType.DateTime);
        commands.Parameters["@Status_Date"].Value = time;
        commands.Parameters.Add("@Article_No", System.Data.SqlDbType.Int);
        commands.Parameters["@Article_No"].Value = Article_no;
        commands.ExecuteNonQuery();
        commands.Parameters.Clear();


        commands.CommandText = " update Article_User " +
                " set Assign_Complete =1" +
                " where   Article_User.Family_Role_No IN " +
            "   ( select  Family_Role_No  from Family_Role   " +
        " where  Family_Role.Family_Role_Name LIKE 'Editor') AND Article_User.Article_No=@Article_No  ";




        commands.Parameters.Add("@Article_No", System.Data.SqlDbType.Int);
        commands.Parameters["@Article_No"].Value = Article_no;
        commands.ExecuteNonQuery();
        commands.Parameters.Clear();

        //  end Complete_date

        //    }
        //    catch
        //   {

        //    }
        //    finally
        //   {
        ///    commands.Parameters.Clear();
        //    connect.Close();


        //  }
    }
    protected void CmdClose3_Click(object sender, EventArgs e)
    {
        Response.Redirect("InstructionEditor.aspx");
    }

}
