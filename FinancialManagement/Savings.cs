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
    public partial class Savings : Form
    {
        public Savings()
        {
            InitializeComponent();
        }

        private void savingBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.savingBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.financialManagementDataSet2);

        }

        private void Savings_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“financialManagementDataSet2.saving”中。您可以根据需要移动或删除它。
            this.savingTableAdapter.Fill(this.financialManagementDataSet2.saving);

        }

        private void savingDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("保存失败！请检查格式！");
        }
    }
}
