using BLLClasses;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALClasses
{
    class CustomerDA
    {
        // a method to get a list of customers from the database:
        public static List<Customer> GetCustomers()
        {
            // make an empty list of customers
            List<Customer> CustList = new List<Customer>();

            // make an empty customer object
            Customer cust;

            // get connected to the database
            SqlConnection con = InlandMarinaScriptDB.GetConnection();

            // creating the proper sql query to extract data from MS SQL server
            string Query = "SELECT * FROM Customer";

            // creating the proper command to run the query
            SqlCommand comm = new SqlCommand(Query, con);

            // try to run the command
            try
            {
                // opening the connection
                con.Open();

                // creating a sql data reader and run it to read the data from the database
                SqlDataReader dr = comm.ExecuteReader();

                // read line by line as much as there is something to read
                while (dr.Read())
                {
                    // for each line of the returned rows of data from database, 
                    //assign the column values to the properties of a new customer object
                    cust = new Customer();
                    cust.CustomerID = (Int32)dr["Id"];
                    cust.FirstName = dr["FirstName"].ToString();
                    cust.LastName = dr["LastName"].ToString();
                    cust.Phone = dr["Phone"].ToString();
                    cust.City = dr["City"].ToString();

                    // adding the new object to the list of objects
                    CustList.Add(cust);
                }                
                dr.Close(); // closing the data reader
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
            return CustList;
        }

    }
}
