using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Assignment_5
{
    class Count_Lines
    {
        public static void Main()
        {
            string filename = "C:\\.net trainee\\Infinite 1\\basic.txt";
            if (File.Exists(filename))
            {
                int count = File.ReadAllLines(filename).Length;
                Console.WriteLine("Number of Lines in the file is: {0}", count);
            }
            else
            {
                Console.WriteLine("File is does not exis");
            }
            Console.Read();
        }
    }
}
