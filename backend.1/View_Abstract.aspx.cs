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
public partial class View_Abstract : System.Web.UI.Page
{
    FunctionSumation ob = new FunctionSumation();
    SqlConnection connect; 
    SqlCommand commands = new SqlCommand();
    SqlDataReader Read_Question;
    protected void Page_Load(object sender, EventArgs e)
    {
        connect = ob.connect;
        int art = Convert.ToInt16(Session["Article_No"]);

        try
        {
            connect.Close();
            connect.Open();
            commands.Connection = connect;
            commands.CommandText = " select Articles.Article_Abstract from Articles where Articles.Article_No=@Article_No  ";
            commands.Parameters.Add("@Article_No", System.Data.SqlDbType.Int);
            commands.Parameters["@Article_No"].Value = art;
            Read_Question = commands.ExecuteReader();
            Read_Question.Read();
            AbstractArticle.Text = Convert.ToString(Read_Question["Article_Abstract"]);

        }
        catch
        {

        }
        finally
        {
            commands.Parameters.Clear();
            connect.Close();
        }





    }
    protected void Button1_Click(object sender, EventArgs e)
    {

    }
}
