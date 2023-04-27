using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace quanlythoitrang
{
    public partial class kho : Form
    {
        string connectionString = @"Data Source=LAPTOP-IJ9867A0\SQL1;Initial Catalog=qlthoitrang;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public kho()
        {
            InitializeComponent();
        }

        private void kho_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            string sql = "select* from sanpham where tensanpham like'%" + textBox1.Text + "%'";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter adt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            string sql = "select* from sanpham";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter adt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
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
