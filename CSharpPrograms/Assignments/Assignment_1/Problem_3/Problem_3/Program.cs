using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the numbers");

            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter sign");
            char sign = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("enter input second number ");
            int b = Convert.ToInt32(Console.ReadLine());
            switch (sign)
            {
                case '+':
                    Console.WriteLine($"{a} + {b} ={a + b}");
                    Console.Read();
                    break;
                case '-':
                    Console.WriteLine($"{a} - {b}={a - b}");
                    Console.Read();
                    break;
                case '*':
                    Console.WriteLine($"{a} * {b}={a * b}");
                    Console.Read();
                    break;
                case '/':
                    Console.WriteLine($"{a}/{b}={ a / b}");
                    Console.Read();
                    break;
                default:
                    Console.WriteLine("invalid grade");
                    Console.Read();
                    break;
            }
            Console.ReadLine();


            }
    }
}
