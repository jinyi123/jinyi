namespace day05_00001
{
    partial class frmHealth
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.gpb1 = new System.Windows.Forms.GroupBox();
            this.txtTC = new System.Windows.Forms.TextBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.lblTCname = new System.Windows.Forms.Label();
            this.gpb2 = new System.Windows.Forms.GroupBox();
            this.dgvForm = new System.Windows.Forms.DataGridView();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnTian = new System.Windows.Forms.Button();
            this.cboItem = new System.Windows.Forms.ComboBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.cboSelect = new System.Windows.Forms.ComboBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblJcxm = new System.Windows.Forms.Label();
            this.lblTclb = new System.Windows.Forms.Label();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gpb1.SuspendLayout();
            this.gpb2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvForm)).BeginInit();
            this.SuspendLayout();
            // 
            // gpb1
            // 
            this.gpb1.Controls.Add(this.txtTC);
            this.gpb1.Controls.Add(this.btnInsert);
            this.gpb1.Controls.Add(this.lblTCname);
            this.gpb1.Location = new System.Drawing.Point(65, 43);
            this.gpb1.Name = "gpb1";
            this.gpb1.Size = new System.Drawing.Size(572, 95);
            this.gpb1.TabIndex = 0;
            this.gpb1.TabStop = false;
            this.gpb1.Text = "新建套餐";
            // 
            // txtTC
            // 
            this.txtTC.Location = new System.Drawing.Point(129, 37);
            this.txtTC.Name = "txtTC";
            this.txtTC.Size = new System.Drawing.Size(274, 25);
            this.txtTC.TabIndex = 6;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(429, 36);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(86, 26);
            this.btnInsert.TabIndex = 1;
            this.btnInsert.Text = "添加";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // lblTCname
            // 
            this.lblTCname.AutoSize = true;
            this.lblTCname.Location = new System.Drawing.Point(41, 44);
            this.lblTCname.Name = "lblTCname";
            this.lblTCname.Size = new System.Drawing.Size(82, 15);
            this.lblTCname.TabIndex = 0;
            this.lblTCname.Text = "套餐名称：";
            // 
            // gpb2
            // 
            this.gpb2.Controls.Add(this.dgvForm);
            this.gpb2.Controls.Add(this.btnDel);
            this.gpb2.Controls.Add(this.btnTian);
            this.gpb2.Controls.Add(this.cboItem);
            this.gpb2.Controls.Add(this.statusStrip1);
            this.gpb2.Controls.Add(this.cboSelect);
            this.gpb2.Controls.Add(this.lblPrice);
            this.gpb2.Controls.Add(this.lblName);
            this.gpb2.Controls.Add(this.lblJcxm);
            this.gpb2.Controls.Add(this.lblTclb);
            this.gpb2.Location = new System.Drawing.Point(65, 181);
            this.gpb2.Name = "gpb2";
            this.gpb2.Size = new System.Drawing.Size(572, 402);
            this.gpb2.TabIndex = 1;
            this.gpb2.TabStop = false;
            this.gpb2.Text = "检查套餐维护";
            // 
            // dgvForm
            // 
            this.dgvForm.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvForm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvForm.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column1,
            this.Column3});
            this.dgvForm.Location = new System.Drawing.Point(44, 157);
            this.dgvForm.MultiSelect = false;
            this.dgvForm.Name = "dgvForm";
            this.dgvForm.RowTemplate.Height = 27;
            this.dgvForm.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvForm.Size = new System.Drawing.Size(522, 239);
            this.dgvForm.TabIndex = 9;
            this.dgvForm.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvForm_CellContentClick);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(394, 79);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(86, 26);
            this.btnDel.TabIndex = 8;
            this.btnDel.Text = "删除";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnTian
            // 
            this.btnTian.Location = new System.Drawing.Point(248, 79);
            this.btnTian.Name = "btnTian";
            this.btnTian.Size = new System.Drawing.Size(86, 26);
            this.btnTian.TabIndex = 7;
            this.btnTian.Text = "添加";
            this.btnTian.UseVisualStyleBackColor = true;
            this.btnTian.Click += new System.EventHandler(this.btnTian_Click);
            // 
            // cboItem
            // 
            this.cboItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboItem.FormattingEnabled = true;
            this.cboItem.Location = new System.Drawing.Point(394, 31);
            this.cboItem.Name = "cboItem";
            this.cboItem.Size = new System.Drawing.Size(121, 23);
            this.cboItem.TabIndex = 6;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(3, 377);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(566, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // cboSelect
            // 
            this.cboSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSelect.FormattingEnabled = true;
            this.cboSelect.Location = new System.Drawing.Point(138, 31);
            this.cboSelect.Name = "cboSelect";
            this.cboSelect.Size = new System.Drawing.Size(121, 23);
            this.cboSelect.TabIndex = 2;
            this.cboSelect.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.cboSelect.SelectionChangeCommitted += new System.EventHandler(this.cboSelect_SelectionChangeCommitted);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(266, 126);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(55, 15);
            this.lblPrice.TabIndex = 4;
            this.lblPrice.Text = "label5";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(51, 126);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(55, 15);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "label4";
            // 
            // lblJcxm
            // 
            this.lblJcxm.AutoSize = true;
            this.lblJcxm.Location = new System.Drawing.Point(299, 39);
            this.lblJcxm.Name = "lblJcxm";
            this.lblJcxm.Size = new System.Drawing.Size(82, 15);
            this.lblJcxm.TabIndex = 2;
            this.lblJcxm.Text = "检查项目：";
            // 
            // lblTclb
            // 
            this.lblTclb.AutoSize = true;
            this.lblTclb.Location = new System.Drawing.Point(51, 39);
            this.lblTclb.Name = "lblTclb";
            this.lblTclb.Size = new System.Drawing.Size(82, 15);
            this.lblTclb.TabIndex = 1;
            this.lblTclb.Text = "套餐列表：";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Name";
            this.Column2.HeaderText = "名称";
            this.Column2.Name = "Column2";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Description";
            this.Column1.HeaderText = "说明";
            this.Column1.Name = "Column1";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Price";
            this.Column3.HeaderText = "价格";
            this.Column3.Name = "Column3";
            // 
            // frmHealth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 595);
            this.Controls.Add(this.gpb2);
            this.Controls.Add(this.gpb1);
            this.Name = "frmHealth";
            this.Text = "体检系统";
            this.Load += new System.EventHandler(this.frmHealth_Load);
            this.gpb1.ResumeLayout(false);
            this.gpb1.PerformLayout();
            this.gpb2.ResumeLayout(false);
            this.gpb2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvForm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpb1;
        public System.Windows.Forms.GroupBox gpb2;
        public System.Windows.Forms.TextBox txtTC;
        public System.Windows.Forms.Button btnInsert;
        public System.Windows.Forms.Label lblTCname;
        public System.Windows.Forms.DataGridView dgvForm;
        public System.Windows.Forms.Button btnDel;
        public System.Windows.Forms.Button btnTian;
        public System.Windows.Forms.ComboBox cboItem;
        public System.Windows.Forms.StatusStrip statusStrip1;
        public System.Windows.Forms.ComboBox cboSelect;
        public System.Windows.Forms.Label lblPrice;
        public System.Windows.Forms.Label lblName;
        public System.Windows.Forms.Label lblJcxm;
        public System.Windows.Forms.Label lblTclb;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}

