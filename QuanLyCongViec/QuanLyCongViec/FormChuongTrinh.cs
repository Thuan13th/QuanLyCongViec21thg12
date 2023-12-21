using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCongViec
{
    public partial class FormChuongTrinh : Form
    {
        bool isThoat = true;

        XuLiDuLieu kn = new XuLiDuLieu();
        public FormChuongTrinh()
        {
            InitializeComponent();
        }
        public void loadDuLieu()
        {
            string sql = "select ID_CongViec,TenCongViec,NhomCongViec,NgayBatDau,NgayKetThuc,TrangThai from CongViec";
            dgv_FormMain.DataSource = kn.taoBang(sql);
        }
        private void FormChuongTrinh_Load(object sender, EventArgs e)
        {
            kn.moKetNoi();
            loadDuLieu();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isThoat)
            {
                DialogResult r = MessageBox.Show("Bạn có chắc muốn thoát", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                {
                    Application.Exit();
                }

            }
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            isThoat = false;
            this.Close();
            FormDangNhap f = new FormDangNhap();
            f.Show();
        }

        private void FormChuongTrinh_FormClosed(object sender, FormClosedEventArgs e)
        {
            loadDuLieu();
            if (isThoat)
            {
                Application.Exit();

            }
        }

        private void btnQuanLyNhanVien_Click(object sender, EventArgs e)
        {
            Form_btnQuanLyNhanVien f = new Form_btnQuanLyNhanVien();
            f.FormClosed += F_FormClosed;
            f.ShowDialog();
        }

        private void F_FormClosed(object sender, FormClosedEventArgs e)
        {
            loadDuLieu();
        }
    }
}
