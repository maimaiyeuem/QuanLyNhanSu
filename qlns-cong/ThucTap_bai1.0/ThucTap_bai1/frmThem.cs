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
    public partial class frmThem : Form
    {
        public frmThem()
        {
            InitializeComponent();
        }

        string imageLocate = "";

        private void frmThem_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyNhanSuDataSet.trinhdo' table. You can move, or remove it, as needed.
            this.trinhdoTableAdapter.Fill(this.quanLyNhanSuDataSet.trinhdo);
            // TODO: This line of code loads data into the 'quanLyNhanSuDataSet.chuyenmon' table. You can move, or remove it, as needed.
            this.chuyenmonTableAdapter.Fill(this.quanLyNhanSuDataSet.chuyenmon);
            // TODO: This line of code loads data into the 'quanLyNhanSuDataSet.chucvu' table. You can move, or remove it, as needed.
            this.chucvuTableAdapter.Fill(this.quanLyNhanSuDataSet.chucvu);
            // TODO: This line of code loads data into the 'quanLyNhanSuDataSet.phongban' table. You can move, or remove it, as needed.
            this.phongbanTableAdapter.Fill(this.quanLyNhanSuDataSet.phongban);
            // TODO: This line of code loads data into the 'quanLiNhanSu_TTDataSet.trinhdo' table. You can move, or remove it, as needed.


        }

        private void btnXacnhan_Click(object sender, EventArgs e)
        {
            if (txtHoten.TextLength > 0 && txtDantoc.TextLength > 0 && txtDiachi.TextLength > 0 && txtQuequan.TextLength > 0 && cboChucvu.Text.Length > 0 && cboChuyenmon.Text.Length > 0 && cboGioitinh.Text.Length > 0 && cboPhongban.Text.Length > 0 && cboTongiao.Text.Length > 0 && cboTrinhdo.Text.Length > 0)
            {
                if ((MessageBox.Show("Bạn muốn thêm nhân viên này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                {

                    //

                    byte[] img = null;

                    if (imageLocate != "")
                    {
                        FileStream fst = new FileStream(imageLocate, FileMode.Open, FileAccess.Read);
                        BinaryReader br = new BinaryReader(fst);
                        img = br.ReadBytes((int)fst.Length);
                    }


                    //



                    Connection.con.Open();
                    if (cboGioitinh.SelectedText == "Nữ")
                    { cboGioitinh.Text = "0"; }
                    else
                    { cboGioitinh.Text = "1"; }
                    string chuoisql = "insert into nhanvien(ten,gioitinh,dantoc,tongiao,quequan,ngaysinh,diachi,anh,phongbanma,chuyenmonma,trinhdoma,chucvuma) select N'{0}',{1},N'{2}',N'{3}',N'{4}',N'{5}',N'{6}',@img,phongban.ma,chuyenmon.ma,trinhdo.ma,chucvu.ma from phongban,chuyenmon,trinhdo,chucvu where (phongban.ten=N'{7}' and chuyenmon.tenchuyenmon=N'{8}' and trinhdo.tentrinhdo=N'{9}' and chucvu.ten=N'{10}')";
                    string them = string.Format(chuoisql, txtHoten.Text, cboGioitinh.Text, txtDantoc.Text, cboTongiao.Text, txtQuequan.Text, dtpNgaysinh.Value.ToString("MM-dd-yyyy"), txtDiachi.Text, cboPhongban.Text, cboChuyenmon.Text, cboTrinhdo.Text, cboChucvu.Text);
                    SqlCommand cmd = new SqlCommand(them, Connection.con);
                    cmd.Parameters.Add(new SqlParameter("@img", img));
                    //
                    //cmd.CommandType = CommandType.Text;
                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Thêm thành công");
                        Connection.con.Close();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        Connection.con.Close();
                    }
                }
            }
            else { MessageBox.Show("Chưa nhập đủ thông tin", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error); }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog opd = new OpenFileDialog();
            opd.Filter = "All files (*.*)|*.*|jpg files(*.jpg)|*.jpg|png files(*.png)|.*png";
            if (opd.ShowDialog() == DialogResult.OK)
            {
                imageLocate = opd.FileName.ToString();
                pbAnh.ImageLocation = imageLocate;
            }
        }
    }
}
