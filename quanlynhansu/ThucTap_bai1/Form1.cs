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
using System.IO;

namespace ThucTap_bai1
{
    public partial class Form1 : Form
    {


        public Form1()
        {

            InitializeComponent();
            _message_ten = "";

        }

        public string _message_ten;
        frmThongKeThuNhap tktn = new frmThongKeThuNhap();
        frmThongKeChuyenMon tkcm = new frmThongKeChuyenMon();


        SqlConnection con = new SqlConnection(@"Data Source=(local)\SQLEXPRESS;Initial Catalog=QuanLyNhanSu;Integrated Security=True");
        DataSet ds = new DataSet();




        public void KetNoiCSDL()
        {

            string sql = " SELECT nv.ma, nv.ten, nv.ngaysinh, nv.quequan, nv.tongiao,nv.diachi, (CASE nv.gioitinh WHEN 'true' THEN N'Nam' WHEN 'false' THEN N'Nữ' END) as gioitinh , phongban.ten , trinhdo.tentrinhdo, chuyenmon.tenchuyenmon, chucvu.ten , nv.anh"
                           + " FROM nhanvien nv"
                           + " INNER JOIN phongban  ON nv.phongbanma = phongban.ma"
                           + " INNER JOIN trinhdo   ON nv.trinhdoma = trinhdo.ma"
                           + " INNER JOIN chuyenmon ON nv.chuyenmonma = chuyenmon.ma"
                           + " INNER JOIN  chucvu   ON nv.chucvuma = chucvu.ma";



            con.Open();
            {
                SqlCommand com = new SqlCommand(sql, con);
                com.CommandType = CommandType.Text;
                SqlDataAdapter da = new SqlDataAdapter(com);
                da.Fill(ds);
            }
            con.Close();

            danh_sachdataGridView1.DataSource = ds.Tables[0].DefaultView;
            danh_sachdataGridView1.Columns["ten1"].HeaderText = "Phòng ban";
            danh_sachdataGridView1.Columns["tentrinhdo"].HeaderText = "Trình độ";
            danh_sachdataGridView1.Columns["tenchuyenmon"].HeaderText = "Chuyên môn";
            danh_sachdataGridView1.Columns["ten2"].HeaderText = "Chức vụ";
            danh_sachdataGridView1.Columns["anh"].Visible = false;
            danh_sachdataGridView1.Columns["ma"].Visible = false;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            KetNoiCSDL();
            LoadData();
        }


        #region Lo_tay_nen_no_ra_may_cai_nay

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void contentsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void xóaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void danh_sachdataGridView1_SelectionChanged(object sender, EventArgs e) // chon tat cac o
        {
            try
            {
                danh_sachdataGridView1.CurrentRow.Selected = true;
            }
            catch
            { }
        }

        #endregion

        private void LoadData() //hien hti du lieu len cac o textbox
        {

            //xoa trang cac o textbox
            txtHoTen.DataBindings.Clear();
            txtChucVu.DataBindings.Clear();
            txtChuyenMon.DataBindings.Clear();
            txtDiaChi.DataBindings.Clear();
            txtPhongBan.DataBindings.Clear();
            txtPhongBan.DataBindings.Clear();
            txtQueQuan.DataBindings.Clear();
            txtTonGiao.DataBindings.Clear();
            txtTrinhDo.DataBindings.Clear();
            txtGioiTinh.DataBindings.Clear();
            mtxtNgaySinh.DataBindings.Clear();
            pbAnh.DataBindings.Clear();

            //hine thi du lieu len
            txtDiaChi.DataBindings.Add("Text", danh_sachdataGridView1.DataSource, "diachi");
            txtHoTen.DataBindings.Add("Text", danh_sachdataGridView1.DataSource, "ten");
            txtPhongBan.DataBindings.Add("Text", danh_sachdataGridView1.DataSource, "ten1");
            txtQueQuan.DataBindings.Add("Text", danh_sachdataGridView1.DataSource, "quequan");
            txtTonGiao.DataBindings.Add("Text", danh_sachdataGridView1.DataSource, "tongiao");
            txtTrinhDo.DataBindings.Add("Text", danh_sachdataGridView1.DataSource, "tentrinhdo");

            txtChuyenMon.DataBindings.Add("Text", danh_sachdataGridView1.DataSource, "tenchuyenmon");
            txtChucVu.DataBindings.Add("Text", danh_sachdataGridView1.DataSource, "ten2");
            txtGioiTinh.DataBindings.Add("Text", danh_sachdataGridView1.DataSource, "gioitinh");

            //maskedtextbox
            mtxtNgaySinh.Mask = "00/00/0000";
            mtxtNgaySinh.DataBindings.Add("Text", danh_sachdataGridView1.DataSource, "ngaysinh");

            //picturebox
            pbAnh.DataBindings.Add(new Binding("Image", danh_sachdataGridView1.DataSource, "anh", true));

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }





        private void tim_kiem_tenToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cboTimKiem_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cboTimKiem.Text == "Tìm theo tên")
            {
                SqlDataAdapter sda = new SqlDataAdapter("SELECT nv.ma, nv.ten, nv.ngaysinh, nv.quequan, nv.tongiao,nv.diachi, (CASE nv.gioitinh WHEN 'true' THEN N'Nam' WHEN 'false' THEN N'Nữ' END) as gioitinh , phongban.ten , trinhdo.tentrinhdo, chuyenmon.tenchuyenmon, chucvu.ten , nv.anh FROM nhanvien nv INNER JOIN phongban  ON nv.phongbanma = phongban.ma INNER JOIN trinhdo   ON nv.trinhdoma = trinhdo.ma INNER JOIN chuyenmon ON nv.chuyenmonma = chuyenmon.ma INNER JOIN  chucvu   ON nv.chucvuma = chucvu.ma WHERE nv.ten LIKE N'" + txtTimKiem.Text + "%'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                danh_sachdataGridView1.DataSource = dt;
                LoadData();

            }
            else if (cboTimKiem.Text == "Tìm theo địa chỉ")
            {
                SqlDataAdapter sda = new SqlDataAdapter("SELECT nv.ma, nv.ten, nv.ngaysinh, nv.quequan, nv.tongiao,nv.diachi, (CASE nv.gioitinh WHEN 'true' THEN N'Nam' WHEN 'false' THEN N'Nữ' END) as gioitinh , phongban.ten , trinhdo.tentrinhdo, chuyenmon.tenchuyenmon, chucvu.ten , nv.anh FROM nhanvien nv INNER JOIN phongban  ON nv.phongbanma = phongban.ma INNER JOIN trinhdo   ON nv.trinhdoma = trinhdo.ma INNER JOIN chuyenmon ON nv.chuyenmonma = chuyenmon.ma INNER JOIN  chucvu   ON nv.chucvuma = chucvu.ma WHERE nv.diachi LIKE N'" + txtTimKiem.Text + "%'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                danh_sachdataGridView1.DataSource = dt;

                LoadData();
            }
            else if (cboTimKiem.Text == "Tìm theo phòng ban")
            {
                SqlDataAdapter sda = new SqlDataAdapter("SELECT nv.ma, nv.ten, nv.ngaysinh, nv.quequan, nv.tongiao,nv.diachi, (CASE nv.gioitinh WHEN 'true' THEN N'Nam' WHEN 'false' THEN N'Nữ' END) as gioitinh , phongban.ten , trinhdo.tentrinhdo, chuyenmon.tenchuyenmon, chucvu.ten , nv.anh FROM nhanvien nv INNER JOIN phongban  ON nv.phongbanma = phongban.ma INNER JOIN trinhdo   ON nv.trinhdoma = trinhdo.ma INNER JOIN chuyenmon ON nv.chuyenmonma = chuyenmon.ma INNER JOIN  chucvu   ON nv.chucvuma = chucvu.ma WHERE phongban.ten LIKE N'" + txtTimKiem.Text + "%'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                danh_sachdataGridView1.DataSource = dt;
                LoadData();

            }

            else if (cboTimKiem.Text == "Tìm theo chức vụ")
            {
                SqlDataAdapter sda = new SqlDataAdapter("SELECT nv.ma, nv.ten, nv.ngaysinh, nv.quequan, nv.tongiao,nv.diachi, (CASE nv.gioitinh WHEN 'true' THEN N'Nam' WHEN 'false' THEN N'Nữ' END) as gioitinh , phongban.ten , trinhdo.tentrinhdo, chuyenmon.tenchuyenmon, chucvu.ten , nv.anh FROM nhanvien nv INNER JOIN phongban  ON nv.phongbanma = phongban.ma INNER JOIN trinhdo   ON nv.trinhdoma = trinhdo.ma INNER JOIN chuyenmon ON nv.chuyenmonma = chuyenmon.ma INNER JOIN  chucvu   ON nv.chucvuma = chucvu.ma WHERE chucvu.ten LIKE N'" + txtTimKiem.Text + "%'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                danh_sachdataGridView1.DataSource = dt;
                LoadData();

            }

        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (cboTimKiem.Text == "Tìm theo tên")
            {
                SqlDataAdapter sda = new SqlDataAdapter("SELECT nv.ma, nv.ten, nv.ngaysinh, nv.quequan, nv.tongiao,nv.diachi, (CASE nv.gioitinh WHEN 'true' THEN N'Nam' WHEN 'false' THEN N'Nữ' END) as gioitinh , phongban.ten , trinhdo.tentrinhdo, chuyenmon.tenchuyenmon, chucvu.ten , nv.anh FROM nhanvien nv INNER JOIN phongban  ON nv.phongbanma = phongban.ma INNER JOIN trinhdo   ON nv.trinhdoma = trinhdo.ma INNER JOIN chuyenmon ON nv.chuyenmonma = chuyenmon.ma INNER JOIN  chucvu   ON nv.chucvuma = chucvu.ma WHERE nv.ten LIKE N'" + txtTimKiem.Text + "%'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                danh_sachdataGridView1.DataSource = dt;

                LoadData();
            }
            else if (cboTimKiem.Text == "Tìm theo địa chỉ")
            {
                SqlDataAdapter sda = new SqlDataAdapter("SELECT nv.ma, nv.ten, nv.ngaysinh, nv.quequan, nv.tongiao,nv.diachi, (CASE nv.gioitinh WHEN 'true' THEN N'Nam' WHEN 'false' THEN N'Nữ' END) as gioitinh , phongban.ten , trinhdo.tentrinhdo, chuyenmon.tenchuyenmon, chucvu.ten , nv.anh FROM nhanvien nv INNER JOIN phongban  ON nv.phongbanma = phongban.ma INNER JOIN trinhdo   ON nv.trinhdoma = trinhdo.ma INNER JOIN chuyenmon ON nv.chuyenmonma = chuyenmon.ma INNER JOIN  chucvu   ON nv.chucvuma = chucvu.ma WHERE nv.diachi LIKE N'" + txtTimKiem.Text + "%'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                danh_sachdataGridView1.DataSource = dt;
                LoadData();

            }
            else if (cboTimKiem.Text == "Tìm theo phòng ban")
            {
                SqlDataAdapter sda = new SqlDataAdapter("SELECT nv.ma, nv.ten, nv.ngaysinh, nv.quequan, nv.tongiao,nv.diachi, (CASE nv.gioitinh WHEN 'true' THEN N'Nam' WHEN 'false' THEN N'Nữ' END) as gioitinh , phongban.ten , trinhdo.tentrinhdo, chuyenmon.tenchuyenmon, chucvu.ten , nv.anh FROM nhanvien nv INNER JOIN phongban  ON nv.phongbanma = phongban.ma INNER JOIN trinhdo   ON nv.trinhdoma = trinhdo.ma INNER JOIN chuyenmon ON nv.chuyenmonma = chuyenmon.ma INNER JOIN  chucvu   ON nv.chucvuma = chucvu.ma WHERE phongban.ten LIKE N'" + txtTimKiem.Text + "%'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                danh_sachdataGridView1.DataSource = dt;
                LoadData();

            }

            else if (cboTimKiem.Text == "Tìm theo chức vụ")
            {
                SqlDataAdapter sda = new SqlDataAdapter("SELECT nv.ma, nv.ten, nv.ngaysinh, nv.quequan, nv.tongiao,nv.diachi, (CASE nv.gioitinh WHEN 'true' THEN N'Nam' WHEN 'false' THEN N'Nữ' END) as gioitinh , phongban.ten , trinhdo.tentrinhdo, chuyenmon.tenchuyenmon, chucvu.ten , nv.anh FROM nhanvien nv INNER JOIN phongban  ON nv.phongbanma = phongban.ma INNER JOIN trinhdo   ON nv.trinhdoma = trinhdo.ma INNER JOIN chuyenmon ON nv.chuyenmonma = chuyenmon.ma INNER JOIN  chucvu   ON nv.chucvuma = chucvu.ma WHERE chucvu.ten LIKE N'" + txtTimKiem.Text + "%'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                danh_sachdataGridView1.DataSource = dt;
                LoadData();

            }
        }

        private void thốngKêTheoMứcThuNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tktn.ShowDialog();
        }

        private void thốngKêTheoChuyênMônToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tkcm.ShowDialog();
        }
    }
}
