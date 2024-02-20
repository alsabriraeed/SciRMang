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
public partial class MessageManagement : System.Web.UI.Page
{
    FunctionSumation ob = new FunctionSumation();
    SqlConnection connect; 
    SqlCommand commands = new SqlCommand();
    SqlDataReader Read_Question;
    protected void Page_Load(object sender, EventArgs e)
    {
        connect = ob.connect;
        if (!IsPostBack)
        {
            load();
        }
    }
    protected void LinkButton3_Click(object sender, EventArgs e)
    {
        ViewMessageForUpdate();
        txtmessagcontent.Enabled = true;
        update.Enabled = true;
        Messagename.Visible = true;
        Message_Name_Drp.Visible = false;
        lblMessageNameSelect.Visible = false;
        lblMessageName.Visible = true;
        txtmessagcontent.Enabled = true;
    }
    protected void LinkButton2_Click(object sender, EventArgs e)
    {
        txtmessagcontent.ReadOnly = false;

    }
    protected void Button3_Click(object sender, EventArgs e)
    {

    }
    protected void Button5_Click(object sender, EventArgs e)
    {

    }
    protected void Button4_Click(object sender, EventArgs e)
    {

    }
    protected void MessgTypeDrp_DataBound(object sender, EventArgs e)
    {

    }
    void ViewMessageForUpdate()
    {
        // try
        //   {
        connect.Close();
        connect.Open();
        commands.Connection = connect;

        commands.CommandText = "select Messages.Message_No,Messages.Message_Content,Messages.Message_Address " +
            "  from Messages,Messages_Type where Messages.Message_No=@Message_No ";
        commands.Parameters.Add("@Message_No", System.Data.SqlDbType.Int);
        commands.Parameters["@Message_No"].Value = Message_Name_Drp.SelectedItem.Value;

        Read_Question = commands.ExecuteReader();
        Read_Question.Read();
        txtmessagcontent.Text = Read_Question["Message_Content"].ToString();
        TxtMessageAddress.Text = Read_Question["Message_Address"].ToString();
        Session["Message_no"] = (int)Read_Question["Message_No"];
        Read_Question.Close();
        commands.Parameters.Clear();
        Messagename.Text = Message_Name_Drp.SelectedItem.Text;

        // }
        //catch
        // {

        //}
        //finally
        //  {
        //  connect.Close();
        // }
    }
    void ViewMessagedelete()
    {
        // try
        //   {
        connect.Close();
        connect.Open();
        commands.Connection = connect;

        commands.CommandText = "select Messages.Message_No,Messages.Message_Content,Messages.Message_Address " +
            "  from Messages,Messages_Type where Messages.Message_No=@Message_No ";
        commands.Parameters.Add("@Message_No", System.Data.SqlDbType.Int);
        commands.Parameters["@Message_No"].Value = Message_Name_Drp0.SelectedItem.Value;

        Read_Question = commands.ExecuteReader();
        Read_Question.Read();
        txtmessagcontent2.Text = Read_Question["Message_Content"].ToString();
        TxtMessageAddress1.Text = Read_Question["Message_Address"].ToString();
        Session["Message_no1"] = (int)Read_Question["Message_No"];
        Read_Question.Close();
        commands.Parameters.Clear();
        Messagename0.Text = Message_Name_Drp0.SelectedItem.Text;

        // }
        //catch
        // {

        //}
        //finally
        //  {
        //  connect.Close();
        // }

    }
    void load()
    {
        Response.Write("..");

        //message Type


        // try
        //   {

        connect.Close();
        connect.Open();
        commands.Connection = connect;
        commands.CommandText = "select Messages_Type.Message_Type_No,Messages_Type.Message_Type_Name " +
            "  from Messages_Type";
        Read_Question = commands.ExecuteReader();
        MessgTypeDrp.DataSource = Read_Question;
        MessgTypeDrp.DataValueField = "Message_Type_No";
        MessgTypeDrp.DataTextField = "Message_Type_Name";
        MessgTypeDrp.DataBind();


        Read_Question.Close();
        MessgTypeDrp.SelectedIndex = 1;
        commands.CommandText = "select Messages.Message_No,Messages.Message_Name " +
          "  from Messages ";
        Read_Question = commands.ExecuteReader();
        Message_Name_Drp.DataSource = Read_Question;
        Message_Name_Drp.DataValueField = "Message_No";
        Message_Name_Drp.DataTextField = "Message_Name";
        Message_Name_Drp.DataBind();




        Read_Question.Close();
        MessgTypeDrp.SelectedIndex = 1;
        commands.CommandText = "select Messages.Message_No,Messages.Message_Name " +
          "  from Messages ";
        Read_Question = commands.ExecuteReader();
        Message_Name_Drp0.DataSource = Read_Question;
        Message_Name_Drp0.DataValueField = "Message_No";
        Message_Name_Drp0.DataTextField = "Message_Name";
        Message_Name_Drp0.DataBind();
        Read_Question.Close();

        // }
        //catch
        // {

        //}
        //finally
        //  {
        //  connect.Close();
        // }}
    }
    protected void LinkButton10_Click(object sender, EventArgs e)
    {
        ViewMessagedelete();
        txtmessagcontent2.Enabled = true;
        delete.Enabled = true;
        Messagename0.Visible = true;
        Message_Name_Drp0.Visible = false;
        lblMessageNameSelect0.Visible = false;
        lblMessageName0.Visible = true;



    }
    protected void update_Click(object sender, EventArgs e)
    {
        FunctionSumation objectFun = new FunctionSumation();
        int Message_No = Convert.ToInt16(Session["Message_No"]);
        objectFun.updatemessagefun(txtmessagcontent.Text, TxtMessageAddress.Text, Messagename.Text, Message_No);

    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        FunctionSumation objectFun = new FunctionSumation();

        objectFun.addmessagefun(txtmessagcontent1.Text, TxtMessageAddress0.Text, MessgTypeDrp.SelectedItem.Value, Message_Name.Text);

    }
    protected void delete_Click(object sender, EventArgs e)
    {
        FunctionSumation objectFun = new FunctionSumation();
        int Message_No = Convert.ToInt16(Session["Message_No1"]);
        objectFun.deletemessagefun(Message_No);

    }
    protected void LinkButton7_Click(object sender, EventArgs e)
    {
        load();
        txtmessagcontent1.Text = "";
        TxtMessageAddress0.Text = "";
        Message_Name.Text = "";
        Panel1.Visible = true;
        Panel2.Visible = false;
        Panel3.Visible = false;
    }
    protected void LinkButton8_Click(object sender, EventArgs e)
    {
        load();
        txtmessagcontent.Text = "";
        TxtMessageAddress.Text = "";
        Messagename.Text = "";
        Messagename.Visible = false;
        Message_Name_Drp.Visible = true;
        lblMessageName.Visible = false;
        lblMessageNameSelect.Visible = true;
        Panel1.Visible = false;
        Panel2.Visible = false;
        Panel3.Visible = true;
    }
    protected void LinkButton9_Click(object sender, EventArgs e)
    {
        load();
        Messagename0.Visible = false;
        Message_Name_Drp0.Visible = true;
        lblMessageName0.Visible = false;
        lblMessageNameSelect0.Visible = true;
        txtmessagcontent2.Text = "";

        Messagename0.Text = "";
        TxtMessageAddress1.Text = "";
        Panel1.Visible = false;
        Panel2.Visible = true;
        Panel3.Visible = false;
    }
}
