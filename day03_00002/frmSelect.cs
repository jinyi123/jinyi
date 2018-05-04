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
    public partial class frmSelect : Form
    {
        List<staff> list1;
        frmMain main1;
        public  DataGridViewRow dgv;
        public frmSelect(frmMain main,List<staff> list)
        {
            InitializeComponent();
            list1 = list;
            main1 = main;
        }
       
     

        private void frmSelect_Load(object sender, EventArgs e)
        {
            List<string> Sex = new List<string>() 
            {
            "男",
            "女",
            };
            cboSex.DataSource = Sex;
            if ((btnEN.Text.Equals("修改")))
             {
                txtID.Text = dgv.Cells[0].Value.ToString();
                txtName.Text = dgv.Cells[1].Value.ToString();
                txtAge.Text = dgv.Cells[2].Value.ToString();
                cboSex.Text = dgv.Cells[3].Value.ToString();
             }
        }
        staff test = new staff();
    
        private void btnEN_Click(object sender, EventArgs e)
        {
            if (btnEN.Text.Equals("确定"))
            {
                if (txtAge.Text != null && txtID.Text != null && txtName.Text != null)
                {
                    bool count = true;
                    foreach (staff item in list1)
                    {
                        if (Convert.ToInt32(txtID.Text) .Equals(item.ID))
                        {
                            count = false;
                            
                        }          
                    }
                    if (count==true)
                    {
                        MessageBox.Show("添加成功");
                            test.ID = Convert.ToInt32(txtID.Text);
                            test.Name = txtName.Text;
                            test.Age = Convert.ToInt32(txtAge.Text);
                            test.Sex = cboSex.Text;
                            list1.Add(test);                           
                            main1.dgvStaff.DataSource = new BindingList<staff>(list1);                       
                            this.Close();
                            
                    }
                    else
                    {
                        MessageBox.Show("录入已有ID");
                    }
                   

                }
                else
                {
                    MessageBox.Show("录入信息不完整");
                }
            }
       
       
        }

      
    }
}
