using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class ProgressEmail : Form
    {
        public ProgressEmail()
        {
            InitializeComponent();
        }

        private void ProgressEmail_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < 99)
            {
                progressBar1.Value += 1;
                label2.Text = progressBar1.Value.ToString() + "%";
            }
            else
            {
                timer1.Stop();
            }
        }

        public void finish()
        {
            progressBar1.Value = 100;
            label2.Text = progressBar1.Value.ToString() + "%";
        }
    }
}
