using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a C# Sharp program to copy the elements of one array into another array.
//(do not use any inbuilt functions)

namespace Arrays_3
{
    internal class Program
    {
        static void Main(string[] args) 
        {
           
            int[] a   =  { 34, 66, 32, 67, 65 };
            int[] b = a;

            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(b[i] + " ");  
            }
            Console.ReadLine();
        }
    }
}
