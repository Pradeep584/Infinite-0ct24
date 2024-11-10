using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2
{
    class Scholarship
    {
        public double Merit(double fee, double marks)
        {
            double scholarshipAmount = 0;
            if (marks > 70 && marks <= 80)
            {
                return scholarshipAmount = fee * 0.20;
            }
            else if (marks > 80 && marks <= 90)
            {
                return scholarshipAmount = fee * 0.30;
            }
            else if (marks > 90)
            {
                return scholarshipAmount = fee * 0.50;
            }
            else
            {
                Console.WriteLine("Your not eligible for Scholarship");
            }
            return scholarshipAmount;
        }

    }
        class MainScholar
        {
            static void Main(string[] args)
            {
                Scholarship scholarship = new Scholarship();
                Console.WriteLine("Enter the marks: ");
                double marks = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter the fee: ");
                double fee = Convert.ToDouble(Console.ReadLine());
                
               Console.WriteLine(scholarship.Merit(fee,marks));
            Console.Read();
            }
        }

    
}
