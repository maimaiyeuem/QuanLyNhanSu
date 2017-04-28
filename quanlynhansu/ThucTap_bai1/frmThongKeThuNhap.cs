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
    public partial class frmThongKeThuNhap : Form
    {
        public frmThongKeThuNhap()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(local)\SQLEXPRESS;Initial Catalog=QuanLyNhanSu;Integrated Security=True");

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void hien()
        {
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select nv.ten as [Họ và tên], l.luong as [Lương] from nhanvien nv inner join luong l on l.nhanvienma = nv.ma", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void tongngansach()
        {
            con.Open();
            SqlCommand da = new SqlCommand("select SUM(luong) from luong", con);
            object obj = da.ExecuteScalar();
            textBox1.Text = obj.ToString();
            con.Close();
        }
        
        private void frmThongKeThuNhap_Load(object sender, EventArgs e)
        {
            hien();
            tongngansach();
        }
    }
}
