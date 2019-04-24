using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace QLBHTB
{
    public partial class trangchu : Form
    {
        public trangchu()
        {
            InitializeComponent();
        }

        private void quanlibaohanhthietbi_Load(object sender, EventArgs e)
        {

        }

        private void nhomhang_Click(object sender, EventArgs e)
        {
          nhomhang f1 = new nhomhang();
            f1.MdiParent = this;
            f1.Show();
        }

        private void hanghoa_Click(object sender, EventArgs e)
        {
            hanghoa f1 = new hanghoa();
            f1.MdiParent = this;
            f1.Show();
        }

        private void hangban_Click(object sender, EventArgs e)
        {
           HangBan f1 = new HangBan ();
            f1.MdiParent = this;
            f1.Show();
        }

        private void hoadon_Click(object sender, EventArgs e)
        {
           hdbanhang f1 = new hdbanhang();
            f1.MdiParent = this;
            f1.Show();
        }

        private void phieunhan_Click(object sender, EventArgs e)
        {
          phieunhan   f1 = new phieunhan();
            f1.MdiParent = this;
            f1.Show();
        }

        private void thietbibh_Click(object sender, EventArgs e)
        {
           thietbibaohanh f1 = new thietbibaohanh();
            f1.MdiParent = this;
            f1.Show();
        }

        private void nhatkibh_Click(object sender, EventArgs e)
        {
            nhatkibaohanh f1 = new nhatkibaohanh();
            f1.MdiParent = this;
            f1.Show();
        }

        private void thoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn thoát khỏi chương trình?", "Thông báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
                Close();
        }

        private void hangbangiatren300000_Click(object sender, EventArgs e)
        {
            FR_hangban f1 = new FR_hangban();
            f1.MdiParent = this;
            f1.Show();
        }

        private void khachhangcodiachihanoi_Click(object sender, EventArgs e)
        {
            nhatkibaohanh f1 = new nhatkibaohanh();
            f1.MdiParent = this;
            f1.Show();
        }
    }
}
