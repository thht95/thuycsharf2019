namespace QLBHTB
{
    partial class trangchu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.danhmuc = new System.Windows.Forms.ToolStripMenuItem();
            this.nhomhang = new System.Windows.Forms.ToolStripMenuItem();
            this.hanghoa = new System.Windows.Forms.ToolStripMenuItem();
            this.hangban = new System.Windows.Forms.ToolStripMenuItem();
            this.hoadon = new System.Windows.Forms.ToolStripMenuItem();
            this.phieunhan = new System.Windows.Forms.ToolStripMenuItem();
            this.baohanh = new System.Windows.Forms.ToolStripMenuItem();
            this.thietbibh = new System.Windows.Forms.ToolStripMenuItem();
            this.nhatkibh = new System.Windows.Forms.ToolStripMenuItem();
            this.baocao = new System.Windows.Forms.ToolStripMenuItem();
            this.hangbangiatren300000 = new System.Windows.Forms.ToolStripMenuItem();
            this.khachhangcodiachihanoi = new System.Windows.Forms.ToolStripMenuItem();
            this.thoat = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.danhmuc,
            this.baohanh,
            this.baocao,
            this.thoat});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // danhmuc
            // 
            this.danhmuc.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nhomhang,
            this.hanghoa,
            this.hangban,
            this.hoadon,
            this.phieunhan});
            this.danhmuc.Name = "danhmuc";
            this.danhmuc.Size = new System.Drawing.Size(77, 20);
            this.danhmuc.Text = "Danh mục ";
            // 
            // nhomhang
            // 
            this.nhomhang.Name = "nhomhang";
            this.nhomhang.Size = new System.Drawing.Size(180, 22);
            this.nhomhang.Text = "nhóm hàng";
            this.nhomhang.Click += new System.EventHandler(this.nhomhang_Click);
            // 
            // hanghoa
            // 
            this.hanghoa.Name = "hanghoa";
            this.hanghoa.Size = new System.Drawing.Size(180, 22);
            this.hanghoa.Text = "hàng hóa";
            this.hanghoa.Click += new System.EventHandler(this.hanghoa_Click);
            // 
            // hangban
            // 
            this.hangban.Name = "hangban";
            this.hangban.Size = new System.Drawing.Size(180, 22);
            this.hangban.Text = "hàng bán ";
            this.hangban.Click += new System.EventHandler(this.hangban_Click);
            // 
            // hoadon
            // 
            this.hoadon.Name = "hoadon";
            this.hoadon.Size = new System.Drawing.Size(180, 22);
            this.hoadon.Text = "hóa đơn BH";
            this.hoadon.Click += new System.EventHandler(this.hoadon_Click);
            // 
            // phieunhan
            // 
            this.phieunhan.Name = "phieunhan";
            this.phieunhan.Size = new System.Drawing.Size(180, 22);
            this.phieunhan.Text = "phiếu nhận";
            this.phieunhan.Click += new System.EventHandler(this.phieunhan_Click);
            // 
            // baohanh
            // 
            this.baohanh.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thietbibh,
            this.nhatkibh});
            this.baohanh.Name = "baohanh";
            this.baohanh.Size = new System.Drawing.Size(69, 20);
            this.baohanh.Text = "Bảo hành";
            // 
            // thietbibh
            // 
            this.thietbibh.Name = "thietbibh";
            this.thietbibh.Size = new System.Drawing.Size(180, 22);
            this.thietbibh.Text = "thiết bị BH";
            this.thietbibh.Click += new System.EventHandler(this.thietbibh_Click);
            // 
            // nhatkibh
            // 
            this.nhatkibh.Name = "nhatkibh";
            this.nhatkibh.Size = new System.Drawing.Size(180, 22);
            this.nhatkibh.Text = "nhật kí BH";
            this.nhatkibh.Click += new System.EventHandler(this.nhatkibh_Click);
            // 
            // baocao
            // 
            this.baocao.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hangbangiatren300000,
            this.khachhangcodiachihanoi});
            this.baocao.Name = "baocao";
            this.baocao.Size = new System.Drawing.Size(64, 20);
            this.baocao.Text = "Báo cáo ";
            // 
            // hangbangiatren300000
            // 
            this.hangbangiatren300000.Name = "hangbangiatren300000";
            this.hangbangiatren300000.Size = new System.Drawing.Size(180, 22);
            this.hangbangiatren300000.Text = "thông tin hàng bán ";
            this.hangbangiatren300000.Click += new System.EventHandler(this.hangbangiatren300000_Click);
            // 
            // khachhangcodiachihanoi
            // 
            this.khachhangcodiachihanoi.Name = "khachhangcodiachihanoi";
            this.khachhangcodiachihanoi.Size = new System.Drawing.Size(180, 22);
            this.khachhangcodiachihanoi.Text = "thông tin hàng hóa";
            this.khachhangcodiachihanoi.Click += new System.EventHandler(this.khachhangcodiachihanoi_Click);
            // 
            // thoat
            // 
            this.thoat.Name = "thoat";
            this.thoat.Size = new System.Drawing.Size(47, 20);
            this.thoat.Text = "thoát";
            this.thoat.Click += new System.EventHandler(this.thoat_Click);
            // 
            // trangchu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "trangchu";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.quanlibaohanhthietbi_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem danhmuc;
        private System.Windows.Forms.ToolStripMenuItem nhomhang;
        private System.Windows.Forms.ToolStripMenuItem hanghoa;
        private System.Windows.Forms.ToolStripMenuItem phieunhan;
        private System.Windows.Forms.ToolStripMenuItem baohanh;
        private System.Windows.Forms.ToolStripMenuItem thietbibh;
        private System.Windows.Forms.ToolStripMenuItem nhatkibh;
        private System.Windows.Forms.ToolStripMenuItem baocao;
        private System.Windows.Forms.ToolStripMenuItem hangbangiatren300000;
        private System.Windows.Forms.ToolStripMenuItem khachhangcodiachihanoi;
        private System.Windows.Forms.ToolStripMenuItem thoat;
        private System.Windows.Forms.ToolStripMenuItem hangban;
        private System.Windows.Forms.ToolStripMenuItem hoadon;
    }
}