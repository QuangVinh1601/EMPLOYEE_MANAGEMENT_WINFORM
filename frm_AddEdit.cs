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
    public partial class frm_AddEdit : Form
    {
        private int taskID = -1; 

        public frm_AddEdit()
        {
            InitializeComponent();
        }

        public frm_AddEdit(int taskID) : this()
        {
            this.taskID = taskID;
            PopulateFields(taskID);
        }

        private void PopulateFields(int taskID)
        {
           
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string connectionString = $"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"E:\\Lập trình .NET_CS 464\\QUANLYCONGVIEC\\QUANLYCONGVIEC\\QUANLYCONGVIEC.mdf\";Integrated Security=True";
            SqlConnection conn = new SqlConnection(connectionString);
            string sql = "Insert into CongViec values ('" + txtTenCongViec.Text + "', N'" + txtMoTa.Text + "',Convert(datetime,'"+txtNgayTao.Text+"',103),  N'" + txtTrangThai.Text + "')";
            SqlCommand comm = new SqlCommand(sql, conn);
            conn.Open();
            int kq = comm.ExecuteNonQuery();
            conn.Close();
            if (kq >= 1) MessageBox.Show("Thêm công việc thành công");

            else MessageBox.Show("Thêm công việc thất bại");
            
            this.Close();
    
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
