using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day04_00004
{
    class Program
    {
        static void Main(string[] args)
        {
            client cl = new client();
            Order or = new Order(cl,1001,"鱼香肉丝");
            waiter wa = new waiter();
            chef ch = new chef();

            cl.dishes(wa,or);
            wa.SendOrder(ch);
            ch.Cook();
            ch.SendAlert(wa);
            wa.Transcook();

            Console.ReadLine();

        }
    }
}
