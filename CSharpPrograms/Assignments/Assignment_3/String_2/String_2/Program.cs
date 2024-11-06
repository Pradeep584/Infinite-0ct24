using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_2
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            String();
            Console.Read();
        }

        static void String()
        {
            Console.WriteLine("Enter the string name: ");
            String str = Console.ReadLine();
            Console.Write("Reversed string is: ");
            String reverse = "";
            for (int i = str.Length-1; i>=0; i--)
            { 
                Console.Write($"{reverse}{str[i]}");
            }
        }


    }
}
