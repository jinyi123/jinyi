using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day04_00004
{
  public  class chef
    {
      private Order or;
      public void GetOrder(Order or)
      {
          this.or = or;
      }
      public void Cook()
      {
          Console.WriteLine("厨师烹制：{0}", or.cai);
          Console.WriteLine("制作完毕");
      }

      public void SendAlert(waiter wa)
      {
          Console.WriteLine("厨师提示服务员取菜！");
          wa.GetOrder(or);
      
      }
    }
}
