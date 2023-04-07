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
        public void ketnoi(string truyvan)
        {
            MySqlCommand cmd;
            MySqlDataAdapter adt = new MySqlDataAdapter();
            MySqlConnection con = new MySqlConnection("server=localhost;port=3306;database=fashion;uid=root;password=huyhung26082002");
            con.Open();
            cmd = new MySqlCommand(truyvan, con);
            DataTable dt = new DataTable();
            adt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        public kho()
        {
            InitializeComponent();
        }

        private void kho_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ketnoi("select * from sanpham where tensanpham like'%" + textBox1.Text + "%'");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ketnoi("select * from sanpham");
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
