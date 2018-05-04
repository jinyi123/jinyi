using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace day05_EX
{
    class Grade
    {
        List<Student> list = new List<Student>();


        public void AddStudent(Student item)
        {
            list.Add(item);     
        }

        public  Dictionary<string, Point> DisplayStudent(Point p)
        {
            Dictionary<string, Point> x = new Dictionary<string,Point>();
            foreach (Student item in list)
            {

                x.Add(item.StuName.ToString(),p);
                p.X = p.X + 155;
                
               
                
            }

            return x;
        }
    }
}
