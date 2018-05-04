using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace questions1
{
    public partial class frmTravel : Form
    {
        public frmTravel()
        {
            InitializeComponent();
        }
        //新建日志对象
        Diary da = new Diary();
        private void frmTravel_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //调用方法传参
            da.record(txtDate.Text,txtSite.Text,txtDiary.Text);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
