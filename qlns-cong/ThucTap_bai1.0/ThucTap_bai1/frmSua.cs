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
    public partial class frmSua : Form
    {

        string imageLocate = "";



        public frmSua()
        {
            InitializeComponent();
        }
        private void LoadDL()
        {
            string stringg = "SELECT nv.ma as 'Mã NV',nv.anh, nv.ten as 'Tên',(CASE nv.gioitinh WHEN 'true' THEN N'Nam' WHEN 'false' THEN N'Nữ' END) as 'Giới tính' ,nv.dantoc as 'Dân tộc',nv.tongiao as 'Tôn giáo', nv.ngaysinh as 'Ngày sinh', nv.quequan as 'Quê quán',nv.diachi as 'Địa chỉ',cm.tenchuyenmon as 'Chuyên môn', pb.ten as 'Phòng ban',cv.ten as 'Chức vụ', td.tentrinhdo as 'Trình độ'"
                + " FROM nhanvien nv"
                + " INNER JOIN phongban pb ON nv.phongbanma = pb.ma"

                + " INNER JOIN trinhdo td ON nv.trinhdoma = td.ma"
                + " INNER JOIN chuyenmon cm ON nv.chuyenmonma=cm.ma"
                + " INNER JOIN chucvu cv ON nv.chucvuma=cv.ma";
            Connection.con.Open();
            SqlCommand cmd = new SqlCommand(stringg, Connection.con);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataTable danhsachnv = new DataTable();
            adp.Fill(danhsachnv);
            adp.Dispose();
            dgvDanhsach.DataSource = danhsachnv;
            Connection.con.Close();
        }

        private void frmSua_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyNhanSuDataSet.trinhdo' table. You can move, or remove it, as needed.
            this.trinhdoTableAdapter.Fill(this.quanLyNhanSuDataSet.trinhdo);
            // TODO: This line of code loads data into the 'quanLyNhanSuDataSet.chuyenmon' table. You can move, or remove it, as needed.
            this.chuyenmonTableAdapter.Fill(this.quanLyNhanSuDataSet.chuyenmon);
            // TODO: This line of code loads data into the 'quanLyNhanSuDataSet.chucvu' table. You can move, or remove it, as needed.
            this.chucvuTableAdapter.Fill(this.quanLyNhanSuDataSet.chucvu);
            // TODO: This line of code loads data into the 'quanLyNhanSuDataSet.phongban' table. You can move, or remove it, as needed.
            this.phongbanTableAdapter.Fill(this.quanLyNhanSuDataSet.phongban);

            LoadDL();
            // TODO: This line of code loads data into the 'quanLiNhanSu_TTDataSet.trinhdo' table. You can move, or remove it, as needed.
           // this.trinhdoTableAdapter.Fill(this.quanLiNhanSu_TTDataSet.trinhdo);
            // TODO: This line of code loads data into the 'quanLiNhanSu_TTDataSet.chuyenmon' table. You can move, or remove it, as needed.
          //  this.chuyenmonTableAdapter.Fill(this.quanLiNhanSu_TTDataSet.chuyenmon);
            // TODO: This line of code loads data into the 'quanLiNhanSu_TTDataSet.chucvu' table. You can move, or remove it, as needed.
           // this.chucvuTableAdapter.Fill(this.quanLiNhanSu_TTDataSet.chucvu);
            // TODO: This line of code loads data into the 'quanLiNhanSu_TTDataSet.phongban' table. You can move, or remove it, as needed.
           // this.phongbanTableAdapter.Fill(this.quanLiNhanSu_TTDataSet.phongban);
            // TODO: This line of code loads data into the 'quanLiNhanSu_TTDataSet.luong' table. You can move, or remove it, as needed.
           // this.luongTableAdapter.Fill(this.quanLiNhanSu_TTDataSet.luong);
            // TODO: This line of code loads data into the 'quanLiNhanSu_TTDataSet.nhanvien' table. You can move, or remove it, as needed.
           // this.nhanvienTableAdapter.Fill(this.quanLiNhanSu_TTDataSet.nhanvien);
            //pbAnh.DataBindings.Add(new Binding("Image", dgvDanhsach.DataSource, "anh", true));

        }


        private void dgvDanhsach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtHoten.Text = dgvDanhsach.CurrentRow.Cells[2].Value.ToString();
            cboGioitinh.Text = dgvDanhsach.CurrentRow.Cells[3].Value.ToString();
            dtpNgaysinh.Text = dgvDanhsach.CurrentRow.Cells[6].Value.ToString();
            txtDantoc.Text = dgvDanhsach.CurrentRow.Cells[4].Value.ToString();
            txtDiachi.Text = dgvDanhsach.CurrentRow.Cells[8].Value.ToString();
            txtQuequan.Text = dgvDanhsach.CurrentRow.Cells[7].Value.ToString();
            cboChucvu.Text = dgvDanhsach.CurrentRow.Cells[11].Value.ToString();
            cboChuyenmon.Text = dgvDanhsach.CurrentRow.Cells[9].Value.ToString();
            cboPhongban.Text = dgvDanhsach.CurrentRow.Cells[10].Value.ToString();
            cboTrinhdo.Text = dgvDanhsach.CurrentRow.Cells[12].Value.ToString();
            cboTongiao.Text = dgvDanhsach.CurrentRow.Cells[5].Value.ToString();
            txtMa.Text = dgvDanhsach.CurrentRow.Cells[0].Value.ToString();


            //------------------------//
            pbAnh.DataBindings.Clear();
            if (dgvDanhsach.CurrentRow.Cells[1] != null)
                pbAnh.DataBindings.Add(new Binding("Image", dgvDanhsach.DataSource, "anh", true));
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //private void btnXoa_Click(object sender, EventArgs e)
        //{
        //    if (MessageBox.Show("Bạn muốn xóa thông tin?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
        //    {
        //        Connection.con.Open();
        //        string sua = string.Format("delete from nhanvien where ma={0}", txtMa.Text);
        //        SqlCommand cmd = new SqlCommand(sua, Connection.con);
        //        cmd.CommandType = CommandType.Text;
        //        try
        //        {
        //            cmd.ExecuteNonQuery();
        //            MessageBox.Show("Xóa thành công");
        //            Connection.con.Close();
        //            LoadDL();
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show(ex.Message);
        //            Connection.con.Close();
        //        }
        //    }
        //}

        private void cboGioitinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboGioitinh.SelectedText == "Nữ")
            { cboGioitinh.ValueMember = "0"; }
            else
            { cboGioitinh.ValueMember = "1"; }
        }


        

        private void btnAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog opd = new OpenFileDialog();
            opd.Filter = "All files (*.*)|*.*|jpg files(*.jpg)|*.jpg|png files(*.png)|.*png";
            if (opd.ShowDialog() == DialogResult.OK)
            {
                imageLocate = opd.FileName.ToString();
                pbAnh.ImageLocation = imageLocate;
            }

        }

        private void btnSua_Click_1(object sender, EventArgs e)
        {

            if (MessageBox.Show("Bạn muốn sửa thông tin?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {


                byte[] img = null;

                FileStream fst = new FileStream(imageLocate, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fst);
                img = br.ReadBytes((int)fst.Length);


                Connection.con.Open();
                string sua = string.Format("update nhanvien set anh = @img, ten=N'{0}',dantoc=N'{1}', gioitinh=N'{2}' ,tongiao=N'{3}',quequan=N'{4}',ngaysinh=N'{5}',diachi=N'{6}',chuyenmonma=(select ma from chuyenmon where chuyenmon.tenchuyenmon=N'{7}'),phongbanma=(select ma from phongban where phongban.ten=N'{8}'),chucvuma=(select ma from chucvu where chucvu.ten=N'{9}'),trinhdoma=(select ma from trinhdo where trinhdo.tentrinhdo=N'{10}') where ma={11}", txtHoten.Text, txtDantoc.Text, cboGioitinh.ValueMember, cboTongiao.Text, txtQuequan.Text, dtpNgaysinh.Value.ToString("MM-dd-yyyy"), txtDiachi.Text, cboChuyenmon.Text, cboPhongban.Text, cboChucvu.Text, cboTrinhdo.Text, txtMa.Text);
                SqlCommand cmd = new SqlCommand(sua, Connection.con);
                cmd.Parameters.Add(new SqlParameter("@img", img));

                cmd.CommandType = CommandType.Text;
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Sửa thành công");
                    Connection.con.Close();
                    LoadDL();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    Connection.con.Close();
                }
            }


        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn xóa thông tin?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Connection.con.Open();
                string sua = string.Format("delete from nhanvien where ma={0}", txtMa.Text);
                SqlCommand cmd = new SqlCommand(sua, Connection.con);
                cmd.CommandType = CommandType.Text;
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Xóa thành công");
                    Connection.con.Close();
                    LoadDL();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    Connection.con.Close();
                }
            }
        }

        private void grpChitiet_Enter(object sender, EventArgs e)
        {

        }
    }
}
