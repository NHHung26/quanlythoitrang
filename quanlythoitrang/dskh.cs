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
using System.Data.SqlClient;
namespace quanlythoitrang
{
    public partial class dskh : Form
    {
        string connectionString = @"Data Source=LAPTOP-IJ9867A0\SQL1;Initial Catalog=qlthoitrang;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        SqlCommand cmd;
        SqlDataAdapter adt;
        public dskh()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            cmd = new SqlCommand("select * from khachhang where Ten like '%" + textBox1.Text + "%'", con);
            adt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void dskh_Load(object sender, EventArgs e)
        {
            
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            cmd = new SqlCommand("select * from khachhang", con);
            adt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
    }
}
