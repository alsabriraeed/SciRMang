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
public partial class new_reviewer_invitation : System.Web.UI.Page
{
    int usr_NO;
    decimal Total;
    FunctionSumation ob = new FunctionSumation();
    SqlConnection connect; 
    SqlCommand commands = new SqlCommand();
    SqlDataReader Read_Question;
    protected void Page_Load(object sender, EventArgs e)
    {
        connect = ob.connect;
        usr_NO = Convert.ToInt16(Session["Reviewer_No"]);
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

        //^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^NEW INVITATION^^^^^^^^^^^^^^^^^^^^^^
        try
        {
            connect.Close();
            connect.Open();
            commands.Connection = connect;
            String quer = " select Article_Information.Article_No,editor_Name.User_Name,Article_Information.Article_Full_Title,Article_Information.Article_Keywords " +
                    " , Current_Status.Current_Status_Date,Current_Status.Current_Status_Name , Status_Date,Article_Type_Name from  Current_Status,  " +
                    " (select Article_No ,Article_Full_Title,Article_Keywords from Articles   " +
                 " where Articles.Article_No  IN " +
               " ( select  Article_User.Article_No from Article_User where Article_User.Lower_User_No =@Lower_User_No " +
               " AND Article_User.Family_Role_No IN(select Family_Role.Family_Role_No from Family_Role where Family_Role.Family_Role_Name LIKE 'Reviewer'  ))    " +
                     " AND Articles.Article_No  IN " +
                     "( select Article_Status_Users.Article_No  from Article_Status_Users where Article_Status_Users.Status_No " +
                     " IN ( select  Status.Status_No  from Status where Status.Family_Role_No IN  " +
                     " ( select Family_Role.Family_Role_No from Family_Role where Family_Role.Family_Role_Name LIKE 'Reviewer' ) " +
                     " AND Status.Status_Name LIKE 'Reviewers Invite'  )AND Article_Status_Users.User_No=@User_No)  " +
                        " AND Articles.Article_No NOT IN " +
                     "( select Article_Status_Users.Article_No  from Article_Status_Users where Article_Status_Users.Status_No " +
                     " IN ( select  Status.Status_No  from Status where Status.Family_Role_No IN  " +
                     " ( select Family_Role.Family_Role_No from Family_Role where Family_Role.Family_Role_Name LIKE 'Reviewer' ) " +
                     " AND Status.Status_Name LIKE 'Reviewers Assign'  OR Status.Status_Name LIKE 'Decline review'  )AND Article_Status_Users.User_No=@User_No) ) Article_Information , " +

                            "(select  Users.User_Name,Article_User.Article_No  from Users,Article_User,Family_Role where Users.User_No=Article_User.Upper_User_no AND " +
                         " Article_User.Lower_User_No=@Lower_User_No AND  Article_User.Family_Role_No=Family_Role.Family_Role_No AND Family_Role.Family_Role_Name LIKE 'Reviewer' )editor_Name ," +

                    " ( select Article_Status_Users.Article_No,Article_Status_Users.Status_Date   from Article_Status_Users where Article_Status_Users.Status_No " +
                             " IN ( select  Status.Status_No  from Status where Status.Family_Role_No IN  " +
                             " ( select Family_Role.Family_Role_No from Family_Role where Family_Role.Family_Role_Name LIKE 'Reviewer' ) " +
                             " AND Status.Status_Name LIKE 'Reviewers Invite'  ) AND Article_Status_Users.User_No=@User_No ) invite_date , " +

                     "(select  Article_Types.Article_Type_Name,Articles.Article_No from  Article_Types,Articles " +
                     "  where   Article_Types.Article_Type_No = Articles.Article_Type_No   ) article_type " +
                     " where Current_Status.Article_No=Article_Information.Article_No AND Article_Information.Article_No=article_type.Article_No " +
                     " AND editor_Name.Article_No = Article_Information.Article_No" +
                     " AND Article_Information.Article_No=invite_date.Article_No  ";




            SqlCommand comm_Que_Type = new SqlCommand(quer, connect);
            SqlDataAdapter adapter = new SqlDataAdapter(comm_Que_Type);
            comm_Que_Type.Parameters.Add("@User_No", System.Data.SqlDbType.Int);
            comm_Que_Type.Parameters["@User_No"].Value = usr_NO;
            comm_Que_Type.Parameters.Add("@Lower_User_No", System.Data.SqlDbType.Int);
            comm_Que_Type.Parameters["@Lower_User_No"].Value = usr_NO;
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

        }
        catch
        {

        }
        finally
        {
            commands.Parameters.Clear();
            connect.Close();
        }
        //END^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^NEW INVITATION^^^^^^^^^^^^^^^^^^^^^^
    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void GridView1_SelectedIndexChanged1(object sender, EventArgs e)
    {

    }
    protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "View_Submation")
        {

            Session["Article_No"] = e.CommandArgument;
            Response.Redirect("View Submission.aspx");
        }
        if (e.CommandName == "Agree_to_Review")
        {
            Session["Article_No"] = e.CommandArgument;
            int Article_no = Convert.ToInt16(Session["Article_No"]);
            DateTime time = new DateTime();
            time = DateTime.Now;
            //  try
            //  {           //   Assign_date

            connect.Open();

            commands.Connection = connect;
            commands.CommandText = "select Status.Status_No from  Status where  " +
                                   "  Status.Status_Name LIKE 'Reviewers Assign'";
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
            commands.Parameters["@User_No"].Value = usr_NO;
            commands.Parameters.Add("@Status_Date", System.Data.SqlDbType.DateTime);
            commands.Parameters["@Status_Date"].Value = time;
            commands.Parameters.Add("@Article_No", System.Data.SqlDbType.Int);
            commands.Parameters["@Article_No"].Value = Article_no;
            commands.ExecuteNonQuery();
            commands.Parameters.Clear();
            //  end  Assign_date

            //   Due_date
            Read_Question.Close();
            DateTime timeNow = new DateTime();
            timeNow = DateTime.Now;
            //connect.Open();
            commands.CommandText = "select Status.Status_No from  Status where  " +
                                   "  Status.Status_Name LIKE 'Review Due'";
            Read_Question = commands.ExecuteReader();
            Read_Question.Read();
            int Status_Nomb = (int)Read_Question[0];
            Read_Question.Close();
            commands.Parameters.Clear();
            commands.CommandText = "select Article_Types.Number_Days_To_Review from  Article_Types,Articles where  " +
                                 " Article_Types.Article_Type_No=Articles.Article_Type_No AND Articles.Article_No=@Article_No ";
            commands.Parameters.Add("@Article_No", System.Data.SqlDbType.Int);
            commands.Parameters["@Article_No"].Value = Article_no;
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
            commands.Parameters["@User_No"].Value = usr_NO;
            commands.Parameters.Add("@Status_Date", System.Data.SqlDbType.DateTime);
            commands.Parameters["@Status_Date"].Value = Due_Date;
            commands.Parameters.Add("@Article_No", System.Data.SqlDbType.Int);
            commands.Parameters["@Article_No"].Value = Article_no;
            commands.ExecuteNonQuery();
            commands.Parameters.Clear();
            //  end  Due_date





            //   }




            //catch
            // {
            //}
            // finally
            // {
            //  connect.Close();
            // }




            Response.Redirect("agree to review conformation.aspx");
        }
        //9999999999999999999999999999999999999999999999
        if (e.CommandName == "Decline_to_Review")
        {
            Session["Article_No"] = e.CommandArgument;
            int Article_no = Convert.ToInt16(Session["Article_No"]);
            DateTime time = new DateTime();
            time = DateTime.Now;
           // try
    //        {
               
                connect.Open();
                commands.Connection = connect;
                commands.CommandText = "select Status.Status_No from  Status where  " +
                                       "  Status.Status_Name LIKE 'Decline review'";
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
                commands.Parameters["@User_No"].Value = usr_NO;
                commands.Parameters.Add("@Status_Date", System.Data.SqlDbType.DateTime);
                commands.Parameters["@Status_Date"].Value = time;
                commands.Parameters.Add("@Article_No", System.Data.SqlDbType.Int);
                commands.Parameters["@Article_No"].Value = Article_no;
                commands.ExecuteNonQuery();
                commands.Parameters.Clear();

      //      }




        //    catch
          //  {
            //}
     //       finally
       //     {
         //       connect.Close();
           // }




            Response.Redirect("DeclineInvitation.aspx");
        }
        //0000000000000000000000000000000000000000
        if (e.CommandName == "View_Abstract")
        {

            Session["Article_No"] = e.CommandArgument;
            Response.Redirect("View_Abstract.aspx");
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
}