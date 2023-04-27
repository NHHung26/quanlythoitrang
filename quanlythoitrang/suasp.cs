using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace quanlythoitrang
{
    public partial class suasp : Form
    {
        string connectionString = @"Data Source=LAPTOP-IJ9867A0\SQL1;Initial Catalog=qlthoitrang;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        SqlCommand cmd;
        SqlDataAdapter adt;
        public suasp()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionString);
            try
            {
                con.Open();
                string mysqlEdit = "UPDATE sanpham SET masanpham = @masanpham, tensanpham = @tensanpham, sz = @sz, mausac = @mausac, sl = @sl, gia = @gia WHERE tensanpham = @tensanpham";
                cmd = new SqlCommand(mysqlEdit, con);
                cmd.Parameters.AddWithValue("@masanpham", textBox1.Text);
                cmd.Parameters.AddWithValue("@tensanpham", textBox2.Text);
                cmd.Parameters.AddWithValue("@sz", textBox3.Text);
                cmd.Parameters.AddWithValue("@mausac", textBox4.Text);
                cmd.Parameters.AddWithValue("@sl", textBox5.Text);
                cmd.Parameters.AddWithValue("@gia", textBox6.Text);

                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Sửa thành công!!",
                      "Thông báo", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Sửa thất bại!!",
                      "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
    }
}
