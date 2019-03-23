using BLLClasses;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALClasses
{
    public class SlipDockDA
    {
        // a method to get a list of leased slips for a specific customer from the database:
        public static List<SlipDock> GetLeases(int Id)
        {
            // make an empty list of slip-dock
            List<SlipDock> SDList = new List<SlipDock>();

            // make an empty slip-dock object
            SlipDock SlDk = new SlipDock();

            // get connected to the database
            SqlConnection con = InlandMarinaScriptDB.GetConnection();

            // creating the proper sql query to extract data from MS SQL server
            string Query = "SELECT Dock.ID AS DockID, Name, Slip.ID AS SlipID, Width, Length, WaterService, ElectricalService FROM Slip " +
                "INNER JOIN Dock ON DockID = Dock.ID INNER JOIN Lease ON SlipID = Slip.ID WHERE CustomerID = @CustomerID";

            // creating the proper command to run the query
            SqlCommand comm = new SqlCommand(Query, con);

            comm.Parameters.AddWithValue("@CustomerID", Id);

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
                    //assign the column values to the properties of a new slip-dock object
                    SlDk = new SlipDock();
                    SlDk.DockId = (int)dr["DockID"];
                    SlDk.DockName = dr["Name"].ToString();
                    SlDk.SlipId = (int)dr["SlipID"];
                    SlDk.Width = (int)dr["Width"];
                    SlDk.Length = (int)dr["Length"];
                    SlDk.WaterService = (bool)dr["WaterService"];
                    SlDk.ElectricalService = (bool)dr["ElectricalService"];

                    // adding the new object to the list of objects
                    SDList.Add(SlDk);
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
            return SDList;
        }
    }
}
