namespace WinFormsApp1
{
    partial class forgotPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(forgotPassword));
            email = new TextBox();
            emailPTB = new PictureBox();
            button1 = new Button();
            panel1 = new Panel();
            sEmailPTB = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel2 = new Panel();
            pictureBox5 = new PictureBox();
            button5 = new Button();
            Close = new Button();
            ((System.ComponentModel.ISupportInitialize)emailPTB).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)sEmailPTB).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // email
            // 
            email.Cursor = Cursors.Hand;
            email.Font = new Font("Tahoma", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            email.Location = new Point(72, 182);
            email.Multiline = true;
            email.Name = "email";
            email.PlaceholderText = "Email";
            email.Size = new Size(315, 50);
            email.TabIndex = 30;
            email.TextChanged += email_TextChanged;
            email.Enter += email_Enter;
            email.Leave += email_Leave;
            // 
            // emailPTB
            // 
            emailPTB.BackColor = Color.White;
            emailPTB.BackgroundImageLayout = ImageLayout.Stretch;
            emailPTB.Image = (Image)resources.GetObject("emailPTB.Image");
            emailPTB.Location = new Point(16, 182);
            emailPTB.Name = "emailPTB";
            emailPTB.Size = new Size(50, 50);
            emailPTB.SizeMode = PictureBoxSizeMode.Zoom;
            emailPTB.TabIndex = 29;
            emailPTB.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Green;
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(132, 238);
            button1.Name = "button1";
            button1.Size = new Size(146, 45);
            button1.TabIndex = 27;
            button1.Text = "Gửi mật khẩu";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(205, 206, 210);
            panel1.Controls.Add(sEmailPTB);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(email);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(emailPTB);
            panel1.Location = new Point(145, 80);
            panel1.Name = "panel1";
            panel1.Size = new Size(410, 300);
            panel1.TabIndex = 31;
            panel1.Paint += panel1_Paint;
            // 
            // sEmailPTB
            // 
            sEmailPTB.BackColor = Color.White;
            sEmailPTB.BackgroundImage = (Image)resources.GetObject("sEmailPTB.BackgroundImage");
            sEmailPTB.BackgroundImageLayout = ImageLayout.Zoom;
            sEmailPTB.Location = new Point(16, 182);
            sEmailPTB.Name = "sEmailPTB";
            sEmailPTB.Size = new Size(50, 50);
            sEmailPTB.SizeMode = PictureBoxSizeMode.Zoom;
            sEmailPTB.TabIndex = 34;
            sEmailPTB.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(16, 13);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(50, 50);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 33;
            pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(132, 52);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(146, 118);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 32;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.LimeGreen;
            label1.Location = new Point(72, 13);
            label1.Name = "label1";
            label1.Size = new Size(306, 36);
            label1.TabIndex = 31;
            label1.Text = "LẤY LẠI MẬT KHẨU";
            label1.Click += label1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(23, 24, 29);
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Controls.Add(pictureBox5);
            panel2.Controls.Add(button5);
            panel2.Controls.Add(Close);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(682, 40);
            panel2.TabIndex = 32;
            panel2.Paint += panel2_Paint;
            panel2.MouseDown += panelMouseDown;
            // 
            // pictureBox5
            // 
            pictureBox5.BackgroundImage = (Image)resources.GetObject("pictureBox5.BackgroundImage");
            pictureBox5.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox5.Dock = DockStyle.Left;
            pictureBox5.Location = new Point(0, 0);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(46, 40);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 24;
            pictureBox5.TabStop = false;
            // 
            // button5
            // 
            button5.AccessibleRole = AccessibleRole.TitleBar;
            button5.BackColor = Color.FromArgb(23, 24, 29);
            button5.BackgroundImage = (Image)resources.GetObject("button5.BackgroundImage");
            button5.BackgroundImageLayout = ImageLayout.Stretch;
            button5.Cursor = Cursors.Hand;
            button5.Dock = DockStyle.Right;
            button5.FlatStyle = FlatStyle.Popup;
            button5.ForeColor = Color.Cornsilk;
            button5.Location = new Point(602, 0);
            button5.Name = "button5";
            button5.Size = new Size(40, 40);
            button5.TabIndex = 23;
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            button5.MouseLeave += mouseLeave;
            button5.MouseHover += mouseOver;
            // 
            // Close
            // 
            Close.AccessibleRole = AccessibleRole.TitleBar;
            Close.BackColor = Color.FromArgb(23, 24, 29);
            Close.BackgroundImage = (Image)resources.GetObject("Close.BackgroundImage");
            Close.BackgroundImageLayout = ImageLayout.Stretch;
            Close.Cursor = Cursors.Hand;
            Close.Dock = DockStyle.Right;
            Close.FlatStyle = FlatStyle.Popup;
            Close.ForeColor = Color.Cornsilk;
            Close.Location = new Point(642, 0);
            Close.Name = "Close";
            Close.Size = new Size(40, 40);
            Close.TabIndex = 20;
            Close.UseVisualStyleBackColor = false;
            Close.Click += Close_Click;
            Close.MouseLeave += mouseLeave;
            Close.MouseHover += mouseOver;
            // 
            // forgotPassword
            // 
            AcceptButton = button1;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 33, 36);
            ClientSize = new Size(682, 453);
            Controls.Add(panel2);
            Controls.Add(panel1);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(700, 500);
            MinimumSize = new Size(700, 500);
            Name = "forgotPassword";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "forgotPassword";
            Load += forgotPassword_Load;
            ((System.ComponentModel.ISupportInitialize)emailPTB).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)sEmailPTB).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TextBox email;
        private PictureBox emailPTB;
        private Button button1;
        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private PictureBox pictureBox5;
        private Button button5;
        private Button Close;
        private PictureBox pictureBox3;
        private PictureBox sEmailPTB;
    }
}