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
public partial class FileInventory : System.Web.UI.Page
{
    FunctionSumation ob = new FunctionSumation();
    SqlConnection connect;

    protected void Page_Load(object sender, EventArgs e)
    {
        connect = ob.connect;
        int article_No = Convert.ToInt16(Session["Article_No"]);
        //    try
        //   {

        connect.Close();
        connect.Open();

        SqlDataReader reader;

        SqlCommand Attach_file_comm = new SqlCommand("select File_No ,File_Order,File_Description,File_Name,File_Size,File_Last_Modified,File_Links_Dowenload,File_Type.File_Type_Name from Attach_Files,File_Type where Article_No=@Article_No" +
            " AND File_Type.File_Type_No=Attach_Files.File_Type_No", connect);
        Attach_file_comm.Parameters.Add("@Article_No", System.Data.SqlDbType.Int);
        Attach_file_comm.Parameters["@Article_No"].Value = article_No;
        connect.Close();
        connect.Open();
        reader = Attach_file_comm.ExecuteReader();

        GridView_File.DataSource = reader;
        GridView_File.DataBind();

        connect.Close();

        //    }
        //        catch
        //       {

        //    }
        //      finally
        //    {
        //         commands.Parameters.Clear();
        //      connect.Close();
        //    }
    }
    protected void GridView_File_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void GridView_File_RowCommand(object sender, GridViewCommandEventArgs e)
    {

    }
}
