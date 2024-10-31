using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());

            if (num1==num2)
            {
                Console.WriteLine($"given {num1} and {num2} are equal");
            }
            else
            {
                Console.WriteLine($"Given two numbers are not equal");
            }
            Console.ReadLine();
        }
    }
}
