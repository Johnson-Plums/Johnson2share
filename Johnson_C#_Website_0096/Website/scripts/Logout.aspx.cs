﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace travelWebsite.scripts
{
    //Author: Josh, Wei, Johnson
    //Time: May 23, 2019
  // log out
    public partial class Logout : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Cookies["custUsername"].Expires = DateTime.Now.AddDays(-1);
            Session.Abandon();
            Response.Redirect("../Index.aspx");
        }
    }
}