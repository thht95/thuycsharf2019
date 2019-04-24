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
    public partial class HangBan : Form
    {
        public HangBan()
        {
            InitializeComponent();
        }
        connect con = new connect();
        int flag;
        private void data()
        {
            con.data("select_HB", dgvhangban);
			con.Load_cbo("cbo_hanghoa" ,cbotenhh);

        }
        private void Themhangban()
        {
            int index = dgvhangban.CurrentRow.Index;
            txtmahb.Text = dgvhangban.Rows[index].Cells[0].Value.ToString();
            txttenhb.Text = dgvhangban.Rows[index].Cells[1].Value.ToString();
            txtsl.Text = dgvhangban.Rows[index].Cells[2].Value.ToString();
            txtgia.Text = dgvhangban.Rows[index].Cells[3].Value.ToString();
            dttgbaohanh.Text = dgvhangban.Rows[index].Cells[4].Value.ToString();
           // cbotenhh.Text = dgvhangban.Rows[index].Cells[5].value.ToString();
		
		}

        void dis_end(bool e)
        {
            txttenhb.Enabled = e;
            txtsl.Enabled = e;
            txtgia.Enabled = e;
            cbotenhh.Enabled = e;


            btnluu.Enabled = e;
            btnhuy.Enabled = e;
            btnthem.Enabled = !e;
            btnsua.Enabled = !e;
            btnxoa.Enabled = !e;
        }
        private void HangBan_Load(object sender, EventArgs e)
        {
            data();
            Themhangban();
            dis_end(false);
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            flag = 0;
            dis_end(true);
            txtmahb.Clear();
            txttenhb.Clear();
            txtsl.Clear();
            txtgia.Clear();
            //cbotenhh.Clear();
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            if (flag == 0)
            {
                try
                {
                    con.connection();
                    SqlCommand cmd = con.cnn.CreateCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "insert_HB";
                    cmd.Parameters.AddWithValue("@mahb", txtmahb.Text);
                    cmd.Parameters.AddWithValue("@tenhb", txttenhb.Text);
                    cmd.Parameters.AddWithValue("@sl", txtsl.Text);
                    cmd.Parameters.AddWithValue("@gia", txtgia  .Text);
                    cmd.Parameters.AddWithValue("@tgbaohanh",Convert.ToDateTime(dttgbaohanh.Value.ToString()));
                    cmd.Parameters.AddWithValue("@mahh", cbotenhh.SelectedValue);
                    cmd.ExecuteNonQuery();
                    HangBan_Load(sender, e);
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
                    cmd.CommandText = "update_HB";
                    cmd.Parameters.AddWithValue("@mahb", txtmahb.Text);
                    cmd.Parameters.AddWithValue("@tenhb", txttenhb.Text);
                    cmd.Parameters.AddWithValue("@sl", txtsl.Text);
                    cmd.Parameters.AddWithValue("@gia", txtgia.Text);
                    cmd.Parameters.AddWithValue("@tgbaohanh", Convert.ToDateTime(dttgbaohanh.Value.ToString()));
                    cmd.Parameters.AddWithValue("@mahh", cbotenhh.SelectedValue);
                    cmd.ExecuteNonQuery();
                    HangBan_Load(sender, e);
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
                cmd.CommandText = "delete_HB";
                cmd.Parameters.AddWithValue("@mahb", txtmahb.Text);
                DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    cmd.ExecuteNonQuery();
                    HangBan_Load(sender, e);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Xóa không thành công");
            }
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            HangBan_Load(sender, e);
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            flag = 1;
            dis_end(true);
        }


		private void dgvhangban_CellClick_1(object sender, DataGridViewCellEventArgs e)
		{
			HangBan_Load(sender, e);
		}
	}
}
