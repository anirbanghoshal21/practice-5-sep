using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_assignment_1
{
    internal class Book
    {
        int bookid;
        string bname;
        float price;
        string author;
        public Book()
        {
            bookid = 100;
            bname = "Harry Potter";
            price = 800;
            author = "J K Rowling";
        }

        public static void Main()
        {
            Book obj = new Book();
            Console.WriteLine(obj.bookid);
            Console.WriteLine(obj.bname);
            Console.WriteLine(obj.price);
            Console.WriteLine(obj.author);

            Console.Read();
        }
    }
}
