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
public partial class View_Reviewer_Commentsaspx : System.Web.UI.Page
{
   
    DataTable table1 = new DataTable();

    FunctionSumation ob = new FunctionSumation();
    SqlConnection connect;
    SqlCommand commands = new SqlCommand();
    SqlDataReader Read_Question;
    protected void Page_Load(object sender, EventArgs e)
    {
        int art = Convert.ToInt16(Session["Article_No"]);
        connect = ob.connect;
        int My_No = Convert.ToInt16(Session["User_No"]);




        if (!IsPostBack)
        {

            Article_No.Text = art.ToString();
            load();

        }


    }

    void load()
    {
        DataTable table2 = new DataTable();
        int art = Convert.ToInt16(Session["Article_No"]);

        table2.Columns.Add("Family_Role", typeof(String));
        table2.Columns.Add("User_order", typeof(String  ));
        table2.Columns.Add("User_No", typeof(int ));
        table2.Columns.Add("Recommendation", typeof(String ));

        String querE = "select Article_User.Lower_User_No,Article_User.User_Order,Family_Role.Family_Role_Name from Article_User,Family_Role where Article_User.Family_Role_No =Family_Role.Family_Role_No " +
            " AND Article_User.Article_No=@Article_No AND Assign_Complete=1  ";

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
           
            String Family_Role = datarow["Family_Role_Name"].ToString();
            
            string   User_order = datarow["User_Order"].ToString();
            String Recommendation = "";
            
           

         try
           {
                connect.Close();
                connect.Open();
                commands.Connection = connect;
                commands.CommandText = " select Question_Answer.AnswerContent from Question_Answer,Questions," +
                     " Decision_and_comments_Type,Decision_and_comments where " +
                        " Question_Answer.QuestionNo=Questions.QuestionNo " +
                        " AND Questions.QuestionContent LIKE 'Recomendation' AND Questions.Dec_Com_No=" +
                        "Decision_and_comments.Dec_Com_No AND Question_Answer.UserNO=@UserNO AND Question_Answer.ArticleNO=@ArticleNO ";
                commands.Parameters.Add("@UserNO", System.Data.SqlDbType.Int);
                commands.Parameters["@UserNO"].Value = user_no;
                commands.Parameters.Add("@ArticleNO", System.Data.SqlDbType.Int);
                commands.Parameters["@ArticleNO"].Value = art;
                Read_Question = commands.ExecuteReader();
                Read_Question.Read();
                Recommendation = Read_Question[0].ToString();
               
                Read_Question.Close();
                commands.Parameters.Clear();

            }
         catch
         {
             Read_Question.Close();
             commands.Parameters.Clear();
         }


        

            DataRow  dr = table2.NewRow();
            dr["Family_Role"] = Family_Role;
            dr["User_order"] = User_order;
            dr["User_No"] = user_no;
            dr["Recommendation"] = Recommendation;
            table2.Rows.Add(dr);
        }

        DataView dv = new DataView(table2);


        if (dv.Count != 0)
        {
          
            if (!this.SortField.Equals(String.Empty))
            {
                string strDirect = String.Empty;
                if (this.SortDirection.Equals("D"))
                    strDirect = " DESC";

                dv.Sort = SortField + strDirect;
            }

            this.GridView1 .DataSource  = dv;
            this.GridView1.DataBind();        }   }



    protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GridView1.PageIndex = e.NewPageIndex;
        load();

        int Current1_Page = (int)e.NewPageIndex;
        Current1_Page += 1;
       
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
        
    }
    protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "view_Review")
        {

            Session["user_no"] = e.CommandArgument;
            Response.Redirect("View Any Review.aspx");
        }
       
    }
    protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
    {


    }

    protected void Button2_Click(object sender, EventArgs e)
    {
       
    }
    protected void Button1_Click(object sender, EventArgs e)
    {

    }
    protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
    {


      
    }
}
