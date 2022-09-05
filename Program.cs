using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_assignment_1
{
    internal class BookCategory
    {
        int catid;
        string catname;
        string desc;
        public BookCategory()
        {
            catid = 10;
            catname = "Action";
            desc = "Interesting";
        }

        public static void Main()
        {
            BookCategory obj = new BookCategory();
            Console.WriteLine(obj.catid);
            Console.WriteLine(obj.catname);
            Console.WriteLine(obj.desc);

            Console.Read();
        }
    }
}
