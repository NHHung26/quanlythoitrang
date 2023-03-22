namespace quanlythoitrang
{
    partial class login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txttk = new TextBox();
            btn_login = new Button();
            btn_exit = new Button();
            txtmk = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.No;
            pictureBox1.Image = Properties.Resources.logashop;
            pictureBox1.Location = new Point(144, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(165, 102);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(92, 129);
            label1.Name = "label1";
            label1.Size = new Size(277, 31);
            label1.TabIndex = 1;
            label1.Text = "ĐĂNG NHẬP HỆ THỐNG";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 195);
            label2.Name = "label2";
            label2.Size = new Size(87, 25);
            label2.TabIndex = 2;
            label2.Text = "Tài Khoản";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 256);
            label3.Name = "label3";
            label3.Size = new Size(87, 25);
            label3.TabIndex = 3;
            label3.Text = "Mật Khẩu";
            // 
            // txttk
            // 
            txttk.Location = new Point(121, 195);
            txttk.Multiline = true;
            txttk.Name = "txttk";
            txttk.Size = new Size(248, 34);
            txttk.TabIndex = 4;
            // 
            // btn_login
            // 
            btn_login.Location = new Point(121, 318);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(105, 37);
            btn_login.TabIndex = 6;
            btn_login.Text = "Login";
            btn_login.UseVisualStyleBackColor = true;
            btn_login.Click += btn_login_Click;
            // 
            // btn_exit
            // 
            btn_exit.Location = new Point(264, 318);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new Size(105, 37);
            btn_exit.TabIndex = 7;
            btn_exit.Text = "Exit";
            btn_exit.UseVisualStyleBackColor = true;
            btn_exit.Click += btn_exit_Click;
            // 
            // txtmk
            // 
            txtmk.Location = new Point(121, 247);
            txtmk.Multiline = true;
            txtmk.Name = "txtmk";
            txtmk.Size = new Size(248, 34);
            txtmk.TabIndex = 8;
            txtmk.UseSystemPasswordChar = true;
            txtmk.PasswordChar = '*';
            // 
            // login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(453, 418);
            Controls.Add(txtmk);
            Controls.Add(btn_exit);
            Controls.Add(btn_login);
            Controls.Add(txttk);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "login";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản Lý Thời Trang";
            Load += login_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txttk;
        private Button btn_login;
        private Button btn_exit;
        private TextBox txtmk;
    }
}