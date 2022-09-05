using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book
{
    public class BookCategory
    {
        private int _catid;

        public int Catid
        {
            get { return _catid; }
            set { _catid = value; }
        }

        private string _catname;

        public string Catname
        {
            get { return _catname; }
            set { _catname = value; }
        }

        private string _desc;

        public string Desc
        {
            get { return _desc; }
            set { _desc = value; }
        }
    }
}
