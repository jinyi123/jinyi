using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day08EXz
{
  public  class cat
    {
      private static cat onlyOne =null;

      private cat() { }
      
      public static cat getInstance()
      {
          if (onlyOne == null)
          {
              onlyOne = new cat();
          }
          return onlyOne;
      }
    }
}
