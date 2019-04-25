using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;


namespace QLBHTB
{
    public partial class nhomhang : Form
    {
        public nhomhang()
        {
            InitializeComponent();
        }

        connect con = new connect();
        int flag;
        private void data()
        {
            con.data("select_NH", dgvnhomhang);



        }
        private void Themnhomhang()
        {
            int index = dgvnhomhang.CurrentRow.Index;
            txtma.Text = dgvnhomhang.Rows[index].Cells[0].Value.ToString();
            txtten.Text = dgvnhomhang.Rows[index].Cells[1].Value.ToString();

        }

        void dis_end(bool e)
        {
            txtten.Enabled = e;

            btnluu.Enabled = e;
            btnhuy.Enabled = e;
            btnthem.Enabled = !e;
            btnsua.Enabled = !e;
            btnxoa.Enabled = !e;
        }
        private void nhomhang_Load(object sender, EventArgs e)
        {
            data();
            Themnhomhang();
            dis_end(false);
        }

        private void dgvnhomhang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Themnhomhang();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            flag = 0;
            dis_end(true);
            txtma.Clear();
            txtten.Clear();
        }

        private bool checkData()
        {
            if (string.IsNullOrEmpty(txtten.Text))
                return false;
            return true;
        }

        private void btnluu_Click(object sender, EventArgs e)
        {

            if (checkData())
            {
                if (flag == 0)
                {
                    try
                    {
                        con.connection();
                        SqlCommand cmd = con.cnn.CreateCommand();
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "insert_NH";
                        cmd.Parameters.AddWithValue("@ma", txtma.Text);
                        cmd.Parameters.AddWithValue("@ten", txtten.Text);

                        cmd.ExecuteNonQuery();
                        nhomhang_Load(sender, e);
                        MessageBox.Show("Dữ liệu hợp lệ");


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
                        cmd.CommandText = "update_NH";
                        cmd.Parameters.AddWithValue("@ma", txtma.Text);
                        cmd.Parameters.AddWithValue("@ten", txtten.Text);

                        MessageBox.Show("Dữ liệu hợp lệ");

                        cmd.ExecuteNonQuery();
                        nhomhang_Load(sender, e);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Sửa không thành công");
                    }
                }
            }
            else
            {
                MessageBox.Show("Dữ liệu không hợp lệ");
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            try
            {
                con.connection();
                SqlCommand cmd = con.cnn.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "delete_NH";
                cmd.Parameters.AddWithValue("@ma", txtma.Text);
                DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    cmd.ExecuteNonQuery();
                    nhomhang_Load(sender, e);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Xóa không thành công");
            }
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            nhomhang_Load(sender, e);
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            flag = 1;
            dis_end(true);
        }
    }
}