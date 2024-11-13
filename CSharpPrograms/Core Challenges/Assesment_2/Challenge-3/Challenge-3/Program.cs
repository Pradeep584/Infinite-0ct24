using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//3.Write a C# program to implement a method that takes an integer as input and throws an exception
  //if the number is negative. Handle the exception in the calling code.

namespace Challenge_3
{
    class Negative
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            try
            {
                CheckForNegative(num);
                Console.WriteLine("The number is valid.");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
            }
            Console.ReadLine();
        }

        static void CheckForNegative(int num)
        {
            if (num < 0)
            {
                throw new ArgumentOutOfRangeException("num", "The number cannot be negative.");
            }
        }
    }
}

