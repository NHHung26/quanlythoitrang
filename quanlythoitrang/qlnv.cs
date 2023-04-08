using MySql.Data.MySqlClient;
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
        string connectionString = "server=localhost;port=3306;database=fashion;uid=root;password=huyhung26082002";
        MySqlCommand cmd;
        MySqlDataAdapter adt;
        public qlnv()
        {
            InitializeComponent();
        }

        private void qlnv_Load(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(connectionString);
            con.Open();
            cmd = new MySqlCommand("select * from nhanvien", con);
            adt = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Clone();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(connectionString);
            con.Open();
            cmd = new MySqlCommand("select * from nhanvien where Ten like '%" + textBox1.Text + "%'", con);
            adt = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Clone();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tinhluong nv = new tinhluong();
            nv.Show();
        }
    }
}