using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the two integers");
            Console.WriteLine("Before Swapping");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("After Swapping");
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.ReadLine();
        }
        
    }
}
