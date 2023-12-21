using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace QuanLyCongViec
{
    internal class XuLiDuLieu
    {
        private readonly string connectionString = @"Data Source=THUAN\SQLEXPRESS;Initial Catalog=QuanLyCongViec_Short1;Integrated Security=True";
        private SqlConnection cnn;
        public XuLiDuLieu()
        {
            cnn = new SqlConnection(connectionString);
        }
        public void moKetNoi()
        {
            if (cnn.State != ConnectionState.Open)
            {
                cnn.Open();
            }
        }

        public void dongKetNoi()
        {
            if (cnn.State == ConnectionState.Open)
            {
                cnn.Close();
            }
        }

        // Tạo bảng:
        public DataTable taoBang(string sql)
        {
            DataTable dt = new DataTable();
            using (SqlDataAdapter da = new SqlDataAdapter(sql, cnn))
            {
                da.Fill(dt);
            }
            return dt;
        }

        // Lây ID
        public int getID()
        {

            // Replace "YourTableName" with the actual table name and "YourIDColumnName" with the actual ID column name
            string query = "SELECT MAX(ID_CongViec) FROM CongViec";

            int newID = GetNextID(connectionString, query);
            return newID;
        }
        
        // ID tự tăng
        static int GetNextID(string connectionString, string query)
        {
            int nextID = 1; // Default starting ID

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    object result = command.ExecuteScalar();
                    if (result != DBNull.Value && result != null)
                    {
                        nextID = Convert.ToInt32(result) + 1;
                    }
                }
            }

            return nextID;
        }

        // Load Data:
        public void loadData()
        {
            string sql = "select ID_NhanVien,TenNhanVien,ChucDanh,BoPhan from NhanVien";
            taoBang(sql);
        }


        // Thêm nhân viên:
        public void themNV(string TenNhanVien, string ChucDanh, string BoPhan)
        {
            string sql = "INSERT INTO NhanVien (ID_NhanVien, TenNhanVien, ChucDanh, BoPhan) " +
                         "VALUES (@ID_NhanVien, @TenNhanVien, @ChucDanh, @BoPhan)";

            using (SqlCommand scm = new SqlCommand(sql, cnn))
            {
                scm.Parameters.AddWithValue("@ID_NhanVien", getID());
                scm.Parameters.AddWithValue("@TenNhanVien", TenNhanVien);
                scm.Parameters.AddWithValue("@ChucDanh", ChucDanh);
                scm.Parameters.AddWithValue("@BoPhan", BoPhan);

                scm.ExecuteNonQuery();
            }
            clearTextBox(TenNhanVien,ChucDanh,BoPhan);
        }


        public void clearTextBox(string TenNhanVien, string ChucDanh, string BoPhan)
        {
            TenNhanVien = "";
            ChucDanh = "";
            BoPhan = "";

        }
        public void clearTextBox(int ID_NhanVien)
        {
            ID_NhanVien = 0;

        }
        


    }
}
