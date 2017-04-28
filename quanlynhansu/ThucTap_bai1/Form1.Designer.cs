namespace ThucTap_bai1
{
    partial class Form1
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
            this.thốngKêToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thốngKêTheoMứcThuNhậpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thốngKêTheoChuyênMônToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hỗTrợToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.huong_danToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.thong_tinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danh_sachdataGridView1 = new System.Windows.Forms.DataGridView();
            this.ma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaysinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quequan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongiao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioitinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtChucVu = new System.Windows.Forms.TextBox();
            this.txtPhongBan = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtChuyenMon = new System.Windows.Forms.TextBox();
            this.txtTrinhDo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.ho_so_chi_tietgroupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.cboTimKiem = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.mtxtNgaySinh = new System.Windows.Forms.MaskedTextBox();
            this.txtGioiTinh = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtQueQuan = new System.Windows.Forms.TextBox();
            this.txtTonGiao = new System.Windows.Forms.TextBox();
            this.Ảnh = new System.Windows.Forms.GroupBox();
            this.pbAnh = new System.Windows.Forms.PictureBox();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.danh_sachdataGridView1)).BeginInit();
            this.ho_so_chi_tietgroupBox1.SuspendLayout();
            this.Ảnh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAnh)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thốngKêToolStripMenuItem,
            this.hỗTrợToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1021, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // thốngKêToolStripMenuItem
            // 
            this.thốngKêToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thốngKêTheoMứcThuNhậpToolStripMenuItem,
            this.thốngKêTheoChuyênMônToolStripMenuItem});
            this.thốngKêToolStripMenuItem.Name = "thốngKêToolStripMenuItem";
            this.thốngKêToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.thốngKêToolStripMenuItem.Text = "Thống kê";
            // 
            // thốngKêTheoMứcThuNhậpToolStripMenuItem
            // 
            this.thốngKêTheoMứcThuNhậpToolStripMenuItem.Name = "thốngKêTheoMứcThuNhậpToolStripMenuItem";
            this.thốngKêTheoMứcThuNhậpToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.thốngKêTheoMứcThuNhậpToolStripMenuItem.Text = "Thống kê theo mức thu nhập";
            this.thốngKêTheoMứcThuNhậpToolStripMenuItem.Click += new System.EventHandler(this.thốngKêTheoMứcThuNhậpToolStripMenuItem_Click);
            // 
            // thốngKêTheoChuyênMônToolStripMenuItem
            // 
            this.thốngKêTheoChuyênMônToolStripMenuItem.Name = "thốngKêTheoChuyênMônToolStripMenuItem";
            this.thốngKêTheoChuyênMônToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.thốngKêTheoChuyênMônToolStripMenuItem.Text = "Thống kê theo chuyên môn";
            this.thốngKêTheoChuyênMônToolStripMenuItem.Click += new System.EventHandler(this.thốngKêTheoChuyênMônToolStripMenuItem_Click);
            // 
            // hỗTrợToolStripMenuItem
            // 
            this.hỗTrợToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.huong_danToolStripMenuItem,
            this.toolStripSeparator2,
            this.thong_tinToolStripMenuItem});
            this.hỗTrợToolStripMenuItem.Name = "hỗTrợToolStripMenuItem";
            this.hỗTrợToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.hỗTrợToolStripMenuItem.Text = "Hỗ trợ";
            // 
            // huong_danToolStripMenuItem
            // 
            this.huong_danToolStripMenuItem.Name = "huong_danToolStripMenuItem";
            this.huong_danToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.huong_danToolStripMenuItem.Text = "Hướng dẫn";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(131, 6);
            // 
            // thong_tinToolStripMenuItem
            // 
            this.thong_tinToolStripMenuItem.Name = "thong_tinToolStripMenuItem";
            this.thong_tinToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.thong_tinToolStripMenuItem.Text = "Thông tin";
            // 
            // danh_sachdataGridView1
            // 
            this.danh_sachdataGridView1.AllowUserToAddRows = false;
            this.danh_sachdataGridView1.AllowUserToDeleteRows = false;
            this.danh_sachdataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.danh_sachdataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.danh_sachdataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.danh_sachdataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ma,
            this.ten,
            this.ngaysinh,
            this.quequan,
            this.tongiao,
            this.diachi,
            this.gioitinh});
            this.danh_sachdataGridView1.Location = new System.Drawing.Point(12, 311);
            this.danh_sachdataGridView1.Name = "danh_sachdataGridView1";
            this.danh_sachdataGridView1.ReadOnly = true;
            this.danh_sachdataGridView1.Size = new System.Drawing.Size(997, 169);
            this.danh_sachdataGridView1.TabIndex = 1;
            this.danh_sachdataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.danh_sachdataGridView1.SelectionChanged += new System.EventHandler(this.danh_sachdataGridView1_SelectionChanged);
            // 
            // ma
            // 
            this.ma.DataPropertyName = "ma";
            this.ma.HeaderText = "Mã nhân viên";
            this.ma.Name = "ma";
            this.ma.ReadOnly = true;
            // 
            // ten
            // 
            this.ten.DataPropertyName = "ten";
            this.ten.HeaderText = "Họ và tên";
            this.ten.Name = "ten";
            this.ten.ReadOnly = true;
            // 
            // ngaysinh
            // 
            this.ngaysinh.DataPropertyName = "ngaysinh";
            this.ngaysinh.HeaderText = "Ngày sinh";
            this.ngaysinh.Name = "ngaysinh";
            this.ngaysinh.ReadOnly = true;
            // 
            // quequan
            // 
            this.quequan.DataPropertyName = "quequan";
            this.quequan.HeaderText = "Quê quán";
            this.quequan.Name = "quequan";
            this.quequan.ReadOnly = true;
            // 
            // tongiao
            // 
            this.tongiao.DataPropertyName = "tongiao";
            this.tongiao.HeaderText = "Tôn giáo";
            this.tongiao.Name = "tongiao";
            this.tongiao.ReadOnly = true;
            // 
            // diachi
            // 
            this.diachi.DataPropertyName = "diachi";
            this.diachi.HeaderText = "Địa chỉ";
            this.diachi.Name = "diachi";
            this.diachi.ReadOnly = true;
            // 
            // gioitinh
            // 
            this.gioitinh.DataPropertyName = "gioitinh";
            this.gioitinh.HeaderText = "Giới tính";
            this.gioitinh.Name = "gioitinh";
            this.gioitinh.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(190, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ tên";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(286, 10);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.ReadOnly = true;
            this.txtHoTen.Size = new System.Drawing.Size(162, 20);
            this.txtHoTen.TabIndex = 1;
            // 
            // txtChucVu
            // 
            this.txtChucVu.Location = new System.Drawing.Point(286, 52);
            this.txtChucVu.Name = "txtChucVu";
            this.txtChucVu.ReadOnly = true;
            this.txtChucVu.Size = new System.Drawing.Size(162, 20);
            this.txtChucVu.TabIndex = 2;
            // 
            // txtPhongBan
            // 
            this.txtPhongBan.Location = new System.Drawing.Point(286, 92);
            this.txtPhongBan.Name = "txtPhongBan";
            this.txtPhongBan.ReadOnly = true;
            this.txtPhongBan.Size = new System.Drawing.Size(162, 20);
            this.txtPhongBan.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(190, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Chức vụ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(190, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Phòng ban";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(190, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Chuyên môn";
            // 
            // txtChuyenMon
            // 
            this.txtChuyenMon.Location = new System.Drawing.Point(286, 130);
            this.txtChuyenMon.Name = "txtChuyenMon";
            this.txtChuyenMon.ReadOnly = true;
            this.txtChuyenMon.Size = new System.Drawing.Size(162, 20);
            this.txtChuyenMon.TabIndex = 7;
            // 
            // txtTrinhDo
            // 
            this.txtTrinhDo.Location = new System.Drawing.Point(286, 165);
            this.txtTrinhDo.Name = "txtTrinhDo";
            this.txtTrinhDo.ReadOnly = true;
            this.txtTrinhDo.Size = new System.Drawing.Size(162, 20);
            this.txtTrinhDo.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(190, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Trình độ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(529, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Quê quán";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(529, 132);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Địa chỉ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(529, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Ngày sinh";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(529, 94);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Tôn giáo";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(529, 172);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "Giới tính";
            // 
            // ho_so_chi_tietgroupBox1
            // 
            this.ho_so_chi_tietgroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ho_so_chi_tietgroupBox1.AutoSize = true;
            this.ho_so_chi_tietgroupBox1.Controls.Add(this.txtTimKiem);
            this.ho_so_chi_tietgroupBox1.Controls.Add(this.cboTimKiem);
            this.ho_so_chi_tietgroupBox1.Controls.Add(this.label11);
            this.ho_so_chi_tietgroupBox1.Controls.Add(this.mtxtNgaySinh);
            this.ho_so_chi_tietgroupBox1.Controls.Add(this.txtGioiTinh);
            this.ho_so_chi_tietgroupBox1.Controls.Add(this.txtDiaChi);
            this.ho_so_chi_tietgroupBox1.Controls.Add(this.txtQueQuan);
            this.ho_so_chi_tietgroupBox1.Controls.Add(this.txtTonGiao);
            this.ho_so_chi_tietgroupBox1.Controls.Add(this.label10);
            this.ho_so_chi_tietgroupBox1.Controls.Add(this.label9);
            this.ho_so_chi_tietgroupBox1.Controls.Add(this.label8);
            this.ho_so_chi_tietgroupBox1.Controls.Add(this.label7);
            this.ho_so_chi_tietgroupBox1.Controls.Add(this.label6);
            this.ho_so_chi_tietgroupBox1.Controls.Add(this.label5);
            this.ho_so_chi_tietgroupBox1.Controls.Add(this.txtTrinhDo);
            this.ho_so_chi_tietgroupBox1.Controls.Add(this.txtChuyenMon);
            this.ho_so_chi_tietgroupBox1.Controls.Add(this.label4);
            this.ho_so_chi_tietgroupBox1.Controls.Add(this.label3);
            this.ho_so_chi_tietgroupBox1.Controls.Add(this.label2);
            this.ho_so_chi_tietgroupBox1.Controls.Add(this.txtPhongBan);
            this.ho_so_chi_tietgroupBox1.Controls.Add(this.txtChucVu);
            this.ho_so_chi_tietgroupBox1.Controls.Add(this.txtHoTen);
            this.ho_so_chi_tietgroupBox1.Controls.Add(this.label1);
            this.ho_so_chi_tietgroupBox1.Controls.Add(this.Ảnh);
            this.ho_so_chi_tietgroupBox1.Location = new System.Drawing.Point(12, 61);
            this.ho_so_chi_tietgroupBox1.Name = "ho_so_chi_tietgroupBox1";
            this.ho_so_chi_tietgroupBox1.Size = new System.Drawing.Size(997, 244);
            this.ho_so_chi_tietgroupBox1.TabIndex = 2;
            this.ho_so_chi_tietgroupBox1.TabStop = false;
            this.ho_so_chi_tietgroupBox1.Text = "Hồ sơ chi tiết";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(494, 205);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(300, 20);
            this.txtTimKiem.TabIndex = 32;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // cboTimKiem
            // 
            this.cboTimKiem.FormattingEnabled = true;
            this.cboTimKiem.Items.AddRange(new object[] {
            "Tìm theo tên",
            "Tìm theo địa chỉ",
            "Tìm theo chức vụ",
            "Tìm theo phòng ban"});
            this.cboTimKiem.Location = new System.Drawing.Point(287, 204);
            this.cboTimKiem.Name = "cboTimKiem";
            this.cboTimKiem.Size = new System.Drawing.Size(161, 21);
            this.cboTimKiem.TabIndex = 31;
            this.cboTimKiem.Text = "Tìm theo tên";
            this.cboTimKiem.SelectedIndexChanged += new System.EventHandler(this.cboTimKiem_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(190, 204);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 13);
            this.label11.TabIndex = 30;
            this.label11.Text = "Tìm kiếm";
            // 
            // mtxtNgaySinh
            // 
            this.mtxtNgaySinh.Location = new System.Drawing.Point(613, 10);
            this.mtxtNgaySinh.Name = "mtxtNgaySinh";
            this.mtxtNgaySinh.ReadOnly = true;
            this.mtxtNgaySinh.Size = new System.Drawing.Size(181, 20);
            this.mtxtNgaySinh.TabIndex = 29;
            // 
            // txtGioiTinh
            // 
            this.txtGioiTinh.Location = new System.Drawing.Point(613, 165);
            this.txtGioiTinh.Name = "txtGioiTinh";
            this.txtGioiTinh.ReadOnly = true;
            this.txtGioiTinh.Size = new System.Drawing.Size(181, 20);
            this.txtGioiTinh.TabIndex = 26;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(613, 130);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.ReadOnly = true;
            this.txtDiaChi.Size = new System.Drawing.Size(181, 20);
            this.txtDiaChi.TabIndex = 19;
            // 
            // txtQueQuan
            // 
            this.txtQueQuan.Location = new System.Drawing.Point(613, 51);
            this.txtQueQuan.Name = "txtQueQuan";
            this.txtQueQuan.ReadOnly = true;
            this.txtQueQuan.Size = new System.Drawing.Size(181, 20);
            this.txtQueQuan.TabIndex = 18;
            // 
            // txtTonGiao
            // 
            this.txtTonGiao.Location = new System.Drawing.Point(613, 91);
            this.txtTonGiao.Name = "txtTonGiao";
            this.txtTonGiao.ReadOnly = true;
            this.txtTonGiao.Size = new System.Drawing.Size(181, 20);
            this.txtTonGiao.TabIndex = 17;
            // 
            // Ảnh
            // 
            this.Ảnh.Controls.Add(this.pbAnh);
            this.Ảnh.Location = new System.Drawing.Point(6, 19);
            this.Ảnh.Name = "Ảnh";
            this.Ảnh.Size = new System.Drawing.Size(142, 166);
            this.Ảnh.TabIndex = 0;
            this.Ảnh.TabStop = false;
            this.Ảnh.Text = "Ảnh";
            this.Ảnh.UseWaitCursor = true;
            // 
            // pbAnh
            // 
            this.pbAnh.Location = new System.Drawing.Point(6, 14);
            this.pbAnh.Name = "pbAnh";
            this.pbAnh.Size = new System.Drawing.Size(130, 146);
            this.pbAnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAnh.TabIndex = 0;
            this.pbAnh.TabStop = false;
            this.pbAnh.UseWaitCursor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 492);
            this.Controls.Add(this.ho_so_chi_tietgroupBox1);
            this.Controls.Add(this.danh_sachdataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.danh_sachdataGridView1)).EndInit();
            this.ho_so_chi_tietgroupBox1.ResumeLayout(false);
            this.ho_so_chi_tietgroupBox1.PerformLayout();
            this.Ảnh.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbAnh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.DataGridView danh_sachdataGridView1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ToolStripMenuItem hỗTrợToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem huong_danToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thong_tinToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtChucVu;
        private System.Windows.Forms.TextBox txtPhongBan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtChuyenMon;
        private System.Windows.Forms.TextBox txtTrinhDo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox ho_so_chi_tietgroupBox1;
        private System.Windows.Forms.TextBox txtQueQuan;
        private System.Windows.Forms.TextBox txtTonGiao;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn ma;
        private System.Windows.Forms.DataGridViewTextBoxColumn ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaysinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn quequan;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongiao;
        private System.Windows.Forms.DataGridViewTextBoxColumn diachi;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioitinh;
        private System.Windows.Forms.TextBox txtGioiTinh;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.MaskedTextBox mtxtNgaySinh;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.ComboBox cboTimKiem;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox Ảnh;
        private System.Windows.Forms.PictureBox pbAnh;
        private System.Windows.Forms.ToolStripMenuItem thốngKêToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thốngKêTheoMứcThuNhậpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thốngKêTheoChuyênMônToolStripMenuItem;
    }
}

