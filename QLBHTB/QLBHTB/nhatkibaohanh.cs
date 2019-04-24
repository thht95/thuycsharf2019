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
    public partial class nhatkibaohanh : Form
    {
        public nhatkibaohanh()
        {
            InitializeComponent();
        }

        connect con = new connect();
        int flag;
        private void data()
        {
            con.data("select_NKBH", dgvnkbh);

        }
        private void Themnkbh()
        {
            int index = dgvnkbh.CurrentRow.Index;
            txtmank.Text = dgvnkbh.Rows[index].Cells[0].Value.ToString();
            txtnn.Text = dgvnkbh.Rows[index].Cells[1].Value.ToString();
            txtcgq.Text = dgvnkbh.Rows[index].Cells[2].Value.ToString();
            txttennv.Text = dgvnkbh.Rows[index].Cells[3].Value.ToString();
            dtngaybd.Text = dgvnkbh.Rows[index].Cells[4].Value.ToString();
            dtngaykt.Text = dgvnkbh.Rows[index].Cells[5].Value.ToString();
            txtmatbbh.Text = dgvnkbh.Rows[index].Cells[6].Value.ToString();
        }

        void dis_end(bool e)
        {
            txtnn.Enabled = e;
            txtcgq.Enabled = e;
            txttennv.Enabled = e;
            txtmatbbh.Enabled = e;


            btnluu.Enabled = e;
            btnhuy.Enabled = e;
            btnthem.Enabled = !e;
            btnsua.Enabled = !e;
            btnxoa.Enabled = !e;
        }


        private void dgvnkbh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            nhatkibaohanh_Load(sender, e);
        }

        private void nhatkibaohanh_Load(object sender, EventArgs e)
        {
            data();
            Themnkbh();
            dis_end(false);
        }

        private void btnthem_Click_1(object sender, EventArgs e)
        {
            flag = 0;
            dis_end(true);
            txtmank.Clear();
            txtnn.Clear();
            txtcgq.Clear();
            txttennv.Clear();
            txtmatbbh.Clear();
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
                    cmd.CommandText = "insert_NKBH";
                    cmd.Parameters.AddWithValue("@mankbh", txtmank.Text);
                    cmd.Parameters.AddWithValue("@nguyennhan", txtnn.Text);
                    cmd.Parameters.AddWithValue("@cachgiaiquyet", txtcgq.Text);
                    cmd.Parameters.AddWithValue("@tennv", txttennv.Text);
                    cmd.Parameters.AddWithValue("@ngaybd", Convert.ToDateTime(dtngaybd.Value.ToString()));
                    cmd.Parameters.AddWithValue("@ngaykt", Convert.ToDateTime(dtngaykt.Value.ToString()));
                    cmd.Parameters.AddWithValue("@matbbh", txtmatbbh.Text);
                    cmd.ExecuteNonQuery();
                    nhatkibaohanh_Load(sender, e);
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
                    cmd.CommandText = "update_NKBH";
                    cmd.Parameters.AddWithValue("@mankbh", txtmank.Text);
                    cmd.Parameters.AddWithValue("@nguyennhan", txtnn.Text);
                    cmd.Parameters.AddWithValue("@cachgiaiquyet", txtcgq.Text);
                    cmd.Parameters.AddWithValue("@tennv", txttennv.Text);
                    cmd.Parameters.AddWithValue("@ngaybd", Convert.ToDateTime(dtngaybd.Value.ToString()));
                    cmd.Parameters.AddWithValue("@ngaykt", Convert.ToDateTime(dtngaykt.Value.ToString()));
                    cmd.Parameters.AddWithValue("@matbbh", txtmatbbh.Text);
                    cmd.ExecuteNonQuery();
                    nhatkibaohanh_Load(sender, e);
                }
                catch (Exception)
                {
                    MessageBox.Show("Sửa không thành công");
                }
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            try
            {
                con.connection();
                SqlCommand cmd = con.cnn.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "delete_NKBH";
                cmd.Parameters.AddWithValue("@mankbh", txtmank.Text);
                DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    cmd.ExecuteNonQuery();
                    nhatkibaohanh_Load(sender, e);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Xóa không thành công");
            }
        }

        private void btnsua_Click_1(object sender, EventArgs e)
        {
            flag = 1;
            dis_end(true);
        }

        private void btnhuy_Click_1(object sender, EventArgs e)
        {
            nhatkibaohanh_Load(sender, e);
        }
    }
}

