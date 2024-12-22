using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace RailwayProject
{
    class User
    {
        public static SqlConnection conn = null;
        public static SqlCommand cmd = null;
        public static IDataReader dr = null;
        static int counter = 0;
        public static void User_Menu()
        {
            Console.WriteLine("Please View Train Information before Book Tickets");
            Console.WriteLine("1.View Train Information");
            Console.WriteLine("2.Book Tickets");
            Console.WriteLine("3.Cancel Tickets");
            counter++; // 1
            string UserChoice = Console.ReadLine();

            switch (UserChoice)
            {
                case "1":
                    View_Train_Information();
                    break;
                case "2":
                    Book_Ticket();
                    break;
                case "3":
                    Cancel_Ticket();
                    break;
                default:
                    Console.WriteLine("Invalid Option");
                    break;
            }

        }
        public static void View_Train_Information()
        {
            conn = new SqlConnection("Data Source = ICS-LT-D244D6D0; database = RailwayProject; trusted_connection = true;");
            conn.Open();

            cmd = new SqlCommand("sp_view_Trains", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            dr = cmd.ExecuteReader();
            Console.WriteLine("Available Trains are:");

            while (dr.Read())
            {
                Console.WriteLine($"TrainNo:{dr["TrainNo"]},TrainName:{dr["TrainName"]}, FromStation:{dr["FromStation"]},TicketPrice:{dr["TicketPrice"]},ToStation:{dr["ToStation"]},ClassType:{dr["ClassType"]},Status:{dr["Status"]}");
            }
            while (counter == 1)
            {
                User_Menu();
                break;
            }   

           

        }

        public static void Book_Ticket() {

            Console.WriteLine("Enter Train Number");
            int TrainNo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Train Name");
            string TrainName = Console.ReadLine();

            Console.WriteLine("Enter Passenger Name");
            string PassengerName = Console.ReadLine();

            Console.WriteLine("Enter Passenger Age");
            int PassengerAge = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Gender");
            string Gender = Console.ReadLine();

            Console.WriteLine("Enter the Class Type");
            string ClassType = Console.ReadLine();

            Console.WriteLine("Enter the Number of Seats");
            int Number_of_seats = Convert.ToInt32(Console.ReadLine());

            conn = new SqlConnection("Data Source = ICS-LT-D244D6D0;database = RailwayProject;trusted_connection = true");
            conn.Open();

            cmd = new SqlCommand("sp_Book_Ticket", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@TrainNo", TrainNo);
            cmd.Parameters.AddWithValue("@TrainName", TrainName);
            cmd.Parameters.AddWithValue("@PassengerName", PassengerName);
            cmd.Parameters.AddWithValue("@PassengerAge", PassengerAge);
            cmd.Parameters.AddWithValue("@Gender", Gender);
            cmd.Parameters.AddWithValue("@ClassType", ClassType);
            cmd.Parameters.AddWithValue("@Number_of_seats", Number_of_seats);
            int result = cmd.ExecuteNonQuery();
            if (result > 0)
            {
                Console.WriteLine("Ticket is booked successfully.");
            }
            else
            {
                Console.WriteLine("Ticket is Not Booked........");
            }

        }
    

        public static void Cancel_Ticket()
        {
            Console.WriteLine("Enter Train Number");
            int TrainNo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Train Name");
            string TrainName = Console.ReadLine();

            Console.WriteLine("Enter Passenger Name ");
            string PassengerName = Console.ReadLine();

            conn = new SqlConnection("Data Source = ICS-LT-D244D6D0; database = RailwayProject;trusted_connection = true");

            conn.Open();

            cmd = new SqlCommand("sp_Cancel_Ticket", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@TrainNo", TrainNo);
            cmd.Parameters.AddWithValue("@TrainName", TrainName);
            cmd.Parameters.AddWithValue("@PassengerName", PassengerName);
            int result = cmd.ExecuteNonQuery();
            if(result > 0)
            {
                Console.WriteLine("Ticket is cancelled successfully.");
            }
            else
            {
                Console.WriteLine("Ticket is not cancelled");
            }

        }

    }

    class Exit
    {
        public static void exit()
            {
            Console.WriteLine("Your exited from the home page");
            }
    } 
}
