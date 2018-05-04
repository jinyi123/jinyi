using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day08EXz
{
    public class Div:Calculate
    {
        public override double Calc()
        {
            if (this.Numright==0)
            {
                throw new Exception ("除数不能为0");
            }
            else
            {
                return this.Numleft / this.Numright;
            }
           
        }
    }
}
