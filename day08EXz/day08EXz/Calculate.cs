using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day08EXz
{
  public abstract class Calculate
    {
        public double Numleft { get; set; }
        public double Numright { get; set; }

        public abstract double Calc();
    }
}
