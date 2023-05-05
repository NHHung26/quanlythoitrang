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
    public partial class themsp : Form
    {
        string connectionString = @"Data Source=DESKTOP-2L6E1U1\MSSQLSERVER01;Initial Catalog=qlthoitrang;Integrated Security=True";
        SqlCommand cmd;
         SqlDataAdapter adt;
        public themsp()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionString);
            try
            {
                con.Open();
                string sql = "INSERT INTO sanpham (idsanpham, tensanpham, size, soluong, mausac, giatien)  VALUES (@idsanpham, @tensanpham, @size, @soluong,@mausac, @giatien)";
                cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@idsanpham", textBox1.Text);
                cmd.Parameters.AddWithValue("@tensanpham", textBox2.Text);
                cmd.Parameters.AddWithValue("@size", textBox3.Text);
                cmd.Parameters.AddWithValue("@soluong", textBox4.Text);
                cmd.Parameters.AddWithValue("@mausac", textBox5.Text);
                cmd.Parameters.AddWithValue("@giatien", textBox6.Text);

                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Thêm thành công!!",
                      "Thông báo", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Thêm thất bại!!",
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

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
