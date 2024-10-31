using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the two numbers");
            int p=Convert.ToInt32(Console.ReadLine());  
            int q=Convert.ToInt32(Console.ReadLine());

            if (p == q)
            {
                Console.WriteLine(3 * (p + q));
            }
            else
            {
                Console.WriteLine("The given two numbers are not equal");
               
            }
            Console.ReadLine();
        }
    }
}
