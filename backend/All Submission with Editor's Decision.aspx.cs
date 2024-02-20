﻿using System;
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
public partial class All_Submission_with_Editor_s_Decision : System.Web.UI.Page
{
    int usr_NO;
    decimal Total;
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

            load();
            Total_Submission.Text = Session["Count"].ToString();
            FunctionSumation obUserName = new FunctionSumation();
            User_Name.Text = obUserName.User_Name(usr_NO);
        }


    }
    void load()
    {
        //^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^Group By Assined ^^^^^^^^^^^^^^^^^^^^^^
        // try
        //  {
        connect.Close();
        connect.Open();
        commands.Connection = connect;
        String quer = " select Author_name.User_Name AS author_name,Article_Information.Article_No," +
                           "submitted_date.Status_Date AS submitted_Date,Article_Information.Article_Full_Title,Article_Information.Article_Keywords " +
                " , Current_Status.Current_Status_Date ,Current_Status.Current_Status_Name ,Article_Type_Name from  Current_Status,  " +

                " (select Articles.Article_No ,Articles.Article_Full_Title,Articles.Article_Keywords from Articles " +

                " where   Articles.Article_No NOT IN(select Article_User.Article_No  from Article_User where  Article_User.Assign_Complete =0 )  " +
                    " AND  Articles.Article_No  IN(select Article_User.Article_No  from Article_User " +
                     ")" +



                 " AND Articles.Article_No NOT  IN" +
          " ( select Article_Status_Users.Article_No from  Article_Status_Users where  " +
                      "  Article_Status_Users.Status_No IN(select Status.Status_No from Status where  Status.Status_Name LIKE 'Accept' )) " +

                       " AND Articles.Article_No NOT  IN" +
          " ( select Article_Status_Users.Article_No from  Article_Status_Users where  " +
                      "  Article_Status_Users.Status_No IN(select Status.Status_No from Status where  Status.Status_Name LIKE 'Reject' )) " +

                       " AND Articles.Article_No NOT  IN" +
          " ( select Article_Status_Users.Article_No from  Article_Status_Users where  " +
                      "  Article_Status_Users.Status_No IN(select Status.Status_No from Status where  Status.Status_Name LIKE 'Withdrawen' )) " +
                            "  )Article_Information, " +


                    "( select Article_Status_Users.Article_No,Article_Status_Users.Status_Date  from Article_Status_Users,Family_Role,Status where Article_Status_Users.Status_No " +
                 " = Status.Status_No AND Status.Family_Role_No =Family_Role.Family_Role_No AND Family_Role.Family_Role_Name LIKE 'Author'  " +
                 " AND Status.Status_Name LIKE 'Submitted')submitted_date , " +



                  "(select  Users.User_Name,Articles.Article_No  from Users,Articles where  Articles.Article_Corresponding_Author_No=Users.User_No )Author_name ," +

                 "(select  Article_Types.Article_Type_Name,Articles.Article_No from  Article_Types,Articles " +
                 "  where   Article_Types.Article_Type_No = Articles.Article_Type_No   ) article_type " +
                 " where Current_Status.Article_No=Article_Information.Article_No AND Article_Information.Article_No=article_type.Article_No " +



                 " AND submitted_date.Article_No=Article_Information.Article_No AND Author_name.Article_No=Article_Information.Article_No " +

                 "  ";






        SqlCommand comm_Que_Type = new SqlCommand(quer, connect);
        SqlDataAdapter adapter = new SqlDataAdapter(comm_Que_Type);
        comm_Que_Type.Parameters.Add("@User_No", System.Data.SqlDbType.Int);
        comm_Que_Type.Parameters["@User_No"].Value = usr_NO;
        DataTable table = new DataTable();
        adapter.Fill(table);
        comm_Que_Type.Parameters.Clear();
        Total = decimal.Parse(table.Compute("count(Article_No)", "Article_No>=0").ToString());
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
    protected void db_AllsubmissionDecision_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void db_AllsubmissionDecision_RowCommand(object sender, GridViewCommandEventArgs e)
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
        if (e.CommandName == "View_Submation")
        {

            Session["Article_No"] = e.CommandArgument;
            Response.Redirect("View Submission.aspx");
        }
        if (e.CommandName == "Set_Final_Desicion")
        {


            Session["Article_No"] = e.CommandArgument;
            Response.Redirect("Set Final Disposition.aspx");
        }
        if (e.CommandName == "Notify_Author")
        {

            Session["Article_No"] = e.CommandArgument;
            Response.Redirect("Set Final Disposition.aspx");
        }
        if (e.CommandName == "View_Reviews_and_comments")
        {

            Session["Article_No"] = e.CommandArgument;
            Response.Redirect("View Reviewer Commentsaspx.aspx");
        }

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
    protected void db_AllsubmissionDecision_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        int usr_NO = Convert.ToInt16(Session["User_No"]);
        FunctionSumation obUnassign = new FunctionSumation();
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            if (obUnassign.TestPermission(usr_NO, "Manager", "Details") == false)
            {
                e.Row.FindControl("Details").Visible = false;
            }
            if (obUnassign.TestPermission(usr_NO, "Manager", "History") == false)
            {
                e.Row.FindControl("History").Visible = false;
            }

            if (obUnassign.TestPermission(usr_NO, "Manager", "Send_Email") == false)
            {
                e.Row.FindControl("Send_Email").Visible = false;
            }
            if (obUnassign.TestPermission(usr_NO, "Manager", "File_Inventory") == false)
            {
                e.Row.FindControl("File_Inventory").Visible = false;
            }

            if (obUnassign.TestPermission(usr_NO, "Manager", "Notify Author") == false)
            {
                e.Row.FindControl("Notify_Author").Visible = false;
            }
            if (obUnassign.TestPermission(usr_NO, "Manager", "View Reviews and comments") == false)
            {
                e.Row.FindControl("View_Reviews_and_comments").Visible = false;
            }

            if (obUnassign.TestPermission(usr_NO, "Manager", "Set_Final_Disposition") == false)
            {
                e.Row.FindControl("Set_Final_Desicion").Visible = false;
            }

        }
    }
}
