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
public partial class Editor_For_Article : System.Web.UI.Page
{

    decimal Total;
    DataTable table1 = new DataTable();

    FunctionSumation ob = new FunctionSumation();
    SqlConnection connect; 
    SqlCommand commands = new SqlCommand();
    SqlDataReader Read_Question;
    protected void Page_Load(object sender, EventArgs e)
    {
        connect = ob.connect;
        int art = Convert.ToInt16(Session["Article_No"]);

        int My_No = Convert.ToInt16(Session["User_No"]);




        if (!Page.IsPostBack)
        {
            Article_No.Text = art.ToString();

            load();

        }


    }

    void load()
    {
        DataTable table2 = new DataTable();
        int art = Convert.ToInt16(Session["Article_No"]);

        table2.Columns.Add("Invite_Date", typeof(String));
        table2.Columns.Add("Assign_Date", typeof(String));
        table2.Columns.Add("Due_Reivew_Date", typeof(String));
        table2.Columns.Add("Recomendation", typeof(String));
        table2.Columns.Add("Reviewer_name", typeof(String));
        table2.Columns.Add("Complete_Date", typeof(String));
        table2.Columns.Add("Status_Review", typeof(String));
        table2.Columns.Add("User_No", typeof(int));

        String querE = "select Article_User.Lower_User_No from Article_User where Article_User.Family_Role_No IN(select Family_Role.Family_Role_No from Family_Role where Family_Role_Name LIKE 'Editor')" +
            " AND Article_User.Article_No=@Article_No  ";

        SqlCommand comm_Que_TypeE = new SqlCommand(querE, connect);
        comm_Que_TypeE.Parameters.Add("@Article_No", System.Data.SqlDbType.Int);
        comm_Que_TypeE.Parameters["@Article_No"].Value = art;
        SqlDataAdapter adapterE = new SqlDataAdapter(comm_Que_TypeE);
        DataTable tableE = new DataTable();
        adapterE.Fill(tableE);
        comm_Que_TypeE.Parameters.Clear();

        foreach (DataRow datarow in tableE.Select())
        {
            int user_no = (int)datarow["Lower_User_No"];

            String Invite_Date = "";
            String Assign_Date = "";
            String Due_Reivew_Date = "";
            String Recomendation = "";
            String Reviewer_name = "";
            String Complete_Date = "";
            String Status_Review = "";
            try
            {
                connect.Close();
                connect.Open();
                commands.Connection = connect;
                commands.CommandText = " select Article_Status_Users.User_No,Article_Status_Users.Status_Date from Article_Status_Users where Article_Status_Users.Status_No IN(select Status.Status_No " +
                      "  from Status where Status.Family_Role_No IN (select Family_Role.Family_Role_No from Family_Role " +
                      "  where Family_Role.Family_Role_Name LIKE 'Editor') AND Status.Status_Name LIKE 'Editor Invite')" +
                      " AND Article_Status_Users.Article_No=@Article_No AND Article_Status_Users.User_No=@User_No";
                commands.Parameters.Add("@User_No", System.Data.SqlDbType.Int);
                commands.Parameters["@User_No"].Value = user_no;
                commands.Parameters.Add("@Article_No", System.Data.SqlDbType.Int);
                commands.Parameters["@Article_No"].Value = art;
                Read_Question = commands.ExecuteReader();
                Read_Question.Read();
                Invite_Date = Read_Question[1].ToString();
                Read_Question.Close();
                commands.Parameters.Clear();

            }
            catch { }


            commands.Parameters.Clear();
            try
            {
                connect.Close();
                connect.Open();
                commands.Connection = connect;
                commands.CommandText = " select Article_Status_Users.User_No,Article_Status_Users.Status_Date from Article_Status_Users where Article_Status_Users.Status_No IN(select Status.Status_No " +
                      "  from Status where Status.Family_Role_No IN (select Family_Role.Family_Role_No from Family_Role " +
                      "  where Family_Role.Family_Role_Name LIKE 'Editor') AND Status.Status_Name LIKE 'Editor Assign')" +
                      " AND Article_Status_Users.Article_No=@Article_No AND Article_Status_Users.User_No=@User_No";
                commands.Parameters.Add("@User_No", System.Data.SqlDbType.Int);
                commands.Parameters["@User_No"].Value = user_no;
                commands.Parameters.Add("@Article_No", System.Data.SqlDbType.Int);
                commands.Parameters["@Article_No"].Value = art;
                Read_Question = commands.ExecuteReader();
                Read_Question.Read();
                Assign_Date = Read_Question[1].ToString();

                Read_Question.Close();
                commands.Parameters.Clear();

            }
            catch { }

            commands.Parameters.Clear();

            try
            {
                connect.Close();
                connect.Open();
                commands.Connection = connect;
                commands.CommandText = " select Article_Status_Users.User_No,Article_Status_Users.Status_Date from Article_Status_Users where Article_Status_Users.Status_No IN(select Status.Status_No " +
                      "  from Status where Status.Family_Role_No IN (select Family_Role.Family_Role_No from Family_Role " +
                      "  where Family_Role.Family_Role_Name LIKE 'Editor') AND Status.Status_Name LIKE 'Edit Due')" +
                      " AND Article_Status_Users.Article_No=@Article_No AND Article_Status_Users.User_No=@User_No";
                commands.Parameters.Add("@User_No", System.Data.SqlDbType.Int);
                commands.Parameters["@User_No"].Value = user_no;
                commands.Parameters.Add("@Article_No", System.Data.SqlDbType.Int);
                commands.Parameters["@Article_No"].Value = art;
                Read_Question = commands.ExecuteReader();
                Read_Question.Read();
                Due_Reivew_Date = Read_Question[1].ToString();
                Read_Question.Close();
                commands.Parameters.Clear();

            }
            catch { }

            commands.Parameters.Clear();
            //Complete date
            try
            {
                connect.Close();
                connect.Open();
                commands.Connection = connect;
                commands.CommandText = " select Article_Status_Users.User_No,Article_Status_Users.Status_Date from Article_Status_Users where Article_Status_Users.Status_No IN(select Status.Status_No " +
                      "  from Status where Status.Family_Role_No IN (select Family_Role.Family_Role_No from Family_Role " +
                      "  where Family_Role.Family_Role_Name LIKE 'Editor') AND Status.Status_Name LIKE 'Complete Edit')" +
                      " AND Article_Status_Users.Article_No=@Article_No AND Article_Status_Users.User_No=@User_No";
                commands.Parameters.Add("@User_No", System.Data.SqlDbType.Int);
                commands.Parameters["@User_No"].Value = user_no;
                commands.Parameters.Add("@Article_No", System.Data.SqlDbType.Int);
                commands.Parameters["@Article_No"].Value = art;
                Read_Question = commands.ExecuteReader();
                Read_Question.Read();
                Complete_Date = Read_Question[1].ToString();
                Read_Question.Close();
                commands.Parameters.Clear();

            }
            catch { }

            commands.Parameters.Clear();
            try
            {
                connect.Close();
                connect.Open();
                commands.Connection = connect;
                commands.CommandText = " select Question_Answer.AnswerContent from Question_Answer,Questions," +
                     " Decision_and_comments_Type,Decision_and_comments where " +
                        " Question_Answer.QuestionNo=Questions.QuestionNo " +
                        " AND Questions.QuestionContent LIKE 'Recomendation' AND Questions.Dec_Com_No=" +
                        "Decision_and_comments.Dec_Com_No AND Decision_and_comments.Dec_Com_Type_No=" +
                        " Decision_and_comments_Type.Dec_com_Type_NO AND Decision_and_comments_Type.Dec_com_Type_Name " +
                        " LIKE 'Editor' AND Question_Answer.UserNO=@UserNO AND Question_Answer.ArticleNO=@ArticleNO ";
                commands.Parameters.Add("@UserNO", System.Data.SqlDbType.Int);
                commands.Parameters["@UserNO"].Value = user_no;
                commands.Parameters.Add("@ArticleNO", System.Data.SqlDbType.Int);
                commands.Parameters["@ArticleNO"].Value = art;
                Read_Question = commands.ExecuteReader();
                Read_Question.Read();
                Recomendation = Read_Question[0].ToString();
                Read_Question.Close();
                commands.Parameters.Clear();

            }
            catch { }
            //current Status

            commands.Parameters.Clear();
            try
            {
                connect.Close();
                connect.Open();
                commands.Connection = connect;
                commands.CommandText = "select Status_Name from Status where Status.Status_No IN (select Status_No " +
                 "from Article_Status_Users where Article_Status_Users.User_No=@User_No AND Article_Status_Users.Status_Date IN(" +
                 " select max(Status_Date)  from Article_Status_Users " +
             "  where Article_Status_Users.Article_No=@Article_No AND Article_Status_Users.User_No=@User_No AND " +
             "  Article_Status_Users.Status_No IN(select Status.Status_No from Status where Status.Family_Role_No IN" +
             "  (select Family_Role.Family_Role_No from Family_Role  where Family_Role.Family_Role_Name LIKE 'Editor')" +
             "  AND Status.Status_Name NOT LIKE 'Edit Due'   )))";
                commands.Parameters.Add("@User_No", System.Data.SqlDbType.Int);
                commands.Parameters["@User_No"].Value = user_no;
                commands.Parameters.Add("@Article_No", System.Data.SqlDbType.Int);
                commands.Parameters["@Article_No"].Value = art;
                Read_Question = commands.ExecuteReader();
                Read_Question.Read();
                Status_Review = Read_Question[0].ToString();
                Read_Question.Close();
                commands.Parameters.Clear();

            }
            catch { }


            commands.Parameters.Clear();
            //suer_Nmae
            try
            {
                connect.Close();
                connect.Open();
                commands.Connection = connect;
                commands.CommandText = " select Users.User_Name from Users where User_No=@User_No ";
                commands.Parameters.Add("@User_No", System.Data.SqlDbType.Int);
                commands.Parameters["@User_No"].Value = user_no;
                Read_Question = commands.ExecuteReader();
                Read_Question.Read();
                Reviewer_name = Read_Question[0].ToString();
                Read_Question.Close();
                commands.Parameters.Clear();

            }
            catch { }
            commands.Parameters.Clear();


            DateTime Elapsed = new DateTime();
            DateTime Now_Date = new DateTime();
            Now_Date = DateTime.Now;
            Elapsed = Now_Date;

            DataRow dr = table2.NewRow();
            dr["Invite_Date"] = Invite_Date;
            dr["Assign_Date"] = Assign_Date;
            dr["Due_Reivew_Date"] = Due_Reivew_Date;
            dr["Recomendation"] = Recomendation;
            dr["Reviewer_name"] = Reviewer_name;
            dr["Complete_Date"] = Complete_Date;
            dr["Status_Review"] = Status_Review;
            dr["User_No"] = user_no;
            table2.Rows.Add(dr);

        }

        DataView dv = new DataView(table2);

        Total = decimal.Parse(table2.Compute("count(User_No)", "User_No>=0").ToString());
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


    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void GridView1_PageIndexChanged(object sender, EventArgs e)
    {
        Pages_Number.Text = GridView1.PageCount.ToString();
    }
    protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "Edite_Date_Edite_Due")
        {

            Session["Editor_no"] = e.CommandArgument;
            GridView1.Visible = false;
            EditDuedatePanal.Visible = true;
            String Due_Reivew_Date = "";
            int art = Convert.ToInt16(Session["Article_No"]);
            int Editor_no = Convert.ToInt16(Session["Editor_no"]);

            try
            {
                connect.Close();
                connect.Open();
                commands.Connection = connect;
                commands.CommandText = " select Article_Status_Users.User_No,Article_Status_Users.Status_Date from Article_Status_Users where Article_Status_Users.Status_No IN(select Status.Status_No " +
                      "  from Status where Status.Family_Role_No IN (select Family_Role.Family_Role_No from Family_Role " +
                      "  where Family_Role.Family_Role_Name LIKE 'Editor') AND Status.Status_Name LIKE 'Edit Due')" +
                      " AND Article_Status_Users.Article_No=@Article_No AND Article_Status_Users.User_No=@User_No";
                commands.Parameters.Add("@User_No", System.Data.SqlDbType.Int);
                commands.Parameters["@User_No"].Value = Editor_no;
                commands.Parameters.Add("@Article_No", System.Data.SqlDbType.Int);
                commands.Parameters["@Article_No"].Value = art;
                Read_Question = commands.ExecuteReader();
                Read_Question.Read();
                Due_Reivew_Date = Read_Question[1].ToString();
                Read_Question.Close();
                commands.Parameters.Clear();

            }
            catch { }
            EditDueTxt.Text = Due_Reivew_Date.ToString();
        }
    }
    protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
    {


    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        EditDuedatePanal.Visible = false;
        GridView1.Visible = true;
    }
    protected void Button1_Click(object sender, EventArgs e)
    {

        int art = Convert.ToInt16(Session["Article_No"]);
        int Editor_no = Convert.ToInt16(Session["Editor_no"]);
        try
        {
            connect.Close();
            connect.Open();
            commands.Connection = connect;
            commands.CommandText = " update Article_Status_Users  " +
                " set User_No =@User_No,Status_Date=@Status_Date where " +
                " Article_Status_Users.Article_No=@Article_No AND Article_Status_Users.User_No=@User_No AND  Article_Status_Users.Status_No IN(select Status.Status_No " +
                      "  from Status where Status.Family_Role_No IN (select Family_Role.Family_Role_No from Family_Role " +
                      "  where Family_Role.Family_Role_Name LIKE 'Editor') AND Status.Status_Name LIKE 'Edit Due')";
            commands.Parameters.Add("@User_No", System.Data.SqlDbType.Int);
            commands.Parameters["@User_No"].Value = Editor_no;
            commands.Parameters.Add("@Article_No", System.Data.SqlDbType.Int);
            commands.Parameters["@Article_No"].Value = art;
            commands.Parameters.Add("@Status_Date", System.Data.SqlDbType.DateTime);
            commands.Parameters["@Status_Date"].Value = Convert.ToDateTime(EditDueTxt.Text);
            commands.ExecuteNonQuery();


            commands.Parameters.Clear();

        }
        catch { }

        EditDuedatePanal.Visible = false;
        GridView1.Visible = true;
        load();
    }
    protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        int usr_NO = Convert.ToInt16(Session["User_No"]);


        FunctionSumation obUnassign = new FunctionSumation();
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            if (obUnassign.TestPermission(usr_NO, "Manager", "Update Date Due For Editor") == false)
            {
                e.Row.FindControl("Edite_Date_Edite_Due").Visible = false;
            }
        }
    }
}
