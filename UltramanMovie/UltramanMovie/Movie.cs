using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UltramanMovie
{
    public enum MovieType
    {
        //喜剧
        Comedy,
        //战争
        War,
        //爱情
        Romance,
        //动作
        Action,
        //卡通
        Cartoon,
        //恐怖
        Thriller,
        //冒险
        Adventure
    }
    public class Movie
    {
        public Movie() { }
        public Movie(string movieName, string poster, string director, string actor, MovieType movieType, int price)
        {
            this.MovieName = movieName;
            this.Poster = poster;
            this.Director = director;
            this.Actor = actor;
            this.MovieType = movieType;
            this.Price = price;
        }

        /// <summary>
        /// 电影名称
        /// </summary>
        private string movieName;
        /// <summary>
        /// 海报图片名
        /// </summary>
        private string poster;
        /// <summary>
        /// 导演名
        /// </summary>
        private string director;
        /// <summary>
        /// 主演
        /// </summary>
        private string actor;
        /// <summary>
        /// 电影类型
        /// </summary>
        private MovieType movieType;
        /// <summary>
        /// 电影定价
        /// </summary>
        private int price;
        public string MovieName
        {
            get { return movieName; }
            set { movieName = value; }
        }


        public string Poster
        {
            get { return poster; }
            set { poster = value; }
        }


        public string Director
        {
            get { return director; }
            set { director = value; }
        }


        public string Actor
        {
            get { return actor; }
            set { actor = value; }
        }


        public MovieType MovieType
        {
            get { return movieType; }
            set { movieType = value; }
        }


        public int Price
        {
            get { return price; }
            set { price = value; }
        }
    }
}
