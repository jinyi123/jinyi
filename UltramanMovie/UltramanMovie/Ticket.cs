using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UltramanMovie
{
    [Serializable]
    public class Ticket
    {
        public Ticket() { }
        public Ticket(ScheduleItem scheduleItem, Seat seat)
        {
            this.ScheduleItem = scheduleItem;
            this.Seat = seat;
        }

        /// <summary>
        /// 座位对象
        /// </summary>
        private Seat seat;  //座位号
        /// <summary>
        /// 票价
        /// </summary>
        private int price;
        /// <summary>
        /// 所属的放映场次
        /// </summary>
        private ScheduleItem scheduleItem; //播放场次

        public Seat Seat
        {
            get { return seat; }
            set { seat = value; }
        }


        public int Price
        {
            get { return price; }
            set { price = value; }
        }


        public ScheduleItem ScheduleItem
        {
            get { return scheduleItem; }
            set { scheduleItem = value; }
        }

        /// <summary>
        /// 计算票价的方法
        /// 可重写
        /// </summary>
        public virtual void CalcPrice()
        {
            this.Price = this.ScheduleItem.Movie.Price;
        }

        /// <summary>
        /// 打印票实现
        /// </summary>
        public virtual void Print()
        {
            string fileName = this.ScheduleItem.Time.Replace(":", "-") + " " + this.Seat.SeatNum + ".txt";
            FileStream fs = new FileStream(fileName, FileMode.Create);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine("***************************");
            sw.WriteLine("        青鸟影院");
            sw.WriteLine("---------------------------");
            sw.WriteLine(" 电影名：\t{0}", this.ScheduleItem.Movie.MovieName);
            sw.WriteLine(" 时间：  \t{0}", this.ScheduleItem.Time);
            sw.WriteLine(" 座位号：\t{0}", this.Seat.SeatNum);
            sw.WriteLine(" 价格：  \t{0}", this.Price.ToString());
            sw.WriteLine("***************************");
            sw.Close();
            fs.Close();
        }

        /// <summary>
        /// 显示售出票信息
        /// </summary>
        public virtual void Show()
        {
            System.Windows.Forms.MessageBox.Show("已售出");
        }

    }
}
