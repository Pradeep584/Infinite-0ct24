using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMoperations
{
    internal class P3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter Input first number");
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
                    Console.WriteLine($"{a}/{b}={a / b}");
                    Console.Read();
                    break;
                default:
                    Console.WriteLine("Please enter proper sign");
                    Console.Read();
                    break;

            }

        }
    }
}
    

