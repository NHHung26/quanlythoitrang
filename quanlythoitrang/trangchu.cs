using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanlythoitrang
{
    public partial class trangchu : Form
    {
        public trangchu()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            kho kho = new kho();
            kho.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            dskh d = new dskh();
            d.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            qlnv hung = new qlnv();
            hung.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            qlbh z = new qlbh();
            z.Show();
        }
    }
}
