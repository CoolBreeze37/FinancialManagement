using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialManagement
{
    public class Sql
    {
        public SqlConnection sql()
        {
            string strConnection = "user id=sa;password=ghostq;";
            strConnection += "Database=FinancialManagement;Server=LAPTOP-PKQ3PVP4;";
            strConnection += "Connect Timeout=30";
            SqlConnection sqlConnection = new SqlConnection(strConnection);
            return sqlConnection;
        }
        
    }
}
