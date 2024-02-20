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
public partial class remove : System.Web.UI.Page
{  FunctionSumation ob = new FunctionSumation();
    SqlConnection connect;
 
   SqlCommand comm1 = new SqlCommand();

    protected void Page_Load(object sender, EventArgs e)
    {

        connect = ob.connect;

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        comm1.Connection = connect;
        connect.Close();
        connect.Open();
        comm1.CommandText = "delete  from  Article_User ";
        comm1.ExecuteNonQuery();

        connect.Close();
    }
}
