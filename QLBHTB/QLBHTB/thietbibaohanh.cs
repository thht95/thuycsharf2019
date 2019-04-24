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

namespace QLBHTB
{
    public partial class thietbibaohanh : Form
    {
        public thietbibaohanh()
        {
            InitializeComponent();
        }
        connect con = new connect();
        int flag;
        private void data()
        {
            con.data("select_TBBH", dgvtbbh);



        }
        private void Themthietbibaohanh()
        {
            int index = dgvtbbh.CurrentRow.Index;
            txtttbh.Text = dgvtbbh.Rows[index].Cells[1].Value.ToString();
            txtnh.Text = dgvtbbh.Rows[index].Cells[2].Value.ToString();
            txtmahb.Text = dgvtbbh.Rows[index].Cells[3].Value.ToString();
        }

        void dis_end(bool e)
        {
           
            txtttbh.Enabled = e;
            txtnh.Enabled = e;
            txtmahb.Enabled = e;

            btnluu.Enabled = e;
            btnhuy.Enabled = e;
            btnthem.Enabled = !e;
            btnsua.Enabled = !e;
            btnxoa.Enabled = !e;
        }
        private void thietbibaohanh_Load(object sender, EventArgs e)
        {
            data();
            Themthietbibaohanh();
            dis_end(false);
        }

        private void dgvtbbh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Themthietbibaohanh();
        }

        //private void thietbibaohanh_Load_1(object sender, EventArgs e)
        //{
        //    data();
        //    Themthietbibaohanh();
        //    dis_end(false);
        //}

        private void btnthem_Click_1(object sender, EventArgs e)
        {
            flag = 0;
            dis_end(true);

            txtttbh.Clear();
            txtnh.Clear();
            txtmahb.Clear();
        }

        private void btnsua_Click_1(object sender, EventArgs e)
        {
            flag = 1;
            dis_end(true);
        }

        private void btnxoa_Click_1(object sender, EventArgs e)
        {
            try
            {
                con.connection();
                SqlCommand cmd = con.cnn.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "delete_TBBH";
                cmd.Parameters.AddWithValue("@matbbh", txtmatbbh.Text);
                DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    cmd.ExecuteNonQuery();
                    thietbibaohanh_Load(sender, e);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Xóa không thành công");
            }
        }

        private void btnluu_Click_1(object sender, EventArgs e)
        {

            if (flag == 0)
            {
                try
                {
                    con.connection();
                    SqlCommand cmd = con.cnn.CreateCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "insert_TBBH";
                    cmd.Parameters.AddWithValue("@matbbh", txtmatbbh.Text);
                    cmd.Parameters.AddWithValue("@tinhtrangbh", txtttbh.Text);
                    cmd.Parameters.AddWithValue("@pdnguyennhan", txtnh.Text);
                    cmd.Parameters.AddWithValue("@mahb", txtmahb.Text);
                    cmd.ExecuteNonQuery();
                    thietbibaohanh_Load(sender, e);
                }
                catch (Exception)
                {
                    MessageBox.Show("Thêm không thành công");
                }
            }
            else
            {
                try
                {
                    con.connection();
                    SqlCommand cmd = con.cnn.CreateCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "update_TBBH";

                    cmd.Parameters.AddWithValue("@tinhtrangbh", txtttbh.Text);
                    cmd.Parameters.AddWithValue("@pdnguyennhan", txtnh.Text);
                    cmd.Parameters.AddWithValue("@mahb", txtmahb.Text);
                    cmd.ExecuteNonQuery();
                    thietbibaohanh_Load(sender, e);
                }
                catch (Exception)
                {
                    MessageBox.Show("Sửa không thành công");
                }
            }
        }

        private void btnhuy_Click_1(object sender, EventArgs e)
        {
            thietbibaohanh_Load(sender, e);
        }
    }
}