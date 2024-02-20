using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.SessionState;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Data.SqlClient;
public partial class HistoryForSubmission : System.Web.UI.Page
{
    FunctionSumation ob = new FunctionSumation();
    SqlConnection connect;
   SqlCommand comm1 = new SqlCommand();
    SqlDataReader Read_Question;
    protected void Page_Load(object sender, EventArgs e)
    {

        int art = Convert.ToInt16(Session["Article_No"]);
        connect = ob.connect;

        try
        {
            connect.Close();
            connect.Open();
            comm1.Connection = connect;
            comm1.CommandText = "select Articles.Article_Revision,user_name.User_No ,user_name.User_Name,Status_name.Status_Name," +
                "Status_name.Family_Role_Name ,status_date.Status_Date from Articles ,"
                + "(select Users.User_No,Users.User_Name from Users)user_name ," +
                "(select Status.Status_Name,Family_Role.Family_Role_Name,Status.Status_No  from Status,Family_Role where" +
                " Family_Role.Family_Role_No= Status.Family_Role_No AND  Status.Status_Name NOT LIKE 'Edit Due' AND" +
                "  Status.Status_Name NOT LIKE 'Review Due' )Status_name ," +
                "(select Article_Status_Users.User_No,Article_Status_Users.Status_Date" +
                ",Article_Status_Users.Status_No from Article_Status_Users where Article_Status_Users.Article_No" +
                "=@Article_No  ) status_date " +
                "where Status_name.Status_No=status_date.Status_No AND " +
                " status_date.User_No=user_name.User_No " +
                " AND Articles.Article_No=@Article_No " +
                " ORDER BY (User_No)  ";
            comm1.Parameters.Add("@Article_No", System.Data.SqlDbType.Int);
            comm1.Parameters["@Article_No"].Value = art;
            Read_Question = comm1.ExecuteReader();
            Status_history.DataSource = Read_Question;
            Status_history.DataBind();






        }
        catch { }
        finally
        {
            comm1.Parameters.Clear();
            connect.Close();
        }

        //message


        try
        {
            connect.Close();
            connect.Open();
            comm1.Connection = connect;
            comm1.CommandText = "select Articles.Article_Revision,user_name.User_No ,user_name.User_Name,Message_no.Message_Name,Message_no.Message_No," +
                "family_role.Family_Role_Name ,Message_no.Message_Send_Date from Articles ,"
                + "(select Users.User_No,Users.User_Name from Users)user_name ," +

                "(select Messages.Message_No,Message_User.Sender_No,Message_User.Message_Send_Date,Messages.Message_Name from Messages,Message_User where " +
               " Messages.Message_No=Message_User.Message_No AND Message_User.Article_No=@Article_No)Message_no ," +

               " (select Message_User.Message_No ,Family_Role.Family_Role_Name from Message_User," +
               "   Family_Role where Family_Role.Family_Role_No=Message_User.Family_Role_No AND" +
               "  Message_User.Article_No=@Article_No ) family_role " +

               " where Message_no.Sender_No=user_name.User_No  AND " +
               "family_role.Message_No=Message_no.Message_No" +
                " AND Articles.Article_No=@Article_No " +
                " ";
            comm1.Parameters.Add("@Article_No", System.Data.SqlDbType.Int);
            comm1.Parameters["@Article_No"].Value = art;
            Read_Question = comm1.ExecuteReader();
            Message_history.DataSource = Read_Question;
            Message_history.DataBind();






        }
        catch { }
        finally
        {
            comm1.Parameters.Clear();
            connect.Close();
        }

    }
    protected void Message_history_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "Message_name")
        {
            Session["Message_No"] = e.CommandArgument;
            Response.Redirect("ViewLetterForMessageHistory.aspx");
        }
    }
}
