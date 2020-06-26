using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinancialManagement
{
    
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void CancelLogin_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ConfirmLogin_Click(object sender, EventArgs e)
        {



            SqlConnection sqlConnection = new Sql().sql();

            sqlConnection.Open();
            //if(objConnection.State == ConnectionState.Open)
            //{
            //    label4.Text = "连接成功！";
            //}
            string sqlStr = string.Format("select * from SystemUsers where uname='{0}'",LoginUserName.Text);
            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand.CommandText = sqlStr;
            sqlCommand.Connection =  sqlConnection;
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while(sqlDataReader.Read())
            {
                User user = new User();
                user.uname = sqlDataReader[0].ToString();
                user.password = sqlDataReader[1].ToString();
                user.right= sqlDataReader.GetBoolean(2);
                user.role= sqlDataReader.GetString(3);
                user.gender = sqlDataReader.GetString(4);


                if (LoginUserName.Text.Equals(user.uname)&&LoginUserPassworld.Text.Equals(user.password) )
                {
                    this.Hide();
                    Form Main = new Main(this,user);
                    Main.ShowDialog();
                }
                else
                {
                    label4.Text = "用户名或密码错误！";
                }
             }
            sqlConnection.Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
    public class User
    {
        public string uname { get; set; }
        public string password { get; set; }
        public bool right { get; set; }
        public string role { get; set; }
        public string gender { get; set; }
    }
}
