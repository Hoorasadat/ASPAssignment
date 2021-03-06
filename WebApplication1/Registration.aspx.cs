﻿using BLLClasses;
using DALClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Registration : System.Web.UI.Page
    {
        public Customer cust = new Customer();

        protected void Page_Load(object sender, EventArgs e)
        {
            //check if the user logs in or not
            if (Session["customer"] != null)

                // if not, redirect from the registration page
                Response.Redirect("~/LeaseSlip.aspx");
        }

                protected void btnLogin_Click(object sender, EventArgs e)
        {
            string FN = txtFName.Text;
            string LN = txtLName.Text;

            try
            {
                // make an empty customer object
                Customer cust = new Customer();

                cust = CustomerDA.FindCustomer(FN, LN);
                if (cust == null)
                    lblLogErr.Text = "Either the entered info is not correct or such a user does not exist." +
                        "If you are sure that you have already registered, please get sure that you enter correct info.";

                else
                {
                    lblLogErr.Text = @"You are successfully loged in! If you wish, you can go to the 'Lease Slip page' for a new lease.";

                    Session.Add("customer", cust);

                    hplLease.Visible = true;
                    btnLogin.Visible = false;

                }
                    
            }
            catch (Exception ex)
            {
                throw new Exception("Data error occurred. Contact application support.", ex);
            }
        }


        protected void btnRegister_Click1(object sender, EventArgs e)
        {
            string FN = txtFirstName.Text;
            string LN = txtLastName.Text;
            string PN = txtPhone.Text;
            string CY = txtCity.Text;

            Customer customer = CustomerDA.FindCustomer(FN, LN);

            if (customer == null)
            {
                try
                {
                    // make an empty customer object
                    Customer cust = new Customer();

                    cust.CustomerID = CustomerDA.InsertCustomers(FN, LN, PN, CY);
                    cust.FirstName = FN;
                    cust.LastName = LN;
                    cust.Phone = PN;
                    cust.City = CY;

                    lblRegErr.Text = @"You are successfully Registered! If you wish, you can go to the 'Lease Slip page' for a new lease.";

                    Session.Add("customer", cust);

                    hplLease.Visible = true;
                    btnRegister.Visible = false;

                }

                catch (Exception ex)
                {
                    throw new Exception("Data error occurred. Contact application support.", ex);
                }
            }
            else
                lblRegErr.Text = " You have already registered!";
        }
    }
}