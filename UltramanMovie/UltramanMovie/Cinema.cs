using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UltramanMovie
{
    public class Cinema
    {
        public Cinema()
        {
            seats = new Dictionary<string, Seat>();
            soldTickets = new List<Ticket>();
            schedule = new Schedule();
        }
        /// <summary>
        /// 放映厅座位集合
        /// </summary>
        private Dictionary<string, Seat> seats;
        public Dictionary<string, Seat> Seats
        {
            get { return seats; }
            set { seats = value; }
        }
        // 当天的放映计划
        private Schedule schedule;
        /// <summary>
        /// 当天的放映计划
        /// </summary>
        public Schedule Schedule
        {
            get { return schedule; }
            set { schedule = value; }
        }
        //已售票集合
        private List<Ticket> soldTickets;
        public List<Ticket> SoldTickets
        {
            get { return soldTickets; }
            set { soldTickets = value; }
        }
    }
}
