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
public partial class PermissionManagement : System.Web.UI.Page
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
            Panel11.Visible = false;
            Panel10.Visible = true;
            Panel12.Visible = false;
            AdminFunctiopanel.Visible = false;



        }
        if (e.CommandName == "Reviewer_Permissions")
        {

            Session["User_No"] = e.CommandArgument;
            Panel10.Visible = false;
            Panel11.Visible = true;
            Panel12.Visible = false;
            AdminFunctiopanel.Visible = false;
            testreviewerper();
        }

        if (e.CommandName == "Update_Role")
        {

            Session["User_No"] = e.CommandArgument;
            Panel10.Visible = false;
            Panel11.Visible = false;
            test_Role();
            AdminFunctiopanel.Visible = false;
            Panel12.Visible = true;

        }
        if (e.CommandName == "Administrator_Function")
        {

            Session["User_No"] = e.CommandArgument;
            Panel10.Visible = false;
            Panel11.Visible = false;

            Panel12.Visible = false;
            AdminFunctiopanel.Visible = true;
            testAdminPer();
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
    protected void LinkButton8_Click1(object sender, EventArgs e)
    {
        PanelGeneralpermission.Visible = true;
        int usr_NO = Convert.ToInt16(Session["User_No"]);


        FunctionSumation obUnassign = new FunctionSumation();
        if (obUnassign.TestPermission(usr_NO, "General", "Allow Automatic login to this role") == true)
        {

            CheckBoxList5.Items[0].Selected = true;
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
    }
    protected void LinkButton7_Click(object sender, EventArgs e)
    {
        Panel6.Visible = true;
        int usr_NO = Convert.ToInt16(Session["User_No"]);


        FunctionSumation obUnassign = new FunctionSumation();
        if (obUnassign.TestPermission(usr_NO, "Manager", "New Submission Requiring Assignment") == true)
        {

            CheckBoxList3.Items[0].Selected = true;
        }
        if (obUnassign.TestPermission(usr_NO, "Manager", "Resived Submissions Requiring Assignment") == true)
        {
            CheckBoxList3.Items[1].Selected = true;
        }
        if (obUnassign.TestPermission(usr_NO, "Manager", "Details") == true)
        {
            CheckBoxList3.Items[2].Selected = true;
        }
        if (obUnassign.TestPermission(usr_NO, "Manager", "History") == true)
        {
            CheckBoxList3.Items[3].Selected = true;
        }
        if (obUnassign.TestPermission(usr_NO, "Manager", "Remove_Submission") == true)
        {
            CheckBoxList3.Items[4].Selected = true;
        }
        if (obUnassign.TestPermission(usr_NO, "Manager", "File_Inventory") == true)
        {
            CheckBoxList3.Items[5].Selected = true;
        }
        if (obUnassign.TestPermission(usr_NO, "Manager", "Assign To My Self") == true)
        {
            CheckBoxList3.Items[6].Selected = true;
        }
        if (obUnassign.TestPermission(usr_NO, "Manager", "Send_Email") == true)
        {
            CheckBoxList3.Items[7].Selected = true;
        }
        if (obUnassign.TestPermission(usr_NO, "Manager", "Linked Submissions") == true)
        {
            CheckBoxList3.Items[8].Selected = true;
        }
        if (obUnassign.TestPermission(usr_NO, "Manager", "View All Assigned Submmisssion Being Edited") == true)
        {
            CheckBoxList3.Items[9].Selected = true;
        }
        if (obUnassign.TestPermission(usr_NO, "Manager", "View All Assigned Submmisssions") == true)
        {
            CheckBoxList3.Items[10].Selected = true;
        }
        if (obUnassign.TestPermission(usr_NO, "Manager", "View Submmisssions out For Revision") == true)
        {
            CheckBoxList3.Items[11].Selected = true;
        }
        if (obUnassign.TestPermission(usr_NO, "Manager", "All Submissions With Editors Decision") == true)
        {
            CheckBoxList3.Items[12].Selected = true;
        }
        if (obUnassign.TestPermission(usr_NO, "Manager", "Group By Editor Assigned") == true)
        {
            CheckBoxList3.Items[13].Selected = true;
        }
        if (obUnassign.TestPermission(usr_NO, "Manager", "Group By Editor With current Responsibility") == true)
        {
            CheckBoxList3.Items[14].Selected = true;
        }
        if (obUnassign.TestPermission(usr_NO, "Manager", "Accept") == true)
        {
            CheckBoxList3.Items[15].Selected = true;
        }
        if (obUnassign.TestPermission(usr_NO, "Manager", "Reject") == true)
        {
            CheckBoxList3.Items[16].Selected = true;
        }
        if (obUnassign.TestPermission(usr_NO, "Manager", "Withdrawen") == true)
        {
            CheckBoxList3.Items[17].Selected = true;
        }
        if (obUnassign.TestPermission(usr_NO, "Manager", "Set_Final_Disposition") == true)
        {
            CheckBoxList3.Items[18].Selected = true;
        }
        if (obUnassign.TestPermission(usr_NO, "Manager", "Group By Submission With  Current Status") == true)
        {
            CheckBoxList3.Items[19].Selected = true;
        }
        if (obUnassign.TestPermission(usr_NO, "Manager", "Active Linked Submision Groups") == true)
        {
            CheckBoxList3.Items[20].Selected = true;
        }
        if (obUnassign.TestPermission(usr_NO, "Manager", "Inactive Linked Submision Groups") == true)
        {
            CheckBoxList3.Items[21].Selected = true;
        }
        if (obUnassign.TestPermission(usr_NO, "Manager", "Notify Author") == true)
        {
            CheckBoxList3.Items[22].Selected = true;
        }
        if (obUnassign.TestPermission(usr_NO, "Manager", "View Reviews and comments") == true)
        {
            CheckBoxList3.Items[23].Selected = true;
        }
        if (obUnassign.TestPermission(usr_NO, "Manager", "Create/Edit Linked SubmissionGroup") == true)
        {
            CheckBoxList3.Items[24].Selected = true;
        }
        if (obUnassign.TestPermission(usr_NO, "Manager", "View Linked Submission Group ") == true)
        {
            CheckBoxList3.Items[25].Selected = true;
        }
        if (obUnassign.TestPermission(usr_NO, "Manager", "Set Active/Inactive Group") == true)
        {
            CheckBoxList3.Items[26].Selected = true;
        }
        if (obUnassign.TestPermission(usr_NO, "Manager", "Update Date Due For Editor") == true)
        {
            CheckBoxList3.Items[27].Selected = true;
        }
        if (obUnassign.TestPermission(usr_NO, "Manager", "Update Date Due For Reviewer") == true)
        {
            CheckBoxList3.Items[28].Selected = true;
        }

    }
    protected void LinkButton9_Click(object sender, EventArgs e)
    {
        Panel8.Visible = true;
        int usr_NO = Convert.ToInt16(Session["User_No"]);

       
        FunctionSumation obUnassign = new FunctionSumation();
        
        if (obUnassign.TestPermission(usr_NO, "New Submissions", "New Assignment") == true)
        {
            CheckBoxList4.Items[0].Selected = true;
        }
        if (obUnassign.TestPermission(usr_NO, "New Submissions", "Details") == true)
        {
            CheckBoxList4.Items[1].Selected = true;
        }
        if (obUnassign.TestPermission(usr_NO, "New Submissions", "History") == true)
        {
            CheckBoxList4.Items[2].Selected = true;
        }
        if (obUnassign.TestPermission(usr_NO, "New Submissions", "Remove_Submission") == true)
        {
            CheckBoxList4.Items[3].Selected = true;
        }
        if (obUnassign.TestPermission(usr_NO, "New Submissions", "File_Inventory") == true)
        {
            CheckBoxList4.Items[4].Selected = true;
        }
        if (obUnassign.TestPermission(usr_NO, "New Submissions", "UnAssign other Editor") == true)
        {
            CheckBoxList4.Items[5].Selected = true;
        }
        if (obUnassign.TestPermission(usr_NO, "New Submissions", "Send_Email") == true)
        {
            CheckBoxList4.Items[6].Selected = true;
        }
        if (obUnassign.TestPermission(usr_NO, "New Submissions", "Linked Submissions") == true)
        {
            CheckBoxList4.Items[7].Selected = true;
        }
        if (obUnassign.TestPermission(usr_NO, "New Submissions", "Recive Assignment With Invitation") == true)
        {
            CheckBoxList4.Items[8].Selected = true;
        }
        if (obUnassign.TestPermission(usr_NO, "New Submissions", "Recive Assignment Without Invitation") == true)
        {
            CheckBoxList4.Items[9].Selected = true;
        }
        if (obUnassign.TestPermission(usr_NO, "New Submissions", "Assign_Editor") == true)
        {
            CheckBoxList4.Items[10].Selected = true;
        }
        if (obUnassign.TestPermission(usr_NO, "New Submissions", "Invite_Editor") == true)
        {
            CheckBoxList4.Items[11].Selected = true;
        }
        if (obUnassign.TestPermission(usr_NO, "New Submissions", "UnAssign  My Self") == true)
        {
            CheckBoxList4.Items[12].Selected = true;
        }
        if (obUnassign.TestPermission(usr_NO, "New Submissions", "Unassign Reviewer") == true)
        {
            CheckBoxList4.Items[13].Selected = true;
        }
    }

    protected void LinkButton10_Click(object sender, EventArgs e)
    {
        Panel9.Visible = true;
        int usr_NO = Convert.ToInt16(Session["User_No"]);


        FunctionSumation obUnassign = new FunctionSumation();
        if (obUnassign.TestPermission(usr_NO, "Direct To Editor ", "Direct To Editor New Submission") == true)
        {
            CheckBoxList2.Items[0].Selected = true;
        }
        if (obUnassign.TestPermission(usr_NO, "Direct To Editor ", "Direct To Editor Resived Submission") == true)
        {
            CheckBoxList2.Items[1].Selected = true;
        }
        if (obUnassign.TestPermission(usr_NO, "Direct To Editor ", "Details") == true)
        {
            CheckBoxList2.Items[2].Selected = true;
        }
        if (obUnassign.TestPermission(usr_NO, "Direct To Editor ", "History") == true)
        {
            CheckBoxList2.Items[3].Selected = true;
        }
        if (obUnassign.TestPermission(usr_NO, "Direct To Editor ", "Remove_Submission") == true)
        {
            CheckBoxList2.Items[4].Selected = true;
        }
        if (obUnassign.TestPermission(usr_NO, "Direct To Editor ", "Redirect Other Editor") == true)
        {
            CheckBoxList2.Items[5].Selected = true;
        }
        if (obUnassign.TestPermission(usr_NO, "Direct To Editor ", "Assign To My Self") == true)
        {
            CheckBoxList2.Items[6].Selected = true;
        }
        if (obUnassign.TestPermission(usr_NO, "Direct To Editor ", "Send_Email") == true)
        {
            CheckBoxList2.Items[7].Selected = true;
        }

    }
    protected void Button5_Click(object sender, EventArgs e)
    {
        CheckBoxList5.Visible = true;
        int usr_NO = Convert.ToInt16(Session["User_No"]);


        FunctionSumation obUnassign = new FunctionSumation();
        obUnassign.deleteALLPermissionPerType(usr_NO, "General");
        if (CheckBoxList5.Items[0].Selected)
        {

            obUnassign.deletePermission(usr_NO, "General", "Allow Automatic login to this role");
            obUnassign.InsertPermission(usr_NO, "General", "Allow Automatic login to this role");
        }
        if (CheckBoxList5.Items[1].Selected)
        {
            obUnassign.deletePermission(usr_NO, "General", "Propose Reviewers");
            obUnassign.InsertPermission(usr_NO, "General", "Propose Reviewers");

        }
        if (CheckBoxList5.Items[2].Selected)
        {
            obUnassign.deletePermission(usr_NO, "General", "Remove Proposed Reviewers");
            obUnassign.InsertPermission(usr_NO, "General", "Remove Proposed Reviewers");

        }
        if (CheckBoxList5.Items[3].Selected)
        {
            obUnassign.deletePermission(usr_NO, "General", "Proxy register New Author");
            obUnassign.InsertPermission(usr_NO, "General", "Proxy register New Author");

        }
        if (CheckBoxList5.Items[4].Selected)
        {
            obUnassign.deletePermission(usr_NO, "General", "Proxy Register New Reviewer");
            obUnassign.InsertPermission(usr_NO, "General", "Proxy Register New Reviewer");

        }
        if (CheckBoxList5.Items[5].Selected)
        {
            obUnassign.deletePermission(usr_NO, "General", "Proxy Register New Editor");
            obUnassign.InsertPermission(usr_NO, "General", "Proxy Register New Editor");

        }
    }
    protected void Button6_Click(object sender, EventArgs e)
    {
        CheckBoxList3.Visible = true;
        int usr_NO = Convert.ToInt16(Session["User_No"]);


        FunctionSumation obUnassign = new FunctionSumation();
        obUnassign.deleteALLPermissionPerType(usr_NO, "Manager");
        if (CheckBoxList3.Items[0].Selected)
        {
            obUnassign.deletePermission(usr_NO, "Manager", "New Submission Requiring Assignment");
            obUnassign.InsertPermission(usr_NO, "Manager", "New Submission Requiring Assignment");

        }
        if (CheckBoxList3.Items[1].Selected)
        {
            obUnassign.deletePermission(usr_NO, "Manager", "Resived Submissions Requiring Assignment");
            obUnassign.InsertPermission(usr_NO, "Manager", "Resived Submissions Requiring Assignment");

        }
        if (CheckBoxList3.Items[2].Selected)
        {
            obUnassign.deletePermission(usr_NO, "Manager", "Details");
            obUnassign.InsertPermission(usr_NO, "Manager", "Details");


        }
        if (CheckBoxList3.Items[3].Selected)
        {
            obUnassign.deletePermission(usr_NO, "Manager", "History");
            obUnassign.InsertPermission(usr_NO, "Manager", "History");

        }
        if (CheckBoxList3.Items[4].Selected)
        {
            obUnassign.deletePermission(usr_NO, "Manager", "Remove_Submission");
            obUnassign.InsertPermission(usr_NO, "Manager", "Remove_Submission");

        }
        if (CheckBoxList3.Items[5].Selected)
        {
            obUnassign.deletePermission(usr_NO, "Manager", "File_Inventory");
            obUnassign.InsertPermission(usr_NO, "Manager", "File_Inventory");

        }
        if (CheckBoxList3.Items[6].Selected)
        {
            obUnassign.deletePermission(usr_NO, "Manager", "Assign To My Self");
            obUnassign.InsertPermission(usr_NO, "Manager", "Assign To My Self");


        }
        if (CheckBoxList3.Items[7].Selected)
        {
            obUnassign.deletePermission(usr_NO, "Manager", "Send_Email");
            obUnassign.InsertPermission(usr_NO, "Manager", "Send_Email");


        }
        if (CheckBoxList3.Items[8].Selected)
        {
            obUnassign.deletePermission(usr_NO, "Manager", "Linked Submissions");
            obUnassign.InsertPermission(usr_NO, "Manager", "Linked Submissions");


        }
        if (CheckBoxList3.Items[9].Selected)
        {
            obUnassign.deletePermission(usr_NO, "Manager", "View All Assigned Submmisssion Being Edited");
            obUnassign.InsertPermission(usr_NO, "Manager", "View All Assigned Submmisssion Being Edited");

        }
        if (CheckBoxList3.Items[10].Selected)
        {
            obUnassign.deletePermission(usr_NO, "Manager", "View All Assigned Submmisssions");
            obUnassign.InsertPermission(usr_NO, "Manager", "View All Assigned Submmisssions");


        }
        if (CheckBoxList3.Items[11].Selected)
        {
            obUnassign.deletePermission(usr_NO, "Manager", "View Submmisssions out For Revision");
            obUnassign.InsertPermission(usr_NO, "Manager", "View Submmisssions out For Revision");

        }
        if (CheckBoxList3.Items[12].Selected)
        {
            obUnassign.deletePermission(usr_NO, "Manager", "All Submissions With Editors Decision");
            obUnassign.InsertPermission(usr_NO, "Manager", "All Submissions With Editors Decision");


        }
        if (CheckBoxList3.Items[13].Selected)
        {
            obUnassign.deletePermission(usr_NO, "Manager", "Group By Editor Assigned");
            obUnassign.InsertPermission(usr_NO, "Manager", "Group By Editor Assigned");

        }
        if (CheckBoxList3.Items[14].Selected)
        {
            obUnassign.deletePermission(usr_NO, "Manager", "Group By Editor With current Responsibility");
            obUnassign.InsertPermission(usr_NO, "Manager", "Group By Editor With current Responsibility");

        }
        if (CheckBoxList3.Items[15].Selected)
        {
            obUnassign.deletePermission(usr_NO, "Manager", "Accept");
            obUnassign.InsertPermission(usr_NO, "Manager", "Accept");

        }
        if (CheckBoxList3.Items[16].Selected)
        {
            obUnassign.deletePermission(usr_NO, "Manager", "Reject");
            obUnassign.InsertPermission(usr_NO, "Manager", "Reject");


        }
        if (CheckBoxList3.Items[17].Selected)
        {
            obUnassign.deletePermission(usr_NO, "Manager", "Withdrawen");
            obUnassign.InsertPermission(usr_NO, "Manager", "Withdrawen");

        }
        if (CheckBoxList3.Items[18].Selected)
        {
            obUnassign.deletePermission(usr_NO, "Manager", "Set_Final_Disposition");
            obUnassign.InsertPermission(usr_NO, "Manager", "Set_Final_Disposition");

        }
        if (CheckBoxList3.Items[19].Selected)
        {
            obUnassign.deletePermission(usr_NO, "Manager", "Group By Submission With  Current Status");
            obUnassign.InsertPermission(usr_NO, "Manager", "Group By Submission With  Current Status");

        }
        if (CheckBoxList3.Items[20].Selected)
        {
            obUnassign.deletePermission(usr_NO, "Manager", "Active Linked Submision Groups");
            obUnassign.InsertPermission(usr_NO, "Manager", "Active Linked Submision Groups");

        }
        if (CheckBoxList3.Items[21].Selected)
        {
            obUnassign.deletePermission(usr_NO, "Manager", "Inactive Linked Submision Groups");
            obUnassign.InsertPermission(usr_NO, "Manager", "Inactive Linked Submision Groups");

        }
        if (CheckBoxList3.Items[22].Selected)
        {
            obUnassign.deletePermission(usr_NO, "Manager", "Notify Author");
            obUnassign.InsertPermission(usr_NO, "Manager", "Notify Author");

        }
        if (CheckBoxList3.Items[23].Selected)
        {
            obUnassign.deletePermission(usr_NO, "Manager", "View Reviews and comments");
            obUnassign.InsertPermission(usr_NO, "Manager", "View Reviews and comments");

        }
        if (CheckBoxList3.Items[24].Selected)
        {
            obUnassign.deletePermission(usr_NO, "Manager", "Create/Edit Linked SubmissionGroup");
            obUnassign.InsertPermission(usr_NO, "Manager", "Create/Edit Linked SubmissionGroup");

        }
        if (CheckBoxList3.Items[25].Selected)
        {
            obUnassign.deletePermission(usr_NO, "Manager", "View Linked Submission Group ");
            obUnassign.InsertPermission(usr_NO, "Manager", "View Linked Submission Group ");

        }
        if (CheckBoxList3.Items[26].Selected)
        {
            obUnassign.deletePermission(usr_NO, "Manager", "Set Active/Inactive Group");
            obUnassign.InsertPermission(usr_NO, "Manager", "Set Active/Inactive Group");

        }
        if (CheckBoxList3.Items[27].Selected)
        {
            obUnassign.deletePermission(usr_NO, "Manager", "Update Date Due For Editor");
            obUnassign.InsertPermission(usr_NO, "Manager", "Update Date Due For Editor");

        }
        if (CheckBoxList3.Items[28].Selected)
        {
            obUnassign.deletePermission(usr_NO, "Manager", "Update Date Due For Reviewer");
            obUnassign.InsertPermission(usr_NO, "Manager", "Update Date Due For Reviewer");

        }
    }
    protected void CheckBoxList6_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void Button7_Click(object sender, EventArgs e)
    {
        int usr_NO = Convert.ToInt16(Session["User_No"]);


        FunctionSumation obUnassign = new FunctionSumation();
        obUnassign.deleteALLPermissionPerType(usr_NO, "New Submissions");
        if (CheckBoxList4.Items[0].Selected)
        {
            obUnassign.deletePermission(usr_NO, "New Submissions", "New Assignment");
            obUnassign.InsertPermission(usr_NO, "New Submissions", "New Assignment");

        }
        if (CheckBoxList4.Items[1].Selected)
        {
            obUnassign.deletePermission(usr_NO, "New Submissions", "Details");
            obUnassign.InsertPermission(usr_NO, "New Submissions", "Details");


        }
        if (CheckBoxList4.Items[2].Selected)
        {
            obUnassign.deletePermission(usr_NO, "New Submissions", "History");
            obUnassign.InsertPermission(usr_NO, "New Submissions", "History");

        }
        if (CheckBoxList4.Items[3].Selected)
        {
            obUnassign.deletePermission(usr_NO, "New Submissions", "Remove_Submission");
            obUnassign.InsertPermission(usr_NO, "New Submissions", "Remove_Submission");

        }
        if (CheckBoxList4.Items[4].Selected)
        {
            obUnassign.deletePermission(usr_NO, "New Submissions", "File_Inventory");
            obUnassign.InsertPermission(usr_NO, "New Submissions", "File_Inventory");

            CheckBoxList4.Items[4].Selected = true;
        }
        if (CheckBoxList4.Items[5].Selected)
        {
            obUnassign.deletePermission(usr_NO, "New Submissions", "UnAssign other Editor");
            obUnassign.InsertPermission(usr_NO, "New Submissions", "UnAssign other Editor");

        }
        if (CheckBoxList4.Items[6].Selected)
        {
            obUnassign.deletePermission(usr_NO, "New Submissions", "Send_Email");
            obUnassign.InsertPermission(usr_NO, "New Submissions", "Send_Email");

        }
        if (CheckBoxList4.Items[7].Selected)
        {
            obUnassign.deletePermission(usr_NO, "New Submissions", "Linked Submissions");
            obUnassign.InsertPermission(usr_NO, "New Submissions", "Linked Submissions");

        }
        if (CheckBoxList4.Items[8].Selected)
        {
            obUnassign.deletePermission(usr_NO, "New Submissions", "Recive Assignment With Invitation");
            obUnassign.InsertPermission(usr_NO, "New Submissions", "Recive Assignment With Invitation");

        }
        if (CheckBoxList4.Items[9].Selected)
        {
            obUnassign.deletePermission(usr_NO, "New Submissions", "Recive Assignment Without Invitation");
            obUnassign.InsertPermission(usr_NO, "New Submissions", "Recive Assignment Without Invitation");

        }
        if (CheckBoxList4.Items[10].Selected)
        {
            obUnassign.deletePermission(usr_NO, "New Submissions", "Assign_Editor");
            obUnassign.InsertPermission(usr_NO, "New Submissions", "Assign_Editor");


        }
        if (CheckBoxList4.Items[11].Selected)
        {
            obUnassign.deletePermission(usr_NO, "New Submissions", "Invite_Editor");
            obUnassign.InsertPermission(usr_NO, "New Submissions", "Invite_Editor");

        }
        if (CheckBoxList4.Items[12].Selected)
        {
            obUnassign.deletePermission(usr_NO, "New Submissions", "UnAssign  My Self");
            obUnassign.InsertPermission(usr_NO, "New Submissions", "UnAssign  My Self");


        }
        if (CheckBoxList4.Items[13].Selected)
        {
            obUnassign.deletePermission(usr_NO, "New Submissions", "Unassign Reviewer");
            obUnassign.InsertPermission(usr_NO, "New Submissions", "Unassign Reviewer");


        }
    }
    protected void Button8_Click(object sender, EventArgs e)
    {
        CheckBoxList2.Visible = true;
        int usr_NO = Convert.ToInt16(Session["User_No"]);


        FunctionSumation obUnassign = new FunctionSumation();
        obUnassign.deleteALLPermissionPerType(usr_NO, "Direct To Editor ");
        if (CheckBoxList2.Items[0].Selected)
        {
            obUnassign.deletePermission(usr_NO, "Direct To Editor ", "Direct To Editor New Submission");
            obUnassign.InsertPermission(usr_NO, "Direct To Editor ", "Direct To Editor New Submission");


        }
        if (CheckBoxList2.Items[1].Selected)
        {
            obUnassign.deletePermission(usr_NO, "Direct To Editor ", "Direct To Editor Resived Submission");
            obUnassign.InsertPermission(usr_NO, "Direct To Editor ", "Direct To Editor Resived Submission");

        }
        if (CheckBoxList2.Items[2].Selected)
        {
            obUnassign.deletePermission(usr_NO, "Direct To Editor ", "Details");
            obUnassign.InsertPermission(usr_NO, "Direct To Editor ", "Details");

        }
        if (CheckBoxList2.Items[3].Selected)
        {
            obUnassign.deletePermission(usr_NO, "Direct To Editor ", "History");
            obUnassign.InsertPermission(usr_NO, "Direct To Editor ", "History");


        }
        if (CheckBoxList2.Items[4].Selected)
        {
            obUnassign.deletePermission(usr_NO, "Direct To Editor ", "Remove_Submission");
            obUnassign.InsertPermission(usr_NO, "Direct To Editor ", "Remove_Submission");


        }
        if (CheckBoxList2.Items[5].Selected)
        {
            obUnassign.deletePermission(usr_NO, "Direct To Editor ", "Redirect Other Editor");
            obUnassign.InsertPermission(usr_NO, "Direct To Editor ", "Redirect Other Editor");


        }
        if (CheckBoxList2.Items[6].Selected)
        {
            obUnassign.deletePermission(usr_NO, "Direct To Editor ", "Assign To My Self");
            obUnassign.InsertPermission(usr_NO, "Direct To Editor ", "Assign To My Self");


        }
        if (CheckBoxList2.Items[7].Selected)
        {
            obUnassign.deletePermission(usr_NO, "Direct To Editor ", "Send_Email");
            obUnassign.InsertPermission(usr_NO, "Direct To Editor ", "Send_Email");


        }
    }
    protected void LinkButton11_Click(object sender, EventArgs e)
    {

    }
    protected void Button9_Click(object sender, EventArgs e)
    {
        PanelReviewerpermission.Visible = true;
        int usr_NO = Convert.ToInt16(Session["User_No"]);


        FunctionSumation obUnassign = new FunctionSumation();
        obUnassign.deleteALLPermissionPerType(usr_NO, "Reviews");
        if (CheckBoxList7.Items[0].Selected)
        {
            obUnassign.deletePermission(usr_NO, "Reviews", "Recieve Invitation");
            obUnassign.InsertPermission(usr_NO, "Reviews", "Recieve Invitation");

        }
        if (CheckBoxList7.Items[1].Selected)
        {
            obUnassign.deletePermission(usr_NO, "Reviews", "Decline To Review");
            obUnassign.InsertPermission(usr_NO, "Reviews", "Decline To Review");

        }
    }

    void test_Role()
    {
        int usr_NO = Convert.ToInt16(Session["User_No"]);
        FunctionSumation obUnassign = new FunctionSumation();
        if (obUnassign.TestprimaryRole(usr_NO, "Editor") == true)
        {
            Editor.Items[0].Selected = true;
        }
        if (obUnassign.TestRole(usr_NO, "Editor", "Managing Editor") == true)
        {
            CheckBoxList8.Items[0].Selected = true;
        }
        if (obUnassign.TestRole(usr_NO, "Editor", "Editor_in_Chief") == true)
        {
            CheckBoxList8.Items[1].Selected = true;
        }
        if (obUnassign.TestRole(usr_NO, "Editor", "Associate Editor") == true)
        {
            CheckBoxList8.Items[2].Selected = true;
        }


        //reviewer
        if (obUnassign.TestprimaryRole(usr_NO, "Reviewer") == true)
        {
            Reviwerlist.Items[0].Selected = true;
        }
        if (obUnassign.TestRole(usr_NO, "Reviewer", "Language Reviewer") == true)
        {
            CheckBoxList9.Items[0].Selected = true;
        }
        if (obUnassign.TestRole(usr_NO, "Reviewer", "Referee") == true)
        {
            CheckBoxList9.Items[1].Selected = true;
        }
        if (obUnassign.TestRole(usr_NO, "Reviewer", "Statistical Referee") == true)
        {
            CheckBoxList9.Items[2].Selected = true;
        }
        if (obUnassign.TestRole(usr_NO, "Reviewer", "Potential Reviewer") == true)
        {
            CheckBoxList9.Items[3].Selected = true;
        }

        if (obUnassign.TestRole(usr_NO, "Reviewer", "Entire Database") == true)
        {
            CheckBoxList9.Items[4].Selected = true;
        }
        //author
        if (obUnassign.TestprimaryRole(usr_NO, "Author") == true)
        {
            Author.Items[0].Selected = true;
        }

        if (obUnassign.TestRole(usr_NO, "Author", "Author") == true)
        {
            CheckBoxList10.Items[0].Selected = true;
        }

    }
    protected void Button10_Click(object sender, EventArgs e)
    {
        int usr_NO = Convert.ToInt16(Session["User_No"]);
        FunctionSumation obUnassign = new FunctionSumation();
        obUnassign.deleteAllRole(usr_NO, "Editor");
        if (CheckBoxList8.Items[0].Selected)
        {
            obUnassign.deleteRole(usr_NO, "Editor", "Managing Editor");
            obUnassign.InsertRole(usr_NO, "Editor", "Managing Editor");

        }
        if (CheckBoxList8.Items[1].Selected)
        {
            obUnassign.deleteRole(usr_NO, "Editor", "Editor_in_Chief");
            obUnassign.InsertRole(usr_NO, "Editor", "Editor_in_Chief");


        }
        if (CheckBoxList8.Items[2].Selected)
        {
            obUnassign.deleteRole(usr_NO, "Editor", "Associate Editor");
            obUnassign.InsertRole(usr_NO, "Editor", "Associate Editor");


        }
    }
    protected void Button11_Click(object sender, EventArgs e)
    {
        int usr_NO = Convert.ToInt16(Session["User_No"]);
        FunctionSumation obUnassign = new FunctionSumation();
        obUnassign.deleteAllRole(usr_NO, "Reviewer");
        if (CheckBoxList9.Items[0].Selected)
        {
            obUnassign.deleteRole(usr_NO, "Reviewer", "Language Reviewer");
            obUnassign.InsertRole(usr_NO, "Reviewer", "Language Reviewer");

        }
        if (CheckBoxList9.Items[1].Selected)
        {
            obUnassign.deleteRole(usr_NO, "Reviewer", "Referee");
            obUnassign.InsertRole(usr_NO, "Reviewer", "Referee");

        }
        if (CheckBoxList9.Items[2].Selected)
        {
            obUnassign.deleteRole(usr_NO, "Reviewer", "Statistical Referee");
            obUnassign.InsertRole(usr_NO, "Reviewer", "Statistical Referee");

        }
        if (CheckBoxList9.Items[3].Selected)
        {
            obUnassign.deleteRole(usr_NO, "Reviewer", "Potential Reviewer");
            obUnassign.InsertRole(usr_NO, "Reviewer", "Potential Reviewer");

        }

        if (CheckBoxList9.Items[4].Selected)
        {
            obUnassign.deleteRole(usr_NO, "Reviewer", "Entire Database");
            obUnassign.InsertRole(usr_NO, "Reviewer", "Entire Database");


        }
    }
    protected void Button12_Click(object sender, EventArgs e)
    {
        int usr_NO = Convert.ToInt16(Session["User_No"]);
        FunctionSumation obUnassign = new FunctionSumation();
        obUnassign.deleteAllRole(usr_NO, "Author");
        if (CheckBoxList10.Items[0].Selected)
        {
            obUnassign.deleteRole(usr_NO, "Author", "Author");
            obUnassign.InsertRole(usr_NO, "Author", "Author");


        }
    }
    protected void Button13_Click(object sender, EventArgs e)
    {
        int usr_NO = Convert.ToInt16(Session["User_No"]);
        FunctionSumation obUnassign = new FunctionSumation();

        if (CheckBoxList8.Items[0].Selected)
        {
            obUnassign.deleteRole(usr_NO, "Editor", "Managing Editor");
            obUnassign.InsertRole(usr_NO, "Editor", "Managing Editor");

        }
        if (CheckBoxList8.Items[1].Selected)
        {
            obUnassign.deleteRole(usr_NO, "Editor", "Editor_in_Chief");
            obUnassign.InsertRole(usr_NO, "Editor", "Editor_in_Chief");


        }
        if (CheckBoxList8.Items[2].Selected)
        {
            obUnassign.deleteRole(usr_NO, "Editor", "Associate Editor");
            obUnassign.InsertRole(usr_NO, "Editor", "Associate Editor");


        }
    }
    void testAdminPermission()
    {
        int usr_NO = Convert.ToInt16(Session["User_No"]);


        FunctionSumation obUnassign = new FunctionSumation();
        if (obUnassign.TestPermission(usr_NO, "General", "Allow Automatic login to this role") == true)
        {

            CheckBoxList5.Items[0].Selected = true;
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
    }

    protected void Button14_Click(object sender, EventArgs e)
    {
        int usr_NO = Convert.ToInt16(Session["User_No"]);


        FunctionSumation obUnassign = new FunctionSumation();
        obUnassign.deleteALLPermissionPerType(usr_NO, "Administrator Function");

        if (CheckBoxList1.Items[0].Selected)
        {
            obUnassign.deletePermission(usr_NO, "Administrator Function", "permissional management");
            obUnassign.InsertPermission(usr_NO, "Administrator Function", "permissional management");


        }
        if (CheckBoxList1.Items[1].Selected)
        {
            obUnassign.deletePermission(usr_NO, "Administrator Function", "pages management");
            obUnassign.InsertPermission(usr_NO, "Administrator Function", "pages management");

        }
        if (CheckBoxList1.Items[2].Selected)
        {
            obUnassign.deletePermission(usr_NO, "Administrator Function", "user management");
            obUnassign.InsertPermission(usr_NO, "Administrator Function", "user management");


        }
        if (CheckBoxList1.Items[3].Selected)
        {
            obUnassign.deletePermission(usr_NO, "Administrator Function", "message management");
            obUnassign.InsertPermission(usr_NO, "Administrator Function", "message management");


        }
    }
    void testAdminPer()
    {
        Panel6.Visible = true;
        int usr_NO = Convert.ToInt16(Session["User_No"]);


        FunctionSumation obUnassign = new FunctionSumation();
        if (obUnassign.TestPermission(usr_NO, "Administrator Function", "permissional management") == true)
        {

            CheckBoxList1.Items[0].Selected = true;
        }
        if (obUnassign.TestPermission(usr_NO, "Administrator Function", "pages management") == true)
        {
            CheckBoxList1.Items[1].Selected = true;
        }
        if (obUnassign.TestPermission(usr_NO, "Administrator Function", "user management") == true)
        {

            CheckBoxList1.Items[2].Selected = true;
        }
        if (obUnassign.TestPermission(usr_NO, "Administrator Function", "message management") == true)
        {
            CheckBoxList1.Items[3].Selected = true;
        }
    }
    void testreviewerper()
    {
        PanelReviewerpermission.Visible = true;
        int usr_NO = Convert.ToInt16(Session["User_No"]);


        FunctionSumation obUnassign = new FunctionSumation();
        if (obUnassign.TestPermission(usr_NO, "Reviews", "Recieve Invitation") == true)
        {

            CheckBoxList7.Items[0].Selected = true;
        }
        if (obUnassign.TestPermission(usr_NO, "Reviews", "Decline To Review") == true)
        {

            CheckBoxList7.Items[1].Selected = true;
        }
    }
}
