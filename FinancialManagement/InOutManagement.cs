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
    
    public partial class InOutManagement : Form
    {
        DataView dataView1 = new DataView();
        DataView dataView2 = new DataView();
        public InOutManagement()
        {
            InitializeComponent();
        }

        private void InOutManagement_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“financialManagementDataSet1.outcome”中。您可以根据需要移动或删除它。
            this.outcomeTableAdapter.Fill(this.financialManagementDataSet1.outcome);
            dataView1 = financialManagementDataSet1.Tables["income"].DefaultView;
            incomeDataGridView.DataSource = dataView1;
            // TODO: 这行代码将数据加载到表“financialManagementDataSet1.income”中。您可以根据需要移动或删除它。
            this.incomeTableAdapter.Fill(this.financialManagementDataSet1.income);
            dataView2 = financialManagementDataSet1.Tables["outcome"].DefaultView;
            outcomeDataGridView.DataSource = dataView2;

        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            string orderstr = "";
            if (comboBox1.Text != "")
                if (radioButton1.Checked)
                    orderstr = comboBox1.Text + " ASC";
            dataView1.Sort = orderstr;

        }

        private void radioButton2_Click(object sender, EventArgs e)
        {
            string orderstr = "";
            if (comboBox1.Text != "")
                if (radioButton2.Checked)
                    orderstr = comboBox1.Text + " DESC";
            dataView1.Sort = orderstr;
        }

        private void radioButton4_Click(object sender, EventArgs e)
        {
            string orderstr = "";
            if (comboBox2.Text != "")
                if (radioButton4.Checked)
                    orderstr = comboBox2.Text + " ASC";
            dataView2.Sort = orderstr;
        }

        private void radioButton3_Click(object sender, EventArgs e)
        {
            string orderstr = "";
            if (comboBox2.Text != "")
                if (radioButton3.Checked)
                    orderstr = comboBox2.Text + " DESC";
            dataView2.Sort = orderstr;
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            this.incomeTableAdapter.Adapter.Update(financialManagementDataSet1);
            MessageBox.Show("保存成功！");
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.outcomeTableAdapter.Adapter.Update(financialManagementDataSet1);
            MessageBox.Show("保存成功！");
        }

        private void InComeManagement_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

            MessageBox.Show("收入表保存失败！请按正确格式填写！");

        }
        private void OutComeManagement_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

            MessageBox.Show("支出表保存失败！请按正确格式填写！");

        }
    }
}
