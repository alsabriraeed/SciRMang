using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.SessionState;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Data.SqlClient;
public partial class Revised__Submissions_Requering_Assignments : System.Web.UI.Page
{
    int My_No;
    decimal Total;
    FunctionSumation ob = new FunctionSumation();
    SqlConnection connect; 
    SqlCommand commands = new SqlCommand();
    SqlDataReader Read_Question;
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


        String quer = " select Articles.Article_No ,Article_Types.Article_Type_Name,   " +
            "Articles.Article_Full_Title,User_names.User_Name,Submitted_Status_Date.Status_Date,   " +
            "Curent_Status.Current_Status_Date,Curent_Status.Current_Status_Name" +
            " from  Articles," +
      " ( select Current_Status.Article_No,Current_Status.Current_Status_Date,Current_Status.Current_Status_Name from  Current_Status where  " +
                  "  Current_Status.Current_Status_Name LIKE 'Recieved' ) Curent_Status  ," +

         "( select  Article_No from Articles where  Articles.Article_No IN " +
                  "( select Article_Status_Users.Article_No  from Article_Status_Users where Article_Status_Users.Status_No " +
                 " IN ( select  Status.Status_No  from Status where Status.Family_Role_No IN  " +
                 " ( select Family_Role.Family_Role_No from Family_Role where Family_Role.Family_Role_Name LIKE 'Editor' ) " +
                 " AND Status.Status_Name LIKE 'Recieved'  )AND Article_Status_Users.User_No=@User_No )) Article_Reciever ," +



        " (select Users.User_Name,Articles.Article_No from  Users,Articles where Articles.Article_Corresponding_Author_No=Users.User_No) User_names , " +
        "  ( select Article_Status_Users.Article_No,Article_Status_Users.Status_Date  from Article_Status_Users where Article_Status_Users.Status_No " +
                 " IN ( select  Status.Status_No  from Status where Status.Family_Role_No IN  " +
                 " ( select Family_Role.Family_Role_No from Family_Role where Family_Role.Family_Role_Name LIKE 'Author' ) " +
                 " AND Status.Status_Name LIKE 'Submitted'  ) )Submitted_Status_Date, " +
                "(select Article_Types.Article_Type_Name,Articles.Article_No from  Article_Types,Articles where" +
                " Article_Types.Article_Type_No = Articles.Article_Type_No ) Article_Types " +
                 "where Articles.Article_No =Article_Types.Article_No " +
                " AND Articles.Article_No = Curent_Status.Article_No" +
                 " AND Articles.Article_No = User_names.Article_No  " +
                 " AND Articles.Article_No = Submitted_Status_Date.Article_No  " +
                  " AND Articles.Article_No = Article_Reciever.Article_No  " +
                 " AND Articles.Article_Revision NOT LIKE '0' " +

                   " AND  Articles.Article_No NOT IN (select Article_User.Article_No   from Article_User where  " +
            " Article_User.Family_Role_No IN  ( select Family_Role.Family_Role_No from  Family_Role where  " +
                                 "  Family_Role.Family_Role_Name  LIKE 'Editor' ) AND  Upper_User_no=@Upper_User_no) ";




        SqlCommand comm_Que_Type = new SqlCommand(quer, connect);
        SqlDataAdapter adapter = new SqlDataAdapter(comm_Que_Type);
        comm_Que_Type.Parameters.Add("@User_No", System.Data.SqlDbType.Int);
        comm_Que_Type.Parameters["@User_No"].Value = My_No;
        comm_Que_Type.Parameters.Add("@Upper_User_no", System.Data.SqlDbType.Int);
        comm_Que_Type.Parameters["@Upper_User_no"].Value = My_No;
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

        if (e.CommandName == "Remove_Submission")
        {

            Session["Article_No"] = e.CommandArgument;
            Response.Redirect("View Submission.aspx");
        }
        if (e.CommandName == "Assign_To_MySelf")
        {
            connect.Close();
            connect.Open();
            commands.Connection = connect;
            int User_order;
            int My_No = Convert.ToInt16(Session["User_No"]);
            Session["Article_No"] = e.CommandArgument;
            int article_No = Convert.ToInt16(Session["Article_No"]);
            DateTime time = new DateTime();
            time = DateTime.Now;

            // Current Status 


            //    try
            //   {
            connect.Close();

            connect.Open();
            /*       commands.CommandText = " update Current_Status " +
                       " set Current_Status_Name ='Need Aproval',Current_Status_Date=@Current_Status_Date " +
                       " where Article_No=@Article_No ";

                   commands.Parameters.Add("@Current_Status_Date", System.Data.SqlDbType.DateTime);
                   commands.Parameters["@Current_Status_Date"].Value = time;
                   commands.Parameters.Add("@Article_No", System.Data.SqlDbType.Int);
                   commands.Parameters["@Article_No"].Value = article_No;
                   commands.ExecuteNonQuery();
                   Read_Question.Close();
                   commands.Parameters.Clear();*/


            // And status_Users



            commands.CommandText = "select Status.Status_No from  Status where  " +
                                     "  Status.Status_Name LIKE 'Editor Assign'";
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
            commands.Parameters["@User_No"].Value = My_No;
            commands.Parameters.Add("@Status_Date", System.Data.SqlDbType.DateTime);
            commands.Parameters["@Status_Date"].Value = time;
            commands.Parameters.Add("@Article_No", System.Data.SqlDbType.Int);
            commands.Parameters["@Article_No"].Value = article_No;
            commands.ExecuteNonQuery();
            commands.Parameters.Clear();


            commands.CommandText = "select Status.Status_No from  Status where  " +
                                     "  Status.Status_Name LIKE 'Editor Invite '";
            Read_Question = commands.ExecuteReader();
            Read_Question.Read();
            int Status_Nom1 = (int)Read_Question[0];
            Read_Question.Close();
            commands.Parameters.Clear();

            commands.CommandText = "insert into Article_Status_Users ( Status_No ,User_No,Status_Date,Article_No )" +
                "values(@Status_No,@User_No,@Status_Date,@Article_No) ";

            commands.Parameters.Add("@Status_No", System.Data.SqlDbType.Int);
            commands.Parameters["@Status_No"].Value = Status_Nom1;
            commands.Parameters.Add("@User_No", System.Data.SqlDbType.Int);
            commands.Parameters["@User_No"].Value = My_No;
            commands.Parameters.Add("@Status_Date", System.Data.SqlDbType.DateTime);
            commands.Parameters["@Status_Date"].Value = time;
            commands.Parameters.Add("@Article_No", System.Data.SqlDbType.Int);
            commands.Parameters["@Article_No"].Value = article_No;
            commands.ExecuteNonQuery();
            commands.Parameters.Clear();



            DateTime timeNow = new DateTime();
            timeNow = DateTime.Now;
            //connect.Open();
            commands.CommandText = "select Status.Status_No from  Status where  " +
                                   "  Status.Status_Name LIKE 'Edit Due'";
            Read_Question = commands.ExecuteReader();
            Read_Question.Read();
            int Status_Nomb = (int)Read_Question[0];
            Read_Question.Close();
            commands.Parameters.Clear();
            commands.CommandText = "select Article_Types.Number_Days_To_Edit from  Article_Types,Articles where  " +
                                 " Article_Types.Article_Type_No=Articles.Article_Type_No AND Articles.Article_No=@Article_No ";
            commands.Parameters.Add("@Article_No", System.Data.SqlDbType.Int);
            commands.Parameters["@Article_No"].Value = article_No;
            Read_Question = commands.ExecuteReader();
            Read_Question.Read();
            DateTime Due_Date = timeNow.AddDays((int)Read_Question[0]);
            Read_Question.Close();
            commands.Parameters.Clear();
            commands.CommandText = "insert into Article_Status_Users ( Status_No ,User_No,Status_Date,Article_No )" +
             "values(@Status_No,@User_No,@Status_Date,@Article_No) ";
            commands.Parameters.Add("@Status_No", System.Data.SqlDbType.Int);
            commands.Parameters["@Status_No"].Value = Status_Nomb;
            commands.Parameters.Add("@User_No", System.Data.SqlDbType.Int);
            commands.Parameters["@User_No"].Value = My_No;
            commands.Parameters.Add("@Status_Date", System.Data.SqlDbType.DateTime);
            commands.Parameters["@Status_Date"].Value = Due_Date;
            commands.Parameters.Add("@Article_No", System.Data.SqlDbType.Int);
            commands.Parameters["@Article_No"].Value = article_No;
            commands.ExecuteNonQuery();
            commands.Parameters.Clear();
            //  end  Due_date

            //   }
            //  catch
            //  {

            //  }
            //  finally
            // {
            //   commands.Parameters.Clear();
            //   connect.Close();
            // }





            //    try
            //   {
            connect.Close();
            Read_Question.Close();
            connect.Open();



            // And status_Users



            commands.CommandText = "select Family_Role.Family_Role_No from  Family_Role where  " +
                                     "  Family_Role.Family_Role_Name  LIKE 'Editor'";
            Read_Question = commands.ExecuteReader();
            Read_Question.Read();
            int Role_Nom = (int)Read_Question[0];
            Read_Question.Close();
            commands.Parameters.Clear();

            commands.CommandText = "select max(User_Order)   from Article_User where Article_No=@Article_No AND " +
                " Article_User.Family_Role_No IN  ( select Family_Role.Family_Role_No from  Family_Role where  " +
                                     "  Family_Role.Family_Role_Name  LIKE 'Editor' ) GROUP BY Article_No ";
            commands.Parameters.Add("@Article_No", System.Data.SqlDbType.Int);
            commands.Parameters["@Article_No"].Value = article_No;
            Read_Question = commands.ExecuteReader();
            if (Read_Question.Read())
            {
                User_order = (int)Read_Question[0];
                User_order += 1;

            }
            else
            {
                User_order = 1;
            }

            Read_Question.Close();
            commands.Parameters.Clear();

            // set message_User

            commands.CommandText = "insert into Article_User (Lower_User_No ,Upper_User_no,Family_Role_No,Article_No,User_Order,Assign_Complete )" +
                           "values(@Lower_User_No ,@Upper_User_no,@Family_Role_No,@Article_No,@User_Order,@Assign_Complete) ";

            commands.Parameters.Add("@Lower_User_No", System.Data.SqlDbType.Int);
            commands.Parameters["@Lower_User_No"].Value = My_No;
            commands.Parameters.Add("@Upper_User_no", System.Data.SqlDbType.Int);
            commands.Parameters["@Upper_User_no"].Value = My_No;
            commands.Parameters.Add("@Family_Role_No", System.Data.SqlDbType.Int);
            commands.Parameters["@Family_Role_No"].Value = Role_Nom;
            commands.Parameters.Add("@Article_No", System.Data.SqlDbType.Int);
            commands.Parameters["@Article_No"].Value = article_No;
            commands.Parameters.Add("@User_Order", System.Data.SqlDbType.Int);
            commands.Parameters["@User_Order"].Value = User_order;
            commands.Parameters.Add("@Assign_Complete", System.Data.SqlDbType.Int);
            commands.Parameters["@Assign_Complete"].Value = 0;
            commands.ExecuteNonQuery();
            commands.Parameters.Clear();
            connect.Close();
            //   }
            //  catch
            //  {

            //  }
            //  finally
            // {
            //   commands.Parameters.Clear();
            //   connect.Close();
            // }












            Response.Redirect("AssignMySelf.aspx");
        }

        if (e.CommandName == "Details")
        {

            Session["Article_No"] = e.CommandArgument;
            Response.Redirect("View Submission.aspx");
        }
        if (e.CommandName == "Assign_Editor")
        {

            Session["Article_No"] = e.CommandArgument;
            Response.Redirect("AssignEditor.aspx");
        }

        if (e.CommandName == "Redirec_other_Editor")
        {

            Session["Article_No"] = e.CommandArgument;
            Response.Redirect("Redirect other Editor.aspx");
        }

        if (e.CommandName == "Send_Email")
        {

            Session["Article_No"] = e.CommandArgument;
            Response.Redirect("SendAdHocEmail.aspx");
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



            if (obUnassign.TestPermission(usr_NO, "Manager", "Details") == false)
            {
                e.Row.FindControl("Details").Visible = false;
            }
            if (obUnassign.TestPermission(usr_NO, "Manager", "History") == false)
            {
                e.Row.FindControl("History").Visible = false;
            }
            if (obUnassign.TestPermission(usr_NO, "Manager", "Remove_Submission") == false)
            {
                e.Row.FindControl("Remove_Submission").Visible = false;
            }
            if (obUnassign.TestPermission(usr_NO, "Manager", "File_Inventory") == false)
            {
                e.Row.FindControl("File_Inventory").Visible = false;
            }
            if (obUnassign.TestPermission(usr_NO, "Manager", "Assign To My Self") == false)
            {
                e.Row.FindControl("Assign_To_MySelf").Visible = false;
            }
            if (obUnassign.TestPermission(usr_NO, "Manager", "Send_Email") == false)
            {
                e.Row.FindControl("Send_Email").Visible = false;
            }
            if (obUnassign.TestPermission(usr_NO, "New Submissions", "Assign_Editor") == false)
            {
                e.Row.FindControl("Assign_Editor").Visible = false;
            }
            if (obUnassign.TestPermission(usr_NO, "New Submissions", "Invite_Editor") == false)
            {
                e.Row.FindControl("Invite_Editor").Visible = false;
            }







        }
    }
}
