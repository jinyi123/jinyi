using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day05_00001
{
  public  class CheckIeem
    {
      //检查类
        public string Name { get; set; }//检查的名字
        public string Description { get; set; }    //检查的描述   
        public int Price { get; set; }//检查的价钱

        public CheckIeem(string name, string description, int price)//带参构造
        {
            this.Name = name;
            this.Description = description;
            this.Price = price;
        }
        public CheckIeem()//无参构造
        {
            
        }
    }
}
