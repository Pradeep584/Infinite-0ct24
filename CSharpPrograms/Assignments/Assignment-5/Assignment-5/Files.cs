using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Assignment_5
{
    class Files
    {
            public static void Main(string[] args)
            {
                Console.WriteLine("Enter the size of an array: ");
                int a = Convert.ToInt32(Console.ReadLine());
                string[] str = new string[a];

                for (int i = 0; i < a;i++)
                {
                    Console.WriteLine("Enter the string: " + i + 1);
                    str[i] = Console.ReadLine();
                }


                string write_path = "Problem-2";
                FileStream fs= new FileStream(write_path, FileMode.Create, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs);
                foreach (string s in str)
                {
                   sw.WriteLine(s);
                }
                Console.WriteLine("The Words are stored in the File");
                sw.Flush();
                sw.Close();
                sw.Close();
                Console.ReadLine();
            }
        
    }
}
