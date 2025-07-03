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

namespace WinFormsApp1
{
    public partial class Noti : Form
    {
        private Person user;
        private int NotificationID;
        public Noti(Person user)
        {
            this.user = user;
            InitializeComponent();
            string maNhanVien = user.MaNV;
            LoadNotifications(maNhanVien);
        }
        private void LoadNotifications(string maNhanVien)
        {
            string query = "SELECT NotificationID, Tiêu_đề, Message, IsRead FROM Notifications WHERE Mã_nhân_viên = @MaNhanVien";

            using (SqlConnection conn = connection.GetConnection())
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaNhanVien", maNhanVien);
                conn.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        NotiUserControl notiControl = new NotiUserControl();
                        notiControl.Title = reader["Tiêu_đề"].ToString();
                        notiControl.Content = reader["Message"].ToString();
                        notiControl.IsRead = reader.GetBoolean(reader.GetOrdinal("IsRead"));
                        notiControl.id = reader.GetInt32(reader.GetOrdinal("NotificationID"));
                        flowLayoutPanel1.Controls.Add(notiControl);
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Noti_Deactivate(object sender, EventArgs e)
        {
            if (this != null)
            {
                this.Close(); // Close the form when it is deactivated
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            foreach (Control control in flowLayoutPanel1.Controls)
            {
                if (control is NotiUserControl notiControl)
                {
                    notiControl.IsRead = true;
                }
            }
        }

        private void Noti_Load(object sender, EventArgs e)
        {

        }
    }
}
