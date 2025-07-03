using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WinFormsApp1
{
    class connection
    {
        private static string sql = @"Data Source=LAPTOP-CHM74T1E\MSSQLSERVER01;Initial Catalog=Manage;Integrated Security=True";
        public static SqlConnection GetConnection()
        {
            return new SqlConnection(sql);
        }
    }
}
