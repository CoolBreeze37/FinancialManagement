namespace FinancialManagement
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.用户信息管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addDeleteUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.编辑个人信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.收支信息管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.收支信息提交ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.债务信息管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.债务信息添加ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.储蓄信息管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.储蓄信息管理ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.计算器ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.当前登录用户ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.公告栏ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.menuStrip1.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Font = new System.Drawing.Font("宋体", 9.163636F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(284, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 14);
            this.label4.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("宋体", 26.18182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(584, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(402, 46);
            this.label1.TabIndex = 22;
            this.label1.Text = "今日投资信息实况";
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(372, 110);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(665, 384);
            this.webBrowser1.TabIndex = 21;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(18, 18);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.用户信息管理ToolStripMenuItem,
            this.收支信息管理ToolStripMenuItem,
            this.债务信息管理ToolStripMenuItem,
            this.储蓄信息管理ToolStripMenuItem,
            this.计算器ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1043, 33);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 用户信息管理ToolStripMenuItem
            // 
            this.用户信息管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addDeleteUserToolStripMenuItem,
            this.编辑个人信息ToolStripMenuItem});
            this.用户信息管理ToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.用户信息管理ToolStripMenuItem.Name = "用户信息管理ToolStripMenuItem";
            this.用户信息管理ToolStripMenuItem.Size = new System.Drawing.Size(102, 29);
            this.用户信息管理ToolStripMenuItem.Text = "用户信息";
            // 
            // addDeleteUserToolStripMenuItem
            // 
            this.addDeleteUserToolStripMenuItem.Name = "addDeleteUserToolStripMenuItem";
            this.addDeleteUserToolStripMenuItem.Size = new System.Drawing.Size(244, 30);
            this.addDeleteUserToolStripMenuItem.Text = "增删登录用户";
            this.addDeleteUserToolStripMenuItem.Click += new System.EventHandler(this.addDeleteUserToolStripMenuItem_Click);
            // 
            // 编辑个人信息ToolStripMenuItem
            // 
            this.编辑个人信息ToolStripMenuItem.Name = "编辑个人信息ToolStripMenuItem";
            this.编辑个人信息ToolStripMenuItem.Size = new System.Drawing.Size(244, 30);
            this.编辑个人信息ToolStripMenuItem.Text = "编辑登录用户信息";
            this.编辑个人信息ToolStripMenuItem.Click += new System.EventHandler(this.编辑个人信息ToolStripMenuItem_Click);
            // 
            // 收支信息管理ToolStripMenuItem
            // 
            this.收支信息管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.收支信息提交ToolStripMenuItem});
            this.收支信息管理ToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.收支信息管理ToolStripMenuItem.Name = "收支信息管理ToolStripMenuItem";
            this.收支信息管理ToolStripMenuItem.Size = new System.Drawing.Size(102, 29);
            this.收支信息管理ToolStripMenuItem.Text = "收支信息";
            // 
            // 收支信息提交ToolStripMenuItem
            // 
            this.收支信息提交ToolStripMenuItem.Name = "收支信息提交ToolStripMenuItem";
            this.收支信息提交ToolStripMenuItem.Size = new System.Drawing.Size(206, 30);
            this.收支信息提交ToolStripMenuItem.Text = "收支信息管理";
            this.收支信息提交ToolStripMenuItem.Click += new System.EventHandler(this.收支信息提交ToolStripMenuItem_Click);
            // 
            // 债务信息管理ToolStripMenuItem
            // 
            this.债务信息管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.债务信息添加ToolStripMenuItem});
            this.债务信息管理ToolStripMenuItem.Name = "债务信息管理ToolStripMenuItem";
            this.债务信息管理ToolStripMenuItem.Size = new System.Drawing.Size(102, 29);
            this.债务信息管理ToolStripMenuItem.Text = "债务信息";
            // 
            // 债务信息添加ToolStripMenuItem
            // 
            this.债务信息添加ToolStripMenuItem.Name = "债务信息添加ToolStripMenuItem";
            this.债务信息添加ToolStripMenuItem.Size = new System.Drawing.Size(206, 30);
            this.债务信息添加ToolStripMenuItem.Text = "债务信息管理";
            this.债务信息添加ToolStripMenuItem.Click += new System.EventHandler(this.债务信息添加ToolStripMenuItem_Click);
            // 
            // 储蓄信息管理ToolStripMenuItem
            // 
            this.储蓄信息管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.储蓄信息管理ToolStripMenuItem1});
            this.储蓄信息管理ToolStripMenuItem.Name = "储蓄信息管理ToolStripMenuItem";
            this.储蓄信息管理ToolStripMenuItem.Size = new System.Drawing.Size(102, 29);
            this.储蓄信息管理ToolStripMenuItem.Text = "储蓄信息";
            // 
            // 储蓄信息管理ToolStripMenuItem1
            // 
            this.储蓄信息管理ToolStripMenuItem1.Name = "储蓄信息管理ToolStripMenuItem1";
            this.储蓄信息管理ToolStripMenuItem1.Size = new System.Drawing.Size(206, 30);
            this.储蓄信息管理ToolStripMenuItem1.Text = "储蓄信息管理";
            this.储蓄信息管理ToolStripMenuItem1.Click += new System.EventHandler(this.储蓄信息管理ToolStripMenuItem1_Click);
            // 
            // 计算器ToolStripMenuItem
            // 
            this.计算器ToolStripMenuItem.Name = "计算器ToolStripMenuItem";
            this.计算器ToolStripMenuItem.Size = new System.Drawing.Size(83, 29);
            this.计算器ToolStripMenuItem.Text = "计算器";
            this.计算器ToolStripMenuItem.Click += new System.EventHandler(this.计算器ToolStripMenuItem_Click_1);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(177, 1);
            this.toolStripContainer1.Location = new System.Drawing.Point(12, 63);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(177, 26);
            this.toolStripContainer1.TabIndex = 26;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip2.GripMargin = new System.Windows.Forms.Padding(0);
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(18, 18);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.当前登录用户ToolStripMenuItem,
            this.公告栏ToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(15, 63);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Padding = new System.Windows.Forms.Padding(0);
            this.menuStrip2.Size = new System.Drawing.Size(174, 24);
            this.menuStrip2.TabIndex = 0;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // 当前登录用户ToolStripMenuItem
            // 
            this.当前登录用户ToolStripMenuItem.Name = "当前登录用户ToolStripMenuItem";
            this.当前登录用户ToolStripMenuItem.Size = new System.Drawing.Size(107, 24);
            this.当前登录用户ToolStripMenuItem.Text = "当前登录用户";
            this.当前登录用户ToolStripMenuItem.Click += new System.EventHandler(this.当前登录用户ToolStripMenuItem_Click);
            // 
            // 公告栏ToolStripMenuItem
            // 
            this.公告栏ToolStripMenuItem.Name = "公告栏ToolStripMenuItem";
            this.公告栏ToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.公告栏ToolStripMenuItem.Text = "公告栏";
            this.公告栏ToolStripMenuItem.Click += new System.EventHandler(this.公告栏ToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::FinancialManagement.Properties.Resources._1;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.monthCalendar1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(12, 89);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(342, 404);
            this.panel1.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("宋体", 11.78182F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Image = global::FinancialManagement.Properties.Resources._2;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "欢迎用户：";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.BackColor = System.Drawing.Color.White;
            this.monthCalendar1.Location = new System.Drawing.Point(47, 104);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("宋体", 11.78182F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Image = global::FinancialManagement.Properties.Resources._2;
            this.label3.Location = new System.Drawing.Point(115, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 19);
            this.label3.TabIndex = 10;
            this.label3.Text = "张三";
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::FinancialManagement.Properties.Resources._2;
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.richTextBox1);
            this.panel2.Location = new System.Drawing.Point(12, 89);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(342, 404);
            this.panel2.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label5.Font = new System.Drawing.Font("宋体", 22.25455F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Image = global::FinancialManagement.Properties.Resources._2;
            this.label5.Location = new System.Drawing.Point(121, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 35);
            this.label5.TabIndex = 2;
            this.label5.Text = "通知";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.richTextBox1.Cursor = System.Windows.Forms.Cursors.No;
            this.richTextBox1.Enabled = false;
            this.richTextBox1.Location = new System.Drawing.Point(3, 46);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(336, 183);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "尊敬的各位用户：\n       软件处于测试阶段\n\n";
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.Control;
            this.listView1.BackgroundImage = global::FinancialManagement.Properties.Resources._1;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 61);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(342, 280);
            this.listView1.TabIndex = 15;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1043, 508);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStripContainer1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Main";
            this.Text = "Main";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 用户信息管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addDeleteUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 编辑个人信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 收支信息管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 收支信息提交ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 债务信息管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 债务信息添加ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 储蓄信息管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 计算器ToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem 当前登录用户ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 公告栏ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 储蓄信息管理ToolStripMenuItem1;
    }
}