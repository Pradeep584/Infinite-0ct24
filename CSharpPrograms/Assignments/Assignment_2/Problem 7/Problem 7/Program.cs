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
            Console.WriteLine("Enter the input number: ");
            int p = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Output:");
            for (int i=1; i<=3; i+=2)
            {
                for (int j = 1; j <= 3; j += 3)
                {
                    Console.WriteLine($"{p} {p} {p} {p}");
                }
                Console.WriteLine($"{p}{p}{p}{p}");
            }

            Console.ReadLine(); 
                
        }
    }
}
