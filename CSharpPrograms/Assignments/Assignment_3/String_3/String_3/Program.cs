using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String();
            Console.ReadLine();
        }
        static void String ()
        {
            Console.WriteLine("Enter the two strings: ");
            String str1 = Console.ReadLine();   
            String str2 = Console.ReadLine();
            if (str1 == str2)
            {
                Console.WriteLine("The given two strings are equal");
            }
            else 
            {
                Console.WriteLine("They are not equal");
            }
        }
    }
}
