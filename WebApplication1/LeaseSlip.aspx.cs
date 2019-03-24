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
        // a public current customer
        public Customer Cust = new Customer();
        public int CustId = 0;

        public int SlId = 0;

        protected void Page_Load(object sender, EventArgs e)
        {
            //check if the user logs in or not
            if (Session["customer"] == null)

                // if not, redirect to the registration page
                Response.Redirect("~/Registration.aspx");
            else
            {
                //finding the loged-in user's 
                Cust = (Customer)Session["customer"];
                CustId = Cust.CustomerID;

                //****************************************************

                DisplayeOldLeas();

                //****************************************************

                // make an empty list of docks
                List<Dock> DockList = new List<Dock>();

                // make a table of all docks
                DockList = SlipDockDA.GetDocks();
                grdDock.DataSource = DockList;
                grdDock.DataBind();

                //****************************************************

            }
        }

        private void DisplayeOldLeas()
        {
            // make an empty list of slip - dock
            List<SlipDock> SDList = new List<SlipDock>();

            // make a table of previouse leases of the loged-in user
            SDList = SlipDockDA.GetLeases(CustId);
            grdLeases.DataSource = SDList;
            grdLeases.DataBind();

            //grdLeases.Columns["DockID"].HeaderText = "Dock #";
            //grdLeases.Columns["Name"].HeaderText = "Dock Name";
        }

        protected void grdDock_SelectedIndexChanged1(object sender, EventArgs e)
        {
            GridViewRow row = grdDock.SelectedRow;
            int Id = Convert.ToInt32(row.Cells[1].Text);

            // make an empty list of slips and fill it with a dock's empty slips
            var SlipList = SlipDockDA.GetSlips(Id);
            grdSlip.DataSource = SlipList;
            grdSlip.DataBind();
        }



        protected void grdSlip_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow row = grdSlip.SelectedRow;
            int SlId = Convert.ToInt32(row.Cells[1].Text);            
        }



        protected void btnLease_Click(object sender, EventArgs e)
        {
            if (SlId != 0)
            {
                // add a new lease
                int leaseID = 0;
                leaseID = SlipDockDA.InsertLease(SlId, CustId);

                // fill a label box with a message
                if (leaseID == 0)
                    lblLease.Text = "You successfully lease a slip.";
                else
                    lblLease.Text = "You couldn't lease a slip! Call us to help you.";

                // refresh
                DisplayeOldLeas();
            }
            else
                lblLease.Text = "Select a slip before pressing the lease button!";

        }
    }
}