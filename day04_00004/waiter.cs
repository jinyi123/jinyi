using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day04_00004
{
  public class waiter
    {
      private Order or;

      public void GetOrder(Order or)
      {
          this.or = or;
      
      }
      public void SendOrder(chef ch)
      {
          Console.WriteLine("服务员将菜{0}传给厨师",or.cai);
          ch.GetOrder(or);
      
      }

      public void Transcook()
      {
          Console.WriteLine("服务员将菜{0}给客户{1}",or.cai,or.ID);
          or.wang.Eat();
      
      }
    }
}
