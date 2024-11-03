using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

//Write a  Program to assign integer values to an array  and then print the following
	//a.	Average value of Array elements
	//b.	Minimum and Maximum value in an array 

namespace Arrays1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = {5, 17, 23, 29, 35, 41, 57};
            arr.Average();
            arr.Min();
            arr.Max();
            Console.WriteLine(arr.Average());
            Console.WriteLine(arr.Min());
            Console.WriteLine(arr.Max());
            Console.Read();


        }
    }
}
