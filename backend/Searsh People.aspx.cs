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
public partial class Searsh_People : System.Web.UI.Page
{

    int usr_NO;
    decimal Total;
    DataTable table = new DataTable();
    FunctionSumation ob = new FunctionSumation();
    SqlConnection connect; 
    SqlCommand commands = new SqlCommand();
    //    SqlDataReader Read_Question;
    protected void Page_Load(object sender, EventArgs e)
    {
        connect = ob.connect;
        Response.Write("..");

        usr_NO = Convert.ToInt16(Session["User_No"]);
        if (!Page.IsPostBack)
        {


            FunctionSumation obUserName = new FunctionSumation();
            User_Name.Text = obUserName.User_Name(usr_NO);
        }


    }
    void load()
    {

        //^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^Group By Assined ^^^^^^^^^^^^^^^^^^^^^^
        // try
        //  {
        String quer = "";
        connect.Close();
        connect.Open();
        commands.Connection = connect;

        if (DropDcreteria.SelectedItem.Text.Equals("Last name") && Selectordropdown.SelectedItem.Text.Equals("Begins with"))
        {

            quer = " select  " +
                     "  Users.User_Name,Users.User_No  from Users  where Users.User_No  IN (select  User_Role.User_No from User_Role  " +
                     "  where User_Role.Role_No IN (select Role.Role_No  from Role  where Family_Role_No IN (select Family_Role.Family_Role_No from Family_Role " +
                     " where Family_Role.Family_Role_Name=@Family_Role_Name ))) " +
                     "AND Users.User_Name =@User_Name";

            SqlCommand comm_Que_Type = new SqlCommand(quer, connect);
            SqlDataAdapter adapter = new SqlDataAdapter(comm_Que_Type);
            comm_Que_Type.Parameters.Add("@User_Name", System.Data.SqlDbType.VarChar, 50);
            comm_Que_Type.Parameters["@User_Name"].Value = VuleSearch.Text;
            comm_Que_Type.Parameters.Add("@Family_Role_Name", System.Data.SqlDbType.VarChar, 50);
            comm_Que_Type.Parameters["@Family_Role_Name"].Value = ddownRole.SelectedItem.Text;
            adapter.Fill(table);
            comm_Que_Type.Parameters.Clear();

        }
        if (DropDcreteria.SelectedItem.Text.Equals("Last name") && Selectordropdown.SelectedItem.Text.Equals("Begins with") && ddownRole.SelectedItem.Text.Equals("All"))
        {

            quer = " select  " +
                     "  Users.User_Name,Users.User_No  from Users   " +
                     "where Users.User_Name =@User_Name";

            SqlCommand comm_Que_Type = new SqlCommand(quer, connect);
            SqlDataAdapter adapter = new SqlDataAdapter(comm_Que_Type);
            comm_Que_Type.Parameters.Add("@User_Name", System.Data.SqlDbType.VarChar, 50);
            comm_Que_Type.Parameters["@User_Name"].Value = VuleSearch.Text;
            adapter.Fill(table);
            comm_Que_Type.Parameters.Clear();
        }







        Total = decimal.Parse(table.Compute("count(User_No)", "User_No>=0").ToString());
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

            this.db_AllsubmissionDecision.DataSource = dv;
            this.db_AllsubmissionDecision.DataBind();
        }

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
    protected void TreeView7_TreeNodeCheckChanged(object sender, TreeNodeEventArgs e)
    {

    }
    protected void LinkButton8_Click(object sender, EventArgs e)
    {


    }
    protected void db_AllsubmissionDecision_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void db_AllsubmissionDecision_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        db_AllsubmissionDecision.PageIndex = e.NewPageIndex;
        load();

        int Current1_Page = (int)e.NewPageIndex;
        Current1_Page += 1;
        Current_Page.Text = Current1_Page.ToString();
    }
    protected void db_AllsubmissionDecision_Sorting(object sender, GridViewSortEventArgs e)
    {
        if (e.SortExpression.Trim() == this.SortField)
            this.SortDirection = (this.SortDirection == "D" ? "A" : "D");
        else
            this.SortDirection = "A";

        this.SortField = e.SortExpression;
        load();
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
    protected void db_AllsubmissionDecision_PageIndexChanged(object sender, EventArgs e)
    {
        Pages_Number.Text = db_AllsubmissionDecision.PageCount.ToString();
    }
    protected void db_AllsubmissionDecision_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "Permission_Editor")
        {

            Session["User_No"] = e.CommandArgument;
            usr_NO = Convert.ToInt16(Session["User_No"]);


            /*   FunctionSumation obUnassign = new FunctionSumation();
               if (obUnassign.TestPermission(usr_NO, "General", "Allow Automatic login to this role") == true)
               {
                   CheckBoxList5.Items[0].Selected=true;
               }
               if (obUnassign.TestPermission(usr_NO, "General", "Propose Reviewers") == true)
               {
                   CheckBoxList5.Items[1].Selected = true;
               }
               if (obUnassign.TestPermission(usr_NO, "General", "Remove Proposed Reviewers") == true)
               {
                   CheckBoxList5.Items[2].Selected = true;
               }
               if (obUnassign.TestPermission(usr_NO, "General", "Proxy register New Author") == true)
               {
                   CheckBoxList5.Items[3].Selected = true;
               }
               if (obUnassign.TestPermission(usr_NO, "General", "Proxy Register New Reviewer") == true)
               {
                   CheckBoxList5.Items[4].Selected = true;
               }
               if (obUnassign.TestPermission(usr_NO, "General", "Proxy Register New Editor") == true)
               {
                   CheckBoxList5.Items[5].Selected = true;
               }
               */


        }
        if (e.CommandName == "Reviewer_Permissions")
        {

            Session["User_No"] = e.CommandArgument;

        }

        if (e.CommandName == "Update_Role")
        {

            Session["User_No"] = e.CommandArgument;



        }
        if (e.CommandName == "Send_Email")
        {

            Session["Article_No"] = e.CommandArgument;
            Response.Redirect("SendAdHocEmail.aspx");
        }
    }
    protected void Button4_Click(object sender, EventArgs e)
    {


        load();
        Total_Submission.Text = Session["Count"].ToString();
    }







}
