using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day02_00002
{
    public class BOOK
    {
        public string Bookname { get; set; }
        public int BookRmb { get; set; }
        public override string ToString()
        {
            return Bookname.ToString();
        }
    }
}
