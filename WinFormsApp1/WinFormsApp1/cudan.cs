using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using ADGV;
using System.Data.Common;

namespace WinFormsApp1
{
    public partial class cudan : Form
    {
        string connectionString = @"Data Source=LAPTOP-CHM74T1E\MSSQLSERVER01;Initial Catalog=Manage;Integrated Security=True";
        public cudan()
        {
            InitializeComponent();
        }
        private void CongNo()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM Công_nợ";
                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        AssignRowHeaderIDs(dataTable);
                        advancedDataGridView1.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void YeuCau()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM Yêu_cầu_dịch_vụ";
                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        advancedDataGridView1.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void TinhTrang()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT Mã_căn_hộ as 'Mã căn hộ',Tình_trạng_nội_thất,Tình_trạng_người_ở,Tình_trạng_bàn_giao FROM Căn_hộ";
                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        AssignRowHeaderIDs(dataTable);
                        advancedDataGridView1.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void CuDan()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM Resident";
                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        AssignRowHeaderIDs(dataTable);
                        advancedDataGridView1.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void CanHo()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM Căn_Hộ";
                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        AssignRowHeaderIDs(dataTable);
                        advancedDataGridView1.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = comboBox1.SelectedItem.ToString();
            switch (selectedItem)
            {
                case "Công nợ":
                    CongNo();
                    ConfigureComboBox();
                    break;
                case "Yêu cầu dịch vụ":
                    YeuCau();
                    ConfigureComboBox();
                    break;
                case "Tình trạng căn hộ":
                    TinhTrang();
                    ConfigureComboBox();
                    break;
                case "Danh sách cư dân":
                    CuDan();
                    ConfigureComboBox();
                    break;
                case "Danh sách căn hộ":
                    CanHo();
                    ConfigureComboBox();
                    break;
                default:
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
        }

        private DataTable AssignRowHeaderIDs(DataTable dataTable)
        {
            {
                DataColumn sttColumn = new DataColumn("STT", typeof(int));
                dataTable.Columns.Add(sttColumn);
                dataTable.Columns["STT"].SetOrdinal(0);
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    dataTable.Rows[i]["STT"] = i + 1;
                }

                return dataTable;
            }
        }

        private void advancedDataGridView1_SortStringChanged(object sender, EventArgs e)
        {
            string sortString = advancedDataGridView1.SortString;
            if (!string.IsNullOrEmpty(sortString))
            {
                (advancedDataGridView1.DataSource as DataTable).DefaultView.Sort = sortString;
            }
            else
            {
                (advancedDataGridView1.DataSource as DataTable).DefaultView.Sort = "";
            }
        }

        private void advancedDataGridView1_FilterStringChanged(object sender, EventArgs e)
        {
            string filterString = advancedDataGridView1.FilterString;
            if (!string.IsNullOrEmpty(filterString))
            {
                (advancedDataGridView1.DataSource as DataTable).DefaultView.RowFilter = filterString;
            }
            else
            {
                (advancedDataGridView1.DataSource as DataTable).DefaultView.RowFilter = "";
            }
        }

        private void ConfigureComboBox()
        {
            comboBox2.Items.Clear();
            foreach (DataGridViewColumn column in advancedDataGridView1.Columns)
            {
                comboBox2.Items.Add(column.HeaderText);
            }
            if (comboBox2.Items.Count > 0)
                comboBox2.SelectedIndex = 0;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedItem == null)
                return;

            string columnName = comboBox2.SelectedItem.ToString();
            string filterValue = textBox1.Text;

            DataTable dataTable = advancedDataGridView1.DataSource as DataTable;
            if (dataTable != null)
            {
                Type columnType = dataTable.Columns[columnName].DataType;

                if (columnType == typeof(string))
                {
                    // Use LIKE operator for string type
                    dataTable.DefaultView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", columnName, filterValue);
                }
                else
                {
                    // Convert data to string and use LIKE operator for non-string types
                    dataTable.DefaultView.RowFilter = string.Format("Convert([{0}], 'System.String') LIKE '%{1}%'", columnName, filterValue);
                }
            }
        }

    }
}
