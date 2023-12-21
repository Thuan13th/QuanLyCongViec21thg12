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
    public partial class Form_btnQuanLyNhanVien : Form
    {
        XuLiDuLieu kn = new XuLiDuLieu();

        SqlConnection connection;
        SqlCommand command;
        string str = "";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();


        public Form_btnQuanLyNhanVien()
        {
            InitializeComponent();
            HandleCellContentClickEvent();
        }

        private void Form_btnQuanLyNhanVien_Load(object sender, EventArgs e)
        {
            kn.moKetNoi();
            LoadDuLieu();
        }

        // Load dữ liệu:
        public void LoadDuLieu()
        {
            string sql = "select ID_NhanVien,TenNhanVien,ChucDanh,BoPhan from NhanVien";
            dgv_btn_QLNV.DataSource = kn.taoBang(sql);
        }
        private void HandleCellContentClickEvent()
        {
            dgv_btn_QLNV.CellContentClick += dgv_btn_QLNV_CellContentClick;
        }
        private void dgv_btn_QLNV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int chiso = -1;
            DataTable bang = new DataTable();
            bang = (DataTable)dgv_btn_QLNV.DataSource;
            chiso = dgv_btn_QLNV.SelectedCells[0].RowIndex;
            DataRow hang = bang.Rows[chiso];

            txtIDNhanVien.Text = hang["ID_NhanVien"].ToString();
            txtTenNhanVien.Text = hang["TenNhanVien"].ToString();
            txtChucDanh.Text = hang["ChucDanh"].ToString();
            txtBoPhan.Text = hang["BoPhan"].ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            command=connection.CreateCommand();
            command.CommandText = "insert into NhanVien values = ('"+txtIDNhanVien+"','"+txtTenNhanVien+"','"+txtChucDanh+"','"+txtBoPhan+"')";
            command.ExecuteNonQuery();
            LoadDuLieu();
        }
    }
}
