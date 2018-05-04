using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace S2230NET
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
       
           
          
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void ptbExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void btnDeng_Click(object sender, EventArgs e)
        {
            //建立数组遍历循环
            foreach (User item in Userinfo.user)
            {
                //验证用户名密码正确
                if (txtName.Text.Equals(item.Email) && txtPwd.Text.Equals(item.Pwd))
                {
                    frmGame g = new frmGame();
                    //窗体传值
                    g.lblTitle.Text = item.Name + "召唤师，欢迎来到英雄联盟";
                    g.Show();
                    this.Close();
                    break;

                }
                    //不正确
                else
                {
                    MessageBox.Show("用户信息错误");
                    break;
                }
            }
           
        }

        private void lblZhu_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmInsertUser se = new frmInsertUser();
            se.Show();
        }
    }
}
