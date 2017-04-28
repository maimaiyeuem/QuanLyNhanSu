namespace ThucTap_bai1
{
    partial class frmThem
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
            this.components = new System.ComponentModel.Container();
            this.pbAnh = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtHoten = new System.Windows.Forms.TextBox();
            this.cboGioitinh = new System.Windows.Forms.ComboBox();
            this.cboTongiao = new System.Windows.Forms.ComboBox();
            this.cboPhongban = new System.Windows.Forms.ComboBox();
            this.phongbanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cboChucvu = new System.Windows.Forms.ComboBox();
            this.chucvuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cboChuyenmon = new System.Windows.Forms.ComboBox();
            this.chuyenmonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cboTrinhdo = new System.Windows.Forms.ComboBox();
            this.trinhdoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtpNgaysinh = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtDiachi = new System.Windows.Forms.TextBox();
            this.btnXacnhan = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.txtDantoc = new System.Windows.Forms.TextBox();
            this.txtQuequan = new System.Windows.Forms.TextBox();
            this.btnChonAnh = new System.Windows.Forms.Button();
            this.quanLyNhanSuDataSet = new ThucTap_bai1.QuanLyNhanSuDataSet();
            this.phongbanBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.phongbanTableAdapter = new ThucTap_bai1.QuanLyNhanSuDataSetTableAdapters.phongbanTableAdapter();
            this.chucvuBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.chucvuTableAdapter = new ThucTap_bai1.QuanLyNhanSuDataSetTableAdapters.chucvuTableAdapter();
            this.chuyenmonBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.chuyenmonTableAdapter = new ThucTap_bai1.QuanLyNhanSuDataSetTableAdapters.chuyenmonTableAdapter();
            this.trinhdoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.trinhdoTableAdapter = new ThucTap_bai1.QuanLyNhanSuDataSetTableAdapters.trinhdoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pbAnh)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.phongbanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chucvuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chuyenmonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trinhdoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyNhanSuDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phongbanBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chucvuBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chuyenmonBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trinhdoBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // pbAnh
            // 
            this.pbAnh.Location = new System.Drawing.Point(6, 19);
            this.pbAnh.Name = "pbAnh";
            this.pbAnh.Size = new System.Drawing.Size(160, 148);
            this.pbAnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAnh.TabIndex = 0;
            this.pbAnh.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pbAnh);
            this.groupBox1.Location = new System.Drawing.Point(12, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(172, 173);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ảnh";
            // 
            // txtHoten
            // 
            this.txtHoten.Location = new System.Drawing.Point(306, 35);
            this.txtHoten.Name = "txtHoten";
            this.txtHoten.Size = new System.Drawing.Size(152, 20);
            this.txtHoten.TabIndex = 2;
            // 
            // cboGioitinh
            // 
            this.cboGioitinh.FormattingEnabled = true;
            this.cboGioitinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cboGioitinh.Location = new System.Drawing.Point(306, 71);
            this.cboGioitinh.Name = "cboGioitinh";
            this.cboGioitinh.Size = new System.Drawing.Size(100, 21);
            this.cboGioitinh.TabIndex = 3;
            // 
            // cboTongiao
            // 
            this.cboTongiao.FormattingEnabled = true;
            this.cboTongiao.Items.AddRange(new object[] {
            "Không tôn giáo",
            "Phật giáo",
            "Công giáo",
            "Hào hảo",
            "Cao đài",
            "Tin lành",
            "Khác"});
            this.cboTongiao.Location = new System.Drawing.Point(306, 238);
            this.cboTongiao.Name = "cboTongiao";
            this.cboTongiao.Size = new System.Drawing.Size(100, 21);
            this.cboTongiao.TabIndex = 3;
            // 
            // cboPhongban
            // 
            this.cboPhongban.DataSource = this.phongbanBindingSource1;
            this.cboPhongban.DisplayMember = "ten";
            this.cboPhongban.FormattingEnabled = true;
            this.cboPhongban.Location = new System.Drawing.Point(608, 73);
            this.cboPhongban.Name = "cboPhongban";
            this.cboPhongban.Size = new System.Drawing.Size(170, 21);
            this.cboPhongban.TabIndex = 3;
            this.cboPhongban.ValueMember = "ma";
            // 
            // cboChucvu
            // 
            this.cboChucvu.DataSource = this.chucvuBindingSource1;
            this.cboChucvu.DisplayMember = "ten";
            this.cboChucvu.FormattingEnabled = true;
            this.cboChucvu.Location = new System.Drawing.Point(608, 115);
            this.cboChucvu.Name = "cboChucvu";
            this.cboChucvu.Size = new System.Drawing.Size(170, 21);
            this.cboChucvu.TabIndex = 3;
            this.cboChucvu.ValueMember = "ma";
            // 
            // cboChuyenmon
            // 
            this.cboChuyenmon.DataSource = this.chuyenmonBindingSource1;
            this.cboChuyenmon.DisplayMember = "tenchuyenmon";
            this.cboChuyenmon.FormattingEnabled = true;
            this.cboChuyenmon.Location = new System.Drawing.Point(608, 154);
            this.cboChuyenmon.Name = "cboChuyenmon";
            this.cboChuyenmon.Size = new System.Drawing.Size(170, 21);
            this.cboChuyenmon.TabIndex = 3;
            this.cboChuyenmon.ValueMember = "ma";
            // 
            // cboTrinhdo
            // 
            this.cboTrinhdo.DataSource = this.trinhdoBindingSource1;
            this.cboTrinhdo.DisplayMember = "tentrinhdo";
            this.cboTrinhdo.FormattingEnabled = true;
            this.cboTrinhdo.Location = new System.Drawing.Point(608, 199);
            this.cboTrinhdo.Name = "cboTrinhdo";
            this.cboTrinhdo.Size = new System.Drawing.Size(170, 21);
            this.cboTrinhdo.TabIndex = 3;
            this.cboTrinhdo.ValueMember = "ma";
            // 
            // dtpNgaysinh
            // 
            this.dtpNgaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgaysinh.Location = new System.Drawing.Point(306, 112);
            this.dtpNgaysinh.Name = "dtpNgaysinh";
            this.dtpNgaysinh.Size = new System.Drawing.Size(100, 20);
            this.dtpNgaysinh.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(210, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 23);
            this.label1.TabIndex = 8;
            this.label1.Text = "Họ tên";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(210, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 23);
            this.label2.TabIndex = 8;
            this.label2.Text = "Giới tính";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(210, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 23);
            this.label3.TabIndex = 8;
            this.label3.Text = "Ngày sinh";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(214, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "Địa chỉ";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(214, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 23);
            this.label5.TabIndex = 8;
            this.label5.Text = "Dân tộc";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(210, 237);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 23);
            this.label6.TabIndex = 8;
            this.label6.Text = "Tôn giáo";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.Location = new System.Drawing.Point(494, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 23);
            this.label8.TabIndex = 8;
            this.label8.Text = "Quê quán";
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label9.Location = new System.Drawing.Point(494, 70);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 23);
            this.label9.TabIndex = 8;
            this.label9.Text = "Phòng ban";
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label10.Location = new System.Drawing.Point(494, 110);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 23);
            this.label10.TabIndex = 8;
            this.label10.Text = "Chức vụ";
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label11.Location = new System.Drawing.Point(494, 153);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(97, 23);
            this.label11.TabIndex = 8;
            this.label11.Text = "Chuyên môn";
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label12.Location = new System.Drawing.Point(494, 197);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(97, 23);
            this.label12.TabIndex = 8;
            this.label12.Text = "Trình độ";
            // 
            // txtDiachi
            // 
            this.txtDiachi.Location = new System.Drawing.Point(307, 154);
            this.txtDiachi.Name = "txtDiachi";
            this.txtDiachi.Size = new System.Drawing.Size(151, 20);
            this.txtDiachi.TabIndex = 9;
            // 
            // btnXacnhan
            // 
            this.btnXacnhan.Location = new System.Drawing.Point(344, 287);
            this.btnXacnhan.Name = "btnXacnhan";
            this.btnXacnhan.Size = new System.Drawing.Size(75, 45);
            this.btnXacnhan.TabIndex = 10;
            this.btnXacnhan.Text = "Xác nhận";
            this.btnXacnhan.UseVisualStyleBackColor = true;
            this.btnXacnhan.Click += new System.EventHandler(this.btnXacnhan_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(516, 287);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 45);
            this.btnThoat.TabIndex = 11;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // txtDantoc
            // 
            this.txtDantoc.Location = new System.Drawing.Point(307, 195);
            this.txtDantoc.Name = "txtDantoc";
            this.txtDantoc.Size = new System.Drawing.Size(151, 20);
            this.txtDantoc.TabIndex = 9;
            // 
            // txtQuequan
            // 
            this.txtQuequan.Location = new System.Drawing.Point(608, 36);
            this.txtQuequan.Name = "txtQuequan";
            this.txtQuequan.Size = new System.Drawing.Size(170, 20);
            this.txtQuequan.TabIndex = 9;
            // 
            // btnChonAnh
            // 
            this.btnChonAnh.Location = new System.Drawing.Point(58, 251);
            this.btnChonAnh.Name = "btnChonAnh";
            this.btnChonAnh.Size = new System.Drawing.Size(75, 23);
            this.btnChonAnh.TabIndex = 12;
            this.btnChonAnh.Text = "Chọn ảnh";
            this.btnChonAnh.UseVisualStyleBackColor = true;
            this.btnChonAnh.Click += new System.EventHandler(this.btnChonAnh_Click);
            // 
            // quanLyNhanSuDataSet
            // 
            this.quanLyNhanSuDataSet.DataSetName = "QuanLyNhanSuDataSet";
            this.quanLyNhanSuDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // phongbanBindingSource1
            // 
            this.phongbanBindingSource1.DataMember = "phongban";
            this.phongbanBindingSource1.DataSource = this.quanLyNhanSuDataSet;
            // 
            // phongbanTableAdapter
            // 
            this.phongbanTableAdapter.ClearBeforeFill = true;
            // 
            // chucvuBindingSource1
            // 
            this.chucvuBindingSource1.DataMember = "chucvu";
            this.chucvuBindingSource1.DataSource = this.quanLyNhanSuDataSet;
            // 
            // chucvuTableAdapter
            // 
            this.chucvuTableAdapter.ClearBeforeFill = true;
            // 
            // chuyenmonBindingSource1
            // 
            this.chuyenmonBindingSource1.DataMember = "chuyenmon";
            this.chuyenmonBindingSource1.DataSource = this.quanLyNhanSuDataSet;
            // 
            // chuyenmonTableAdapter
            // 
            this.chuyenmonTableAdapter.ClearBeforeFill = true;
            // 
            // trinhdoBindingSource1
            // 
            this.trinhdoBindingSource1.DataMember = "trinhdo";
            this.trinhdoBindingSource1.DataSource = this.quanLyNhanSuDataSet;
            // 
            // trinhdoTableAdapter
            // 
            this.trinhdoTableAdapter.ClearBeforeFill = true;
            // 
            // frmThem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 394);
            this.Controls.Add(this.btnChonAnh);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXacnhan);
            this.Controls.Add(this.txtDantoc);
            this.Controls.Add(this.txtQuequan);
            this.Controls.Add(this.txtDiachi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpNgaysinh);
            this.Controls.Add(this.cboTrinhdo);
            this.Controls.Add(this.cboTongiao);
            this.Controls.Add(this.cboChuyenmon);
            this.Controls.Add(this.cboChucvu);
            this.Controls.Add(this.cboPhongban);
            this.Controls.Add(this.cboGioitinh);
            this.Controls.Add(this.txtHoten);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmThem";
            this.Text = "frmThem";
            this.Load += new System.EventHandler(this.frmThem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbAnh)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.phongbanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chucvuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chuyenmonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trinhdoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyNhanSuDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phongbanBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chucvuBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chuyenmonBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trinhdoBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbAnh;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtHoten;
        private System.Windows.Forms.ComboBox cboGioitinh;
        private System.Windows.Forms.ComboBox cboTongiao;
        private System.Windows.Forms.ComboBox cboPhongban;
        private System.Windows.Forms.ComboBox cboChucvu;
        private System.Windows.Forms.ComboBox cboChuyenmon;
        private System.Windows.Forms.ComboBox cboTrinhdo;
        private System.Windows.Forms.DateTimePicker dtpNgaysinh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtDiachi;
        private System.Windows.Forms.Button btnXacnhan;
        private System.Windows.Forms.Button btnThoat;
     
        private System.Windows.Forms.BindingSource phongbanBindingSource;
  
        private System.Windows.Forms.BindingSource chucvuBindingSource;
        
        private System.Windows.Forms.BindingSource chuyenmonBindingSource;
   
        private System.Windows.Forms.BindingSource trinhdoBindingSource;
   
        private System.Windows.Forms.TextBox txtDantoc;
        private System.Windows.Forms.TextBox txtQuequan;
        private System.Windows.Forms.Button btnChonAnh;
        private QuanLyNhanSuDataSet quanLyNhanSuDataSet;
        private System.Windows.Forms.BindingSource phongbanBindingSource1;
        private QuanLyNhanSuDataSetTableAdapters.phongbanTableAdapter phongbanTableAdapter;
        private System.Windows.Forms.BindingSource chucvuBindingSource1;
        private QuanLyNhanSuDataSetTableAdapters.chucvuTableAdapter chucvuTableAdapter;
        private System.Windows.Forms.BindingSource chuyenmonBindingSource1;
        private QuanLyNhanSuDataSetTableAdapters.chuyenmonTableAdapter chuyenmonTableAdapter;
        private System.Windows.Forms.BindingSource trinhdoBindingSource1;
        private QuanLyNhanSuDataSetTableAdapters.trinhdoTableAdapter trinhdoTableAdapter;
    }
}