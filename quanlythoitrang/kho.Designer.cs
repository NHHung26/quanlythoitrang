namespace quanlythoitrang
{
    partial class kho
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
            dataGridView1 = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(40, 191);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(724, 291);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(222, 9);
            label1.Name = "label1";
            label1.Size = new Size(342, 38);
            label1.TabIndex = 1;
            label1.Text = "DANH SÁCH SẢN PHẨM";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(40, 71);
            label2.Name = "label2";
            label2.Size = new Size(186, 28);
            label2.TabIndex = 2;
            label2.Text = "Nhập tên sản phẩm:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(232, 67);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(391, 43);
            textBox1.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(629, 63);
            button1.Name = "button1";
            button1.Size = new Size(120, 47);
            button1.TabIndex = 4;
            button1.Text = "Tìm kiếm";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.Location = new Point(40, 139);
            button2.Name = "button2";
            button2.Size = new Size(143, 35);
            button2.TabIndex = 5;
            button2.Text = "Tất cả sản phẩm";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(222, 139);
            button3.Name = "button3";
            button3.Size = new Size(143, 35);
            button3.TabIndex = 6;
            button3.Text = "Thêm sản phẩm";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(444, 139);
            button4.Name = "button4";
            button4.Size = new Size(143, 35);
            button4.TabIndex = 7;
            button4.Text = "Sửa sản phẩm";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(621, 139);
            button5.Name = "button5";
            button5.Size = new Size(143, 35);
            button5.TabIndex = 8;
            button5.Text = "Xóa sản phẩm";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // kho
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 505);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "kho";
            Text = "Form1";
            Load += kho_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
    }
}