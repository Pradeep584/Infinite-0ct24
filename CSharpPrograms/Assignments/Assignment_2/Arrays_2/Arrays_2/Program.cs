using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program in C# to accept ten marks and display the following
//	a.	Total
//	b.	Average
//	c.	Minimum marks
//	d.	Maximum marks
//	e.	Display marks in ascending order
//	f.	Display marks in descending order
namespace Arrays_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the 10 marks");
            int[] arr = new int[10] ;

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            int total = 0;
            for (int i = 0; i < arr.Length; i++)
            { 
                total += arr[i];
            }
            Console.WriteLine("The total marks:");
            Console.WriteLine(total);

            int avg = 0;
            for (int i = 0; i < arr.Length; i++)
            { 
                avg = total/arr[i];
            }
            Console.WriteLine("The average marks are:");
            Console.WriteLine(avg);

            int min_marks= 0;
            for (int i = 0;i < arr.Length; i++)
            {
                min_marks= arr.Min();
            }
            Console.WriteLine("The minimum marks are: ");
            Console.WriteLine(min_marks);

            int max_marks= 0;
            for(int i = 0;i<arr.Length;i++)
            {
                max_marks= arr.Max();
            }
            Console.WriteLine("The maximum marks are: ");
            Console.WriteLine(max_marks);

            Console.WriteLine("Ascending order is: ");
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }

            }
            for(int i=0; i<arr.Length;i++)
            {
                Console.WriteLine(arr[i]);
            }

            Console.WriteLine("Descending order is: ");

            for(int i=0;i<arr.Length;i++)
            {
               for(int j=0;j<arr.Length;j++)
                {
                    if (arr[i] < arr[j])
                    {
                       int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            for (int i=0; i<arr.Length;i++)
            {
                Console.WriteLine(arr[i]);
             }
            Console.ReadLine();


        }
    }
}
