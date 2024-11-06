using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//2.Write a C# Sharp program to exchange the first and last characters in a given string and return the new string.
 
//Sample Input:
//"abcd"
//"a"
//"xy"
//Expected Output:
 
//dbca
//a
//yx



namespace Challenge_2
{
    class Program
    {
        static void StringExchange ()

        {
            String str = Console.ReadLine();
            if (str.Length <= 1)
            {
                return str;
                return str[str.Length - 1] + str.Substring 1,str.Length - 2) +str[0];
            }

        }

        public static void main()
        {
            Console.WriteLine("SwapFirstLastChar:");
            Console.ReadLine();
        }
           

        
    }
}
