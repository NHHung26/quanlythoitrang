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
    public partial class xoasp : Form
    {

        string connectionString = "server=localhost;port=3306;database=fashion;uid=root;password=duc2002latao@";
        MySqlCommand cmd;
        MySqlDataAdapter adt;
        public xoasp()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(connectionString);
            try
            {
                con.Open();
                string mysqlEdit = "DELETE FROM sanpham WHERE TenSanPham = @TenSanPham";
                cmd = new MySqlCommand(mysqlEdit, con);
                cmd.Parameters.AddWithValue("@TenSanPham", textBox1.Text);
                if (cmd.ExecuteNonQuery() == 1)
                {
                    DialogResult rs = MessageBox.Show("Bạn thực sự muốn xóa sản phẩm này này?",
                "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (rs == DialogResult.Yes)
                        this.Close();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại!!",
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
