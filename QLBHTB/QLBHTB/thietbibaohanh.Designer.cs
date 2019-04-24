namespace QLBHTB
{
    partial class thietbibaohanh
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
            this.dgvtbbh = new System.Windows.Forms.DataGridView();
            this.maTBBH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tinhtrangBH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PDnguyennhan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maHB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.txt = new System.Windows.Forms.Label();
            this.txtnh = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtmahb = new System.Windows.Forms.TextBox();
            this.txtttbh = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnhuy = new System.Windows.Forms.Button();
            this.btnluu = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.txtmatbbh = new System.Windows.Forms.TextBox();
            this.btnthem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtbbh)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvtbbh
            // 
            this.dgvtbbh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvtbbh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maTBBH,
            this.tinhtrangBH,
            this.PDnguyennhan,
            this.maHB});
            this.dgvtbbh.Location = new System.Drawing.Point(15, 214);
            this.dgvtbbh.Name = "dgvtbbh";
            this.dgvtbbh.Size = new System.Drawing.Size(432, 150);
            this.dgvtbbh.TabIndex = 90;
            this.dgvtbbh.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvtbbh_CellClick);
            // 
            // maTBBH
            // 
            this.maTBBH.DataPropertyName = "maTBBH";
            this.maTBBH.HeaderText = "mã thiết bị BH";
            this.maTBBH.Name = "maTBBH";
            // 
            // tinhtrangBH
            // 
            this.tinhtrangBH.DataPropertyName = "tinhtrangBH";
            this.tinhtrangBH.HeaderText = "tình trạng bảo hành";
            this.tinhtrangBH.Name = "tinhtrangBH";
            // 
            // PDnguyennhan
            // 
            this.PDnguyennhan.DataPropertyName = "PDnguyennhan";
            this.PDnguyennhan.HeaderText = "đoán nguyên nhân";
            this.PDnguyennhan.Name = "PDnguyennhan";
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
            this.label7.Location = new System.Drawing.Point(12, 184);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(139, 13);
            this.label7.TabIndex = 89;
            this.label7.Text = "danh sách thiết bị bảo hành";
            // 
            // txt
            // 
            this.txt.AutoSize = true;
            this.txt.Location = new System.Drawing.Point(252, 58);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(97, 13);
            this.txt.TabIndex = 86;
            this.txt.Text = "đoán nguyên nhân";
            // 
            // txtnh
            // 
            this.txtnh.Location = new System.Drawing.Point(359, 54);
            this.txtnh.Name = "txtnh";
            this.txtnh.Size = new System.Drawing.Size(100, 20);
            this.txtnh.TabIndex = 85;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(278, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 84;
            this.label4.Text = "mã hàng bán ";
            // 
            // txtmahb
            // 
            this.txtmahb.Location = new System.Drawing.Point(359, 92);
            this.txtmahb.Name = "txtmahb";
            this.txtmahb.Size = new System.Drawing.Size(100, 20);
            this.txtmahb.TabIndex = 83;
            // 
            // txtttbh
            // 
            this.txtttbh.Location = new System.Drawing.Point(124, 93);
            this.txtttbh.Name = "txtttbh";
            this.txtttbh.Size = new System.Drawing.Size(100, 20);
            this.txtttbh.TabIndex = 82;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 81;
            this.label3.Text = "tình trạng BH";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 80;
            this.label2.Text = "mã thiết bị BH";
            // 
            // btnhuy
            // 
            this.btnhuy.Location = new System.Drawing.Point(432, 136);
            this.btnhuy.Name = "btnhuy";
            this.btnhuy.Size = new System.Drawing.Size(75, 23);
            this.btnhuy.TabIndex = 79;
            this.btnhuy.Text = "hủy";
            this.btnhuy.UseVisualStyleBackColor = true;
            this.btnhuy.Click += new System.EventHandler(this.btnhuy_Click_1);
            // 
            // btnluu
            // 
            this.btnluu.Location = new System.Drawing.Point(332, 136);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(75, 23);
            this.btnluu.TabIndex = 78;
            this.btnluu.Text = "lưu";
            this.btnluu.UseVisualStyleBackColor = true;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click_1);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(228, 136);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(75, 23);
            this.btnxoa.TabIndex = 77;
            this.btnxoa.Text = "xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click_1);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(124, 136);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(75, 23);
            this.btnsua.TabIndex = 76;
            this.btnsua.Text = "sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click_1);
            // 
            // txtmatbbh
            // 
            this.txtmatbbh.Location = new System.Drawing.Point(124, 55);
            this.txtmatbbh.Name = "txtmatbbh";
            this.txtmatbbh.Size = new System.Drawing.Size(100, 20);
            this.txtmatbbh.TabIndex = 75;
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(18, 136);
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
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 13);
            this.label1.TabIndex = 73;
            this.label1.Text = "thông tin thiết bị bảo hành  ";
            // 
            // thietbibaohanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvtbbh);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt);
            this.Controls.Add(this.txtnh);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtmahb);
            this.Controls.Add(this.txtttbh);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnhuy);
            this.Controls.Add(this.btnluu);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.txtmatbbh);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.label1);
            this.Name = "thietbibaohanh";
            this.Text = "thietbibaohanh";
            this.Load += new System.EventHandler(this.thietbibaohanh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvtbbh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvtbbh;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label txt;
        private System.Windows.Forms.TextBox txtnh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtmahb;
        private System.Windows.Forms.TextBox txtttbh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnhuy;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.TextBox txtmatbbh;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn maTBBH;
        private System.Windows.Forms.DataGridViewTextBoxColumn tinhtrangBH;
        private System.Windows.Forms.DataGridViewTextBoxColumn PDnguyennhan;
        private System.Windows.Forms.DataGridViewTextBoxColumn maHB;
    }
}