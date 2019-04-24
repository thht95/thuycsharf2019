namespace QLBHTB
{
    partial class hanghoa
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
			this.txttenhh = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.btnhuy = new System.Windows.Forms.Button();
			this.btnluu = new System.Windows.Forms.Button();
			this.btnxoa = new System.Windows.Forms.Button();
			this.btnsua = new System.Windows.Forms.Button();
			this.txtmahh = new System.Windows.Forms.TextBox();
			this.btnthem = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtdactinh = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtdacdiem = new System.Windows.Forms.TextBox();
			this.txttennh = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.dgvhanghoa = new System.Windows.Forms.DataGridView();
			this.maHH = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tenHH = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dacdiem = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dactinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tenNH = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cbotennh = new System.Windows.Forms.ComboBox();
			((System.ComponentModel.ISupportInitialize)(this.dgvhanghoa)).BeginInit();
			this.SuspendLayout();
			// 
			// txttenhh
			// 
			this.txttenhh.Location = new System.Drawing.Point(157, 104);
			this.txttenhh.Name = "txttenhh";
			this.txttenhh.Size = new System.Drawing.Size(100, 20);
			this.txttenhh.TabIndex = 21;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(74, 107);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(70, 13);
			this.label3.TabIndex = 20;
			this.label3.Text = "tên hàng hóa";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(74, 69);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(69, 13);
			this.label2.TabIndex = 19;
			this.label2.Text = "mã hàng hóa";
			// 
			// btnhuy
			// 
			this.btnhuy.Location = new System.Drawing.Point(490, 147);
			this.btnhuy.Name = "btnhuy";
			this.btnhuy.Size = new System.Drawing.Size(75, 23);
			this.btnhuy.TabIndex = 18;
			this.btnhuy.Text = "hủy";
			this.btnhuy.UseVisualStyleBackColor = true;
			this.btnhuy.Click += new System.EventHandler(this.btnhuy_Click_1);
			// 
			// btnluu
			// 
			this.btnluu.Location = new System.Drawing.Point(390, 147);
			this.btnluu.Name = "btnluu";
			this.btnluu.Size = new System.Drawing.Size(75, 23);
			this.btnluu.TabIndex = 17;
			this.btnluu.Text = "lưu";
			this.btnluu.UseVisualStyleBackColor = true;
			this.btnluu.Click += new System.EventHandler(this.btnluu_Click_1);
			// 
			// btnxoa
			// 
			this.btnxoa.Location = new System.Drawing.Point(286, 147);
			this.btnxoa.Name = "btnxoa";
			this.btnxoa.Size = new System.Drawing.Size(75, 23);
			this.btnxoa.TabIndex = 16;
			this.btnxoa.Text = "xóa";
			this.btnxoa.UseVisualStyleBackColor = true;
			this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click_1);
			// 
			// btnsua
			// 
			this.btnsua.Location = new System.Drawing.Point(182, 147);
			this.btnsua.Name = "btnsua";
			this.btnsua.Size = new System.Drawing.Size(75, 23);
			this.btnsua.TabIndex = 15;
			this.btnsua.Text = "sửa";
			this.btnsua.UseVisualStyleBackColor = true;
			this.btnsua.Click += new System.EventHandler(this.btnsua_Click_1);
			// 
			// txtmahh
			// 
			this.txtmahh.Location = new System.Drawing.Point(157, 66);
			this.txtmahh.Name = "txtmahh";
			this.txtmahh.Size = new System.Drawing.Size(100, 20);
			this.txtmahh.TabIndex = 14;
			// 
			// btnthem
			// 
			this.btnthem.Location = new System.Drawing.Point(76, 147);
			this.btnthem.Name = "btnthem";
			this.btnthem.Size = new System.Drawing.Size(75, 23);
			this.btnthem.TabIndex = 13;
			this.btnthem.Text = "thêm";
			this.btnthem.UseVisualStyleBackColor = true;
			this.btnthem.Click += new System.EventHandler(this.btnthem_Click_1);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(45, 32);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(96, 13);
			this.label1.TabIndex = 12;
			this.label1.Text = "thông tin hàng hóa";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(307, 107);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(48, 13);
			this.label4.TabIndex = 24;
			this.label4.Text = "đặc tính";
			// 
			// txtdactinh
			// 
			this.txtdactinh.Location = new System.Drawing.Point(390, 104);
			this.txtdactinh.Name = "txtdactinh";
			this.txtdactinh.Size = new System.Drawing.Size(100, 20);
			this.txtdactinh.TabIndex = 23;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(307, 69);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(55, 13);
			this.label5.TabIndex = 26;
			this.label5.Text = "đặc điểm ";
			// 
			// txtdacdiem
			// 
			this.txtdacdiem.Location = new System.Drawing.Point(390, 66);
			this.txtdacdiem.Name = "txtdacdiem";
			this.txtdacdiem.Size = new System.Drawing.Size(100, 20);
			this.txtdacdiem.TabIndex = 25;
			// 
			// txttennh
			// 
			this.txttennh.AutoSize = true;
			this.txttennh.Location = new System.Drawing.Point(534, 107);
			this.txttennh.Name = "txttennh";
			this.txttennh.Size = new System.Drawing.Size(78, 13);
			this.txttennh.TabIndex = 28;
			this.txttennh.Text = "tên nhóm hàng";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(45, 195);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(113, 13);
			this.label7.TabIndex = 29;
			this.label7.Text = "danh sách nhóm hàng";
			// 
			// dgvhanghoa
			// 
			this.dgvhanghoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvhanghoa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maHH,
            this.tenHH,
            this.dacdiem,
            this.dactinh,
            this.tenNH});
			this.dgvhanghoa.Location = new System.Drawing.Point(48, 225);
			this.dgvhanghoa.Name = "dgvhanghoa";
			this.dgvhanghoa.Size = new System.Drawing.Size(536, 150);
			this.dgvhanghoa.TabIndex = 30;
			this.dgvhanghoa.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvhanghoa_CellClick);
			// 
			// maHH
			// 
			this.maHH.DataPropertyName = "maHH";
			this.maHH.HeaderText = "Mã hàng hóa";
			this.maHH.Name = "maHH";
			// 
			// tenHH
			// 
			this.tenHH.DataPropertyName = "tenHH";
			this.tenHH.HeaderText = "Tên Hàng hóa";
			this.tenHH.Name = "tenHH";
			// 
			// dacdiem
			// 
			this.dacdiem.DataPropertyName = "dacdiem";
			this.dacdiem.HeaderText = "Đặc điểm";
			this.dacdiem.Name = "dacdiem";
			// 
			// dactinh
			// 
			this.dactinh.DataPropertyName = "dactinh";
			this.dactinh.HeaderText = "Đặc tính";
			this.dactinh.Name = "dactinh";
			// 
			// tenNH
			// 
			this.tenNH.DataPropertyName = "tenNH";
			this.tenNH.HeaderText = "tên nhóm hàng";
			this.tenNH.Name = "tenNH";
			// 
			// cbotennh
			// 
			this.cbotennh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbotennh.FormattingEnabled = true;
			this.cbotennh.Location = new System.Drawing.Point(617, 103);
			this.cbotennh.Name = "cbotennh";
			this.cbotennh.Size = new System.Drawing.Size(121, 21);
			this.cbotennh.TabIndex = 31;
			// 
			// hanghoa
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 387);
			this.Controls.Add(this.cbotennh);
			this.Controls.Add(this.dgvhanghoa);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.txttennh);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.txtdacdiem);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtdactinh);
			this.Controls.Add(this.txttenhh);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btnhuy);
			this.Controls.Add(this.btnluu);
			this.Controls.Add(this.btnxoa);
			this.Controls.Add(this.btnsua);
			this.Controls.Add(this.txtmahh);
			this.Controls.Add(this.btnthem);
			this.Controls.Add(this.label1);
			this.Name = "hanghoa";
			this.Text = "hanghoa";
			this.Load += new System.EventHandler(this.hanghoa_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvhanghoa)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txttenhh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnhuy;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.TextBox txtmahh;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtdactinh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtdacdiem;
        private System.Windows.Forms.Label txttennh;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvhanghoa;
		private System.Windows.Forms.ComboBox cbotennh;
		private System.Windows.Forms.DataGridViewTextBoxColumn maHH;
		private System.Windows.Forms.DataGridViewTextBoxColumn tenHH;
		private System.Windows.Forms.DataGridViewTextBoxColumn dacdiem;
		private System.Windows.Forms.DataGridViewTextBoxColumn dactinh;
		private System.Windows.Forms.DataGridViewTextBoxColumn tenNH;
	}
}