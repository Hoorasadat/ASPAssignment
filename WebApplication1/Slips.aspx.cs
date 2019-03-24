using BLLClasses;
using DALClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Slip : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // make an empty list of slip-dock
            List<SlipDock> DkSlList = new List<SlipDock>();

            DkSlList = SlipDockDA.GetDockSlips();

            grdSlips.DataSource = DkSlList;
            DataBind();
        }
    }
}