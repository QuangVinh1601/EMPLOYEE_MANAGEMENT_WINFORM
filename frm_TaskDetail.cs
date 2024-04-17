using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QUANLYCONGVIEC
{
    public partial class frm_TaskDetail : Form
    {
        private int taskID;

        public frm_TaskDetail(int taskID)
        {
            InitializeComponent();
            this.taskID = taskID;
        }

        private void DetailForm_Load(object sender, EventArgs e)
        {
            // Hiển thị thông tin chi tiết của công việc dựa trên ID
            ShowTaskDetail(taskID);
        }

        private void ShowTaskDetail(int taskID)
        {
            try
            {
                string connectionString = "YOUR_CONNECTION_STRING_HERE";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM CongViec WHERE ID = @ID";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@ID", taskID);
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        txtTenCongViec.Text = reader["TenCongViec"].ToString();
                        txtMoTa.Text = reader["MoTa"].ToString();
                        lblNgayTaoValue.Text = reader["NgayTao"].ToString();
                        lblTrangThaiValue.Text = reader["TrangThai"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy công việc với ID = " + taskID);
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
                this.Close();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DetailForm_Load_1(object sender, EventArgs e)
        {

        }

        private void lbTrangThaiValue_Click(object sender, EventArgs e)
        {

        }
    }
}