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
public partial class AssignEditorNoComplete : System.Web.UI.Page
{

    DataTable table1 = new DataTable();
    DataTable table2 = new DataTable();
    int My_No;
    decimal Total;
    FunctionSumation ob = new FunctionSumation();
    SqlConnection connect;
    SqlCommand commands = new SqlCommand();
    //     SqlDataReader Read_Question;
    protected void Page_Load(object sender, EventArgs e)
    {
        My_No = Convert.ToInt16(Session["User_No"]);

        connect = ob.connect;


        if (!Page.IsPostBack)
        {

            load();
            Total_Submission.Text = Session["Count"].ToString();
            FunctionSumation obUserName = new FunctionSumation();
            User_Name.Text = obUserName.User_Name(My_No);
        }


    }

    void load()
    {
        // ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^NEW SUBMISSIONS REQUIRING ASSIGNMENT^^^^^^^^^^
        // try
        // {
        connect.Close();
        connect.Open();
        commands.Connection = connect;
        String quer = "select Article_User.Lower_User_No,Article_User.Article_No  from Article_User where  Article_User.Family_Role_No IN" +
                         "( select Family_Role.Family_Role_No from Family_Role where Family_Role.Family_Role_Name LIKE 'Editor') AND " +
                         "Article_User.Upper_User_No=@Upper_User_No  AND Assign_Complete =0 ";


        SqlCommand comm_Que_Type = new SqlCommand(quer, connect);
        SqlDataAdapter adapter = new SqlDataAdapter(comm_Que_Type);
        comm_Que_Type.Parameters.Add("@Upper_User_No", System.Data.SqlDbType.Int);
        comm_Que_Type.Parameters["@Upper_User_No"].Value = My_No;
        DataTable table = new DataTable();
        adapter.Fill(table);



        table2.Columns.Add("Article_No", typeof(int));
        table2.Columns.Add("Article_Type_Name", typeof(string));
        table2.Columns.Add("Article_Full_Title", typeof(String));
        table2.Columns.Add("User_Name", typeof(String));
        table2.Columns.Add("Status_Date", typeof(String));
        table2.Columns.Add("Current_Status_Date", typeof(String));
        table2.Columns.Add("Editor_name", typeof(String));
        table2.Columns.Add("Current_Status_Name", typeof(String));
        table2.Columns.Add("Assign_Date", typeof(String));
        foreach (DataRow datarow in table.Select())
        {


            int Article_no = (int)datarow["Article_No"];
            int Editor_no = (int)datarow["Lower_User_No"];

            commands.Parameters.Clear();

            String quer1 = " select Articles.Article_No ,Article_Types.Article_Type_Name,   " +
         "Articles.Article_Full_Title,User_names.User_Name,Submitted_Status_Date.Status_Date,   " +
         " Current_Status.Current_Status_Date,Current_Status.Current_Status_Name ,Assign_Editor.Status_Date AS Assign_Date ,Editor_name.User_Name  AS Editor_Name  from Articles ,Current_Status ,  " +

         "(select Users.User_No,Article_User.Article_No,Users.User_Name from Users,Article_User   where Users.User_No=Article_User.Lower_User_No AND " +
              "    Users.User_No=@User_No AND Article_User.Article_No=@Article_No AND Article_User.Lower_User_No=@Lower_User_No) Editor_name ," +

                    " (select Users.User_Name from  Users,Articles where Articles.Article_Corresponding_Author_No=Users.User_No AND Articles.Article_No=@Article_No) User_names , " +

                    "  ( select Article_Status_Users.Status_Date  from Article_Status_Users where Article_Status_Users.Status_No " +
              " IN ( select  Status.Status_No  from Status where Status.Family_Role_No IN  " +
             " ( select Family_Role.Family_Role_No from Family_Role where Family_Role.Family_Role_Name LIKE 'Author' ) " +
              " AND Status.Status_Name LIKE 'Submitted'  )AND  Article_Status_Users.Article_No=@Article_No  )Submitted_Status_Date, " +

              "(select  Article_Types.Article_Type_Name from  Article_Types,Articles where" +
             " Article_Types.Article_Type_No = Articles.Article_Type_No AND Articles.Article_No=@Article_No  ) Article_Types, " +

              " ( select Article_Status_Users.Status_Date,Article_Status_Users.Article_No from Article_Status_Users where Article_Status_Users.Status_No " +
                  " IN ( select  Status.Status_No  from Status where Status.Family_Role_No IN  " +
                  " ( select Family_Role.Family_Role_No from Family_Role where Family_Role.Family_Role_Name LIKE 'Editor' ) " +
                 " AND Status.Status_Name LIKE 'Editor Assign') AND Article_Status_Users.Article_No=@Article_No AND " +
               "  Article_Status_Users.User_No=@User_No  )Assign_Editor " +

                " where Articles.Article_No IN( select Article_Status_Users.Article_No from Article_Status_Users where Article_Status_Users.Status_No " +
                  " IN ( select  Status.Status_No  from Status where Status.Family_Role_No IN  " +
                  " ( select Family_Role.Family_Role_No from Family_Role where Family_Role.Family_Role_Name LIKE 'Editor' ) " +
                 " AND Status.Status_Name LIKE 'Editor Assign') AND Article_Status_Users.Article_No=@Article_No AND " +
               "  Article_Status_Users.User_No=@User_No  )  " +

               " AND Articles.Article_No NOT IN( select Article_Status_Users.Article_No from Article_Status_Users where Article_Status_Users.Status_No " +
                  " IN ( select  Status.Status_No  from Status where Status.Family_Role_No IN  " +
                  " ( select Family_Role.Family_Role_No from Family_Role where Family_Role.Family_Role_Name LIKE 'Editor' ) " +
                 " AND Status.Status_Name LIKE 'Complete Edit') AND Article_Status_Users.Article_No=@Article_No AND " +
               "  Article_Status_Users.User_No=@User_No  ) AND Articles.Article_No=@Article_No  AND  Current_Status.Article_No=@Article_No " +
               " AND Current_Status.Article_No=Articles.Article_No " +
               " AND Editor_name.Article_No=Articles.Article_No " +
               " AND Assign_Editor.Article_No=Articles.Article_No ";

            SqlCommand comm_Que_Type1 = new SqlCommand(quer1, connect);
            SqlDataAdapter adapter1 = new SqlDataAdapter(comm_Que_Type1);
            comm_Que_Type1.Parameters.Add("@User_No", System.Data.SqlDbType.Int);
            comm_Que_Type1.Parameters["@User_No"].Value = Editor_no;
            comm_Que_Type1.Parameters.Add("@Lower_User_No", System.Data.SqlDbType.Int);
            comm_Que_Type1.Parameters["@Lower_User_No"].Value = Editor_no;
            comm_Que_Type1.Parameters.Add("@Article_No", System.Data.SqlDbType.Int);
            comm_Que_Type1.Parameters["@Article_No"].Value = Article_no;

            adapter1.Fill(table1);



            if (table1.Rows.Count != 0)
            {
                foreach (DataRow datarow1 in table1.Select())
                {


                    DataRow dr = table2.NewRow();
                    dr["Article_No"] = datarow1["Article_No"];
                    dr["Article_Type_Name"] = datarow1["Article_Type_Name"];
                    dr["Article_Full_Title"] = datarow1["Article_Full_Title"];
                    dr["User_Name"] = datarow1["User_Name"];
                    dr["Status_Date"] = datarow1["Status_Date"];
                    dr["Current_Status_Date"] = datarow1["Current_Status_Date"];
                    dr["Current_Status_Name"] = datarow1["Current_Status_Name"];
                    dr["Editor_Name"] = datarow1["Editor_Name"];
                    dr["Assign_Date"] = datarow1["Assign_Date"];
                    table2.Rows.Add(dr);

                    // dr.Delete();
                }
                table1.Clear();
            }

        }

        DataView dv = new DataView(table2);

        Total = decimal.Parse(table.Compute("count(Article_No)", "Article_No>=0").ToString());
        Session["Count"] = Total;



        if (dv.Count != 0)
        {
            if (!this.SortField.Equals(String.Empty))
            {
                string strDirect = String.Empty;
                if (this.SortDirection.Equals("D"))
                    strDirect = " DESC";

                dv.Sort = SortField + strDirect;
            }

            this.GridView1.DataSource = dv;
            this.GridView1.DataBind();
        }


        //   }
        //   catch
        // {

        // }
        //  finally
        //     {
        //      commands.Parameters.Clear();
        //        connect.Close();
        //  }

    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
    {

        if (e.CommandName == "Details")
        {
            Session["Article_No"] = e.CommandArgument;
            Response.Redirect("DetailForManuscriptNumber2.aspx");
        }
        if (e.CommandName == "History")
        {

            Session["Article_No"] = e.CommandArgument;
            Response.Redirect("HistoryForSubmission.aspx");
        }


        if (e.CommandName == "File_Inventory")
        {

            Session["Article_No"] = e.CommandArgument;
            Response.Redirect("FileInventory.aspx");
        }








        if (e.CommandName == "Send_Email")
        {

            Session["Article_No"] = e.CommandArgument;
            Response.Redirect("SendAdHocEmail.aspx");
        }



        if (e.CommandName == "Unassign_Other_Editor")
        {

            Session["Article_No"] = e.CommandArgument;
            Response.Redirect("beginUnassignEditor.aspx");
        }


    }
    protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {

        GridView1.PageIndex = e.NewPageIndex;
        load();

        int Current1_Page = (int)e.NewPageIndex;
        Current1_Page += 1;
        Current_Page.Text = Current1_Page.ToString();
    }
    protected void GridView1_Sorting(object sender, GridViewSortEventArgs e)
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
    protected void GridView1_PageIndexChanged(object sender, EventArgs e)
    {
        Pages_Number.Text = GridView1.PageCount.ToString();
    }
    protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        int usr_NO = Convert.ToInt16(Session["User_No"]);
        FunctionSumation obUnassign = new FunctionSumation();
        if (e.Row.RowType == DataControlRowType.DataRow)
        {


            if (obUnassign.TestPermission(usr_NO, "New Submissions", "Details") == false)
            {
                e.Row.FindControl("Details").Visible = false;
            }
            if (obUnassign.TestPermission(usr_NO, "New Submissions", "History") == false)
            {
                e.Row.FindControl("History").Visible = false;
            }

            if (obUnassign.TestPermission(usr_NO, "New Submissions", "File_Inventory") == false)
            {
                e.Row.FindControl("File_Inventory").Visible = false;
            }

            if (obUnassign.TestPermission(usr_NO, "New Submissions", "Send_Email") == false)
            {
                e.Row.FindControl("Send_Email").Visible = false;
            }

            if (obUnassign.TestPermission(usr_NO, "New Submissions", "UnAssign other Editor") == false)
            {
                e.Row.FindControl("Unassign_Other_Editor").Visible = false;
            }
        }
    }
}
