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
    public partial class tinhluong : Form
    {
        string connectionString = "server=localhost;port=3306;database=fashion;uid=root;password=duc2002latao@";
        MySqlCommand cmd;
        MySqlDataAdapter adt;
        public tinhluong()
        {
            InitializeComponent();
        }


        private void button2_Click_1(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(connectionString);
            con.Open();
            cmd = new MySqlCommand("SELECT Ten, MucLuong, GioLam, SUM(MucLuong * GioLam) AS TienLuong FROM fashion.nhanvien where Ten = '" + txtten.Text + "' GROUP BY Ten, MucLuong, GioLam;", con);
            adt = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Clone();
        }
    }
}
