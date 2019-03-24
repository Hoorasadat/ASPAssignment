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
            // check if the user logs in or not
            //if (Session["customer"] == null)

            //    // if not, redirect to the registration page
            //    Response.Redirect("~/Registration.aspx");
            //else
            //{
            //****************************************************
            // finding the loged-in user's ID
            //Customer Cust = new Customer();
            //Cust = (Customer)Session["customer"];
            //int ID = Cust.CustomerID;
            int ID = 1;
                //****************************************************
                // make an empty list of slip - dock
                List<SlipDock> SDList = new List<SlipDock>();

                // make a table of previouse leases of the loged-in user
                SDList = SlipDockDA.GetLeases(ID);
                grdLeases.DataSource = SDList;
                grdLeases.DataBind();

            //grdLeases.Columns["DockID"].HeaderText = "Dock #";
            //grdLeases.Columns["Name"].HeaderText = "Dock Name";

            //****************************************************
            // make an empty list of docks
            List<Dock> DockList = new List<Dock>();

            // make a table of all docks
            DockList = SlipDockDA.GetDocks();
            grdDock.DataSource = DockList;
            grdDock.DataBind();

            //****************************************************

            //}
        }

        protected void grdDock_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow row = grdDock.SelectedRow;
            int Id = Convert.ToInt32(row.Cells[1].Text);

            // make an empty list of docks
            List<Slip> SlipList = new List<Slip>();

            // make a table of all docks
            SlipList = SlipDockDA.GetSlips(Id);
            grdSlip.DataSource = SlipList;
            grdSlip.DataBind();
        }
    }
}