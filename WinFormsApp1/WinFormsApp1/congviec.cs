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
using System.Windows.Forms.DataVisualization.Charting;
using ADGV;

namespace WinFormsApp1
{
    public partial class congviec : Form
    {
        private List<Button> buttons;
        private string connectionString = @"Data Source=LAPTOP-CHM74T1E\MSSQLSERVER01;Initial Catalog=Manage;Integrated Security=True";
        private DateTime targetDate = new DateTime(2024, 5, 30);
        DateTime fromDate = new DateTime();
        private string phongban = "";
        public congviec()
        {
            InitializeComponent();
            InitializeButtons();
        }

        private void InitializeButtons()
        {
            buttons = new List<Button> { button1, button2, button3, button4 };
            foreach (Button button in buttons)
            {
                button.Click += Button_Click;
            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            foreach (Button button in buttons)
            {
                button.BackColor = Color.FromArgb(42, 45, 86);
            }
            clickedButton.BackColor = System.Drawing.Color.Teal;
        }       

        private void GetTotalDoanhThuByBoPhan(DateTime fromDate, DateTime targetDate)
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"
                    SELECT 
                        PC.Mã_bộ_phận, 
                        ISNULL(SUM(GQ.Doanh_thu), 0) AS Total_Doanh_thu
                    FROM 
                        Phân_công_cho_BP PC
                    LEFT JOIN 
                        Giải_quyết GQ ON PC.Mã_công_việc = GQ.Mã_công_việc
                    WHERE 
                        GQ.Ngày_cập_nhật <= @TargetDate AND GQ.Ngày_cập_nhật >= @FromDate
                    GROUP BY 
                        PC.Mã_bộ_phận
                ";

                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@TargetDate", targetDate);
                    command.Parameters.AddWithValue("@FromDate", fromDate);
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                    dataAdapter.Fill(dataTable);

                    chart1.DataSource = dataTable;
                    chart1.Series[0].XValueMember = "Mã_bộ_phận";
                    chart1.Series[0].YValueMembers = "Total_Doanh_thu";
                    chart1.DataBind();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void TotalCount(DateTime fromDate, DateTime targetDate)
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT COUNT(*) AS Total_CongViec, " +
                               "SUM(CASE WHEN Tình_trạng = N'Hoàn thành' AND Hoãn = 0 THEN 1 ELSE 0 END) AS CongViecDungHan, " +
                               "COUNT(*) - SUM(CASE WHEN Tình_trạng = N'Hoàn thành' THEN 1 ELSE 0 END) AS CongViecChuaHoanThanh, " +
                               "SUM(CASE WHEN Hoãn = 1 THEN 1 ELSE 0 END) AS CongViecTreHan " +
                               "FROM Giải_quyết WHERE Ngày_cập_nhật <= @TargetDate AND Ngày_cập_nhật >= @FromDate;";

                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@TargetDate", targetDate);
                    command.Parameters.AddWithValue("@FromDate", fromDate);
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                    dataAdapter.Fill(dataTable);

                    int totalCongViec = Convert.ToInt32(dataTable.Rows[0]["Total_CongViec"]);
                    int congViecDungHan = Convert.ToInt32(dataTable.Rows[0]["CongViecDungHan"]);
                    int congViecChuaHoanThanh = Convert.ToInt32(dataTable.Rows[0]["CongViecChuaHoanThanh"]);
                    int congViecTreHan = Convert.ToInt32(dataTable.Rows[0]["CongViecTreHan"]);
                    tong.Text = totalCongViec.ToString();
                    dunghan.Text = congViecDungHan.ToString();
                    trehan.Text = congViecTreHan.ToString();
                    khong.Text = congViecChuaHoanThanh.ToString();

                    int[] data = { congViecDungHan, congViecTreHan, congViecChuaHoanThanh};
                    DrawPieChart(data);                 
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void DrawPieChart(int[] data)
        {
            foreach (var series in chart2.Series)
            {
                series.Points.Clear();
            }

            string[] statuses = { "Đúng hạn", "Trễ hạn", "Không hoàn thành" };
            chart2.Series[0].IsValueShownAsLabel = true;
            for (int i = 0; i < data.Length; i++)
            {
                chart2.Series[0].Points.AddXY(statuses[i], data[i]);              
            }            
        }

        private void ChiTietPhongBan(DateTime fromDate, DateTime targetDate)
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"
                    SELECT 
                        PC.Mã_bộ_phận, 
                        ISNULL(SUM(GQ.Doanh_thu), 0) AS Doanh_thu,
                        COUNT(*) AS So_CongViec,
                        SUM(CASE WHEN Tình_trạng = N'Hoàn thành' AND Hoãn = 0 THEN 1 ELSE 0 END) AS Đúng_hạn,  
                        COUNT(*) - SUM(CASE WHEN Tình_trạng = N'Hoàn thành' THEN 1 ELSE 0 END) AS Chưa_hoàn_thành,
                        SUM(CASE WHEN Hoãn = 1 THEN 1 ELSE 0 END) AS Trễ_hạn
                    FROM 
                        Phân_công_cho_BP PC
                    LEFT JOIN 
                        Giải_quyết GQ ON PC.Mã_công_việc = GQ.Mã_công_việc
                    WHERE 
                        GQ.Ngày_cập_nhật <= @TargetDate AND GQ.Ngày_cập_nhật >= @FromDate
                    GROUP BY 
                        PC.Mã_bộ_phận
                ";

                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@TargetDate", targetDate);
                    command.Parameters.AddWithValue("@FromDate", fromDate);
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                    dataAdapter.Fill(dataTable);
                    advancedDataGridView1.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void ChiTietNhanVien(DateTime fromDate, DateTime targetDate, String PhongBan)
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"
                    SELECT 
                        GQ.Mã_nhân_viên, 
                        ISNULL(SUM(GQ.Doanh_thu), 0) AS Doanh_thu,
                        COUNT(*) AS So_CongViec,
                        SUM(CASE WHEN Tình_trạng = N'Hoàn thành' AND Hoãn = 0 THEN 1 ELSE 0 END) AS Đúng_hạn,  
                        COUNT(*) - SUM(CASE WHEN Tình_trạng = N'Hoàn thành' THEN 1 ELSE 0 END) AS Chưa_hoàn_thành,
                        SUM(CASE WHEN Hoãn = 1 THEN 1 ELSE 0 END) AS Trễ_hạn
                    FROM 
                        Phân_công_cho_BP PC
                    LEFT JOIN 
                        Giải_quyết GQ ON PC.Mã_công_việc = GQ.Mã_công_việc
                    WHERE 
                        PC.Mã_Bộ_Phận = @PhongBan AND
                        GQ.Ngày_cập_nhật <= @TargetDate AND GQ.Ngày_cập_nhật >= @FromDate 
                    GROUP BY 
                        GQ.Mã_nhân_viên
                ";

                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@TargetDate", targetDate);
                    command.Parameters.AddWithValue("@FromDate", fromDate);
                    command.Parameters.AddWithValue("@PhongBan", PhongBan);
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                    dataAdapter.Fill(dataTable);
                    advancedDataGridView1.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
        private void congviec_Load(object sender, EventArgs e)
        {
            phongban = "all";
            button4.BackColor = System.Drawing.Color.Teal;
            fromDate = targetDate.AddDays(-30);
            GetTotalDoanhThuByBoPhan(fromDate, targetDate);
            TotalCount(fromDate, targetDate);
            if (phongban == "all")
            {
                ChiTietPhongBan(fromDate, targetDate);
            }
            else
            {
                ChiTietNhanVien(fromDate, targetDate, phongban);
            }           
            comboBox1.SelectedIndex = 0;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            fromDate = targetDate.AddDays(-30);
            GetTotalDoanhThuByBoPhan(fromDate, targetDate);
            TotalCount(fromDate, targetDate);
            if (phongban == "all")
            {
                ChiTietPhongBan(fromDate, targetDate);
            }
            else
            {
                ChiTietNhanVien(fromDate, targetDate, phongban);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            fromDate = targetDate.AddDays(-14);
            GetTotalDoanhThuByBoPhan(fromDate, targetDate);
            TotalCount(fromDate, targetDate);
            if (phongban == "all")
            {
                ChiTietPhongBan(fromDate, targetDate);
            }
            else
            {
                ChiTietNhanVien(fromDate, targetDate, phongban);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fromDate = targetDate.AddDays(-7);
            GetTotalDoanhThuByBoPhan(fromDate, targetDate);
            TotalCount(fromDate, targetDate);
            if (phongban == "all")
            {
                ChiTietPhongBan(fromDate, targetDate);
            }
            else
            {
                ChiTietNhanVien(fromDate, targetDate, phongban);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fromDate = targetDate.AddDays(-0);
            GetTotalDoanhThuByBoPhan(fromDate, targetDate);
            TotalCount(fromDate, targetDate);
            if (phongban == "all")
            {
                ChiTietPhongBan(fromDate, targetDate);
            }
            else
            {
                ChiTietNhanVien(fromDate, targetDate, phongban);
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = comboBox1.SelectedItem.ToString();
            switch (selectedItem)
            {
                case "Tất cả":
                    phongban = "all";
                    ChiTietPhongBan(fromDate, targetDate);
                    break;
                case "Dịch vụ":
                    phongban = "DV";
                    ChiTietNhanVien(fromDate, targetDate, phongban);
                    break;
                case "Vệ sinh":
                    phongban = "VS";
                    ChiTietNhanVien(fromDate, targetDate, phongban);
                    break;
                case "Xây dựng":
                    phongban = "XD";
                    ChiTietNhanVien(fromDate, targetDate, phongban);
                    break;
                case "Kĩ thuật":
                    phongban = "KT";
                    ChiTietNhanVien(fromDate, targetDate, phongban);
                    break;
                case "An ninh":
                    phongban = "AN";
                    ChiTietNhanVien(fromDate, targetDate, phongban);
                    break;
                case "Tài chính":
                    phongban = "TC";
                    ChiTietNhanVien(fromDate, targetDate, phongban);
                    break;
                default:
                    break;
            }
        }
    }
           
}
