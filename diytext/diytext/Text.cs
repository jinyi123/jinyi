using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace diytext
{
    public partial class Text : TextBox
    {
        public Text()
        {
            InitializeComponent();
        }
      
        private void Text_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if ((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == '.' || (byte)(e.KeyChar) == 8)
            {
               
              
            }
            else
            {
                e.Handled = true;
            }
        }

        private void Text_KeyUp(object sender, KeyEventArgs e)
        {
           
        }
    }
}
