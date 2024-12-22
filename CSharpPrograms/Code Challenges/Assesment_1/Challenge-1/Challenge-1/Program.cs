using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks

//1.Write a C# Sharp program to remove the character at a given position in the string.
//    The given position will be in the range 0..(string length -1) inclusive.
 
//Sample Input:
//"Python", 1
//"Python", 0
//"Python", 4
//Expected Output:
//Pthon
//ython
//Pythn



namespace Challenge_1
{
    class Program
    {
        static void Main(string[] args)
        {
            String str  = Console.ReadLine();
            for(int i = 1;i<str.Length; i++)
            {

                str.Add(i);
            }
            Console.WriteLine("Enter the present list: ");
            foreach(int j in str)
            {
                Console.WriteLine(j);
            }
            Console.WriteLine("");
            Console.WriteLine("After reversing: ");

            str.Reverse();
            foreach (int j in str)
            {
                Console.WriteLine(j);
            }
        }

        

        
    }
}
