using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day02_00002
{
    class Program
    {

        static void Main(string[] args)
        {
            #region 001
            ////新建对象
            //ArrayList list = new ArrayList();
            ////添加
            //list.Add("堂吉诃德");
            //list.Add("哈姆雷特");
            //list.Add("守望者");
            //list.Add("冰与火之歌");
            //list.Add("百年孤独");
            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //}
            ////删除
            //list.Remove("冰与火之歌");
            //list.RemoveAt(2);
            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //}
            ////修改
            //list[2] = "饥饿游戏";
            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.ReadLine(); 
            #endregion

            #region 002
            //ArrayList list = new ArrayList()
            //{
            //    new BOOK(){Bookname = "堂吉诃德"},
            //    new BOOK(){Bookname = "哈姆雷特"}
            
            //};
            //foreach (BOOK item in list)
            //{
            //    Console.WriteLine(item.Bookname);
            //}
            //Console.ReadLine(); 
            #endregion

            #region 双列集合
            //Hashtable table = new Hashtable();
            //table.Add("放逐之刃", "锐雯");
            //table.Add("无双剑姬", "菲奥娜");
            //table.Add("刀锋意志", "艾瑞莉娅");
            ////通过key拿value
            //Console.WriteLine("==============傲娇的分割线================");
            //foreach (string item in table.Keys)
            //{
            //    Console.WriteLine(item);
            //    Console.WriteLine(table[item]);
            //}
            ////直接拿值
            //Console.WriteLine("==============高冷的分割线================");
            //foreach (string item in table.Values)
            //{
            //    Console.WriteLine(item);
            //}
            ////同时迭代
            //Console.WriteLine("==============安静的分割线================");
            //foreach (DictionaryEntry item in table)
            //{
            //    Console.WriteLine(item.Key + "\t" + item.Value);
            //} 
            #endregion

            //Dictionary<string, BOOK> table1 = new Dictionary<string, BOOK>();
            //BOOK b1 = new BOOK();
            //b1.Bookname = "守望者";
            //b1.BookRmb = 66;
            //string a = Convert.ToString(b1.BookRmb);
            //table1.Add(a,b1);
            //foreach (string item in table1.Keys)
            //{
            //    Console.WriteLine( item+table1[item]);
            //}

            Dictionary<int, BOOK> table = new Dictionary<int, BOOK>() 
            { 
            
            {001,new BOOK{BookRmb = 66,Bookname = "哈姆雷特"}}
            
            
            };

            Console.ReadLine();
        }
    }
}
