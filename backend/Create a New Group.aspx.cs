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
public partial class Create_a_New_Group : System.Web.UI.Page
{
    FunctionSumation ob = new FunctionSumation();
    SqlConnection connect; 
    SqlCommand commands = new SqlCommand();
    //    SqlDataReader Read_Question;
    protected void Page_Load(object sender, EventArgs e)
    {
        connect = ob.connect;
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        int usr_NO = Convert.ToInt16(Session["User_No"]);
        int art = Convert.ToInt16(Session["Article_No"]);
        //  try
        //  {
        connect.Close();
        connect.Open();
        commands.Connection = connect;
        commands.CommandText = "insert into Linked_Submission_Group ( Linked_Submission_Group_Name,User_No ,Linked_Submission_Group_Status)" +
                    " values(@Linked_Submission_Group_Name,@User_No,@Linked_Submission_Group_Status) ";

        commands.Parameters.Add("@Linked_Submission_Group_Name", System.Data.SqlDbType.Text);
        commands.Parameters["@Linked_Submission_Group_Name"].Value = Group_Name.Text;

        commands.Parameters.Add("@Linked_Submission_Group_Status", System.Data.SqlDbType.Int);
        commands.Parameters["@Linked_Submission_Group_Status"].Value = 0;
        commands.Parameters.Add("@User_No", System.Data.SqlDbType.Int);
        commands.Parameters["@User_No"].Value = usr_NO;
        commands.ExecuteNonQuery();
        commands.Parameters.Clear();
        connect.Close();
        // }

        //  catch
        //   {

        // }
        //  finally
        //{
        //  commands.Parameters.Clear();
        //connect.Close();
        //  }
    }
}
