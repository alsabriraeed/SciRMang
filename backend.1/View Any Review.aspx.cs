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
public partial class View_Any_Review : System.Web.UI.Page
{

    int My_No; int art;
    protected void Page_Load(object sender, EventArgs e)
    {


        My_No = Convert.ToInt16(Session["user_no"]);

        art = Convert.ToInt16(Session["Article_No"]);


        if (!Page.IsPostBack)
        {
            FunctionSumation obUserName = new FunctionSumation();
            User_Name.Text = obUserName.User_Name(My_No);
            Manuscript_Number.Text = art.ToString();
            Reviewer_Blind_Comments_to_Editor.Text = obUserName.commentsFunOverall("Comment To Editor", My_No, art);
            Reviewer_Blind_Comments_to_Author.Text = obUserName.commentsFunOverall("Comment To Author", My_No, art);




        }

    }
    protected void Reviewer_Blind_Comments_to_Author_TextChanged(object sender, EventArgs e)
    {

    }


    protected void Button2_Click(object sender, EventArgs e)
    {
      
        Response.Redirect("View Reviewer Commentsaspx.aspx");
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
    
        Response.Redirect("View Reviewer Commentsaspx.aspx");
    }
    protected void Reviewer_Blind_Comments_to_Editor_TextChanged(object sender, EventArgs e)
    {

    }
}
