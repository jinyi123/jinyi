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
    public partial class player : Form
    {
        private player()
        {
            InitializeComponent();
        }
        private static player  onlyOne=null;
        public string path = null;
        private void player_Load(object sender, EventArgs e)
        {

        }

        public void play()
        {
           

            axWindowsMediaPlayer1.URL = path;
            
        }
        public static player getinstance()
        {
            onlyOne = null;
       
                onlyOne = new player();

        
            return onlyOne;
        }

        private void player_FormClosing(object sender, FormClosingEventArgs e)
        {
           // onlyOne = null;
        }
    }
}
