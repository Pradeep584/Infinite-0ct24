using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Positive_or_Negative_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            if (a > 0)
            {
                Console.WriteLine("The given number is positive");
            }

            else 
                    {
                      Console.WriteLine("The given number negative");
                    }
            Console.Read();
        }
    }
}
