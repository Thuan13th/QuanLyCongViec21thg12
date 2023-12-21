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
namespace QuanLyCongViec
{
    public partial class FormDangNhap : Form
    {
        private const string connectionString = @"Data Source=THUAN\SQLEXPRESS;Initial Catalog=QuanLyCongViec_Short1;Integrated Security=True";
        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void FormDangNhap_Load(object sender, EventArgs e)
        {

        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string queryDangNhap = "SELECT *  FROM TaiKhoan1 Where TenDangNhap = N'" + txtTaiKhoan.Text + "' and MatKhau = '" + txtMatKhau.Text + "'";
            SqlConnection conn = new SqlConnection(@"Data Source=THUAN\SQLEXPRESS;Initial Catalog=QuanLyCongViec;Integrated Security=True");
            SqlDataAdapter da = new SqlDataAdapter(queryDangNhap, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Đăng nhập thành công", "Thông báo");
                this.Hide();
                FormChuongTrinh f = new FormChuongTrinh();
                f.ShowDialog();
            }
            else
            {
                MessageBox.Show("Vui lòng thử lại", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                txtTaiKhoan.Focus();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Bạn có chắc muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
