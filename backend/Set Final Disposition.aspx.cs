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
public partial class Set_Final_Disposition : System.Web.UI.Page
{
    int User_no = 1;
    FunctionSumation ob = new FunctionSumation();
    SqlConnection connect; 
    SqlCommand commands = new SqlCommand();
    SqlDataReader Read_Question;
    protected void Page_Load(object sender, EventArgs e)
    {
        connect = ob.connect;


    }
    protected void CmdClose0_Click(object sender, EventArgs e)
    {
        int art = Convert.ToInt16(Session["Article_No"]);
        //  try
        //  {
        connect.Close();
        connect.Open();
        commands.Connection = connect;

        commands.CommandText = " update Articles " +
           " set  Article_Final_Disposition_term =@Article_Final_Disposition_term  where Articles.Article_No=@Article_No";

        commands.Parameters.Add("@Article_Final_Disposition_term", System.Data.SqlDbType.VarChar, 50);
        commands.Parameters["@Article_Final_Disposition_term"].Value = Final_Dispositiondropdown.SelectedItem.Value;
        commands.Parameters.Add("@Article_No", System.Data.SqlDbType.Int);
        commands.Parameters["@Article_No"].Value = art;
        commands.ExecuteNonQuery();
        connect.Close();

        // }
        // catch
        // {

        //  }
        //  finally
        // {
        //     commands.Parameters.Clear();
        //     connect.Close();
        //   }

        DateTime time = new DateTime();
        time = DateTime.Now;
        //  try
        //   {

        connect.Open();
        commands.CommandText = "select Status.Status_No from  Status where  " +
                               "  Status.Status_Name =@Status_Name";

        commands.Parameters.Add("@Status_Name", System.Data.SqlDbType.VarChar);
        commands.Parameters["@Status_Name"].Value = Final_Dispositiondropdown.SelectedItem.Value;
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
        commands.Parameters["@User_No"].Value = User_no;
        commands.Parameters.Add("@Status_Date", System.Data.SqlDbType.DateTime);
        commands.Parameters["@Status_Date"].Value = time;
        commands.Parameters.Add("@Article_No", System.Data.SqlDbType.Int);
        commands.Parameters["@Article_No"].Value = art;
        commands.ExecuteNonQuery();
        commands.Parameters.Clear();

        commands.CommandText = " update Current_Status " +
            " set Current_Status_Name =@Current_Status_Name,Current_Status_Date=@Current_Status_Date " +
            " where   Current_Status.Article_No=@Article_No";

        commands.Parameters.Add("@Current_Status_Date", System.Data.SqlDbType.DateTime);
        commands.Parameters["@Current_Status_Date"].Value = time;

        commands.Parameters.Add("@Current_Status_Name", System.Data.SqlDbType.VarChar, 50);
        commands.Parameters["@Current_Status_Name"].Value = Final_Dispositiondropdown.SelectedItem.Value;

        commands.Parameters.Add("@Article_No", System.Data.SqlDbType.Int);
        commands.Parameters["@Article_No"].Value = art;
        commands.ExecuteNonQuery();


        //  }




        //   catch
        //  {
        //  }
        // finally
        // {
        //    connect.Close();
        // }


    }
}
