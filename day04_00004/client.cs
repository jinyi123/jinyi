using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day04_00004
{
   public class client
    {
       public void dishes(waiter wa , Order or)
       {
           Console.WriteLine("顾客开始点菜:{0}",or.cai);
           wa.GetOrder(or);
       
       }

       public void Eat()
       {

           Console.WriteLine("mia~mia~mia！");
       }

    }
}
