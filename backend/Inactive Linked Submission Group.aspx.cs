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
public partial class Inactive_Linked_Submission_Group : System.Web.UI.Page
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
        String quer = " select editor_Name.User_Name,Author_name.User_Name AS author_name,Article_Information.Article_No,Group_Name.Linked_Submission_Group_Name," +
                           "submitted_date.Status_Date AS submitted_Date,Article_Information.Article_Full_Title,Article_Information.Article_Keywords " +
                " , Current_Status.Current_Status_Date ,Current_Status.Current_Status_Name ,Article_Type_Name from  Current_Status,  " +
                " (select Articles.Article_No ,Articles.Article_Full_Title,Articles.Article_Keywords from Articles" +

             " where Articles.Article_No IN(select  Linked_submission_Article.Article_No  from Linked_submission_Article where Linked_submission_Article.Linked_Submission_Group_No " +
            " IN(select  Linked_Submission_Group.Linked_Submission_Group_No from Linked_Submission_Group  where Linked_Submission_Group.Linked_Submission_Group_Status=0 ))     " +
                             ")Article_Information, " +

              "(select  Linked_submission_Article.Article_No,Linked_Submission_Group.Linked_Submission_Group_Name " +
             " from Linked_submission_Article,Linked_Submission_Group where Linked_submission_Article.Linked_Submission_Group_No=Linked_Submission_Group.Linked_Submission_Group_No )Group_Name, " +

                    "( select Article_Status_Users.Article_No,Article_Status_Users.Status_Date  from Article_Status_Users,Family_Role,Status where Article_Status_Users.Status_No " +
                 " = Status.Status_No AND Status.Family_Role_No =Family_Role.Family_Role_No AND Family_Role.Family_Role_Name LIKE 'Author'  " +
                 " AND Status.Status_Name LIKE 'Submitted')submitted_date , " +


                 "(select DISTINCT Users.User_Name,Linked_submission_Article.Article_No  from Users,Linked_submission_Article where " +
                 " Users.User_No=Linked_submission_Article.User_No  )editor_Name ," +

                 "(select  Users.User_Name,Articles.Article_No  from Users,Articles where  Articles.Article_Corresponding_Author_No=Users.User_No  )Author_name ," +





                 "(select  Article_Types.Article_Type_Name,Articles.Article_No from  Article_Types,Articles " +
                 "  where   Article_Types.Article_Type_No = Articles.Article_Type_No   ) article_type " +

                 " where Current_Status.Article_No=Article_Information.Article_No " +
                  "AND Article_Information.Article_No=article_type.Article_No " +
                  "AND Article_Information.Article_No=Group_Name.Article_No " +

                 " AND editor_Name.Article_No = Article_Information.Article_No  " +

                 " AND submitted_date.Article_No=Article_Information.Article_No " +
                 " AND Author_name.Article_No=Article_Information.Article_No  ";



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
        if (e.CommandName == "View_Submation")
        {

            Session["Article_No"] = e.CommandArgument;
            Response.Redirect("View Submission.aspx");
        }
        if (e.CommandName == "Remove_from_Group")
        {

            Session["Article_No"] = e.CommandArgument;
            DeleteSubmissionFromGroup();
            load1();
        }
    }
    void DeleteSubmissionFromGroup()
    {
        int art = Convert.ToInt16(Session["Article_No"]);
        // try
        //   {

        connect.Close();
        connect.Open();
        command.Connection = connect;
        command.CommandText = "delete from  Linked_submission_Article where Linked_submission_Article.Article_No=@Article_No ";
        command.Parameters.Add("@Article_No", System.Data.SqlDbType.Int);
        command.Parameters["@Article_No"].Value = art;
        command.ExecuteNonQuery();
        connect.Close();

        command.Parameters.Clear();

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
}
