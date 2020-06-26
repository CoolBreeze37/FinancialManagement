using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinancialManagement
{
    public partial class EditUserInfocs : Form
    {
        DataView dataView = new DataView();
        public EditUserInfocs()
        {
            InitializeComponent();
        }
        private void classesDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e) { }
        private void EditUserInfocs_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“financialManagementDataSet.SystemUsers”中。您可以根据需要移动或删除它。
            this.systemUsersTableAdapter.Fill(this.financialManagementDataSet1.SystemUsers);
            
            dataView = financialManagementDataSet1.Tables["SystemUsers"].DefaultView;
            systemUsersDataGridView.DataSource = dataView;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            comboBox1.Text = "";
            comboBox2.Text = "";
            comboBox3.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string condstr = "";
            if (textBox1.Text != "")
                condstr = "uname like '" + textBox1.Text + "%'";
            if (comboBox1.Text != "")
                if (condstr != "")
                    condstr += " AND role = '" + comboBox1.Text + "'";
                else
                    condstr = "role = '" + comboBox1.Text + "'";
            if (comboBox2.Text != "")
                if (condstr != "")
                    condstr += " AND gender = '" + comboBox2.Text + "'";
                else
                    condstr = "gender = '" + comboBox2.Text + "'";
            if (comboBox3.Text != "")
                if (condstr != "")
                    condstr += " AND isAdmin = " + comboBox3.Text;
                else
                    condstr = "isAdmin = " + comboBox3.Text;
            dataView.RowFilter = condstr;
        }

        private void button4_Click(object sender, EventArgs e)
        {

                this.systemUsersTableAdapter.Update(financialManagementDataSet1);
                MessageBox.Show("保存成功！");

        }

        private void systemUsersDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

                MessageBox.Show("保存失败！请查看用户名是否重复或是否有未填写的值！");
            
        }
    }

   
}
