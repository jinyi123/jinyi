using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day04_00004
{
  public  class Order
    {
        public client wang;
        public int ID { get; set; }
        public string  cai { get; set; }

        public Order(client name,int id,string cai)
        {
            wang = name;
            ID = id;
            this.cai = cai;
        
        
        }
    }
}
