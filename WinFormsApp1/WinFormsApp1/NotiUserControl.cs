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
    public partial class NotiUserControl : UserControl
    {
        public int id;
        public string Title
        {
            get { return label1.Text; }
            set { label1.Text = value; }
        }

        public string Content
        {
            get { return label2.Text; }
            set { label2.Text = value; }
        }

        public bool IsRead
        {
            get { return checkBox1.Checked; }
            set { checkBox1.Checked = value; }
        }
        public NotiUserControl()
        {
            InitializeComponent();
        }

        private void label2_MouseHover(object sender, EventArgs e)
        {
            ToolTip tooltip = new ToolTip();
            tooltip.SetToolTip(label2, label2.Text);
        }

        private void label1_MouseHover(object sender, EventArgs e)
        {
            ToolTip tooltip = new ToolTip();
            tooltip.SetToolTip(label1, label1.Text);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            UpdateNotificationReadStatus(this.id, this.IsRead);
        }
        private void UpdateNotificationReadStatus(int notificationId, bool isRead)
        {
            string query = "UPDATE Notifications SET IsRead = @IsRead WHERE NotificationID = @NotificationID";

            using (SqlConnection conn = connection.GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@IsRead", isRead);
                    cmd.Parameters.AddWithValue("@NotificationID", notificationId);

                    conn.Open();
                    int result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        Console.WriteLine("Database updated successfully.");
                    }
                    else
                    {
                        Console.WriteLine("No records were updated.");
                    }
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
