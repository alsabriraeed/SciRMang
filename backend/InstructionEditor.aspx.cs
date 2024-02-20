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
public partial class InstructionEditor : System.Web.UI.Page
{
    FunctionSumation ob = new FunctionSumation();
    SqlConnection connect;
    // SqlCommand commands = new SqlCommand();
    int My_No;
    int art;
    protected void Page_Load(object sender, EventArgs e)
    {
        connect = ob.connect;
        My_No = Convert.ToInt16(Session["User_No"]);

        art = Convert.ToInt16(Session["Article_No"]);


        if (!Page.IsPostBack)
        {
            FunctionSumation obUserName = new FunctionSumation();
            User_Name.Text = obUserName.User_Name(My_No);
            Manuscript_Number.Text = art.ToString();
            String quer = "select Article_User.Lower_User_No,Family_Role.Family_Role_Name,Article_User.User_Order  from Article_User,Family_Role " +
                           " where  Article_User.Family_Role_No = Family_Role.Family_Role_No  AND " +
                        "Article_User.Upper_User_No=@Upper_User_No  AND Assign_Complete =1 " +
                        " AND Article_User.Article_No=@Article_No ";


            SqlCommand comm_Que_Type = new SqlCommand(quer, connect);
            SqlDataAdapter adapter = new SqlDataAdapter(comm_Que_Type);
            comm_Que_Type.Parameters.Add("@Upper_User_No", System.Data.SqlDbType.Int);
            comm_Que_Type.Parameters["@Upper_User_No"].Value = My_No;
            comm_Que_Type.Parameters.Add("@Article_No", System.Data.SqlDbType.Int);
            comm_Que_Type.Parameters["@Article_No"].Value = art;
            DataTable table = new DataTable();
            adapter.Fill(table);
            foreach (DataRow datarow in table.Select())
            {

                String Family_name = datarow["Family_Role_Name"].ToString();
                int Editor_no = (int)datarow["Lower_User_No"];

                Response.Write(Editor_no);
                Reviewer_Blind_Comments_to_Editor.Text = obUserName.commentsFun(Family_name, "Comment To Editor", Editor_no, art);
                Reviewer_Blind_Comments_to_Author.Text = obUserName.commentsFun(Family_name, "Comment To Author", Editor_no, art);
            }

            // }
            // catch
            //  {
            //    Submissions_Under_Review_cont.Text = "(0)";
            //  }
            //finally
            // {
            comm_Que_Type.Parameters.Clear();
            //   connect.Close();
            // }

        }

    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        FunctionSumation obUserName = new FunctionSumation();
        obUserName.inseranswerQuestion("Editor", "Comment To Editor", Reviewer_Blind_Comments_to_Editor.Text, My_No, art);
        obUserName.inseranswerQuestion("Editor", "Comment To Author", Reviewer_Blind_Comments_to_Author.Text, My_No, art);
        Response.Redirect("EditorinCilfDecisionandCommentsforManuscript.aspx");
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        FunctionSumation obUserName = new FunctionSumation();
        obUserName.inseranswerQuestion("Editor", "Comment To Editor", Reviewer_Blind_Comments_to_Editor.Text, My_No, art);
        obUserName.inseranswerQuestion("Editor", "Comment To Author", Reviewer_Blind_Comments_to_Author.Text, My_No, art);
        Response.Redirect("EditorinCilfDecisionandCommentsforManuscript.aspx");
    }
    protected void Reviewer_Blind_Comments_to_Editor_TextChanged(object sender, EventArgs e)
    {

    }
}
