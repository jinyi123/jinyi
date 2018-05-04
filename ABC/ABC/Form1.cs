using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.skinEngine1.SkinFile = Application.StartupPath + "//Calmness.ssk";
           
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
        }

        private void sada1_TextChanged(object sender, EventArgs e)
        {

        }

        private void sada1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)8 && e.KeyChar != (char)13 && e.KeyChar != (char)46 && !(char.IsNumber(e.KeyChar)))
            {
                e.Handled = true;
                MessageBox.Show("请输入数字和小数点");
                sada1.Focus();
                return;
            }


            //小数点不能在开头
            if (e.KeyChar == (char)46 && sada1.Text.Length == 0)
            {
                e.Handled = true;
                MessageBox.Show("请先输入数字");
                return;
            }



            int a = 0; //计算小数点的个数的变量  

            a = sada1.Text.ToString().Trim().Split('.').Length;


            if (e.KeyChar == (char)46 && a > 1)
            {
                e.Handled = true;
                MessageBox.Show("注意只能输入一个小数点");
                return;
            }  
        }


    }
}
