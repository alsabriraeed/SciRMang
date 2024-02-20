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
public partial class Linked_Group : System.Web.UI.Page
{
    int usr_NO;
    decimal Total;
    FunctionSumation ob = new FunctionSumation();
    SqlConnection connect;
    SqlCommand command = new SqlCommand();
    //  SqlDataReader Read_Question;
    protected void Page_Load(object sender, EventArgs e)
    {
        usr_NO = Convert.ToInt16(Session["User_No"]);

        connect = ob.connect;
        if (!Page.IsPostBack)
        {

            load1();
            Total_Submission.Text = Session["Count"].ToString();
            FunctionSumation obUserName = new FunctionSumation();
            User_Name.Text = obUserName.User_Name(usr_NO);
        }


    }
    void load1()
    {

        //^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^NEW ASsignment^^^^^^^^^^^^^^^^^^^^^
        // try
        //   {
        connect.Close();
        connect.Open();
        command.Connection = connect;
        String quer = "select  Linked_Submission_Group.Linked_Submission_Group_Name,Linked_Submission_Group.Linked_Submission_Group_No," +
            " Linked_Submission_Group.Linked_Submission_Group_Status " +
             " from Linked_Submission_Group  ";

        SqlCommand comm_Que_Type = new SqlCommand(quer, connect);
        SqlDataAdapter adapter = new SqlDataAdapter(comm_Que_Type);
        comm_Que_Type.Parameters.Add("@User_No", System.Data.SqlDbType.Int);
        comm_Que_Type.Parameters["@User_No"].Value = usr_NO;
        comm_Que_Type.Parameters.Add("@Lower_User_No", System.Data.SqlDbType.Int);
        comm_Que_Type.Parameters["@Lower_User_No"].Value = usr_NO;
        comm_Que_Type.Parameters.Add("@Upper_User_no", System.Data.SqlDbType.Int);
        comm_Que_Type.Parameters["@Upper_User_no"].Value = usr_NO;
        DataTable table = new DataTable();
        adapter.Fill(table);
        comm_Que_Type.Parameters.Clear();
        Total = decimal.Parse(table.Compute("count(Linked_Submission_Group_No)", "Linked_Submission_Group_No>=0").ToString());
        Session["Count"] = Total;
        DataView dv = new DataView(table);
        if (dv.Count != 0)
        {
            if (!this.SortField.Equals(String.Empty))
            {
                string strDirect = String.Empty;
                if (this.SortDirection.Equals("D"))
                    strDirect = " DESC";

                dv.Sort = SortField + strDirect;
            }

            this.db_pending.DataSource = dv;
            this.db_pending.DataBind();
        }

        //  }
        //    catch
        //  {

        // }
        //  finally
        //  {
        //    command.Parameters.Clear();
        //    connect.Close();
        // }

    }
    protected void db_pending_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void db_pending_Sorting(object sender, GridViewSortEventArgs e)
    {
        if (e.SortExpression.Trim() == this.SortField)
            this.SortDirection = (this.SortDirection == "D" ? "A" : "D");
        else
            this.SortDirection = "A";

        this.SortField = e.SortExpression;
        load1();
    }
    string SortDirection
    {
        get
        {
            object o = ViewState["SortDirection"];
            if (o == null)
                return String.Empty;
            else
                return (string)o;
        }
        set
        {
            ViewState["SortDirection"] = value;
        }
    }
    string SortField
    {
        get
        {
            object o = ViewState["SortField"];
            if (o == null)
                return String.Empty;
            else
                return (string)o;
        }
        set
        {
            ViewState["SortField"] = value;
        }
    }
    protected void db_pending_PageIndexChanged(object sender, EventArgs e)
    {
        Pages_Number.Text = db_pending.PageCount.ToString();
    }
    protected void db_pending_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        db_pending.PageIndex = e.NewPageIndex;
        load1();

        int Current1_Page = (int)e.NewPageIndex;
        Current1_Page += 1;
        Current_Page.Text = Current1_Page.ToString();
    }
    protected void db_pending_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "Edite_Linked_Group")
        {

            Session["Linked_Submission_Group_No"] = e.CommandArgument;
            Response.Redirect("View Submission.aspx");
        }
        if (e.CommandName == "Set_Inactive_Status")
        {

            Session["Linked_Submission_Group_No"] = e.CommandArgument;
            setInactiveGroup();
            load1();
        }
        if (e.CommandName == "Set_active_Status")
        {

            Session["Linked_Submission_Group_No"] = e.CommandArgument;
            setactiveGroup();
            load1();
        }

        if (e.CommandName == "Clear_Group")
        {

            Session["Linked_Submission_Group_No"] = e.CommandArgument;
            DeleteALLSubmisiionFromGroup();
            load1();
        }
    }
    public void setInactiveGroup()
    {
        SqlCommand commands = new SqlCommand();
        int Linked_Submission_Group_no = Convert.ToInt16(Session["Linked_Submission_Group_No"]);
        connect.Close();
        connect.Open();
        commands.Connection = connect;


        commands.CommandText = " update Linked_Submission_Group " +
            " set  Linked_Submission_Group_Status =@Linked_Submission_Group_Status where Linked_Submission_Group_No=@Linked_Submission_Group_No";


        commands.Parameters.Add("@Linked_Submission_Group_Status", System.Data.SqlDbType.Int);
        commands.Parameters["@Linked_Submission_Group_Status"].Value = 0;
        commands.Parameters.Add("@Linked_Submission_Group_No", System.Data.SqlDbType.Int);
        commands.Parameters["@Linked_Submission_Group_No"].Value = Linked_Submission_Group_no;
        commands.ExecuteNonQuery();
        commands.Parameters.Clear();
        connect.Close();
    }
    public void setactiveGroup()
    {
        SqlCommand commands = new SqlCommand();
        int Linked_Submission_Group_no = Convert.ToInt16(Session["Linked_Submission_Group_No"]);
        connect.Close();
        connect.Open();
        commands.Connection = connect;


        commands.CommandText = " update Linked_Submission_Group " +
            " set  Linked_Submission_Group_Status =@Linked_Submission_Group_Status where Linked_Submission_Group_No=@Linked_Submission_Group_No";


        commands.Parameters.Add("@Linked_Submission_Group_Status", System.Data.SqlDbType.Int);
        commands.Parameters["@Linked_Submission_Group_Status"].Value = 1;
        commands.Parameters.Add("@Linked_Submission_Group_No", System.Data.SqlDbType.Int);
        commands.Parameters["@Linked_Submission_Group_No"].Value = Linked_Submission_Group_no;
        commands.ExecuteNonQuery();
        commands.Parameters.Clear();
        connect.Close();
    }
    public void DeleteALLSubmisiionFromGroup()
    {
        SqlCommand commands = new SqlCommand();
        int Linked_Submission_Group_no = Convert.ToInt16(Session["Linked_Submission_Group_No"]);
        connect.Close();
        connect.Open();
        commands.Connection = connect;


        commands.CommandText = " delete from  Linked_submission_Article " +
            " where Linked_Submission_Group_No=@Linked_Submission_Group_No";


        commands.Parameters.Add("@Linked_Submission_Group_No", System.Data.SqlDbType.Int);
        commands.Parameters["@Linked_Submission_Group_No"].Value = Linked_Submission_Group_no;
        commands.ExecuteNonQuery();
        commands.Parameters.Clear();
        connect.Close();
    }
}
