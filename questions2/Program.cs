using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace questions2
{
    class Program
    {
        static void Main(string[] args)
        {
            //常见抽象父类集合并初始化
            List<vehicle> list = new List<vehicle> { new kite(), new aircraft(), new Superman() };
       
            //遍历show方法
            foreach (vehicle item in list)
            {
                item.show();
            }
            Console.ReadKey();
        }
    }
}
