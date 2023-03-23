using MySql.Data.MySqlClient;
using System.Data;

namespace quanlythoitrang
{
    public partial class login : Form
    {
        string constr;
        MySqlConnection conn;
        MySqlCommand cmd;
        MySqlDataAdapter adapter;
        public login()
        {
            InitializeComponent();
            
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection("server=localhost;port=3306;user=root;password=huyhung26082002;database=fashion;");
            try
            {
                conn.Open();
                string tk = txttk.Text;
                string mk = txtmk.Text;
                string mysql = "select * from login where taikhoan='"+tk+"' and matkhau='"+mk+"'";
                MySqlCommand cmd = new MySqlCommand(mysql, conn);
                MySqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read() == true)
                {
                    trangchu tc = new trangchu();
                    tc.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Đăng nhập thất bại!!",
                       "Thông báo", MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối");
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