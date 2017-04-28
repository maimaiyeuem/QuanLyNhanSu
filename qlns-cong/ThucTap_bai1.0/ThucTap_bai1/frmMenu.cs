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

namespace ThucTap_bai1
{
    public partial class frmMenu : Form
    {
        frmThem Themformthem = new frmThem();
        frmSua Themformsua = new frmSua();
        public frmMenu()
        {
            InitializeComponent();


        }

        //SqlConnection con = new SqlConnection(@"Data Source=(local)\SQLEXPRESS;Initial Catalog=QuanLyNhanSu;Integrated Security=True;User ID=sa;Connect Timeout=200");

        public void KetNoiCSDL()
        {
            string sql = "SELECT nv.ma, nv.ten,nv.anh, nv.ngaysinh, nv.quequan, nv.tongiao,nv.diachi, (CASE nv.gioitinh WHEN 'true' THEN N'Nam' WHEN 'false' THEN N'Nữ' END) as gioitinh, phongban.ten , trinhdo.tentrinhdo"
                + " FROM nhanvien nv"
                + " INNER JOIN phongban ON nv.phongbanma = phongban.ma"

                + " INNER JOIN trinhdo ON nv.trinhdoma = trinhdo.ma";

            SqlCommand com = new SqlCommand(sql, Connection.con);
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com);
            // DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            da.Fill(ds);
           
            danh_sachdataGridView1.DataSource = ds.Tables[0].DefaultView;
            danh_sachdataGridView1.Columns["ten1"].HeaderText = "Phòng ban";
            danh_sachdataGridView1.Columns["tentrinhdo"].HeaderText = "Trình độ";
            //dataGridView1.DataSource = ds.Tables[0].DefaultView;
          
        }


        private void loaddata()
        {
            pictureBox1.DataBindings.Clear();
            pictureBox1.DataBindings.Add(new Binding("Image", danh_sachdataGridView1.DataSource, "anh", true));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            KetNoiCSDL();
        }

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

        private void themToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Themformthem.ShowDialog();
        }

        private void toolsmiSua_Click(object sender, EventArgs e)
        {
            Themformsua.ShowDialog();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            KetNoiCSDL();
        }

    }
}
