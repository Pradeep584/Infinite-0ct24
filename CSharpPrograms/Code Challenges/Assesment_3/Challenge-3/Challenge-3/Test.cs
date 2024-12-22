using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_3
{
    class Test
    {
        static void Main()
        {
            Console.Write("Enter length of Box 1: ");
            int l1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter breadth of Box 1: ");
            int b1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("-------------------------------");
            Console.WriteLine();

            Console.Write("Enter length of Box 2: ");
            int l2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter breadth of Box 2: ");
            int b2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("-------------------------------");
            Console.WriteLine();

            Box box1 = new Box(l1, b1);
            Box box2 = new Box(l2, b2);
            Box box3 = box1 + box2;
            Console.WriteLine();
            Console.WriteLine("Box 1 has: " + box1);
            Console.WriteLine("Box 2 has: " + box2);
            Console.WriteLine("Box 3 (Sum of box1 and box2): " + box3);



            Console.Read();
        }
    }
}
