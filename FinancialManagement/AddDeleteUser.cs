using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinancialManagement
{
    public partial class AddDeleteUser : Form
    {
        public AddDeleteUser()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox2_CheckedClick(object sender, EventArgs e)
        {
            checkBox2.Checked = true;
            checkBox3.Checked = false;
        }

        private void checkBox3_CheckedClick(object sender, EventArgs e)
        {
            checkBox2.Checked = false;

            checkBox3.Checked = true;
        }

        private void AddDeleteUser_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new Sql().sql();

            string sqlStr = string.Format("insert into SystemUsers values('{0}','{1}',{2},'{3}','{4}');",textBox1.Text,textBox2.Text,(checkBox1.Checked?1:0),comboBox1.Text,(checkBox2.Checked?'男':'女'));
            SqlCommand sqlCommand = new SqlCommand();
            Console.WriteLine(sqlStr);
            sqlCommand.CommandText = sqlStr;
            sqlCommand.Connection = sqlConnection;

            sqlConnection.Open();
            try
            {
                sqlCommand.ExecuteNonQuery();
                label6.Text = "添加成功！";
            }
            catch
            {
                label7.Text = "用户名已存在！";
            };

            sqlConnection.Close();
        }
    }
}
