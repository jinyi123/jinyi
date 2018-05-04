using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;




namespace UltramanMovie
{
    public partial class frmmovie : Form
    {
        public frmmovie()
        {
            InitializeComponent();
        }
        Schedule sch = new Schedule();
        private void frmmovie_Load(object sender, EventArgs e)
        {
            tvshow();
            seat();
        }

        #region 动态生成座位
        public void seat()
        {
            Point p = new Point();
            int a = 1;
            int b = 1;
            p.X = 38;
            p.Y = 66;
            for (int j = 0; j < 4; j++)
            {
                for (int i = 0; i < 5; i++)
                {

                    Label lb = new Label();
                    lb.Text = a + "-" + b;
                    lb.BackColor = Color.Yellow;
                    lb.Location = p;
                    lb.Size = new Size(55, 25);
                    lb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                    tabPage2.Controls.Add(lb);
                    lb.Click += lb_Click;
                    p.X += 140;
                    b++;

                }
                p.Y += 60;
                p.X = 38;
                b = 1;
                a++;
            }
        }

        void lb_Click(object sender, EventArgs e)
        {
            Label lb = (Label)sender;
            lb.BackColor = Color.Red;
            MessageBox.Show(lb.Text);
        }
        #endregion

        #region 初始化treeview
        public void tvshow()
        {
            string name = null;
            sch.LoadItems();
            foreach (ScheduleItem item in sch.Items.Values)
            {
                if (name == item.Movie.MovieName)
                {
                    continue;
                }
                TreeNode tn = new TreeNode();
                tn.Text = item.Movie.MovieName;
                treeView1.Nodes.Add(tn);
                name = item.Movie.MovieName;
                foreach (string key in sch.Items.Keys)
                {
                    if (sch.Items[key].Movie.MovieName == tn.Text)
                    {
                        tn.Nodes.Add(new TreeNode(key));
                    }
                }
            }
        } 
        #endregion

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (treeView1.SelectedNode.Level==0)
            {
                return;
            }
           
            foreach (string item in sch.Items.Keys)
            {
                if (treeView1.SelectedNode.Text==item&&
                    treeView1.SelectedNode.Parent.Text == sch.Items[item].Movie.MovieName)
                {
                    Image im = new Bitmap(sch.Items[item].Movie.MovieName + ".jpg");
                    pictureBox2.Image = im;
                  
                   
                    lb1.Text = "导演:\t" + sch.Items[item].Movie.Director;
                    
                   
                }
            }
            
        }


        
    }
}
