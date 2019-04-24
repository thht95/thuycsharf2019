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
	public partial class FR_hangban : Form
	{
		public FR_hangban()
		{
			InitializeComponent();
		}
		connect con = new connect();

		private void crystalReportViewer1_Load(object sender, EventArgs e)
		{
			con.connection();
			SqlCommand cmd = con.cnn.CreateCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "rp_gia";
			SqlDataAdapter da = new SqlDataAdapter(cmd);
			DataTable dt = new DataTable();
			da.Fill(dt);
			hangban rp = new hangban();
			rp.SetDataSource(dt);
			crystalReportViewer1.ReportSource = rp;
		}
	}
}
