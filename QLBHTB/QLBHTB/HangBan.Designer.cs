namespace QLBHTB
{
    partial class HangBan
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
			this.dttgbaohanh = new System.Windows.Forms.DateTimePicker();
			this.txttenhh = new System.Windows.Forms.Label();
			this.dgvhangban = new System.Windows.Forms.DataGridView();
			this.maHB = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tenHB = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SL = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TGbaohanh = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tenHH = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.txtsl = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtgia = new System.Windows.Forms.TextBox();
			this.txttenhb = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.btnhuy = new System.Windows.Forms.Button();
			this.btnluu = new System.Windows.Forms.Button();
			this.btnxoa = new System.Windows.Forms.Button();
			this.btnsua = new System.Windows.Forms.Button();
			this.txtmahb = new System.Windows.Forms.TextBox();
			this.btnthem = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.cbotenhh = new System.Windows.Forms.ComboBox();
			((System.ComponentModel.ISupportInitialize)(this.dgvhangban)).BeginInit();
			this.SuspendLayout();
			// 
			// dttgbaohanh
			// 
			this.dttgbaohanh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dttgbaohanh.Location = new System.Drawing.Point(603, 61);
			this.dttgbaohanh.Name = "dttgbaohanh";
			this.dttgbaohanh.Size = new System.Drawing.Size(106, 20);
			this.dttgbaohanh.TabIndex = 71;
			// 
			// txttenhh
			// 
			this.txttenhh.AutoSize = true;
			this.txttenhh.Location = new System.Drawing.Point(513, 107);
			this.txttenhh.Name = "txttenhh";
			this.txttenhh.Size = new System.Drawing.Size(73, 13);
			this.txttenhh.TabIndex = 70;
			this.txttenhh.Text = "tên hàng hóa ";
			// 
			// dgvhangban
			// 
			this.dgvhangban.AllowUserToAddRows = false;
			this.dgvhangban.AllowUserToDeleteRows = false;
			this.dgvhangban.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvhangban.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maHB,
            this.tenHB,
            this.SL,
            this.gia,
            this.TGbaohanh,
            this.tenHH});
			this.dgvhangban.Location = new System.Drawing.Point(53, 226);
			this.dgvhangban.Name = "dgvhangban";
			this.dgvhangban.ReadOnly = true;
			this.dgvhangban.Size = new System.Drawing.Size(635, 150);
			this.dgvhangban.TabIndex = 68;
			this.dgvhangban.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvhangban_CellClick_1);
			// 
			// maHB
			// 
			this.maHB.DataPropertyName = "maHB";
			this.maHB.HeaderText = "mã hàng bán";
			this.maHB.Name = "maHB";
			this.maHB.ReadOnly = true;
			// 
			// tenHB
			// 
			this.tenHB.DataPropertyName = "tenHB";
			this.tenHB.HeaderText = "tên hàng bán";
			this.tenHB.Name = "tenHB";
			this.tenHB.ReadOnly = true;
			// 
			// SL
			// 
			this.SL.DataPropertyName = "SL";
			this.SL.HeaderText = "số lượng";
			this.SL.Name = "SL";
			this.SL.ReadOnly = true;
			// 
			// gia
			// 
			this.gia.DataPropertyName = "gia";
			this.gia.HeaderText = "giá bán ";
			this.gia.Name = "gia";
			this.gia.ReadOnly = true;
			// 
			// TGbaohanh
			// 
			this.TGbaohanh.DataPropertyName = "TGbaohanh";
			this.TGbaohanh.HeaderText = "thời gian bảo hành";
			this.TGbaohanh.Name = "TGbaohanh";
			this.TGbaohanh.ReadOnly = true;
			// 
			// tenHH
			// 
			this.tenHH.DataPropertyName = "tenHH";
			this.tenHH.HeaderText = "tên hàng hóa";
			this.tenHH.Name = "tenHH";
			this.tenHH.ReadOnly = true;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(50, 196);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(108, 13);
			this.label7.TabIndex = 67;
			this.label7.Text = "danh sách hàng bán ";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(488, 69);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(95, 13);
			this.label6.TabIndex = 66;
			this.label6.Text = "thời gian bảo hành";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(312, 70);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(47, 13);
			this.label5.TabIndex = 65;
			this.label5.Text = "số lượng";
			// 
			// txtsl
			// 
			this.txtsl.Location = new System.Drawing.Point(365, 66);
			this.txtsl.Name = "txtsl";
			this.txtsl.Size = new System.Drawing.Size(100, 20);
			this.txtsl.TabIndex = 64;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(317, 108);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(42, 13);
			this.label4.TabIndex = 63;
			this.label4.Text = "giá bán";
			// 
			// txtgia
			// 
			this.txtgia.Location = new System.Drawing.Point(370, 104);
			this.txtgia.Name = "txtgia";
			this.txtgia.Size = new System.Drawing.Size(100, 20);
			this.txtgia.TabIndex = 62;
			// 
			// txttenhb
			// 
			this.txttenhb.Location = new System.Drawing.Point(162, 105);
			this.txttenhb.Name = "txttenhb";
			this.txttenhb.Size = new System.Drawing.Size(100, 20);
			this.txttenhb.TabIndex = 61;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(83, 108);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(70, 13);
			this.label3.TabIndex = 60;
			this.label3.Text = "tên hàng bán";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(83, 70);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(69, 13);
			this.label2.TabIndex = 59;
			this.label2.Text = "mã hàng bán";
			// 
			// btnhuy
			// 
			this.btnhuy.Location = new System.Drawing.Point(495, 148);
			this.btnhuy.Name = "btnhuy";
			this.btnhuy.Size = new System.Drawing.Size(75, 23);
			this.btnhuy.TabIndex = 58;
			this.btnhuy.Text = "hủy";
			this.btnhuy.UseVisualStyleBackColor = true;
			// 
			// btnluu
			// 
			this.btnluu.Location = new System.Drawing.Point(395, 148);
			this.btnluu.Name = "btnluu";
			this.btnluu.Size = new System.Drawing.Size(75, 23);
			this.btnluu.TabIndex = 57;
			this.btnluu.Text = "lưu";
			this.btnluu.UseVisualStyleBackColor = true;
			// 
			// btnxoa
			// 
			this.btnxoa.Location = new System.Drawing.Point(291, 148);
			this.btnxoa.Name = "btnxoa";
			this.btnxoa.Size = new System.Drawing.Size(75, 23);
			this.btnxoa.TabIndex = 56;
			this.btnxoa.Text = "xóa";
			this.btnxoa.UseVisualStyleBackColor = true;
			// 
			// btnsua
			// 
			this.btnsua.Location = new System.Drawing.Point(187, 148);
			this.btnsua.Name = "btnsua";
			this.btnsua.Size = new System.Drawing.Size(75, 23);
			this.btnsua.TabIndex = 55;
			this.btnsua.Text = "sửa";
			this.btnsua.UseVisualStyleBackColor = true;
			// 
			// txtmahb
			// 
			this.txtmahb.Location = new System.Drawing.Point(162, 67);
			this.txtmahb.Name = "txtmahb";
			this.txtmahb.Size = new System.Drawing.Size(100, 20);
			this.txtmahb.TabIndex = 54;
			// 
			// btnthem
			// 
			this.btnthem.Location = new System.Drawing.Point(81, 148);
			this.btnthem.Name = "btnthem";
			this.btnthem.Size = new System.Drawing.Size(75, 23);
			this.btnthem.TabIndex = 53;
			this.btnthem.Text = "thêm";
			this.btnthem.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(50, 33);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(99, 13);
			this.label1.TabIndex = 52;
			this.label1.Text = "thông tin hàng bán ";
			// 
			// cbotenhh
			// 
			this.cbotenhh.FormattingEnabled = true;
			this.cbotenhh.Location = new System.Drawing.Point(603, 105);
			this.cbotenhh.Name = "cbotenhh";
			this.cbotenhh.Size = new System.Drawing.Size(121, 21);
			this.cbotenhh.TabIndex = 72;
			// 
			// HangBan
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.cbotenhh);
			this.Controls.Add(this.dttgbaohanh);
			this.Controls.Add(this.txttenhh);
			this.Controls.Add(this.dgvhangban);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.txtsl);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtgia);
			this.Controls.Add(this.txttenhb);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btnhuy);
			this.Controls.Add(this.btnluu);
			this.Controls.Add(this.btnxoa);
			this.Controls.Add(this.btnsua);
			this.Controls.Add(this.txtmahb);
			this.Controls.Add(this.btnthem);
			this.Controls.Add(this.label1);
			this.Name = "HangBan";
			this.Text = "HangBan";
			((System.ComponentModel.ISupportInitialize)(this.dgvhangban)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dttgbaohanh;
        private System.Windows.Forms.Label txttenhh;
        private System.Windows.Forms.DataGridView dgvhangban;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtsl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtgia;
        private System.Windows.Forms.TextBox txttenhb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnhuy;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.TextBox txtmahb;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cbotenhh;
		private System.Windows.Forms.DataGridViewTextBoxColumn maHB;
		private System.Windows.Forms.DataGridViewTextBoxColumn tenHB;
		private System.Windows.Forms.DataGridViewTextBoxColumn SL;
		private System.Windows.Forms.DataGridViewTextBoxColumn gia;
		private System.Windows.Forms.DataGridViewTextBoxColumn TGbaohanh;
		private System.Windows.Forms.DataGridViewTextBoxColumn tenHH;
	}
}