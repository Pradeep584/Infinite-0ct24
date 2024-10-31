using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace equalornot
{
    internal class P1
    {
        static void Main(string[] args)
        {
            int a=Convert.ToInt32(Console.ReadLine());  
            int b=Convert.ToInt32(Console.ReadLine());

            if (a == b)
            {
                Console.WriteLine($"Given {a} and {b} numbers are equal");
            }
            else
            {
                Console.WriteLine("Given numbers are not equal");
            }
            Console.ReadLine(); 
                    
        }
    }
}
