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
public partial class Current_Editor_Assignment : System.Web.UI.Page
{
    FunctionSumation ob = new FunctionSumation();
    SqlConnection connect;
    SqlCommand comm1 = new SqlCommand();
    SqlDataReader Read_Question;
    protected void Page_Load(object sender, EventArgs e)
    {
        connect = ob.connect;
        comm1.Connection = connect;
        connect.Close();
        connect.Open();




        comm1.CommandText = "select Abstract.Article_No, Status_Assign_Date.Status_Date,Article_Current_Status.Current_Status_Name from Abstract, " +

        "(select Article_User.Article_No from Article_User  where Article_User.User_No =2 AND Family_Role_No IN(select Family_Role.Family_Role_No  from  Family_Role where Family_Role_Name  LIKE 'Editor')) Article_Editor ," +
            "  (select Article_Status_Users.Status_Date ,Article_Status_Users.Article_No from Article_Status_Users where Status_No IN(select Status.Status_No from Status where  Status.Family_Role_No IN( " +
            " select Family_Role.Family_Role_No from Family_Role where  Family_Role.Family_Role_Name LIKE 'Editor'  )AND Status.Status_Name LIKE 'Assign' ))Status_Assign_Date   " +
            " ,( select Current_Status.Article_No,Current_Status.Current_Status_Name from Current_Status) Article_Current_Status" +
            " where  Abstract.Article_No=Status_Assign_Date.Article_No AND  Abstract.Article_No=Article_Editor.Article_No AND Abstract.Article_No=Status_Assign_Date.Article_No ";

        Read_Question = comm1.ExecuteReader();
        while (Read_Question.Read())
        {
            Response.Write(Convert.ToString(Read_Question[0]) + "" + Convert.ToString(Read_Question[1]));
        }
    }
}
