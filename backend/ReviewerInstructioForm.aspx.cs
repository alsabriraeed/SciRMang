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
public partial class ReviewerInstructioForm : System.Web.UI.Page
{


    int My_No;

    FunctionSumation ob = new FunctionSumation();
    SqlConnection connect;
    SqlCommand commands = new SqlCommand();
    //  SqlDataReader Read_Question;


    protected void Page_Load(object sender, EventArgs e)
    {
        connect = ob.connect;
        My_No = Convert.ToInt16(Session["User_No"]);

        int art = Convert.ToInt16(Session["Article_No"]);


        if (!Page.IsPostBack)
        {
            FunctionSumation obUserName = new FunctionSumation();
            User_Name.Text = obUserName.User_Name(My_No);
            Manuscript_Number.Text = art.ToString();




        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {

    }
}
