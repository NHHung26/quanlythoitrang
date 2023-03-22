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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace quanlythoitrang
{
    public partial class suasp : Form
    {
        string connectionString = "server=localhost;port=3306;database=fashion;uid=root;password=huyhung26082002";
        MySqlCommand cmd;
        MySqlDataAdapter adt;
        public suasp()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(connectionString);
            try
            {
                con.Open();
                string mysqlEdit = "UPDATE sanpham SET TenSanPham = @TenSanPham, Size = @Size, MauSac = @MauSac, SoLuong = @Soluong, GiaTien = @GiaTien WHERE TenSanPham = @TenSanPham";
                cmd = new MySqlCommand(mysqlEdit, con);
                cmd.Parameters.AddWithValue("@TenSanPham", textBox1.Text);
                cmd.Parameters.AddWithValue("@Size", textBox2.Text);
                cmd.Parameters.AddWithValue("@MauSac", textBox3.Text);
                cmd.Parameters.AddWithValue("@Soluong", textBox4.Text);
                cmd.Parameters.AddWithValue("@GiaTien", textBox5.Text);

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
