using Class1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Class
{
    public class Cart 
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

        public Cart Cartdata { get; private set; }

        public void AddToCart()
        {
            Cart c = new Cart();

            Console.WriteLine("Enter custid");
            c.Custid = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Bookid");
            c.Bookid = Convert.ToInt32(Console.ReadLine());

            InsertBook(c);
            Console.WriteLine("Book added successfully...");
        }

        private void InsertBook(Cart c)
        {
            
        }

        public void InsertBook(Book bookdata)
        {

            CartList.Add(Cartdata);


        }
        public static List<Cart> CartList = new List<Cart>();
        public void DisplayCartInfo()
        {
            _custid = base.Custid;
            _bookid = base.Bookid;
            Console.WriteLine(_custid);
            Console.WriteLine(_bookid);

        }
    }
}
