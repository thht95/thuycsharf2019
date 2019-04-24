namespace QLBHTB
{
    partial class hdbanhang
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
            this.txttthd = new System.Windows.Forms.TextBox();
            this.dgvhoadon = new System.Windows.Forms.DataGridView();
            this.maHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TGban = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tinhtrangHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.txtmahd = new System.Windows.Forms.TextBox();
            this.btnthem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dttgban = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvhoadon)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(478, 130);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 13);
            this.label8.TabIndex = 114;
            this.label8.Text = "tình trạng hóa đơn";
            // 
            // txttthd
            // 
            this.txttthd.Location = new System.Drawing.Point(577, 126);
            this.txttthd.Name = "txttthd";
            this.txttthd.Size = new System.Drawing.Size(100, 20);
            this.txttthd.TabIndex = 113;
            // 
            // dgvhoadon
            // 
            this.dgvhoadon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvhoadon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maHD,
            this.tenNV,
            this.tenKH,
            this.TGban,
            this.tinhtrangHD,
            this.maHB});
            this.dgvhoadon.Location = new System.Drawing.Point(42, 248);
            this.dgvhoadon.Name = "dgvhoadon";
            this.dgvhoadon.Size = new System.Drawing.Size(635, 150);
            this.dgvhoadon.TabIndex = 112;
            this.dgvhoadon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvhoadon_CellClick);
            // 
            // maHD
            // 
            this.maHD.DataPropertyName = "maHD";
            this.maHD.HeaderText = "mã hóa đơn";
            this.maHD.Name = "maHD";
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
            this.tenKH.HeaderText = "tên khách hàng";
            this.tenKH.Name = "tenKH";
            // 
            // TGban
            // 
            this.TGban.DataPropertyName = "TGban";
            this.TGban.HeaderText = "thời gian bán ";
            this.TGban.Name = "TGban";
            // 
            // tinhtrangHD
            // 
            this.tinhtrangHD.DataPropertyName = "tinhtrangHD";
            this.tinhtrangHD.HeaderText = "tình trạng hóa đơn";
            this.tinhtrangHD.Name = "tinhtrangHD";
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
            this.label7.Location = new System.Drawing.Point(39, 218);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 13);
            this.label7.TabIndex = 111;
            this.label7.Text = "danh sách nhật kí bảo hành";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(505, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 110;
            this.label6.Text = "thời gian bán ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(279, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 108;
            this.label5.Text = "tên nhân viên";
            // 
            // txttennv
            // 
            this.txttennv.Location = new System.Drawing.Point(354, 88);
            this.txttennv.Name = "txttennv";
            this.txttennv.Size = new System.Drawing.Size(100, 20);
            this.txttennv.TabIndex = 107;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(269, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 106;
            this.label4.Text = "tên khách hàng";
            // 
            // txttenkh
            // 
            this.txttenkh.Location = new System.Drawing.Point(354, 126);
            this.txttenkh.Name = "txttenkh";
            this.txttenkh.Size = new System.Drawing.Size(100, 20);
            this.txttenkh.TabIndex = 105;
            // 
            // txtmahb
            // 
            this.txtmahb.Location = new System.Drawing.Point(151, 127);
            this.txtmahb.Name = "txtmahb";
            this.txtmahb.Size = new System.Drawing.Size(100, 20);
            this.txtmahb.TabIndex = 104;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 103;
            this.label3.Text = "mã hàng bán ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 102;
            this.label2.Text = "mã hóa đơn";
            // 
            // btnhuy
            // 
            this.btnhuy.Location = new System.Drawing.Point(459, 170);
            this.btnhuy.Name = "btnhuy";
            this.btnhuy.Size = new System.Drawing.Size(75, 23);
            this.btnhuy.TabIndex = 101;
            this.btnhuy.Text = "hủy";
            this.btnhuy.UseVisualStyleBackColor = true;
            this.btnhuy.Click += new System.EventHandler(this.btnhuy_Click_1);
            // 
            // btnluu
            // 
            this.btnluu.Location = new System.Drawing.Point(359, 170);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(75, 23);
            this.btnluu.TabIndex = 100;
            this.btnluu.Text = "lưu";
            this.btnluu.UseVisualStyleBackColor = true;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(255, 170);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(75, 23);
            this.btnxoa.TabIndex = 99;
            this.btnxoa.Text = "xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(151, 170);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(75, 23);
            this.btnsua.TabIndex = 98;
            this.btnsua.Text = "sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click_1);
            // 
            // txtmahd
            // 
            this.txtmahd.Location = new System.Drawing.Point(151, 89);
            this.txtmahd.Name = "txtmahd";
            this.txtmahd.Size = new System.Drawing.Size(100, 20);
            this.txtmahd.TabIndex = 97;
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(45, 170);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(75, 23);
            this.btnthem.TabIndex = 96;
            this.btnthem.Text = "thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 95;
            this.label1.Text = "thông tin hóa đơn";
            // 
            // dttgban
            // 
            this.dttgban.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dttgban.Location = new System.Drawing.Point(577, 86);
            this.dttgban.Name = "dttgban";
            this.dttgban.Size = new System.Drawing.Size(100, 20);
            this.dttgban.TabIndex = 115;
            // 
            // hdbanhang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dttgban);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txttthd);
            this.Controls.Add(this.dgvhoadon);
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
            this.Controls.Add(this.txtmahd);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.label1);
            this.Name = "hdbanhang";
            this.Text = "hdbanhang";
            this.Load += new System.EventHandler(this.hdbanhang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvhoadon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txttthd;
        private System.Windows.Forms.DataGridView dgvhoadon;
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
        private System.Windows.Forms.TextBox txtmahd;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn maHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TGban;
        private System.Windows.Forms.DataGridViewTextBoxColumn tinhtrangHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn maHB;
        private System.Windows.Forms.DateTimePicker dttgban;
    }
}