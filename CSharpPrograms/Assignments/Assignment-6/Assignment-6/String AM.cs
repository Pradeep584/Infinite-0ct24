using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_6
{
    class StringAM
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string starts with A and M");
            string str = Console.ReadLine();
            string[] s1 = str.Split(' ');

            var filterwords = from s2 in s1
                              where s2.StartsWith("A", StringComparison.OrdinalIgnoreCase) 
                              && s2.EndsWith("M", StringComparison.OrdinalIgnoreCase)
                              select s2;
            foreach (var word in filterwords)
            {
                Console.WriteLine(word); 
            }

            Console.Read();
        }
    }
}
