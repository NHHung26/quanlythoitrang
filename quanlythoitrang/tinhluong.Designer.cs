namespace quanlythoitrang
{
    partial class tinhluong
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
            btntinhluong = new Button();
            dataGridView1 = new DataGridView();
            txtten = new TextBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btntinhluong
            // 
            btntinhluong.Location = new Point(668, 64);
            btntinhluong.Name = "btntinhluong";
            btntinhluong.Size = new Size(100, 32);
            btntinhluong.TabIndex = 11;
            btntinhluong.Text = "Tính lương";
            btntinhluong.UseVisualStyleBackColor = true;
            btntinhluong.Click += button2_Click_1;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(61, 123);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(707, 100);
            dataGridView1.TabIndex = 10;
            // 
            // txtten
            // 
            txtten.Location = new Point(212, 62);
            txtten.Multiline = true;
            txtten.Name = "txtten";
            txtten.Size = new Size(450, 34);
            txtten.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(32, 66);
            label2.Name = "label2";
            label2.Size = new Size(162, 23);
            label2.TabIndex = 7;
            label2.Text = "Nhập tên nhân viên";
            // 
            // tinhluong
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 279);
            Controls.Add(btntinhluong);
            Controls.Add(dataGridView1);
            Controls.Add(txtten);
            Controls.Add(label2);
            Name = "tinhluong";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btntinhluong;
        private DataGridView dataGridView1;
        private TextBox txtten;
        private Label label2;
    }
}