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

namespace QUANLYCONGVIEC
{
    public partial class frm_Edit : Form
    {
        public int ID { get; set; }
        public string TenCongViec { get; set; }
        public string MoTa {  get; set; }
        public string NgayTao { get; set; }
        public string TrangThai { get; set; }
        public string connectionString = $"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"E:\\Lập trình .NET_CS 464\\QUANLYCONGVIEC\\QUANLYCONGVIEC\\QUANLYCONGVIEC.mdf\";Integrated Security=True";
        public frm_Edit()
        {
            InitializeComponent();
        }
        public frm_Edit ( int id, string tencongviec, string mota, string ngaytao, string trangThai)
        {
            ID = id;
            TenCongViec = tencongviec;
            MoTa = mota;
            NgayTao = ngaytao;
            TrangThai = trangThai;
            InitializeComponent();
        }

        private void frm_Edit_Load(object sender, EventArgs e)
        {
            frm_TaskList frm_TaskList = new frm_TaskList();
            frm_TaskList.Close();
            txtTenCongViec.Text = TenCongViec; 
            txtMoTa.Text = MoTa;
            txtNgayTao.Text = NgayTao;
            txtTrangThai.Text = TrangThai;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string sql = "Update CongViec set TenCongViec = N'" + txtTenCongViec.Text + "',MoTa = N'" + txtMoTa.Text + "',NgayTao = Convert(datetime,'" + txtNgayTao.Text + "',103),TrangThai = N'" + txtTrangThai.Text+ "' where ID ='" + ID.ToString() + "'";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand com = new SqlCommand(sql, connection);
            int kq =  com.ExecuteNonQuery();
            connection.Close();
            if (kq >= 1) MessageBox.Show("Cập nhật công việc thành công");
            else MessageBox.Show("Cập nhật công việc thất bại");
            this.Close();
            frm_TaskList frm_TaskList = new frm_TaskList();
            frm_TaskList.ShowDialog();
            
        }
    }
}
