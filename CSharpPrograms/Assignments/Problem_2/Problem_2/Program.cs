using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the numbers");
            int a = Convert.ToInt32(Console.ReadLine());
           
            if(a>0)
            {
                Console.WriteLine($"Given number is positive");
            }
            else
            {
                Console.WriteLine($"Given number is negative");
            }

            Console.ReadLine();


        }
    }
}
