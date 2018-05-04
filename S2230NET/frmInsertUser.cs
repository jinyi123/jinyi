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
    public partial class frmInsertUser : Form
    {
        public frmInsertUser()
        {
            InitializeComponent();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEN_Click(object sender, EventArgs e)
        {
            //非空验证
            if (txtName.Text!=""&&txtUserid.Text!=""&&txtEmali.Text!=""&&txtPwd.Text!=""&&txtXpwd.Text!=""&&txtXemali.Text!="")
            {
                //建立一个判断条件 默认为正确的0
                int a = 0;
                //密码邮箱双重验证
                if (txtPwd.Text != txtXpwd.Text)
                {
                    a = 1;
               
                 }
                if (txtEmali.Text!=txtXemali.Text)
                {
                    a = 2;
         
                }
                switch (a)
                {
                    case 0:
                        //建立数组循环
                        for (int i = 0; i < Userinfo.user.Length; i++)
                        {
                            //如果为空的话
                            if (Userinfo.user[i]==null)
                            {
                                //赋值
                                User us = new User();
                                us.Name = txtName.Text;
                                us.Userid = txtUserid.Text;
                                us.Pwd = txtPwd.Text;
                                us.Email = txtEmali.Text;
                                Userinfo.user[i] = us;
                                MessageBox.Show(Userinfo.user[i].Name);
                                MessageBox.Show("注册成功！");
                              //  打开窗体
                                frmMain ma = new frmMain();
                                ma.Show();
                                this.Close();
                                break;
                            }
                        }
                        break;
                    case 1:
                        //提示
                        MessageBox.Show("两次密码不一致");
                        break;
                    case 2:
                        //提示
                        MessageBox.Show("两次邮箱不一致");
                        break;
                }
            }
            else
            {
                MessageBox.Show("用户信息不完整！");
            }
        }

        private void frmInsertUser_Load(object sender, EventArgs e)
        {

        }
    }
}
