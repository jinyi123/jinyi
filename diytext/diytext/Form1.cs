using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace diytext
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.skinEngine1.SkinFile = Application.StartupPath + "//GlassBrown.ssk";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.skinEngine1.SkinFile = Application.StartupPath + "//GlassBrown.ssk";
        }
    }
}
