using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThucTap_bai1
{
    static class Connection
    {
        static string CoString = @"Data Source=(local)\SQLEXPRESS;Initial Catalog=QuanLyNhanSu;Integrated Security=True;User ID=sa;Connect Timeout=200";
        public static SqlConnection con = new SqlConnection(CoString);
    }
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMenu());
        }
    }
}
