using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class1
{
    public class Book
    {
        private int _bookid;

        public int Bookid
        {
            get { return _bookid; }
            set { _bookid = value; }
        }
        private string _bname;

        public string BookName
        {
            get { return _bname; }
            set { _bname = value; }
        }

        private float _price;

        public float Price
        {
            get { return _price; }
            set { _price = value; }
        }

        private string _author;

        public string author
        {
            get { return _author; }
            set { _author = value; }
        }
        public void InsertBook(int bookid, string bname, float price)
        {
            this.Bookid = bookid;
            this.BookName = bname;
            this.Price = price;
        }

    }
    }

