﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanlythoitrang
{
    public partial class qlnv : Form
    {

        public void ketnoi(string truyvan)
        {
            MySqlCommand cmd;
            MySqlDataAdapter adt;
            MySqlConnection con = new MySqlConnection("server=localhost;port=3306;database=fashion;uid=root;password=huyhung26082002");
            con.Open();
            cmd = new MySqlCommand(truyvan, con);
            DataTable dt = new DataTable();
            adt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
        
        public qlnv()
        {
            InitializeComponent();
        }

        private void qlnv_Load(object sender, EventArgs e)
        {
            
            ketnoi("select * from nhanvien");
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ketnoi("select * from nhanvien where Ten like '%"+textBox1.Text+"%'");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tinhluong nv = new tinhluong();
            nv.Show();
        }
    }
}
