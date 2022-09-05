using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book
{
    internal class Cart
    {
        private int _custid;

        public int Custid
        {
            get { return _custid; }
            set { _custid = value; }
        }

        private int _bookid;

        public int Bookid
        {
            get { return _bookid; }
            set { _bookid = value; }
        }

        private float _price;

        public float Price
        {
            get { return _price; }
            set { _price = value; }
        }

    }
}
