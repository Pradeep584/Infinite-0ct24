using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a C# Sharp program to check the largest number among three given integers.
 
//Sample Input:
//1,2,3
//1,3,2
//1,1,1
//1,2,2
//Expected Output:
//3
//3
//1
//2

namespace Challenge_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());

            if (a > b)
            {
                if (a > c)
                {
                    Console.WriteLine("It is the largest number: " + a);
                }
                Console.WriteLine("It is the largest number: " + c);
            }
            else
            {
                if (b > a)
                {
                    if (b > c)
                    {
                        Console.WriteLine("It is the largest number: " + a);
                    }
                    Console.WriteLine("It is the largest number: " + c);
                }
            }
            Console.ReadLine();
            


        }
    }
}
