using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Assignment_5
{
    class Books
    {
        private String BookName;
        private String AuthorName;

        public string Book_Name
        {
            get
            {
                return BookName;
            }
            set
            {
                BookName = value;
            }
        }
        public string Author_Name
        {
            get
            {
                return AuthorName;
            }
            set
            {
                AuthorName = value;
            }
        }

        public Books(string BookName, string AuthorName)
        {
            this.BookName = BookName;
            this.AuthorName = AuthorName;
        }

        public void Display()
        {
            Console.WriteLine($"Book name : {BookName}");
            Console.WriteLine($"Author name : {AuthorName}");
        }
    }

    class Bookshelf
    {
        private Books[] b = new Books[5];
        public Books this[int index]
        {
            get
            {
                return b[index];
            }
            set
            {
                b[index] = value;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Bookshelf bs = new Bookshelf();
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Enter Book {i + 1} Details");
                Console.WriteLine($"Enter Book {i + 1} Name");
                string bookname = Console.ReadLine();
                Console.WriteLine($"Enter Book {i + 1} AuthorName");
                string authorname = Console.ReadLine();
                bs[i] = new Books(bookname, authorname);
            }

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"-----Book {i + 1} Details are-----");
                bs[i].Display();
            }
            Console.ReadLine();
        }
    }
}

