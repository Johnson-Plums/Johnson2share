using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace travelWebsite
{ //Author: Josh, Wei, Johnson
  //Time: May 23, 2019
    // The packages page that will display the currently available packages in the database
    public partial class Packages : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }
        protected void DataList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataList1.DataBind();
            Session["lastPckgVw"] = ((Label)DataList1.SelectedItem.FindControl("PackageIdLabel")).Text;
            Response.Redirect("ConfirmOrder.aspx");
        }
    }
}