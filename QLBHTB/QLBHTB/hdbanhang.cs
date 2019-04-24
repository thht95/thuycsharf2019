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
    public partial class hdbanhang : Form
    {
        public hdbanhang()
        {
            InitializeComponent();
        }

        connect con = new connect();
        int flag;
        private void data()
        {
            con.data("select_HDBH", dgvhoadon);

        }
        private void Themhoadon()
        {
            int index = dgvhoadon.CurrentRow.Index;
            txtmahd.Text = dgvhoadon.Rows[index].Cells[0].Value.ToString();
            txttennv.Text = dgvhoadon.Rows[index].Cells[1].Value.ToString();
            txttenkh.Text = dgvhoadon.Rows[index].Cells[2].Value.ToString();
            dttgban.Text = dgvhoadon.Rows[index].Cells[3].Value.ToString();
            txttthd.Text = dgvhoadon.Rows[index].Cells[4].Value.ToString();
            txtmahb.Text = dgvhoadon.Rows[index].Cells[5].Value.ToString();
        }

        void dis_end(bool e)
        {
            txttennv.Enabled = e;
            txttenkh.Enabled = e;
            txttthd.Enabled = e;
            txtmahb.Enabled = e;


            btnluu.Enabled = e;
            btnhuy.Enabled = e;
            btnthem.Enabled = !e;
            btnsua.Enabled = !e;
            btnxoa.Enabled = !e;
        }


        private void hdbanhang_Load(object sender, EventArgs e)
        {
            data();
            Themhoadon();
            dis_end(false);
        }

        private void dgvhoadon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            hdbanhang_Load(sender, e);
        }


        private void btnthem_Click(object sender, EventArgs e)
        {
            flag = 0;
            dis_end(true);
            txtmahd.Clear();
            txttennv.Clear();
            txttenkh.Clear();
            txttthd.Clear();
            txtmahb.Clear();
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
                    cmd.CommandText = "insert_HDBH1";
                    cmd.Parameters.AddWithValue("@mahd", txtmahd.Text);
                    cmd.Parameters.AddWithValue("@tennv", txttennv.Text);
                    cmd.Parameters.AddWithValue("@tenkh", txttenkh.Text);
                    cmd.Parameters.AddWithValue("@tgban", Convert.ToDateTime(dttgban.Value.ToString()));
                    cmd.Parameters.AddWithValue("@tinhtranghd", txttthd.Text);
                    cmd.Parameters.AddWithValue("@mahb", txtmahb.Text);
                    cmd.ExecuteNonQuery();
                    hdbanhang_Load(sender, e);
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
                    cmd.CommandText = "update_HDBH";
                    cmd.Parameters.AddWithValue("@mahd", txtmahd.Text);
                    cmd.Parameters.AddWithValue("@tennv", txttennv.Text);
                    cmd.Parameters.AddWithValue("@tenkh", txttenkh.Text);
                    cmd.Parameters.AddWithValue("@tgban", Convert.ToDateTime(dttgban.Value.ToString()));
                    cmd.Parameters.AddWithValue("@tinhtranghd", txttthd.Text);
                    cmd.Parameters.AddWithValue("@mahb", txtmahb.Text);
                    cmd.ExecuteNonQuery();
                    hdbanhang_Load(sender, e);
                }
                catch (Exception)
                {
                    MessageBox.Show("Sửa không thành công");
                }
            }
        }

        private void btnsua_Click_1(object sender, EventArgs e)
        {
            flag = 1;
            dis_end(true);
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {

            try
            {
                con.connection();
                SqlCommand cmd = con.cnn.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "delete_HDBH";
                cmd.Parameters.AddWithValue("@mahd", txtmahd.Text);
                DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    cmd.ExecuteNonQuery();
                    hdbanhang_Load(sender, e);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Xóa không thành công");
            }
        }

        private void btnhuy_Click_1(object sender, EventArgs e)
        {
            hdbanhang_Load(sender, e);
        }
    }
}
