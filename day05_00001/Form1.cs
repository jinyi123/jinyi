using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace day05_00001
{
    public partial class frmHealth : Form
    {
        public frmHealth()
        {
            InitializeComponent();
        }
        //数据初始化
        CheckIeem ieem;
        CheckSet set;
        //新建套餐列表集合
        Dictionary<string, CheckSet> combo = new Dictionary<string, CheckSet>();
        //新建检查项目集合
        List<CheckIeem> items = new List<CheckIeem>
        {
            new CheckIeem("身高","用于检查身高",  10),
            new CheckIeem("体重","用于检查体重",  10),
            new CheckIeem( "视力","用于检查视力", 20),
            new CheckIeem("听力","用于检查听力",  20),
            new CheckIeem("肝功能","用于检查肝功能",  50),
            new CheckIeem("B超","用于检查B超",  100),
            new CheckIeem("心电图","用于检查心电图",  100),
            new CheckIeem("血压","用于检查血压",  10),

        };
        
       //初始化方法
        #region 初始化
        public void info()
        {
            //建立选项
            ieem = new CheckIeem("身高", "用于检查身高", 10);
            //加入新建套餐
            set = new CheckSet(ieem, "入学体检");
            //新建选项并添加到套餐
            set.list.Add(new CheckIeem("肝功能", "用于检查肝功能", 50));
            //新建选项并添加到套餐
            set.list.Add(new CheckIeem("血压", "用于检查血压", 10));
            //计算价钱
            set.Rmb();
            //加入到套餐组
            //组  添加 key      套餐
            combo.Add(set.Name, set);
            
            //绑定数据源，运用BingdingSource把套餐组绑定到下拉框
            BindingSource bs = new BindingSource();
            bs.DataSource = combo;
            cboSelect.DataSource = bs;
            //下拉列表拿key值
            cboSelect.DisplayMember = "Key";

            //把套餐的选项集合添加到下拉框
            cboItem.DataSource = new BindingList<CheckIeem>(items);
            //显示的值拿Name值
            cboItem.DisplayMember = "Name";
            //把                                           套餐组[下拉框文本] 的套餐绑定到dataGridView
            dgvForm.DataSource = new BindingList<CheckIeem>(combo[cboSelect.Text].list);


        } 
        #endregion
        
        private void frmHealth_Load(object sender, EventArgs e)
        {
          
            //初始化
            info();
            //窗体lable4显示的文字
            lblName.Text = "检查项目:" + cboSelect.Text;
            //窗体lable4显示的金额
            lblPrice.Text = combo[cboSelect.Text].Price.ToString ();
            i = 1;
        }


        int i = 0;
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (i==1)
            {
                //更换数据源
                dgvForm.DataSource = combo[cboSelect.Text].list;
                //更换提示
                lblName.Text = "检查项目:" + cboSelect.Text;
                //调用计算价钱方法
                lblPrice.Text = combo[cboSelect.Text].Price.ToString();
                //计算价钱
                combo[cboSelect.Text].Rmb();
            }
          
        }

        /// <summary>
        /// 添加套餐的方法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        #region 添加套餐的方法
        private void btnInsert_Click(object sender, EventArgs e)
        {
            //如果为空
            if (txtTC.Text == string.Empty.Trim())
            {
                MessageBox.Show("请输入正确套餐");
            }
            else
            {
                //定一个条件
                bool pan = true;
                //建立套餐集合遍历循环循环Keys
                foreach (string item in combo.Keys)
                {
                    //如果某个套餐的文本和新建文本相等
                    if (item.Equals(txtTC.Text))
                    {
                        //判定
                        pan = false;
                    }

                }
                if (pan)
                {
                    //新建一个套餐组
                    CheckSet a = new CheckSet();
                    a.Name = txtTC.Text;//设定名称
                    //导入套餐集合
                    //        key     值
                    combo.Add(a.Name, a);
                    //运用bindingSource绑定数据源
                    BindingSource bs = new BindingSource();
                    bs.DataSource = combo;
                    cboSelect.DataSource = bs;
                    //拿到key的值
                    cboSelect.DisplayMember = "Key";
                    cboSelect.SelectedItem = combo[txtTC.Text];                   
                    pan = true;
                    //修改列表文本
                    cboSelect.Text = txtTC.Text;

                    MessageBox.Show("添加成功！");
                }
                else
                {
                    MessageBox.Show("已有该套餐！");
                }

            }

        } 
        #endregion

        /// <summary>
        /// 下拉框更改事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboSelect_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ////更换数据源
            //dgvForm.DataSource = combo[cboSelect.Text].list;
            ////更换提示
            //lblName.Text = "检查项目:" + cboSelect.Text;
            ////调用计算价钱方法
            //lblPrice.Text = combo[cboSelect.Text].Price.ToString();
            ////计算价钱
            //combo[cboSelect.Text].Rmb();
        
        }

        /// <summary>
        /// 添加项目的方法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        #region 添加项目的方法
        private void btnTian_Click(object sender, EventArgs e)
        {
            //定判定条件
            bool pan = false;
            //建立遍历循环 循环一个套餐
                                            //套餐组     .   套餐
                                      //套餐集合[下拉框文本].套餐
            foreach (CheckIeem item in combo[cboSelect.Text].list)
            {
                //如果这个套餐的名字等于你要添加的套餐集合的那一项的名字
                if (item.Name.Equals(items[cboItem.SelectedIndex].Name))
                {
                    //修改条件
                    pan = true;
                    break;
                }
            }
            if (pan)
            {
                MessageBox.Show("已有该项");

            }
            else
            {
                //选中的套餐组       的套餐添加   套餐集合的选中项 
                combo[cboSelect.Text].list.Add(items[cboItem.SelectedIndex]);
                //更新数据源
                dgvForm.DataSource = new BindingList<CheckIeem>(combo[cboSelect.Text].list);
                //刷新label显示文字
                combo[cboSelect.Text].Rmb();
                lblPrice.Text = combo[cboSelect.Text].Price.ToString();
            }
        } 
        #endregion

        /// <summary>
        /// 删除的方法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        #region 删除的方法
        private void btnDel_Click(object sender, EventArgs e)
        {
            //如果套餐组的            套餐 计数大于0
            if (combo[cboSelect.Text].list.Count > 0)
            {
              //套餐组的             套餐  删除   （列表    这一行     索引）
                combo[cboSelect.Text].list.RemoveAt(dgvForm.CurrentRow.Index);
                //更新数据源
                dgvForm.DataSource = new BindingList<CheckIeem>(combo[cboSelect.Text].list);
                //更新价钱
                combo[cboSelect.Text].Rmb();
                lblPrice.Text = combo[cboSelect.Text].Price.ToString();
            }
            else
            {
                MessageBox.Show("已无任何项目！");
            }
        } 
        #endregion


        private void dgvForm_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
