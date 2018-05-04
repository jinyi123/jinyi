namespace S2230NET
{
    partial class frmInsertUser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInsertUser));
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblXemil = new System.Windows.Forms.Label();
            this.lblXpwd = new System.Windows.Forms.Label();
            this.lblpwd = new System.Windows.Forms.Label();
            this.lblUserid = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblEmali = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtUserid = new System.Windows.Forms.TextBox();
            this.txtXemali = new System.Windows.Forms.TextBox();
            this.txtEmali = new System.Windows.Forms.TextBox();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.txtXpwd = new System.Windows.Forms.TextBox();
            this.btnEN = new System.Windows.Forms.Button();
            this.btnNO = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("隶书", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTitle.Location = new System.Drawing.Point(849, 541);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(244, 43);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "通行证注册";
            // 
            // lblXemil
            // 
            this.lblXemil.AutoSize = true;
            this.lblXemil.BackColor = System.Drawing.Color.Transparent;
            this.lblXemil.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblXemil.ForeColor = System.Drawing.Color.Black;
            this.lblXemil.Location = new System.Drawing.Point(12, 582);
            this.lblXemil.Name = "lblXemil";
            this.lblXemil.Size = new System.Drawing.Size(194, 25);
            this.lblXemil.TabIndex = 1;
            this.lblXemil.Text = "确认邮箱地址：";
            // 
            // lblXpwd
            // 
            this.lblXpwd.AutoSize = true;
            this.lblXpwd.BackColor = System.Drawing.Color.Transparent;
            this.lblXpwd.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblXpwd.ForeColor = System.Drawing.Color.Black;
            this.lblXpwd.Location = new System.Drawing.Point(45, 479);
            this.lblXpwd.Name = "lblXpwd";
            this.lblXpwd.Size = new System.Drawing.Size(142, 25);
            this.lblXpwd.TabIndex = 2;
            this.lblXpwd.Text = "确认密码：";
            // 
            // lblpwd
            // 
            this.lblpwd.AutoSize = true;
            this.lblpwd.BackColor = System.Drawing.Color.Transparent;
            this.lblpwd.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblpwd.ForeColor = System.Drawing.Color.Black;
            this.lblpwd.Location = new System.Drawing.Point(97, 371);
            this.lblpwd.Name = "lblpwd";
            this.lblpwd.Size = new System.Drawing.Size(90, 25);
            this.lblpwd.TabIndex = 4;
            this.lblpwd.Text = "密码：";
            // 
            // lblUserid
            // 
            this.lblUserid.AutoSize = true;
            this.lblUserid.BackColor = System.Drawing.Color.Transparent;
            this.lblUserid.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblUserid.ForeColor = System.Drawing.Color.Black;
            this.lblUserid.Location = new System.Drawing.Point(26, 189);
            this.lblUserid.Name = "lblUserid";
            this.lblUserid.Size = new System.Drawing.Size(168, 25);
            this.lblUserid.TabIndex = 5;
            this.lblUserid.Text = "身份证号码：";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblName.ForeColor = System.Drawing.Color.Black;
            this.lblName.Location = new System.Drawing.Point(97, 100);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(90, 25);
            this.lblName.TabIndex = 6;
            this.lblName.Text = "姓名：";
            // 
            // lblEmali
            // 
            this.lblEmali.AutoSize = true;
            this.lblEmali.BackColor = System.Drawing.Color.Transparent;
            this.lblEmali.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblEmali.ForeColor = System.Drawing.Color.Black;
            this.lblEmali.Location = new System.Drawing.Point(45, 281);
            this.lblEmali.Name = "lblEmali";
            this.lblEmali.Size = new System.Drawing.Size(142, 25);
            this.lblEmali.TabIndex = 7;
            this.lblEmali.Text = "邮箱地址：";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(178, 100);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(183, 25);
            this.txtName.TabIndex = 9;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // txtUserid
            // 
            this.txtUserid.Location = new System.Drawing.Point(178, 189);
            this.txtUserid.Name = "txtUserid";
            this.txtUserid.Size = new System.Drawing.Size(237, 25);
            this.txtUserid.TabIndex = 10;
            // 
            // txtXemali
            // 
            this.txtXemali.Location = new System.Drawing.Point(217, 582);
            this.txtXemali.Name = "txtXemali";
            this.txtXemali.Size = new System.Drawing.Size(183, 25);
            this.txtXemali.TabIndex = 11;
            // 
            // txtEmali
            // 
            this.txtEmali.Location = new System.Drawing.Point(217, 281);
            this.txtEmali.Name = "txtEmali";
            this.txtEmali.Size = new System.Drawing.Size(183, 25);
            this.txtEmali.TabIndex = 12;
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(178, 371);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.Size = new System.Drawing.Size(183, 25);
            this.txtPwd.TabIndex = 13;
            // 
            // txtXpwd
            // 
            this.txtXpwd.Location = new System.Drawing.Point(178, 479);
            this.txtXpwd.Name = "txtXpwd";
            this.txtXpwd.Size = new System.Drawing.Size(183, 25);
            this.txtXpwd.TabIndex = 14;
            // 
            // btnEN
            // 
            this.btnEN.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold);
            this.btnEN.ForeColor = System.Drawing.Color.Coral;
            this.btnEN.Location = new System.Drawing.Point(396, 682);
            this.btnEN.Name = "btnEN";
            this.btnEN.Size = new System.Drawing.Size(139, 46);
            this.btnEN.TabIndex = 15;
            this.btnEN.Text = "注册";
            this.btnEN.UseVisualStyleBackColor = true;
            this.btnEN.Click += new System.EventHandler(this.btnEN_Click);
            // 
            // btnNO
            // 
            this.btnNO.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnNO.Location = new System.Drawing.Point(620, 682);
            this.btnNO.Name = "btnNO";
            this.btnNO.Size = new System.Drawing.Size(128, 46);
            this.btnNO.TabIndex = 16;
            this.btnNO.Text = "取消";
            this.btnNO.UseVisualStyleBackColor = true;
            // 
            // frmInsertUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1163, 763);
            this.Controls.Add(this.btnNO);
            this.Controls.Add(this.btnEN);
            this.Controls.Add(this.txtXpwd);
            this.Controls.Add(this.txtPwd);
            this.Controls.Add(this.txtEmali);
            this.Controls.Add(this.txtXemali);
            this.Controls.Add(this.txtUserid);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblEmali);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblUserid);
            this.Controls.Add(this.lblpwd);
            this.Controls.Add(this.lblXpwd);
            this.Controls.Add(this.lblXemil);
            this.Controls.Add(this.lblTitle);
            this.Name = "frmInsertUser";
            this.Text = "注册界面";
            this.Load += new System.EventHandler(this.frmInsertUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        public System.Windows.Forms.Label lblXemil;
        public System.Windows.Forms.Label lblXpwd;
        public System.Windows.Forms.Label lblpwd;
        public System.Windows.Forms.Label lblUserid;
        public System.Windows.Forms.Label lblName;
        public System.Windows.Forms.Label lblEmali;
        public System.Windows.Forms.TextBox txtName;
        public System.Windows.Forms.TextBox txtUserid;
        public System.Windows.Forms.TextBox txtXemali;
        public System.Windows.Forms.TextBox txtEmali;
        public System.Windows.Forms.TextBox txtPwd;
        public System.Windows.Forms.TextBox txtXpwd;
        private System.Windows.Forms.Button btnEN;
        private System.Windows.Forms.Button btnNO;
    }
}