using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace RailwayProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose One Option");
            Console.WriteLine("1.Admin");
            Console.WriteLine("2.User");
            Console.WriteLine("3.Exit");

            Console.WriteLine("Enter your choice:");
            int option = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("------------------------------------");
            switch (option)
            {

                case 1:
                    Admin.Admin_block();
                    break;
                case 2:
                    User.User_Menu();
                    break;
                case 3:
                    Exit.exit();
                    break;
                default:
                    Console.WriteLine("Invalid option.Please try again");
                    break;
            }
            Console.Read();

        }
    }
}
