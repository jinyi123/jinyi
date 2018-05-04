using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
        }
        ChannelManager Manager = new ChannelManager();
        Dictionary<string, ChannelBase> allChannel = null;
        TreeNode tn = new TreeNode();
        TreeNode tn1 = new TreeNode();
        private void Form1_Load(object sender, EventArgs e)
        {
           
            tn.Text = "我的频道";
            tvList.Nodes.Add(tn);
           
            tn1.Text = "所有频道";
            tvList.Nodes.Add(tn1);
            loadChannel();
        }

        public void loadChannel()
        {           
          allChannel = Manager.LoadAllChannel();
          foreach (ChannelBase item in allChannel.Values)
          {

              TreeNode tn = new TreeNode();
              tn.Text = item.ChannelName;
              tn.Tag = item;
              TreeNode node = tn1;
              tn1.Nodes.Add(tn);
              tn.ContextMenuStrip = contextMenuStrip1;
          }
        
        
        
        }
        
        private void tvList_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (tvList.SelectedNode.Level==1)
            {
                ChannelBase channel = (ChannelBase)tvList.SelectedNode.Tag;
                channel.Fetch();
             
                dataGridView1.DataSource = /*new BindingList<TvProgram>(*/channel.TvList/*)*/;   
            }

            
        
        }


    }
}
