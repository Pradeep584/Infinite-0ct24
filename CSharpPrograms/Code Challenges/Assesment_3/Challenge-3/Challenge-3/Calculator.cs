using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Challenge_3;
//4.Write a console program that uses delegate object as an argument to call Calculator Functionalities
//like 1. Addition, 2. Subtraction and 3. Multiplication by taking 2 integers and returning the output to
//the user. You should display all the return values accordingly

namespace Challenge_3
{
    class Calculator
    {
        public delegate int Cal(int x, int y);

        class Program
        {
            static int Addition(int x, int y) => x + y;
            static int Subtraction(int x, int y) => x - y;
            static int Multiplication(int x, int y) => x * y;

            static void Calculate(Challenge_3.Calculator calc, string operation)
            {
                Console.Write("Enter the  first number :" + operation );
                int x = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter the second number :" + operation);
                int y = Convert.ToInt32(Console.ReadLine());
                int result = calc(x, y);
                Console.WriteLine($"{operation} result: {result}");
            }

           public static void Main()
            {
                Console.WriteLine("The Calculator Operations are:");
                Challenge_3.Calculator calcAdd = Addition;
                Calculate(calcAdd, "Addition");

                Challenge_3.Calculator calcSubtract = Subtraction;
                Calculate(calcSubtract, "Subtraction");

                Challenge_3.Calculator calcMultiply = Multiplication;
                Calculate(calcMultiply, "Multiplication");
                Console.Read();
            }

        }

    }
}
