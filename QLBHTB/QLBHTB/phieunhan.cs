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
    public partial class phieunhan : Form
    {
        public phieunhan()
        {
            InitializeComponent();
        }

        connect con = new connect();
        int flag;
        private void data()
        {
            con.data("select_PN", dgvphieunhan);

        }
        private void Themphieunhan()
        {
            int index = dgvphieunhan.CurrentRow.Index;
            txtmapn.Text = dgvphieunhan.Rows[index].Cells[0].Value.ToString();
            txttennv.Text = dgvphieunhan.Rows[index].Cells[1].Value.ToString();
            txttenkh.Text = dgvphieunhan.Rows[index].Cells[2].Value.ToString();
            txtdc.Text = dgvphieunhan.Rows[index].Cells[3].Value.ToString();
            dtngaynhan.Text = dgvphieunhan.Rows[index].Cells[4].Value.ToString();
            dtngaytra.Text = dgvphieunhan.Rows[index].Cells[4].Value.ToString();
            txtmahb.Text = dgvphieunhan.Rows[index].Cells[5].Value.ToString();
        }

        void dis_end(bool e)
        {
            txttennv.Enabled = e;
            txttenkh.Enabled = e;
            txtdc.Enabled = e;
            dtngaynhan.Enabled = e;
            dtngaytra.Enabled = e;
            txtmahb.Enabled = e;

            btnluu.Enabled = e;
            btnhuy.Enabled = e;
            btnthem.Enabled = !e;
            btnsua.Enabled = !e;
            btnxoa.Enabled = !e;
        }
        private void phieunhan_Load(object sender, EventArgs e)
        {
            data();
            Themphieunhan();
            dis_end(false);
        }


        private void dgvphieunhan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            phieunhan_Load(sender, e);
        }

        private void phieunhan_Load_1(object sender, EventArgs e)
        {
            phieunhan_Load(sender, e);
        }

        private void btnthem_Click_1(object sender, EventArgs e)
        {
            flag = 0;
            dis_end(true);
            txtmapn.Clear();
            txttennv.Clear();
            txttenkh.Clear();
            txtdc.Clear();
            // dtngaynhan.Clear();
            // dtngaytra.Clear();
            txtmahb.Clear();
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
                    cmd.CommandText = "insert_PN";
                    cmd.Parameters.AddWithValue("@mapn", txtmapn.Text);
                    cmd.Parameters.AddWithValue("@tennv", txttennv.Text);
                    cmd.Parameters.AddWithValue("@dc", txtdc.Text);
                    cmd.Parameters.AddWithValue("@ngaynhan", Convert.ToDateTime(dtngaynhan.Value.ToString()));
                    cmd.Parameters.AddWithValue("@ngaytra", Convert.ToDateTime(dtngaytra.Value.ToString()));
                    cmd.Parameters.AddWithValue("@mahb", txtmahb.Text);
                    cmd.ExecuteNonQuery();
                    phieunhan_Load(sender, e);

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
                    cmd.CommandText = "update_PN";
                    cmd.Parameters.AddWithValue("@mapn", txtmapn.Text);
                    cmd.Parameters.AddWithValue("@tennv", txttennv.Text);
                    cmd.Parameters.AddWithValue("@dc", txtdc.Text);
                    cmd.Parameters.AddWithValue("@ngaynhan", Convert.ToDateTime(dtngaynhan.Value.ToString()));
                    cmd.Parameters.AddWithValue("@ngaytra", Convert.ToDateTime(dtngaytra.Value.ToString()));
                    cmd.Parameters.AddWithValue("@mahb", txtmahb.Text);
                    cmd.ExecuteNonQuery();
                    phieunhan_Load(sender, e);
                }
                catch (Exception)
                {
                    MessageBox.Show("Sửa không thành công");
                }
            }
        }

        private void btnhuy_Click_1(object sender, EventArgs e)
        {
            phieunhan_Load(sender, e);
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
                cmd.CommandText = "delete_PN";
                cmd.Parameters.AddWithValue("@mapn", txtmapn.Text);
                DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    cmd.ExecuteNonQuery();
                    phieunhan_Load(sender, e);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Xóa không thành công");
            }
        }
    }
}