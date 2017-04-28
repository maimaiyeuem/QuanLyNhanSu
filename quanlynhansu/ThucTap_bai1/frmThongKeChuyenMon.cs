using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThucTap_bai1
{
    public partial class frmThongKeChuyenMon : Form
    {
        public frmThongKeChuyenMon()
        {
            InitializeComponent();
            con = new SqlConnection(@"Data Source=(local)\SQLEXPRESS;Initial Catalog=QuanLyNhanSu;Integrated Security=True");
            dataGridView1.DataSource = null;
        }

        SqlConnection con;

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void hien(string sql)
        {
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void Thongke(string tenluachon, int ma)
        {
            string sql;
            sql = "select nv.ten as [Họ tên], nv.dantoc as [Dân tộc], nv.tongiao as [Tôn giáo],"
                    + " nv.quequan as [Quê quán], nv.ngaysinh as [Ngày sinh], nv.diachi as [Địa chỉ]"
                    + " from nhanvien nv"
                    + " inner join " + tenluachon + " on " + tenluachon + ".ma = nv." + tenluachon + "ma"
                    + " where " + tenluachon + ".ma = " + ma;
            hien(sql);
        }

        private void cboThongke_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboPhongban.Enabled = false;
            cboChuyenmon.Enabled = false;
            cboChucvu.Enabled = false;
            cboTrinhdo.Enabled = false;
            dataGridView1.DataSource = null;

            switch (cboThongke.Text)
            {
                case "Phòng ban":
                    cboPhongban.Enabled = true;
                    break;
                case "Chuyên môn":
                    cboChuyenmon.Enabled = true;
                    break;
                case "Chức vụ":
                    cboChucvu.Enabled = true;
                    break;
                case "Trình độ":
                    cboTrinhdo.Enabled = true;
                    break;
            }
        }

        private void frmThongKeChuyenMon_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyNhanSuDataSet.phongban' table. You can move, or remove it, as needed.
            this.phongbanTableAdapter1.Fill(this.quanLyNhanSuDataSet.phongban);
            // TODO: This line of code loads data into the 'quanLyNhanSuDataSet.chucvu' table. You can move, or remove it, as needed.
            this.chucvuTableAdapter1.Fill(this.quanLyNhanSuDataSet.chucvu);
            // TODO: This line of code loads data into the 'quanLyNhanSuDataSet.trinhdo' table. You can move, or remove it, as needed.
            this.trinhdoTableAdapter1.Fill(this.quanLyNhanSuDataSet.trinhdo);
            // TODO: This line of code loads data into the 'quanLyNhanSuDataSet.chuyenmon' table. You can move, or remove it, as needed.
            this.chuyenmonTableAdapter1.Fill(this.quanLyNhanSuDataSet.chuyenmon);
            // TODO: This line of code loads data into the 'QuanLyNhanSu.chucvu' table. You can move, or remove it, as needed.
           // this.phongbanTableAdapter1.Fill(this.quanLyNhanSuDataSet.phongban);


        }

        private void cboPhongban_SelectedIndexChanged(object sender, EventArgs e)
        {
            Thongke("phongban", cboPhongban.SelectedIndex + 1);
        }

        private void cboChuyenmon_SelectedIndexChanged(object sender, EventArgs e)
        {
            Thongke("chuyenmon", cboChuyenmon.SelectedIndex + 1);
        }

        private void cboTrinhdo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Thongke("trinhdo", cboTrinhdo.SelectedIndex + 1);
        }

        private void cboChucvu_SelectedIndexChanged(object sender, EventArgs e)
        {
            Thongke("chucvu", cboChucvu.SelectedIndex + 1);
        }
    }
}
