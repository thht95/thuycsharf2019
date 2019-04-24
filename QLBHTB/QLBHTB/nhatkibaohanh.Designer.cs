namespace QLBHTB
{
    partial class nhatkibaohanh
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
            this.label9 = new System.Windows.Forms.Label();
            this.txtmatbbh = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvnkbh = new System.Windows.Forms.DataGridView();
            this.maNKBH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nguyennhan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cachgiaiquyet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayBD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayKT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maTBBH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtnn = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtcgq = new System.Windows.Forms.TextBox();
            this.txttennv = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnhuy = new System.Windows.Forms.Button();
            this.btnluu = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.txtmank = new System.Windows.Forms.TextBox();
            this.btnthem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dtngaybd = new System.Windows.Forms.DateTimePicker();
            this.dtngaykt = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvnkbh)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(478, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 13);
            this.label9.TabIndex = 94;
            this.label9.Text = "mã thiết bị BH";
            // 
            // txtmatbbh
            // 
            this.txtmatbbh.Location = new System.Drawing.Point(560, 22);
            this.txtmatbbh.Name = "txtmatbbh";
            this.txtmatbbh.Size = new System.Drawing.Size(100, 20);
            this.txtmatbbh.TabIndex = 93;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(478, 99);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 13);
            this.label8.TabIndex = 92;
            this.label8.Text = "ngày kết thúc ";
            // 
            // dgvnkbh
            // 
            this.dgvnkbh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvnkbh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maNKBH,
            this.nguyennhan,
            this.cachgiaiquyet,
            this.tenNV,
            this.ngayBD,
            this.ngayKT,
            this.maTBBH});
            this.dgvnkbh.Location = new System.Drawing.Point(25, 218);
            this.dgvnkbh.Name = "dgvnkbh";
            this.dgvnkbh.Size = new System.Drawing.Size(719, 150);
            this.dgvnkbh.TabIndex = 90;
            this.dgvnkbh.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvnkbh_CellClick);
            // 
            // maNKBH
            // 
            this.maNKBH.DataPropertyName = "maNKBH";
            this.maNKBH.HeaderText = "mã nhật kí";
            this.maNKBH.Name = "maNKBH";
            // 
            // nguyennhan
            // 
            this.nguyennhan.DataPropertyName = "nguyennhan";
            this.nguyennhan.HeaderText = "nguyên nhân";
            this.nguyennhan.Name = "nguyennhan";
            // 
            // cachgiaiquyet
            // 
            this.cachgiaiquyet.DataPropertyName = "cachgiaiquyet";
            this.cachgiaiquyet.HeaderText = "cách giải quyết";
            this.cachgiaiquyet.Name = "cachgiaiquyet";
            // 
            // tenNV
            // 
            this.tenNV.DataPropertyName = "tenNV";
            this.tenNV.HeaderText = "ten nhân viên";
            this.tenNV.Name = "tenNV";
            // 
            // ngayBD
            // 
            this.ngayBD.DataPropertyName = "ngayBD";
            this.ngayBD.HeaderText = "ngày bắt đầu";
            this.ngayBD.Name = "ngayBD";
            // 
            // ngayKT
            // 
            this.ngayKT.DataPropertyName = "ngayKT";
            this.ngayKT.HeaderText = "ngày kết thúc";
            this.ngayKT.Name = "ngayKT";
            // 
            // maTBBH
            // 
            this.maTBBH.DataPropertyName = "maTBBH";
            this.maTBBH.HeaderText = "mã thiết bị BH";
            this.maTBBH.Name = "maTBBH";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 188);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 13);
            this.label7.TabIndex = 89;
            this.label7.Text = "danh sách nhật kí bảo hành";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(484, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 88;
            this.label6.Text = "ngày bắt đầu";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(262, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 86;
            this.label5.Text = "nguyên nhân";
            // 
            // txtnn
            // 
            this.txtnn.Location = new System.Drawing.Point(337, 58);
            this.txtnn.Name = "txtnn";
            this.txtnn.Size = new System.Drawing.Size(100, 20);
            this.txtnn.TabIndex = 85;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(252, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 84;
            this.label4.Text = "cách giải quyết ";
            // 
            // txtcgq
            // 
            this.txtcgq.Location = new System.Drawing.Point(337, 96);
            this.txtcgq.Name = "txtcgq";
            this.txtcgq.Size = new System.Drawing.Size(100, 20);
            this.txtcgq.TabIndex = 83;
            // 
            // txttennv
            // 
            this.txttennv.Location = new System.Drawing.Point(134, 97);
            this.txttennv.Name = "txttennv";
            this.txttennv.Size = new System.Drawing.Size(100, 20);
            this.txttennv.TabIndex = 82;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 81;
            this.label3.Text = "tên nhân viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 80;
            this.label2.Text = "mã nhật kí BH";
            // 
            // btnhuy
            // 
            this.btnhuy.Location = new System.Drawing.Point(442, 140);
            this.btnhuy.Name = "btnhuy";
            this.btnhuy.Size = new System.Drawing.Size(75, 23);
            this.btnhuy.TabIndex = 79;
            this.btnhuy.Text = "hủy";
            this.btnhuy.UseVisualStyleBackColor = true;
            this.btnhuy.Click += new System.EventHandler(this.btnhuy_Click_1);
            // 
            // btnluu
            // 
            this.btnluu.Location = new System.Drawing.Point(342, 140);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(75, 23);
            this.btnluu.TabIndex = 78;
            this.btnluu.Text = "lưu";
            this.btnluu.UseVisualStyleBackColor = true;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click_1);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(238, 140);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(75, 23);
            this.btnxoa.TabIndex = 77;
            this.btnxoa.Text = "xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(134, 140);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(75, 23);
            this.btnsua.TabIndex = 76;
            this.btnsua.Text = "sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click_1);
            // 
            // txtmank
            // 
            this.txtmank.Location = new System.Drawing.Point(134, 59);
            this.txtmank.Name = "txtmank";
            this.txtmank.Size = new System.Drawing.Size(100, 20);
            this.txtmank.TabIndex = 75;
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(28, 140);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(75, 23);
            this.btnthem.TabIndex = 74;
            this.btnthem.Text = "thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 13);
            this.label1.TabIndex = 73;
            this.label1.Text = "thông tin nhật kí bảo hành";
            // 
            // dtngaybd
            // 
            this.dtngaybd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtngaybd.Location = new System.Drawing.Point(560, 58);
            this.dtngaybd.Name = "dtngaybd";
            this.dtngaybd.Size = new System.Drawing.Size(100, 20);
            this.dtngaybd.TabIndex = 95;
            // 
            // dtngaykt
            // 
            this.dtngaykt.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtngaykt.Location = new System.Drawing.Point(560, 97);
            this.dtngaykt.Name = "dtngaykt";
            this.dtngaykt.Size = new System.Drawing.Size(100, 20);
            this.dtngaykt.TabIndex = 96;
            // 
            // nhatkibaohanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtngaykt);
            this.Controls.Add(this.dtngaybd);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtmatbbh);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dgvnkbh);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtnn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtcgq);
            this.Controls.Add(this.txttennv);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnhuy);
            this.Controls.Add(this.btnluu);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.txtmank);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.label1);
            this.Name = "nhatkibaohanh";
            this.Text = "nhatkibaohanh";
            this.Load += new System.EventHandler(this.nhatkibaohanh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvnkbh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtmatbbh;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgvnkbh;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtnn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtcgq;
        private System.Windows.Forms.TextBox txttennv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnhuy;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.TextBox txtmank;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNKBH;
        private System.Windows.Forms.DataGridViewTextBoxColumn nguyennhan;
        private System.Windows.Forms.DataGridViewTextBoxColumn cachgiaiquyet;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayBD;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayKT;
        private System.Windows.Forms.DataGridViewTextBoxColumn maTBBH;
        private System.Windows.Forms.DateTimePicker dtngaybd;
        private System.Windows.Forms.DateTimePicker dtngaykt;
    }
}