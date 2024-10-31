using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1

{
    class P4
    {
        public void table(int a)
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine($"{a}*{i}={a*i}");
            }
        }

        public static void Main(string[] args)
        {
            P4 p = new P4();
            Console.WriteLine("Enter the number");
            int a = Convert.ToInt32(Console.ReadLine());
            p.table(a);
            Console.ReadLine();
        }
    }
}
