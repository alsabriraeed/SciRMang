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

public partial class Reviewer_Recommendation_and_comments : System.Web.UI.Page
{
    int My_No;

    int art;
    protected void Page_Load(object sender, EventArgs e)
    {


        FunctionSumation obUserName = new FunctionSumation();


        String Rec = obUserName.commentsFun("Reviewer", "Recomendation", My_No, art);
        Overall_Manuscript_Rating.Text = obUserName.commentsFun("Reviewer", "Overall Manuscript  Rating", My_No, art);

        int select_Type = -1;
        foreach (ListItem gg in RecomendationDd.Items)
        {
            select_Type = select_Type + 1;
            if (gg.Text.Equals(Rec))
            {

                RecomendationDd.SelectedIndex = select_Type;

            }
        }


    }


    protected void Reviewer_Blind_Comments_to_Author_TextChanged(object sender, EventArgs e)
    {

    }
    protected void Button7_Click(object sender, EventArgs e)
    {
        //        Reviewer_Blind_Comments_to_Author.Visible = true;
    }
    protected void Button13_Click(object sender, EventArgs e)
    {
        //        Reviewer_Blind_Comments_to_Editor.Visible = true;
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        My_No = Convert.ToInt16(Session["Reviewer_No"]);

        art = Convert.ToInt16(Session["Article_No"]);

        FunctionSumation obUserName = new FunctionSumation();
        obUserName.inseranswerQuestion("Reviewer", "Recomendation", RecomendationDd.SelectedItem.Text, My_No, art);
        obUserName.inseranswerQuestion("Reviewer", "Overall Manuscript  Rating", Overall_Manuscript_Rating.Text, My_No, art);
        Response.Redirect("Reviewer Recommendation and comments for Menuscript Number2.aspx");
    }

    protected void Button3_Click(object sender, EventArgs e)
    {

    }

    protected void Button14_Click(object sender, EventArgs e)
    {
        Response.Redirect("ReviewerInstructioForm.aspx");
    }

    protected void Button12_Click(object sender, EventArgs e)
    {
        Response.Redirect("Instruction Reviewer Comments.aspx");
    }
}
