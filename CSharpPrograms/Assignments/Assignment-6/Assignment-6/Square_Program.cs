using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_6
{
    internal class Square_Program
    {
        static void Main()
        {
            List<int> list = new List<int>();
            Console.WriteLine("Enter the  numbers");
            int num = int.Parse(Console.ReadLine());
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine("Enter elements " + i + 1);
                list.Add(int.Parse(Console.ReadLine()));
            }
            var res = from i in list
                      where i * i > 20
                      select i;
            foreach (var x in res)
            {
                Console.WriteLine($"{x} -> {x * x}");
            }
            Console.ReadLine();
        }
    }
}
