using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//2.Write a class Box that has Length and breadth as its members. Write a function that adds 2 box objects
  //  and stores in the 3rd. Display the 3rd object details. Create a Test class to execute the above.

namespace Challenge_3
{
    public class Box
    {
        public int Length { get; set; }
     
        public int Breadth { get; set; }

        public Box(int length, int breadth)
        {
            Length = length;
            
            Breadth = breadth;
            
        }

        public static Box operator +(Box b1, Box b2)
        {
            return new Box(b1.Length + b2.Length, b1.Breadth + b2.Breadth);
        }

        public override string ToString()
        {
            return $"Length: {Length}, Breadth: {Breadth}";
        }
    }
}
