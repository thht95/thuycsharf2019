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
    public partial class hanghoa : Form
    {
        public hanghoa()
        {
            InitializeComponent();
        }

        connect con = new connect();
        int flag;
        private void data()
        {
            con.data("select_HH", dgvhanghoa);
			con.Load_cbo("cbo_nhomhang", cbotennh); //thay mã = tên 
		}
        private void Themhanghoa()
        {
            int index = dgvhanghoa.CurrentRow.Index;
            txtmahh.Text = dgvhanghoa.Rows[index].Cells[0].Value.ToString();
            txttenhh.Text = dgvhanghoa.Rows[index].Cells[1].Value.ToString();
            txtdacdiem.Text = dgvhanghoa.Rows[index].Cells[2].Value.ToString();
            txtdactinh.Text = dgvhanghoa.Rows[index].Cells[3].Value.ToString();
            cbotennh.Text = dgvhanghoa.Rows[index].Cells[4].Value.ToString();
        }

        void dis_end(bool e)
        {
            txttenhh.Enabled = e;
            txtdacdiem.Enabled = e;
            txtdactinh.Enabled = e;
            cbotennh.Enabled = e;


            btnluu.Enabled = e;
            btnhuy.Enabled = e;
            btnthem.Enabled = !e;
            btnsua.Enabled = !e;
            btnxoa.Enabled = !e;
        }
        private void hanghoa_Load(object sender, EventArgs e)
        {
            data();
            Themhanghoa();
            dis_end(false);
        }


        private void dgvhanghoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Themhanghoa();
        }

        private void btnthem_Click_1(object sender, EventArgs e)
        {

            flag = 0;
            dis_end(true);
            txtmahh.Clear();
            txttenhh.Clear();
            txtdacdiem.Clear();
            txtdactinh.Clear();
           // cbotennh.Clear();
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
					cmd.CommandText = "insert_HH";
					//cmd.Parameters.AddWithValue("@mahh", txtmahh.Text);
					cmd.Parameters.AddWithValue("@tenhh", txttenhh.Text);
					cmd.Parameters.AddWithValue("@dacdiem", txtdacdiem.Text);
					cmd.Parameters.AddWithValue("@dactinh", txtdactinh.Text);
					cmd.Parameters.AddWithValue("@manh", cbotennh.SelectedValue);
					cmd.ExecuteNonQuery();
					hanghoa_Load(sender, e);
				}
				catch (Exception x)
				{
					MessageBox.Show("Thêm không thành công" + x.Message);
				}
			}
			else
			{
				try
				{
					con.connection();
					SqlCommand cmd = con.cnn.CreateCommand();
					cmd.CommandType = CommandType.StoredProcedure;
					cmd.CommandText = "update_HH";
					cmd.Parameters.AddWithValue("@mahh", txtmahh.Text);
					cmd.Parameters.AddWithValue("@tenhh", txttenhh.Text);
					cmd.Parameters.AddWithValue("@dacdiem", txtdacdiem.Text);
					cmd.Parameters.AddWithValue("@dactinh", txtdactinh.Text);
					cmd.Parameters.AddWithValue("@manh", cbotennh.SelectedValue);
					cmd.ExecuteNonQuery();
					hanghoa_Load(sender, e);
				}
				catch (Exception)
				{
					MessageBox.Show("Sửa không thành công");
				}
			}
		}

		private void btnhuy_Click_1(object sender, EventArgs e)
        {
            hanghoa_Load(sender, e);
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
                cmd.CommandText = "delete_HH";
                cmd.Parameters.AddWithValue("@mahh", txtmahh.Text);
                DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    cmd.ExecuteNonQuery();
                    hanghoa_Load(sender, e);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Xóa không thành công");
            }
        }
    }
}