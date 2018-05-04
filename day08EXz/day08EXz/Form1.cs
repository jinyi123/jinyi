using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace day08EXz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            Calculate ca = CalculatorFactory.getInstance(cboCal.Text);
            ca.Numleft = Convert.ToDouble(txtLeft.Text);
            ca.Numright = Convert.ToDouble(txtRight.Text);
            try
            {

                txtResult.Text = ca.Calc().ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                txtResult.Text = "";
                
            }
           
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cat ca2 = cat.getInstance();
            cat ca = cat.getInstance();
            if (ca==ca2)
            {
                MessageBox.Show("颯！");
            }
        }
    }
}
