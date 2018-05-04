using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Xml
{
    class Program
    {
        static void Main(string[] args)
        {

            XmlDocument doc = new XmlDocument();
            doc.Load("book.xml");
            XmlNode root = doc.DocumentElement;
            //foreach (XmlNode item in root.ChildNodes)
            //{
            //    Console.WriteLine(item.Attributes["id"].Value.ToString());
            //    Console.WriteLine("图书名称"+item["bookname"].InnerText);
            //    Console.WriteLine("图书名称" + item["bookprice"].InnerText);
            //    Console.WriteLine("===========end=========================");
            //}
            foreach (XmlNode item in root.ChildNodes)
            {
                foreach (XmlNode Child in item.ChildNodes)
                {
                    if (Child.Name=="bookname")
                    {
                        Console.WriteLine("图书名称"+Child.InnerText);
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
