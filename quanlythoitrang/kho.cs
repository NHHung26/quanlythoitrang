using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace quanlythoitrang
{
    public partial class kho : Form
    {
        string connectionString = "server=localhost;port=3306;database=fashion;uid=root;password=huyhung26082002";
        MySqlCommand cmd;
        MySqlDataAdapter adt;

        public kho()
        {
            InitializeComponent();
        }

        private void kho_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(connectionString);
            con.Open();
            cmd = new MySqlCommand("select * from sanpham where tensanpham like'%" + textBox1.Text + "%'", con);
            adt = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Clone();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            MySqlConnection con = new MySqlConnection(connectionString);
            con.Open();
            cmd = new MySqlCommand("select * from sanpham", con);
            adt = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Clone();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            themsp a = new themsp();
            a.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            suasp b = new suasp();
            b.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            xoasp c = new xoasp();
            c.Show();
        }
    }
}
