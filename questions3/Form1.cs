using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace questions3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Address ad = new Address();
        private void Form1_Load(object sender, EventArgs e)
        {
            //调用方法
            treeviewload();

            
        }



        public void treeviewload()
        {
            //接受返回对象
            XmlElement root = ad.loadxml();
            //创建树节点
            TreeNode tn = new TreeNode();
            //获取自定义name属性
            tn.Text = root.Attributes["name"].Value.ToString();
            //添加节点
            tvAddress.Nodes.Add(tn);
            //遍历
            foreach (XmlElement item in root.ChildNodes)
            {
                TreeNode tn1 = new TreeNode();
                //创建子节点
                tn1.Text = item.Attributes["name"].Value.ToString();
                tn.Nodes.Add(tn1);
                foreach (XmlElement node in item.ChildNodes)
                {
                    
                    TreeNode tn2 = new TreeNode();
                    //判定父节点
                    if (node.ParentNode.Attributes["name"].Value.ToString() == tn1.Text)
                    {
                        //创建子节点
                        tn2.Text = node.Attributes["name"].Value.ToString();
                        tn1.Nodes.Add(tn2);
                    }
                    foreach (XmlElement nodes in node.ChildNodes)
                    {
                        TreeNode tn3 = new TreeNode();
                        //判定父节点
                        if (nodes.ParentNode.Attributes["name"].Value.ToString() == tn2.Text)
                        {
                            //创建子节点
                            tn3.Text = nodes.InnerText;
                            tn2.Nodes.Add(tn3);
                        }
                    }
                }
            }
        
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

            //根据选择深度填写 信息
            if (tvAddress.SelectedNode.Level==0)
            {
                txtJiedao.Text = tvAddress.SelectedNode.Text;
            }
            if (tvAddress.SelectedNode.Level==1)
            {
                txtJiedao.Text = tvAddress.SelectedNode.Parent.Text;
                txtJu.Text = tvAddress.SelectedNode.Text;
            }
            if (tvAddress.SelectedNode.Level==2)
            {
                txtJiedao.Text = tvAddress.SelectedNode.Parent.Parent.Text;
                txtJu.Text = tvAddress.SelectedNode.Parent.Text;
                txtLou.Text=tvAddress.SelectedNode.Text;
            }
            if (tvAddress.SelectedNode.Level==3)
            {
                txtJiedao.Text = tvAddress.SelectedNode.Parent.Parent.Parent.Text;
                txtJu.Text = tvAddress.SelectedNode.Parent.Parent.Text;
                txtLou.Text = tvAddress.SelectedNode.Parent.Text;
                txtNo.Text=tvAddress.SelectedNode.Text;
            }
        }
    }
}
