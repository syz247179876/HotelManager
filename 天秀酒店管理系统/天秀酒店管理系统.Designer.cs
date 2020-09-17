namespace 天秀酒店管理系统
{
    partial class 天秀酒店管理系统
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(天秀酒店管理系统));
            this.label1 = new System.Windows.Forms.Label();
            this.user = new System.Windows.Forms.Label();
            this.pwd = new System.Windows.Forms.Label();
            this.UsertextBox = new System.Windows.Forms.TextBox();
            this.login = new System.Windows.Forms.Button();
            this.cancle = new System.Windows.Forms.Button();
            this.manage = new System.Windows.Forms.RadioButton();
            this.service = new System.Windows.Forms.RadioButton();
            this.pwdtexbox = new System.Windows.Forms.TextBox();
            this.time = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("华文中宋", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Tomato;
            this.label1.Location = new System.Drawing.Point(62, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(509, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "天秀豪华酒店   登入系统";
            // 
            // user
            // 
            this.user.AutoSize = true;
            this.user.BackColor = System.Drawing.Color.Transparent;
            this.user.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.user.ForeColor = System.Drawing.Color.Red;
            this.user.Location = new System.Drawing.Point(95, 174);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(110, 24);
            this.user.TabIndex = 1;
            this.user.Text = "用户名：";
            // 
            // pwd
            // 
            this.pwd.AutoSize = true;
            this.pwd.BackColor = System.Drawing.Color.Transparent;
            this.pwd.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.pwd.ForeColor = System.Drawing.Color.Red;
            this.pwd.Location = new System.Drawing.Point(98, 228);
            this.pwd.Name = "pwd";
            this.pwd.Size = new System.Drawing.Size(85, 24);
            this.pwd.TabIndex = 2;
            this.pwd.Text = "密码：";
            // 
            // UsertextBox
            // 
            this.UsertextBox.Location = new System.Drawing.Point(194, 169);
            this.UsertextBox.Multiline = true;
            this.UsertextBox.Name = "UsertextBox";
            this.UsertextBox.Size = new System.Drawing.Size(179, 25);
            this.UsertextBox.TabIndex = 3;
            // 
            // login
            // 
            this.login.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.login.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.login.ForeColor = System.Drawing.SystemColors.Highlight;
            this.login.Location = new System.Drawing.Point(102, 363);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(90, 34);
            this.login.TabIndex = 7;
            this.login.Text = "登入";
            this.login.UseVisualStyleBackColor = true;
            this.login.Click += new System.EventHandler(this.button1_Click);
            // 
            // cancle
            // 
            this.cancle.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cancle.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cancle.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.cancle.Location = new System.Drawing.Point(274, 363);
            this.cancle.Name = "cancle";
            this.cancle.Size = new System.Drawing.Size(82, 34);
            this.cancle.TabIndex = 8;
            this.cancle.Text = "退出";
            this.cancle.UseVisualStyleBackColor = true;
            this.cancle.Click += new System.EventHandler(this.cancle_Click);
            // 
            // manage
            // 
            this.manage.AutoSize = true;
            this.manage.BackColor = System.Drawing.Color.Transparent;
            this.manage.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.manage.ForeColor = System.Drawing.Color.Black;
            this.manage.Location = new System.Drawing.Point(246, 301);
            this.manage.Name = "manage";
            this.manage.Size = new System.Drawing.Size(70, 24);
            this.manage.TabIndex = 6;
            this.manage.TabStop = true;
            this.manage.Text = "经理";
            this.manage.UseVisualStyleBackColor = false;
            // 
            // service
            // 
            this.service.AutoSize = true;
            this.service.BackColor = System.Drawing.Color.Transparent;
            this.service.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.service.Location = new System.Drawing.Point(115, 301);
            this.service.Name = "service";
            this.service.Size = new System.Drawing.Size(70, 24);
            this.service.TabIndex = 5;
            this.service.TabStop = true;
            this.service.Text = "客服";
            this.service.UseVisualStyleBackColor = false;
            // 
            // pwdtexbox
            // 
            this.pwdtexbox.Location = new System.Drawing.Point(194, 228);
            this.pwdtexbox.Name = "pwdtexbox";
            this.pwdtexbox.Size = new System.Drawing.Size(179, 25);
            this.pwdtexbox.TabIndex = 9;
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.BackColor = System.Drawing.Color.Transparent;
            this.time.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.time.ForeColor = System.Drawing.Color.Black;
            this.time.Location = new System.Drawing.Point(506, 541);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(0, 20);
            this.time.TabIndex = 10;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(1222, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 24);
            this.label2.TabIndex = 11;
            this.label2.Text = "设计者：司云中";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(369, 541);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 20);
            this.label10.TabIndex = 21;
            this.label10.Text = "系统时间:";
            // 
            // skinEngine1
            // 
            this.skinEngine1.SerialNumber = "";
            this.skinEngine1.SkinFile = null;
            // 
            // 天秀酒店管理系统
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1482, 718);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.time);
            this.Controls.Add(this.pwdtexbox);
            this.Controls.Add(this.manage);
            this.Controls.Add(this.service);
            this.Controls.Add(this.cancle);
            this.Controls.Add(this.login);
            this.Controls.Add(this.UsertextBox);
            this.Controls.Add(this.pwd);
            this.Controls.Add(this.user);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "天秀酒店管理系统";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "天秀酒店管理系统";
            this.Load += new System.EventHandler(this.天秀酒店管理系统_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label user;
        private System.Windows.Forms.Label pwd;
        private System.Windows.Forms.TextBox UsertextBox;
        private System.Windows.Forms.Button login;
        private System.Windows.Forms.Button cancle;
        private System.Windows.Forms.RadioButton manage;
        private System.Windows.Forms.RadioButton service;
        private System.Windows.Forms.TextBox pwdtexbox;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private Sunisoft.IrisSkin.SkinEngine skinEngine1;
    }
}

