using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
//Write a program in C# Sharp to append some text to an existing file. If file is not available, 
//then create one in the same workspace.

namespace Challenge_3
{
    class Text_File
    {
        static void Main()
        {
            string filePath = @"C:\.net trainee\Infinite 1\";
            Console.Write("Enter text to append: ");
            string text = Console.ReadLine();

            using (StreamWriter writer = File.AppendText(filePath))
            {
                writer.WriteLine(text);
            }

            Console.WriteLine("Text appended successfully.");
            Console.WriteLine("Appended text:");
            Console.WriteLine(File.ReadAllText(filePath));
            Console.Read();
        }
    }
}
