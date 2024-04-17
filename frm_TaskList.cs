using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace QUANLYCONGVIEC
{
    public partial class frm_TaskList : Form
    {
        public string connectionString = $"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"E:\\Lập trình .NET_CS 464\\QUANLYCONGVIEC\\QUANLYCONGVIEC\\QUANLYCONGVIEC.mdf\";Integrated Security=True";
        public frm_TaskList()
        {
            InitializeComponent();
        }

        private DataTable GetDataFromDatabase()
        {
            DataTable dataTable = new DataTable();

            SqlConnection connection = new SqlConnection(connectionString);
            string query = "SELECT * FROM CongViec";
            SqlDataAdapter adapter = new SqlDataAdapter(query,connection);
            adapter.Fill(dataTable);
            return dataTable;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frm_AddEdit addEditForm = new frm_AddEdit();
            addEditForm.ShowDialog();
            dataGridView1.DataSource = GetDataFromDatabase();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int Id = (int) dataGridView1.CurrentRow.Cells["ID"].Value;
            string tenCongViec = dataGridView1.CurrentRow.Cells["TenCongViec"].Value.ToString();
            string moTa = dataGridView1.CurrentRow.Cells["MoTa"].Value.ToString();
            string ngayTao = dataGridView1.CurrentRow.Cells["NgayTao"].Value.ToString();
            string trangThai = dataGridView1.CurrentRow.Cells["TrangThai"].Value.ToString();
            frm_Edit edit = new frm_Edit(Id, tenCongViec, moTa, ngayTao,trangThai);
            edit.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "DELETE FROM CongViec WHERE ID = '" + dataGridView1.CurrentRow.Cells["ID"].Value.ToString() + "'";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.ExecuteNonQuery();
                    connection.Close();
                    this.Close();
                    frm_TaskList frm_TaskList = new frm_TaskList();
                    frm_TaskList.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Đã xảy ra lỗi khi xóa công việc: " + ex.Message);
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedRowID = (int)dataGridView1.Rows[e.RowIndex].Cells["ID"].Value;
            ShowDetailForm(selectedRowID);
        }

        private void ShowDetailForm(int taskID)
        {
            frm_TaskDetail detailForm = new frm_TaskDetail(taskID);
            detailForm.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MainForm_Load_1(object sender, EventArgs e)
        {
            dataGridView1.DataSource = GetDataFromDatabase();

        }
    }
}
