using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace day05_EX
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Grade g = new Grade();
        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {

            Point p = e.Location;
            Dictionary<string, Point> x = g.DisplayStudent(p);
            foreach (string item in x.Keys)
            {
                Button btn = new Button();
                btn.Name = "btn"+item;
                btn.Text = item;
                btn.Location = x[item];
                this.Controls.Add(btn);

            }
        } 
        

        private void Form1_Load(object sender, EventArgs e)
        {
            g.AddStudent(new Student("迪迦"));
            g.AddStudent(new Student("戴拿"));
            g.AddStudent(new Student("盖亚"));
            g.AddStudent(new Student("阿古茹"));
        }
    }
}
