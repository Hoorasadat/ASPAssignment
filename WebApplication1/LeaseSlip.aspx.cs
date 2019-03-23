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
    public partial class LeaseSlip : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["customer"] == null)
                Response.Redirect("~Registration.aspx");
            else
            {
                Customer Cust = new Customer();
                Cust = (Customer)Session["customer"];
                int ID = Cust.CustomerID;
                // make an empty list of slip - dock
                List<SlipDock> SDList = new List<SlipDock>();
                SDList = SlipDockDA.GetLeases(ID);
                grdLeases.DataSource = SDList;
                DataBind();

                //grdLeases.Columns["DockID"].HeaderText = "Dock #";
                //grdLeases.Columns["Name"].HeaderText = "Dock Name";

            }
        }
    }
}