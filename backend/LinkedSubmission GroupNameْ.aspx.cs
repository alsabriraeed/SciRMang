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
public partial class LinkedSubmission_GroupName_ : System.Web.UI.Page
{
    FunctionSumation ob = new FunctionSumation();
    SqlConnection connect;
    SqlCommand commands = new SqlCommand();
    SqlDataReader Read_Question;
    protected void Page_Load(object sender, EventArgs e)
    {
        connect = ob.connect;
        int art = Convert.ToInt16(Session["Article_No"]);
        if (!IsPostBack)
        {

            // ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^NEW INVITATION^^^^^^^^^^^^^^^^^^^^^^
            try
            {
                connect.Close();
                connect.Open();
                commands.Connection = connect;

                commands.CommandText = "select  Linked_Submission_Group.Linked_Submission_Group_Name,Linked_Submission_Group.Linked_Submission_Group_No," +
                 " Linked_Submission_Group.Linked_Submission_Group_Status " +
                  " from Linked_Submission_Group  ";
                Read_Question = commands.ExecuteReader();

                LinkedGroup.DataSource = Read_Question;
                LinkedGroup.DataValueField = "Linked_Submission_Group_No";
                LinkedGroup.DataTextField = "Linked_Submission_Group_Name";
                LinkedGroup.DataBind();
                Read_Question.Close();
            }

            catch
            {

            }
            finally
            {
                commands.Parameters.Clear();
                connect.Close();
            }
        }
    }
    protected void Button5_Click(object sender, EventArgs e)
    {

    }
    protected void Button4_Click(object sender, EventArgs e)
    {
        int usr_NO = Convert.ToInt16(Session["User_No"]);
        int art = Convert.ToInt16(Session["Article_No"]);
        try
        {
            connect.Close();
            connect.Open();
            commands.Connection = connect;
            commands.CommandText = "insert into Linked_submission_Article (Linked_Submission_Group_No, Article_No,User_No )" +
                        " values(@Linked_Submission_Group_No,@Article_No,@User_No) ";
            commands.Parameters.Add("@Linked_Submission_Group_No", System.Data.SqlDbType.Int);
            commands.Parameters["@Linked_Submission_Group_No"].Value = LinkedGroup.SelectedItem.Value;
            commands.Parameters.Add("@Article_No", System.Data.SqlDbType.Int);
            commands.Parameters["@Article_No"].Value = art;

            commands.Parameters.Add("@User_No", System.Data.SqlDbType.Int);
            commands.Parameters["@User_No"].Value = usr_NO;

            commands.ExecuteNonQuery();
            commands.Parameters.Clear();
            connect.Close();
        }

        catch
        {

        }
        finally
        {
            commands.Parameters.Clear();
            connect.Close();
        }

    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        Response.Redirect("Create a New Group.aspx");
    }
    protected void Button2_Click(object sender, EventArgs e)
    {

    }
}
