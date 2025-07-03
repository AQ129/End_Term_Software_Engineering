using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class modify
    {
        public modify()
        {

        }

        SqlCommand sqlCommand;
        SqlDataReader reader;
        SqlDataAdapter dataAdapter;
        public Person person(string query)
        {
            Person people = new Person();
            using (SqlConnection sqlConnection = connection.GetConnection())
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    if (reader["Hình_ảnh"] == DBNull.Value)
                    {
                        people = new Person(reader.GetString(9), reader.GetString(6), reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetDateTime(4), reader.GetString(5), reader.GetString(7), reader.GetString(8), null);
                    }
                    else
                    {
                        people = new Person(reader.GetString(9), reader.GetString(6), reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetDateTime(4), reader.GetString(5), reader.GetString(7), reader.GetString(8), (byte[])reader["Hình_ảnh"]);
                    }
                    
                }
                sqlConnection.Close();
            }

            using (SqlConnection sqlConnection = connection.GetConnection())
            {
                sqlConnection.Open();
                SqlCommand commandExistence = new SqlCommand("Select * from Nhân_viên where Mã_nhân_viên = '" + people.MaNV + "'", sqlConnection);
                object result = commandExistence.ExecuteScalar();
                if (result != null)
                {
                    reader = commandExistence.ExecuteReader();
                    people.ChucVu = "Nhân viên";
                    while (reader.Read())
                    {
                        people.PhanLoai = reader.GetString(0);
                        people.MaNhom = reader.GetString(2);
                    }
                }
                else
                {
                    SqlCommand commandExistence1 = new SqlCommand("Select * from Trưởng_nhóm where Mã_nhân_viên = '" + people.MaNV + "'", sqlConnection);
                    result = commandExistence1.ExecuteScalar();
                    if (result != null)
                    {
                        reader = commandExistence1.ExecuteReader();
                        people.ChucVu = "Trưởng nhóm";
                        people.PhanLoai = "Toàn thời gian";
                        while (reader.Read())
                        {
                            people.MaNhom = reader.GetString(1);
                        }
                    }
                    else
                    {
                        SqlCommand commandExistence2 = new SqlCommand("Select * from Quản_lý where Mã_nhân_viên = '" + people.MaNV + "'", sqlConnection);
                        result = commandExistence2.ExecuteScalar();
                        if (result != null)
                        {
                            reader = commandExistence2.ExecuteReader();
                            people.ChucVu = "Quản lý";
                            people.PhanLoai = "Toàn thời gian";
                            while (reader.Read())
                            {
                                people.MaBP = reader.GetString(1);
                            }
                        }
                        else
                        {
                            string queryInfo = "SELECT * FROM CEO WHERE Mã_nhân_viên = '" + people.MaNV + "'";
                            SqlCommand commandInfo = new SqlCommand(queryInfo, sqlConnection);
                            reader = commandInfo.ExecuteReader();
                            people.ChucVu = "CEO";
                            while (reader.Read())
                            {
                                people.PhanLoai = "Toàn thời gian";
                            }
                        }
                    }
                }
                sqlConnection.Close();
            }

            if (!people.ChucVu.Equals("CEO"))
            {
                if (people.ChucVu.Equals("Nhân viên") || people.ChucVu.Equals("Trưởng nhóm"))
                {
                    using (SqlConnection sqlConnection = connection.GetConnection())
                    {
                        sqlConnection.Open();
                        sqlCommand = new SqlCommand("Select * from Nhóm where Mã_nhóm = '" + people.MaNhom + "'", sqlConnection);
                        reader = sqlCommand.ExecuteReader();
                        while (reader.Read())
                        {
                            people.TenNhom = reader.GetString(1);
                            people.MaBP = reader.GetString(2);
                        }
                        sqlConnection.Close();
                    }
                }
                using (SqlConnection sqlConnection = connection.GetConnection())
                {
                    sqlConnection.Open();
                    sqlCommand = new SqlCommand("Select * from Bộ_phận where Mã_bộ_phận  = '" + people.MaBP + "'", sqlConnection);
                    reader = sqlCommand.ExecuteReader();
                    while (reader.Read())
                    {
                        people.TenBP = reader.GetString(1);
                    }
                    sqlConnection.Close();
                }

            }
            return people;
        }

        public string getPassword(string query)
        {
            string password = "";
            using (SqlConnection sqlConnection = connection.GetConnection())
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    password = reader.GetString(0);
                }
                sqlConnection.Close();
            }
            return password;
        }

        public void Command(string query)
        {
            using (SqlConnection sqlConnection = connection.GetConnection())
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
            }
        }

        public void CommandAnh(string query, byte[] Anh)
        {
            using (SqlConnection sqlConnection = connection.GetConnection())
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                object value = sqlCommand.Parameters.AddWithValue("@Anh", Anh);
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
            }
        }

        public DataTable table(string query)
        {
            DataTable dataSet = new DataTable();
            using(SqlConnection sqlConnection = connection.GetConnection())
            {
                sqlConnection.Open();
                dataAdapter = new SqlDataAdapter(query, sqlConnection);
                dataAdapter.Fill(dataSet);
                sqlConnection.Close();
            }
            return dataSet;
        }
    }
}
