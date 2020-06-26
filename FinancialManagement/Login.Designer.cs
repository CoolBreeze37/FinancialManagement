namespace FinancialManagement
{
    partial class Login
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LoginUserName = new System.Windows.Forms.ComboBox();
            this.LoginUserPassworld = new System.Windows.Forms.TextBox();
            this.CancelLogin = new System.Windows.Forms.Button();
            this.ConfirmLogin = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("宋体", 26.18182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(211, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(362, 60);
            this.label1.TabIndex = 0;
            this.label1.Text = "理财管理信息系统";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 13.74545F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(231, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "用户名";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 13.74545F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(232, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "密  码";
            // 
            // LoginUserName
            // 
            this.LoginUserName.Font = new System.Drawing.Font("宋体", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LoginUserName.FormattingEnabled = true;
            this.LoginUserName.Location = new System.Drawing.Point(358, 181);
            this.LoginUserName.Name = "LoginUserName";
            this.LoginUserName.Size = new System.Drawing.Size(194, 26);
            this.LoginUserName.TabIndex = 3;
            // 
            // LoginUserPassworld
            // 
            this.LoginUserPassworld.Font = new System.Drawing.Font("宋体", 13.74545F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LoginUserPassworld.Location = new System.Drawing.Point(358, 242);
            this.LoginUserPassworld.Name = "LoginUserPassworld";
            this.LoginUserPassworld.PasswordChar = '*';
            this.LoginUserPassworld.Size = new System.Drawing.Size(194, 31);
            this.LoginUserPassworld.TabIndex = 4;
            // 
            // CancelLogin
            // 
            this.CancelLogin.Font = new System.Drawing.Font("宋体", 13.74545F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CancelLogin.Location = new System.Drawing.Point(236, 331);
            this.CancelLogin.Name = "CancelLogin";
            this.CancelLogin.Size = new System.Drawing.Size(75, 36);
            this.CancelLogin.TabIndex = 5;
            this.CancelLogin.Text = "取消";
            this.CancelLogin.UseVisualStyleBackColor = true;
            this.CancelLogin.Click += new System.EventHandler(this.CancelLogin_Click);
            // 
            // ConfirmLogin
            // 
            this.ConfirmLogin.Font = new System.Drawing.Font("宋体", 13.74545F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ConfirmLogin.Location = new System.Drawing.Point(477, 331);
            this.ConfirmLogin.Name = "ConfirmLogin";
            this.ConfirmLogin.Size = new System.Drawing.Size(75, 36);
            this.ConfirmLogin.TabIndex = 6;
            this.ConfirmLogin.Text = "确认";
            this.ConfirmLogin.UseVisualStyleBackColor = true;
            this.ConfirmLogin.Click += new System.EventHandler(this.ConfirmLogin_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(355, 300);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 14);
            this.label4.TabIndex = 7;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ConfirmLogin);
            this.Controls.Add(this.CancelLogin);
            this.Controls.Add(this.LoginUserPassworld);
            this.Controls.Add(this.LoginUserName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Login";
            this.Text = "登录";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox LoginUserName;
        private System.Windows.Forms.TextBox LoginUserPassworld;
        private System.Windows.Forms.Button CancelLogin;
        private System.Windows.Forms.Button ConfirmLogin;
        private System.Windows.Forms.Label label4;
    }
}

