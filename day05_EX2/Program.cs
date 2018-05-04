using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day05_EX2
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> q = new Queue<string>();
            q.Enqueue("A");
            q.Enqueue("M");
            q.Enqueue("G");
            q.Enqueue("W");

            Console.WriteLine("CURRENT  QUEUE:");
            foreach (string c in q)
            {
                Console.Write(c+"");
                
            }
            Console.WriteLine();
            q.Enqueue("V");
            q.Enqueue("H");
            Console.WriteLine("CURRENT  QUEUE:");
            foreach (string c in q)
            {
                Console.Write(c + "");
                
            }
            Console.WriteLine();
            Console.WriteLine("Removing some values:");
            string str = q.Dequeue();
            Console.WriteLine("the removed value:{0}",str);
            str = q.Dequeue();
            Console.WriteLine("the removed value:{0}", str);
            Console.ReadLine();


        }
    }
}
