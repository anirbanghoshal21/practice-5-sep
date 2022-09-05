using Class1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class3
{
    public class Novel : Book
    {
        float _price;
        public Novel()
        {

        }
        public Novel(int bookid)
        {
            Console.WriteLine("Executed bookid");
        }
        public Novel(int bookid, string bname) : this(bookid)
        {
            
            Console.WriteLine("Executed bookid and bname");
        }
        public  void InsertBook(int bookid, string bname, float price,int pages)
        {

        }
        public new void InsertBook(int bookid, string bname, float price)
        {

        }
    }
}
