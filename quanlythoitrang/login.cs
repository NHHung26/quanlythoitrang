using System.Data;
using System.Data.SqlClient;

namespace quanlythoitrang
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
            
        }
        public static string diachi = @"Data Source=DESKTOP-2L6E1U1\MSSQLSERVER01;Initial Catalog=qlthoitrang;Integrated Security=True";
        public static SqlConnection ketnoi()
        {
            return new SqlConnection(diachi);
        }
        private void btn_login_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = ketnoi())
                {
                    conn.Open();
                    string tk = txttk.Text;
                    string mk = txtmk.Text;
                    string sql = "select count(*) from login where taikhoan=@taikhoan and matkhau=@matkhau";
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@taikhoan", tk);
                        cmd.Parameters.AddWithValue("@matkhau", mk);
                        try
                        {
                            int count = (int)cmd.ExecuteScalar();
                            // Nếu số lượng bản ghi trả về lớn hơn 0, tài khoản và mật khẩu đúng
                            if (count > 0)
                            {
                                trangchu tc = new trangchu();
                                tc.Show();
                            }
                            else
                            {
                                MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Lỗi khi thực hiện truy vấn: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn thực sự muốn đóng ứng dụng này?",
               "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
                this.Close();
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        
    }
}
