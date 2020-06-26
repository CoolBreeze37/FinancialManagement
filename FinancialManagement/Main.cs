using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinancialManagement
{
    public partial class Main : Form
    {
        Form _form;
        User _user;
        public Main(Form form ,User user)
        {
            InitializeComponent();
            _form = form;
            _user = user;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://quotes.money.163.com/old");
            this.timer1.Start();
            if(!_user.right)
            {
                addDeleteUserToolStripMenuItem.Enabled = false;
                编辑个人信息ToolStripMenuItem.Enabled = false;
            }
            else
            {
                addDeleteUserToolStripMenuItem.Enabled = true;
                编辑个人信息ToolStripMenuItem.Enabled = true;
            }
            label3.Text = _user.uname;
        }

         

        public void GetTime()
        {
            DateTime Time = DateTime.Now;
            label4.Text = Time.ToString("T");
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            this.GetTime();
        }

        private void 当前登录用户ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Show();
            panel2.Hide();
        }

        private void 公告栏ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Hide();
            panel2.Show();
        }

        private void 计算器ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form myform = new Calculator();
            myform.ShowDialog();
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            _form.Show();
        }

        private void 修改密码ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddDeleteUser addDeleteUser = new AddDeleteUser();
            addDeleteUser.ShowDialog();
        }

        private void addDeleteUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddDeleteUser addDeleteUser = new AddDeleteUser();
            addDeleteUser.ShowDialog();
        }

        private void 编辑个人信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditUserInfocs editUserInfocs = new EditUserInfocs();
            editUserInfocs.ShowDialog();
        }

        private void 收支信息提交ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InOutManagement inOutManagement = new InOutManagement();
            inOutManagement.ShowDialog();
        }

        private void 债务信息添加ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Debt debt = new Debt();
            debt.ShowDialog();
        }

        private void 储蓄信息管理ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Savings savings = new Savings();
            savings.ShowDialog();
        }

    }
}
