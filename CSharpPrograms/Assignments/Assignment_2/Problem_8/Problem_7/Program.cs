using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer");
            int p = Convert.ToInt32(Console.ReadLine());

            if (p == 1)
            {
                Console.WriteLine("Monday");
            }
            else if (p == 2)
            {
                Console.WriteLine("Tuesday");
            }
            else if (p == 3)
            {
                Console.WriteLine("Wednsday");
            }
            else if (p == 4)
            {
                Console.WriteLine("Thursday");
            }
            else if (p == 5)
            {
                Console.WriteLine("Friday");
            }
            else if (p == 6)
            {
                Console.WriteLine("Saturday");
            }
            else if(p == 7)
            {
                Console.WriteLine("Sunday");
            }
            Console.ReadLine();

        }
    }
}

