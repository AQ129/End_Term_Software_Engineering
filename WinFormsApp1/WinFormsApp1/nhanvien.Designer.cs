namespace WinFormsApp1
{
    partial class nhanvien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            label1 = new Label();
            comboBox1 = new ComboBox();
            advancedDataGridView1 = new ADGV.AdvancedDataGridView();
            label2 = new Label();
            comboBox2 = new ComboBox();
            label3 = new Label();
            textBox1 = new TextBox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)advancedDataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(17, 22);
            label1.Name = "label1";
            label1.Size = new Size(240, 37);
            label1.TabIndex = 1;
            label1.Text = "Dữ liệu nhân viên";
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Nhân viên", "Bộ phận", "Nhóm", "Công việc" });
            comboBox1.Location = new Point(284, 31);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(259, 33);
            comboBox1.TabIndex = 2;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // advancedDataGridView1
            // 
            advancedDataGridView1.AllowUserToAddRows = false;
            advancedDataGridView1.AllowUserToDeleteRows = false;
            advancedDataGridView1.AutoGenerateContextFilters = true;
            advancedDataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            advancedDataGridView1.BackgroundColor = Color.White;
            advancedDataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.RaisedHorizontal;
            advancedDataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(109, 122, 224);
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(128, 128, 255);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            advancedDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            advancedDataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            advancedDataGridView1.DateWithTime = false;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(229, 226, 244);
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            advancedDataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            advancedDataGridView1.EnableHeadersVisualStyles = false;
            advancedDataGridView1.Location = new Point(24, 171);
            advancedDataGridView1.Name = "advancedDataGridView1";
            advancedDataGridView1.ReadOnly = true;
            advancedDataGridView1.RowHeadersVisible = false;
            advancedDataGridView1.RowHeadersWidth = 62;
            advancedDataGridView1.RowTemplate.Height = 30;
            advancedDataGridView1.RowTemplate.ReadOnly = true;
            advancedDataGridView1.RowTemplate.Resizable = DataGridViewTriState.False;
            advancedDataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            advancedDataGridView1.Size = new Size(991, 511);
            advancedDataGridView1.TabIndex = 0;
            advancedDataGridView1.TimeFilter = false;
            advancedDataGridView1.SortStringChanged += advancedDataGridView1_SortStringChanged;
            advancedDataGridView1.FilterStringChanged += advancedDataGridView1_FilterStringChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(465, 120);
            label2.Name = "label2";
            label2.Size = new Size(72, 28);
            label2.TabIndex = 3;
            label2.Text = "Search";
            // 
            // comboBox2
            // 
            comboBox2.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(548, 116);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(185, 33);
            comboBox2.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(738, 116);
            label3.Name = "label3";
            label3.Size = new Size(83, 28);
            label3.TabIndex = 5;
            label3.Text = "Column";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.Location = new Point(830, 115);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(185, 32);
            textBox1.TabIndex = 6;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // panel1
            // 
            panel1.Controls.Add(label3);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(advancedDataGridView1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(comboBox2);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(185, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1040, 716);
            panel1.TabIndex = 7;
            // 
            // nhanvien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(196, 210, 245);
            ClientSize = new Size(1225, 716);
            Controls.Add(panel1);
            DoubleBuffered = true;
            Name = "nhanvien";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)advancedDataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label label1;
        private ComboBox comboBox1;
        private ADGV.AdvancedDataGridView advancedDataGridView1;
        private Label label2;
        private ComboBox comboBox2;
        private Label label3;
        private TextBox textBox1;
        private Panel panel1;
    }
}

