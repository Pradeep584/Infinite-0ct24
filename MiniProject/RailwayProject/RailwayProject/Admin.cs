using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace RailwayProject
{
    class Admin
    {
        public static SqlConnection conn = null;
        public static SqlCommand cmd = null;
        public static IDataReader dr = null;


        public static void Admin_block()
        {
            Console.WriteLine("Select one from below options");
            Console.WriteLine("1.Add Trains");
            Console.WriteLine("2.Modify Trains");
            Console.WriteLine("3.Delete Trains");

            Console.WriteLine("Enter your choice: ");
            int AdminChoice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("-----------------------------------------");
            switch (AdminChoice)
            {
                case 1:
                    AddTrain();
                    break;
                case 2:
                    ModifyTrain();
                    break;
                case 3:
                    DeleteTrain();
                    break;
                default:
                    Console.WriteLine("You selected Invalid option");
                    break;
            }

        }
        public static void AddTrain()
        {

            Console.WriteLine("Please enter the Train Number");
            int TrainNo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter Train Name");
            string TrainName = Console.ReadLine();

            Console.WriteLine("Starting point of station");
            string FromStation = Console.ReadLine();

            Console.WriteLine("Ending point of the station");
            string ToStation = Console.ReadLine();

            Console.WriteLine("Enter The Class Type");
            String ClassType = Console.ReadLine();

            Console.WriteLine("Enter the Status of the train");
            String Status = Console.ReadLine();

            Console.WriteLine("Enter the ticket price");
            int TicketPrice = Convert.ToInt32(Console.ReadLine());


            conn = new SqlConnection("Data Source = ICS-LT-D244D6D0; database = RailwayProject; trusted_connection = true");
            conn.Open();

            cmd = new SqlCommand("sp_Add_Trains", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@TrainNo", TrainNo);
            cmd.Parameters.AddWithValue("@TrainName", TrainName);
            cmd.Parameters.AddWithValue("@FromStation", FromStation);
            cmd.Parameters.AddWithValue("@ToStation", ToStation);
            cmd.Parameters.AddWithValue("@ClassType", ClassType);
            cmd.Parameters.AddWithValue("@Status", Status);
            cmd.Parameters.AddWithValue("@TicketPrice", TicketPrice);
            cmd.ExecuteNonQuery();
            Console.WriteLine("Train added successfully");

        }


        public static void ModifyTrain()
        {
            Console.WriteLine("Enter Train Number to Modify:");
            int TrainNo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Train Name to Modify");
            string TrainName = Console.ReadLine();

            Console.WriteLine("Enter the Station Name to Modify");
            string FromStation = Console.ReadLine();

            Console.WriteLine("Enter the Station Name to Modify");
            string ToStation = Console.ReadLine();

            Console.WriteLine("Enter the Status to Modify");
            string Status = Console.ReadLine();


            conn = new SqlConnection("Data Source = ICS-LT-D244D6D0; database = RailwayProject; trusted_connection = true");
            conn.Open();
            cmd = new SqlCommand("sp_Update_Trains", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@TrainNo", TrainNo);
            cmd.Parameters.AddWithValue("@TrainName", TrainName);
            cmd.Parameters.AddWithValue("@FromStation", FromStation);
            cmd.Parameters.AddWithValue("@ToStation", ToStation);
            cmd.Parameters.AddWithValue("@Status", Status);
            cmd.ExecuteNonQuery();
            Console.WriteLine("Train details are updated");


        }
        public static void DeleteTrain()
        {

            Console.WriteLine("Enter Train Number to Delete");
            int TrainNo = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Enter Train Name to Delete");
            //string TrainName = Console.ReadLine();

            //Console.WriteLine("Enter the Station name to Delete");
            //string FromStation = Console.ReadLine();

            //Console.WriteLine("Enter the station name to Delete");
            //string ToStation = Console.ReadLine();

            conn = new SqlConnection("Data Source = ICS-LT-D244D6D0; database = RailwayProject; trusted_connection = true");
            conn.Open();
            cmd = new SqlCommand("sp_Delete_Trains", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@TrainNo", SqlDbType.Int)).Value = TrainNo;
            //cmd.Parameters.Add(new SqlParameter("@TrainName", SqlDbType.VarChar)).Value = TrainName;
            //cmd.Parameters.Add(new SqlParameter("@FromStation", SqlDbType.VarChar)).Value = FromStation;
            //cmd.Parameters.Add(new SqlParameter("@ToStation", SqlDbType.VarChar)).Value = ToStation;
            int result = cmd.ExecuteNonQuery();
            if (result > 0)
            {
                Console.WriteLine("Train is deleted successfully");
            }
            else
            {
                Console.WriteLine("Train is not deleted");
            }

        }

    }
}