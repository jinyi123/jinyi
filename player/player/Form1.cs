using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace player
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Song> song = new List<Song> 
        {
        new Song(){SongName = "OMFG - Yeah",path="F:\\CloudMusic\\OMFG - Yeah.mp3"},
        new Song(){SongName = "新裤子 - 没有理想的人不伤心",path="F:\\CloudMusic\\新裤子 - 没有理想的人不伤心.mp3"},
        new Song(){SongName = "OMFG - Hello",path="F:\\CloudMusic\\OMFG - Hello.mp3"},
        
        };

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = new BindingList<Song>(song);
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.ReadOnly = true;
        }
       
        private void 播放ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count>0)
            {
                if (dataGridView1.SelectedRows[0].Cells[1].Value==null)
                {
                      MessageBox.Show("请选择一首歌");
                }
                else
                {
                    player play = player.getinstance();
                    play.path = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();                  
                    play.play();
                    play.Show();
                }
              
            }
            else
            {
                MessageBox.Show("请选择一首歌");
            }
           
        }

    }
}
