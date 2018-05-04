using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jiekou1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Ibianshen> bian = new List<Ibianshen> 
            {
            new jiadou(),
            new W()
            };

            foreach (Ibianshen item in bian)
            {
                Console.WriteLine();
                item.bianshen();
                Console.WriteLine();
               
            }
            Console.ReadLine();
        }
    }
}
