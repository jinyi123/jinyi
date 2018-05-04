using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day08EXz
{
   public class Multi:Calculate
    {
       public override double Calc()
       {
           return this.Numleft * this.Numright;
       }
    }
}
