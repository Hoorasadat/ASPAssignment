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
            List<SlipDock> LeaseList = new List<SlipDock>();

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
                    LeaseList.Add(SlDk);
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
            return LeaseList;
        }



        // a method to get a list of empty slips from the database:
        public static List<SlipDock> GetDockSlips()
        {
            // make an empty list of slip-dock
            List<SlipDock> DkSlList = new List<SlipDock>();

            // make an empty slip-dock object
            SlipDock SlDk = new SlipDock();

            // get connected to the database
            SqlConnection con = InlandMarinaScriptDB.GetConnection();

            // creating the proper sql query to extract data from MS SQL server
            string Query = "SELECT Dock.ID AS DockID, Name, Slip.ID AS SlipID, Width, Length, WaterService, ElectricalService " +
                "FROM Slip INNER JOIN Dock ON DockID = Dock.ID WHERE Slip.ID NOT IN(SELECT SlipID FROM Lease)";

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
                    DkSlList.Add(SlDk);
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
            return DkSlList;
        }



        // a method to get a list of docks from the database:
        public static List<Dock> GetDocks()
        {
            // make an empty list of docks
            List<Dock> DockList = new List<Dock>();

            // make an empty slip-dock object
            Dock Dk = new Dock();

            // get connected to the database
            SqlConnection con = InlandMarinaScriptDB.GetConnection();

            // creating the proper sql query to extract data from MS SQL server
            string Query = "SELECT ID, Name, WaterService, ElectricalService FROM Dock";

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
                    //assign the column values to the properties of a new slip-dock object
                    Dk = new Dock();
                    Dk.DockId = (int)dr["ID"];
                    Dk.DockName = dr["Name"].ToString();                   
                    Dk.WaterService = (bool)dr["WaterService"];
                    Dk.ElectricalService = (bool)dr["ElectricalService"];

                    // adding the new object to the list of objects
                    DockList.Add(Dk);
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
            return DockList;
        }



        // a method to get a list of available slips for a selected docks from the database:
        public static List<Slip> GetSlips(int Id)
        {
            // make an empty list of slip-dock
            List<Slip> SlipsList = new List<Slip>();

            // make an empty slip-dock object
            Slip SL = new Slip();

            // get connected to the database
            SqlConnection con = InlandMarinaScriptDB.GetConnection();

            // creating the proper sql query to extract data from MS SQL server
            string Query = "SELECT ID, Width, Length, DockID FROM Slip WHERE DockID = @DockID AND ID NOT IN(SELECT SlipID FROM Lease)";

            // creating the proper command to run the query
            SqlCommand comm = new SqlCommand(Query, con);

            comm.Parameters.AddWithValue("@DockID", Id);

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
                    SL = new Slip();
                    SL.SlipId = (int)dr["ID"];
                    SL.Width = (int)dr["Width"];
                    SL.Length = (int)dr["Length"];
                    SL.DockId = (int)dr["DockID"];

                    // adding the new object to the list of objects
                    SlipsList.Add(SL);
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
            return SlipsList;
        }



        // a method to lease a slip(adding to the database):
        public static int InsertLease(int slipId, int customerId)
        {
            int LsID;
            // get connected to the database
            SqlConnection con = InlandMarinaScriptDB.GetConnection();

            // creating the proper sql query to extract data from MS SQL server
            string Query = "INSERT INTO Lease (SlipID, CustomerID) OUTPUT inserted.[ID] " +
                "VALUES(@SlipID, @CustomerID)";

            // creating the proper command to run the query
            SqlCommand comm = new SqlCommand(Query, con);
            comm.Parameters.AddWithValue("@SlipID", slipId);
            comm.Parameters.AddWithValue("@CustomerID", customerId);

            // try to run the command
            try
            {
                con.Open();
                LsID = (int)comm.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
            return LsID;
        }
    }
}
