namespace quanlythoitrang
{
    partial class trangchu
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(52, 65);
            button1.Name = "button1";
            button1.Size = new Size(178, 65);
            button1.TabIndex = 0;
            button1.Text = "Bán Hàng";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Black;
            button2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(52, 166);
            button2.Name = "button2";
            button2.Size = new Size(178, 65);
            button2.TabIndex = 1;
            button2.Text = "Tra Cứu Hóa Đơn";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.Black;
            button3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.White;
            button3.Location = new Point(52, 269);
            button3.Name = "button3";
            button3.Size = new Size(178, 65);
            button3.TabIndex = 2;
            button3.Text = "Quản Lý Doanh Thu";
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.Black;
            button4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = Color.White;
            button4.Location = new Point(52, 371);
            button4.Name = "button4";
            button4.Size = new Size(178, 65);
            button4.TabIndex = 3;
            button4.Text = "Quản Lý Nhân Viên";
            button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = Color.Black;
            button5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button5.ForeColor = Color.White;
            button5.Location = new Point(297, 65);
            button5.Name = "button5";
            button5.Size = new Size(178, 65);
            button5.TabIndex = 4;
            button5.Text = "Quản Lý Kho";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.Black;
            button6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button6.ForeColor = Color.White;
            button6.Location = new Point(297, 166);
            button6.Name = "button6";
            button6.Size = new Size(178, 65);
            button6.TabIndex = 5;
            button6.Text = "Danh Sách Khách Hàng";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.Black;
            button7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button7.ForeColor = Color.White;
            button7.Location = new Point(297, 269);
            button7.Name = "button7";
            button7.Size = new Size(178, 65);
            button7.TabIndex = 6;
            button7.Text = "Cài Đặt";
            button7.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            button8.BackColor = Color.Black;
            button8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button8.ForeColor = Color.White;
            button8.Location = new Point(297, 371);
            button8.Name = "button8";
            button8.Size = new Size(178, 65);
            button8.TabIndex = 7;
            button8.Text = "Hướng Dẫn";
            button8.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logashop;
            pictureBox1.Location = new Point(590, 53);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(300, 383);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // trangchu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(924, 502);
            Controls.Add(pictureBox1);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "trangchu";
            Text = "Trang Chủ";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private PictureBox pictureBox1;
    }
}