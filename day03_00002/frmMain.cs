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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }



        Dictionary<int, sign_in> table = new Dictionary<int, sign_in>();
        List<staff> list = new List<staff>() { 
                
                new staff(){ID = 1001,Name = "历新年",Age = 21,Sex = "女"},
                new staff(){ID = 1002,Name = "范闲",Age = 24,Sex = "男"},
                new staff(){ID = 1003,Name = "余帘",Age = 23,Sex = "女"}
         
            };

       
        

        private void frmMain_Load(object sender, EventArgs e)
        {
            show();
        }

     

        public void show()
        {
            dgvStaff.DataSource = new BindingList<staff>(list);

        
        }
  
        private void 新增ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSelect se = new frmSelect(this,list);           
            se.Show();
        }

        private void 修改ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSelect se = new frmSelect(this, list);
            se.btnEN.Text = "修改";
            se.dgv = dgvStaff.SelectedRows[0];
            se.txtID.Enabled = false;
            se.Show();
        }

        private void 签到ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(dgvStaff.SelectedRows[0].Cells[0].Value)>0)
            {
                int index = Convert.ToInt32(dgvStaff.SelectedRows[0].Cells[0].Value);
                bool bo = true;
                foreach (int item in table.Keys)
                {
                    if (table[item].ID.Equals(index))
                    {                      
                        bo = false;
                        break;
                    }
                }
                if (bo)
                {
                    sign_in sn = new sign_in();
                    sn.ID = Convert.ToInt32(dgvStaff.SelectedRows[0].Cells[0].Value);
                    sn.Name = dgvStaff.SelectedRows[0].Cells[1].Value.ToString();
                    sn.In = DateTime.Now;
                    table.Add(Convert.ToInt32(dgvStaff.SelectedRows[0].Cells[0].Value),sn);
                    MessageBox.Show("签到成功");
                    bo = true;
                }
                else
                {
                    MessageBox.Show("您已签过到");
                }
            }
            else
            {
                MessageBox.Show("请选中一行");
            }
        }

        private void 签退ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            int index = Convert.ToInt32(dgvStaff.SelectedRows[0].Cells[0].Value);
            if (Convert.ToInt32(dgvStaff.SelectedRows[0].Cells[0].Value) > 0)
            {
                bool a = false;
                foreach (int item in table.Keys)
                {
                   
                     if (table[item].ID == index)
                    {
                        table[item].Out = DateTime.Now;
                        MessageBox.Show("签退成功");
                        a = true;
                        break;

                    }
                    
                }
                  if (!a)
                    {
                        MessageBox.Show("您尚未签到！");
                    }
             
            }
            else
            {
                MessageBox.Show("请选中一行");
            }
        }


        private void 打卡记录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSign si = new frmSign();
            si.table1 = table;
            si.Show();
        }

        private void txtNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            List<staff> list1 = new List<staff>();

            foreach (staff item in list)
            {
                if (item.ID.ToString().IndexOf(txtNo.Text.Trim()) != -1)
                {
                    list1.Add(item);
                }
            }
            dgvStaff.DataSource = new BindingList<staff>(list1);

        }


      



    }
}
