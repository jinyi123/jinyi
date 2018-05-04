using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day05_00001
{
   public class CheckSet
    {//套餐类
       //套餐集合
        public List<CheckIeem> list = new List<CheckIeem>();
       //套餐名字
        public string Name { get; set; }
       //套餐价格
        public int Price { get; set; }

       //带参构造
        public CheckSet(CheckIeem ieem,string name)
        {        
            list.Add(ieem);
            this.Name = name;
            foreach (CheckIeem item in list)
            {
                this.Price += item.Price;
            }
           
        }
       //无参构造

        public CheckSet()
        {
            
        }
       //计算套餐价格的方法
        public void Rmb()
        {
            this.Price = 0;
            foreach (CheckIeem item in list)
            {
                this.Price += item.Price;
            }
        
        }
    }
}
