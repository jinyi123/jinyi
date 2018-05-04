using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace day03_00002
{
    public partial class frmSign : Form
    {
       
        public frmSign( )
        {
            InitializeComponent();
          
        }

        private void frmSign_Load(object sender, EventArgs e)
        {
            show();
           
        }
        public Dictionary<int, sign_in> table1;
        public void show()
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = table1.Values;
            dgvSign.DataSource = bs;
            lblCount.Text = "共有"+dgvSign.RowCount.ToString()+"条记录";
        }
    }
}
