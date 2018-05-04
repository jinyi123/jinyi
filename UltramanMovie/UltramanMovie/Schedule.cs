using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace UltramanMovie
{
   public class Schedule
    {
        //01.定义一个和当前放映计划对应的     【放映场次的集合】
        private Dictionary<string, ScheduleItem> items = new Dictionary<string, ScheduleItem>();

        internal Dictionary<string, ScheduleItem> Items
        {
            get { return items; }
            set { items = value; }
        }

        public void LoadItems()
        {
            XmlDocument myXml = new XmlDocument();
            myXml.Load("ShowList.xml");
            XmlNode root = myXml.DocumentElement;
            foreach (XmlNode item in root.ChildNodes)
            {
                Movie movie = new Movie();
                //一个item代表一个movie
                movie.MovieName = item["Name"].InnerText;
                movie.Poster = item["Poster"].InnerText;
                movie.Director = item["Director"].InnerText;
                movie.Actor = item["Actor"].InnerText;
                //电影类型   xml读取出来的是没有类型的，都是字符串，转成成枚举
                movie.MovieType = (MovieType)Enum.Parse(typeof(MovieType), item["Type"].InnerText);
                movie.Price = Convert.ToInt32(item["Price"].InnerText);

                foreach (XmlNode schedule in item["Schedule"].ChildNodes)
                {
                    //一个schedule代表一个放映场次
                    ScheduleItem sItem = new ScheduleItem();
                    sItem.Time = schedule.InnerText;
                    sItem.Movie = movie;
                    items.Add(sItem.Time, sItem);
                }
            }
        }
    }
}
