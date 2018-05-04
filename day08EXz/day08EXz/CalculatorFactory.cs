using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day08EXz
{
   public class CalculatorFactory
    {
       
       public static Calculate getInstance(string oper)
       {
           Calculate ca = null;
           switch (oper)
           {
               case"+":
                   ca = new Add();
                   break;
               case "-":
                   ca = new Sub();
                   break;
               case "*":
                   ca = new Multi();
                   break;
               case "/":
                   ca = new Div();
                   break;
               case "%":
                   ca = new Remainder();
                   break;
               default:
                   break;
           }
           return ca;
       
       }
    }
}
