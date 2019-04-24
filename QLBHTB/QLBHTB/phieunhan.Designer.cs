namespace QLBHTB
{
    partial class phieunhan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label8 = new System.Windows.Forms.Label();
            this.dgvphieunhan = new System.Windows.Forms.DataGridView();
            this.maPN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diachiKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaynhan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaytra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maHB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txttennv = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txttenkh = new System.Windows.Forms.TextBox();
            this.txtmahb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnhuy = new System.Windows.Forms.Button();
            this.btnluu = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.txtmapn = new System.Windows.Forms.TextBox();
            this.btnthem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtdc = new System.Windows.Forms.TextBox();
            this.dtngaynhan = new System.Windows.Forms.DateTimePicker();
            this.dtngaytra = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvphieunhan)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(508, 96);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 70;
            this.label8.Text = "ngày trả";
            // 
            // dgvphieunhan
            // 
            this.dgvphieunhan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvphieunhan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maPN,
            this.tenNV,
            this.tenKH,
            this.diachiKH,
            this.ngaynhan,
            this.ngaytra,
            this.maHB});
            this.dgvphieunhan.Location = new System.Drawing.Point(23, 214);
            this.dgvphieunhan.Name = "dgvphieunhan";
            this.dgvphieunhan.Size = new System.Drawing.Size(719, 150);
            this.dgvphieunhan.TabIndex = 68;
            this.dgvphieunhan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvphieunhan_CellClick);
            // 
            // maPN
            // 
            this.maPN.DataPropertyName = "maPN";
            this.maPN.HeaderText = "mã phiếu nhận";
            this.maPN.Name = "maPN";
            // 
            // tenNV
            // 
            this.tenNV.DataPropertyName = "tenNV";
            this.tenNV.HeaderText = "tên nhân viên";
            this.tenNV.Name = "tenNV";
            // 
            // tenKH
            // 
            this.tenKH.DataPropertyName = "tenKH";
            this.tenKH.HeaderText = "tên khách ";
            this.tenKH.Name = "tenKH";
            // 
            // diachiKH
            // 
            this.diachiKH.DataPropertyName = "diachiKH";
            this.diachiKH.HeaderText = "địa chỉ khách";
            this.diachiKH.Name = "diachiKH";
            // 
            // ngaynhan
            // 
            this.ngaynhan.DataPropertyName = "ngaynhan";
            this.ngaynhan.HeaderText = "ngày nhận";
            this.ngaynhan.Name = "ngaynhan";
            // 
            // ngaytra
            // 
            this.ngaytra.DataPropertyName = "ngaytra";
            this.ngaytra.HeaderText = "ngày trả";
            this.ngaytra.Name = "ngaytra";
            // 
            // maHB
            // 
            this.maHB.DataPropertyName = "maHB";
            this.maHB.HeaderText = "mã hàng bán ";
            this.maHB.Name = "maHB";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 184);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 13);
            this.label7.TabIndex = 67;
            this.label7.Text = "danh sách phiếu nhận";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(496, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 66;
            this.label6.Text = "ngày nhận";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(260, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 64;
            this.label5.Text = "tên nhân viên";
            // 
            // txttennv
            // 
            this.txttennv.Location = new System.Drawing.Point(335, 54);
            this.txttennv.Name = "txttennv";
            this.txttennv.Size = new System.Drawing.Size(100, 20);
            this.txttennv.TabIndex = 63;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(250, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 62;
            this.label4.Text = "tên khách hàng";
            // 
            // txttenkh
            // 
            this.txttenkh.Location = new System.Drawing.Point(335, 92);
            this.txttenkh.Name = "txttenkh";
            this.txttenkh.Size = new System.Drawing.Size(100, 20);
            this.txttenkh.TabIndex = 61;
            // 
            // txtmahb
            // 
            this.txtmahb.Location = new System.Drawing.Point(132, 93);
            this.txtmahb.Name = "txtmahb";
            this.txtmahb.Size = new System.Drawing.Size(100, 20);
            this.txtmahb.TabIndex = 60;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 59;
            this.label3.Text = "mã hàng bán";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 58;
            this.label2.Text = "mã phiếu nhận";
            // 
            // btnhuy
            // 
            this.btnhuy.Location = new System.Drawing.Point(440, 136);
            this.btnhuy.Name = "btnhuy";
            this.btnhuy.Size = new System.Drawing.Size(75, 23);
            this.btnhuy.TabIndex = 57;
            this.btnhuy.Text = "hủy";
            this.btnhuy.UseVisualStyleBackColor = true;
            this.btnhuy.Click += new System.EventHandler(this.btnhuy_Click_1);
            // 
            // btnluu
            // 
            this.btnluu.Location = new System.Drawing.Point(340, 136);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(75, 23);
            this.btnluu.TabIndex = 56;
            this.btnluu.Text = "lưu";
            this.btnluu.UseVisualStyleBackColor = true;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click_1);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(236, 136);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(75, 23);
            this.btnxoa.TabIndex = 55;
            this.btnxoa.Text = "xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click_1);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(132, 136);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(75, 23);
            this.btnsua.TabIndex = 54;
            this.btnsua.Text = "sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click_1);
            // 
            // txtmapn
            // 
            this.txtmapn.Location = new System.Drawing.Point(132, 55);
            this.txtmapn.Name = "txtmapn";
            this.txtmapn.Size = new System.Drawing.Size(100, 20);
            this.txtmapn.TabIndex = 53;
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(26, 136);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(75, 23);
            this.btnthem.TabIndex = 52;
            this.btnthem.Text = "thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 51;
            this.label1.Text = "thông tin phiếu nhận ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(454, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 13);
            this.label9.TabIndex = 72;
            this.label9.Text = "địa chỉ khách hàng";
            // 
            // txtdc
            // 
            this.txtdc.Location = new System.Drawing.Point(558, 18);
            this.txtdc.Name = "txtdc";
            this.txtdc.Size = new System.Drawing.Size(100, 20);
            this.txtdc.TabIndex = 71;
            // 
            // dtngaynhan
            // 
            this.dtngaynhan.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtngaynhan.Location = new System.Drawing.Point(558, 55);
            this.dtngaynhan.Name = "dtngaynhan";
            this.dtngaynhan.Size = new System.Drawing.Size(100, 20);
            this.dtngaynhan.TabIndex = 73;
            // 
            // dtngaytra
            // 
            this.dtngaytra.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtngaytra.Location = new System.Drawing.Point(558, 93);
            this.dtngaytra.Name = "dtngaytra";
            this.dtngaytra.Size = new System.Drawing.Size(100, 20);
            this.dtngaytra.TabIndex = 74;
            // 
            // phieunhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtngaytra);
            this.Controls.Add(this.dtngaynhan);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtdc);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dgvphieunhan);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txttennv);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txttenkh);
            this.Controls.Add(this.txtmahb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnhuy);
            this.Controls.Add(this.btnluu);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.txtmapn);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.label1);
            this.Name = "phieunhan";
            this.Text = "phieunhan";
            this.Load += new System.EventHandler(this.phieunhan_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvphieunhan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgvphieunhan;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txttennv;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txttenkh;
        private System.Windows.Forms.TextBox txtmahb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnhuy;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.TextBox txtmapn;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtdc;
        private System.Windows.Forms.DataGridViewTextBoxColumn maPN;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn diachiKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaynhan;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaytra;
        private System.Windows.Forms.DataGridViewTextBoxColumn maHB;
        private System.Windows.Forms.DateTimePicker dtngaynhan;
        private System.Windows.Forms.DateTimePicker dtngaytra;
    }
}