﻿using System;
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

public partial class agree_to_review_conformation : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        DateTime date = new DateTime();

        date = DateTime.Now;
        String current_date = Convert.ToString(date);
        Current_date.Text = current_date;

    }
}