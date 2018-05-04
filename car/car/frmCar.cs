using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace car
{
    public partial class frmCar : Form
    {
        public frmCar()
        {
            InitializeComponent();
            
        }

        Dictionary<string, vehicle> Vehicle = new Dictionary<string, vehicle>();
        Dictionary<string, vehicle> RentVehicle = new Dictionary<string, vehicle>();
        //{
        //    {"奥迪A6",new Car("黄色",650,"京A23333","奥迪A6",0,null,3)}
        //}; 

        Car car1 = new Car("黄色", 650, "京A23333", "奥迪A6", 0, null, 3);
        Car car2 = new Car("银灰色", 420, "京QH8635", "大众普桑", 0, null, 3);
        Truck truck1 = new Truck("红色", 1300, "京A88888", "大运重卡", 0, null, 3, 25);
        Truck truck2 = new Truck("蓝色", 950, "京A23333", "大十轮", 0, null, 3, 15);

        private void frmCar_Load(object sender, EventArgs e)
        {
            Vehicle.Add(truck1.Name, truck1);
            Vehicle.Add(car1.Name, car1);
            RentVehicle.Add(car2.Name, car2);
            RentVehicle.Add(truck2.Name, truck2);
            cbo();
        }

        private void rdbTruck_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #region 刷新方法
        private void btn1F5_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            foreach (vehicle item in Vehicle.Values)
            {
               
                if (item is Car)
                {
                    Car ca = item as Car;
                    ListViewItem items = new ListViewItem(ca.LicenseNO);
                    items.SubItems.Add(ca.Name);
                    items.SubItems.Add(ca.Color);
                    items.SubItems.Add(ca.YearsOfservice.ToString());
                    items.SubItems.Add(ca.DailyRent.ToString());
                    items.SubItems.Add("");
                    listView1.Items.Add(items);
                }
                else if (item is Truck)
                {
                    Truck tr = item as Truck;
                    ListViewItem items = new ListViewItem(tr.LicenseNO);
                    items.SubItems.Add(tr.Name);
                    items.SubItems.Add(tr.Color);
                    items.SubItems.Add(tr.YearsOfservice.ToString());
                    items.SubItems.Add(tr.DailyRent.ToString());
                    items.SubItems.Add(tr.Load.ToString());
                    listView1.Items.Add(items);
                }
            }

        }

        private void btnF5_Click(object sender, EventArgs e)
        {
            listView2.Items.Clear();
            foreach (vehicle item in RentVehicle.Values)
            {
                
                if (item is Car)
                {
                    
                    Car ca = item as Car;
                    ListViewItem items = new ListViewItem(ca.LicenseNO);
                    items.SubItems.Add(ca.Name);
                    items.SubItems.Add(ca.Color);
                    items.SubItems.Add(ca.YearsOfservice.ToString());
                    items.SubItems.Add(ca.DailyRent.ToString());
                    listView2.Items.Add(items);
                }
                else if (item is Truck)
                {
                    Truck tr = item as Truck;
                    ListViewItem items = new ListViewItem(tr.LicenseNO);
                    items.SubItems.Add(tr.Name);
                    items.SubItems.Add(tr.Color);
                    items.SubItems.Add(tr.YearsOfservice.ToString());
                    items.SubItems.Add(tr.DailyRent.ToString());
                    items.SubItems.Add(tr.Load.ToString());
                    listView2.Items.Add(items);
                }
            }
        } 
        #endregion

        #region 租车

        private void button2_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                if (txtCount.Text != "")
                {

                    Vehicle.Add(listView2.SelectedItems[0].SubItems[1].Text.ToString(), RentVehicle[listView2.SelectedItems[0].SubItems[1].Text.ToString()]);
                    RentVehicle.Remove(listView2.SelectedItems[0].SubItems[1].Text.ToString());
                    MessageBox.Show((Convert.ToInt32(listView2.SelectedItems[0].SubItems[4].Text) * Convert.ToInt32(txtCount.Text)).ToString());
                }
                else
                {
                    MessageBox.Show("请输入租赁日期");
                }
            }
            else
            {
                MessageBox.Show("请选择一辆车");
            }

        } 
        #endregion

        #region 还车
        private void btnJsuan_Click(object sender, EventArgs e)
        {
            if (listView2.SelectedItems.Count > 0)
            {
                if (txtCount.Text != "")
                {

                    Vehicle.Add(listView2.SelectedItems[0].SubItems[1].Text.ToString(), RentVehicle[listView2.SelectedItems[0].SubItems[1].Text.ToString()]);
                    RentVehicle.Remove(listView2.SelectedItems[0].SubItems[1].Text.ToString());
                    MessageBox.Show((Convert.ToInt32(listView2.SelectedItems[0].SubItems[4].Text) * Convert.ToInt32(txtCount.Text)).ToString());
                }
                else
                {
                    MessageBox.Show("请输入租赁日期");
                }
            }
            else
            {
                MessageBox.Show("请选择一辆车");
            }

        }
        
        #endregion

        public void cbo()
        {
            List<string> li = new List<string> 
            { 
            "-请选择-",
            "红色",
            "银灰色",
            "蓝色",
            "黄色",
            "白色",
            "银灰色",
            "紫色",
            "绿色"
            };
            cboColor.DataSource =  new BindingList<string>(li);
        }
        private void rdbCar_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbTruck.Checked)
            {
                txtLoad.Enabled = true;
            }
            else
            {
                txtLoad.Enabled = false;
            }
        }

        private void btnEN_Click(object sender, EventArgs e)
        {
           
            if (rdbTruck.Checked)
            {
                Vehicle.Add(txtName.Text,new Truck(cboColor.Text, Convert.ToDouble(txtRmb.Text), txtNo.Text, txtName.Text, 0, "", Convert.ToInt32(txtDate.Text),Convert.ToInt32(txtLoad.Text)));
            }
            else
            {
                Vehicle.Add(txtName.Text, new Car(cboColor.Text, Convert.ToDouble(txtRmb.Text), txtNo.Text, txtName.Text, 0, "", Convert.ToInt32(txtDate.Text)));
            }
        }
    
    }
}
