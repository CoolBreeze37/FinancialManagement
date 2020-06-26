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
    public partial class Debt : Form
    {
        public Debt()
        {
            InitializeComponent();
        }

        private void debtBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.debtBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.financialManagementDataSet2);

        }

        private void Debt_Load(object sender, EventArgs e)
        {
            
            // TODO: 这行代码将数据加载到表“financialManagementDataSet2.debt”中。您可以根据需要移动或删除它。
            this.debtTableAdapter.Fill(this.financialManagementDataSet2.debt);

        }

        private void debtDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("保存失败，请检查格式！ps:储蓄状态请先勾选再取消！");
        }
    }
}
