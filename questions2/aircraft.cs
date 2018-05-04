using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace questions2
{
    public class aircraft : vehicle
    {
        public override void show()
        {
            Console.WriteLine("本次航班马上就要起飞了！");
        }
    }
}
