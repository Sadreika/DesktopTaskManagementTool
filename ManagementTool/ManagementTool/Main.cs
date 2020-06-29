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

namespace ManagementTool
{
    public partial class ManagementToolDesktop : Form
    {

        public ManagementToolDesktop()
        {
            InitializeComponent();
            fillingTable();
        }
        public string connectionString = @"Data Source=(LocalDb)\MSSQLLocalDB;Initial Catalog=ManagementToolDatabase;Integrated Security=True";
        public string columnId = "";
        public void setIdOfColumn(string id)
        {
            columnId = id;
        }
        public void fillingTable()
        {
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlDataAdapter sqlData = new SqlDataAdapter("SELECT taskId, taskName FROM [ManagementToolDatabase].[dbo].[OpenTasks]", con);
            DataTable data = new DataTable();
            sqlData.Fill(data);
            openDataGridView.DataSource = data;

            SqlDataAdapter sqlDataForSecondGrid = new SqlDataAdapter("SELECT  taskId, taskName FROM [ManagementToolDatabase].[dbo].[InProgressTasks]", con);
            DataTable dataForSecondGrid = new DataTable();
            sqlDataForSecondGrid.Fill(dataForSecondGrid);
            inProgressDataGridView.DataSource = dataForSecondGrid;

            SqlDataAdapter sqlDataForThirdGrid = new SqlDataAdapter("SELECT  taskId, taskName FROM [ManagementToolDatabase].[dbo].[ClosedTasks]", con);
            DataTable dataForThirdGrid = new DataTable();
            sqlDataForThirdGrid.Fill(dataForThirdGrid);
            closedDataGridView.DataSource = dataForThirdGrid;

            con.Close();

        }
        private void addTaskButton_Click(object sender, EventArgs e)
        {
            TaskCreateForm taskCreation = new TaskCreateForm();
            taskCreation.Show();
        }

        private void openDataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.openDataGridView.Rows[e.RowIndex];
                try
                {
                    var id = row.Cells["openTaskId"].Value.ToString();
                    setIdOfColumn(id);

                }
                catch (Exception)
                {

                }
            }
        }

        private void inProgressDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.inProgressDataGridView.Rows[e.RowIndex];
                try
                {
                    var id = row.Cells["taskInProgressId"].Value.ToString();
                    setIdOfColumn(id);

                }
                catch (Exception)
                {

                }
            }
        }

        private void closedDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.closedDataGridView.Rows[e.RowIndex];
                try
                {
                    var id = row.Cells["ClosedTasksId"].Value.ToString();
                    setIdOfColumn(id);

                }
                catch (Exception)
                {

                }
            }
        }

        private void movingToTasksInProgressbutton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM [ManagementToolDatabase].[dbo].[OpenTasks] WHERE taskId = @id", con);
                cmd.Parameters.AddWithValue("@id", columnId);
                SqlDataReader dataReader = cmd.ExecuteReader();
                string taskName = "";
                string taskDescription = "";
                string status = "";
                string recurring = "";
                string timeSpentOnTask = "";
                if (dataReader.Read())
                {
                    taskName = (dataReader["taskName"].ToString());
                    taskDescription = (dataReader["taskDescription"].ToString());
                    status = (dataReader["status"].ToString());
                    recurring = (dataReader["recurring"].ToString());
                    timeSpentOnTask = (dataReader["timeSpentOnTask"].ToString());
                }
                addingDataToProgressTable(columnId, taskName, taskDescription, status, recurring, timeSpentOnTask);

            }
            catch (Exception)
            {
                MessageBox.Show("Cannot transfer data");
            }
            con.Close();
        }

        public void addingDataToProgressTable(string columnId, string taskName, string taskDescription, string status, string recurring, string timeSpentOnTask)
        {
            SqlConnection con = new SqlConnection(connectionString);
            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Connection = con;
            con.Open();
            try
            {
                cmd.Parameters.AddWithValue("@taskId", (Int16.Parse(columnId)).ToString());
                cmd.Parameters.AddWithValue("@taskName", taskName);
                cmd.Parameters.AddWithValue("@taskDescription", taskDescription);
                cmd.Parameters.AddWithValue("@status", status);
                cmd.Parameters.AddWithValue("@recurring", recurring);
                cmd.Parameters.AddWithValue("@timeSpentOnTask", timeSpentOnTask);

                cmd.CommandText = "INSERT [ManagementToolDatabase].[dbo].[InProgressTasks] (taskId, taskName, taskDescription, status, recurring, timeSpentOnTask)" +
                    " VALUES (@taskId, @taskName, @taskDescription, @status, @recurring, @timeSpentOnTask)";
                cmd.ExecuteNonQuery();
                fillingTable();
            } catch(Exception)
            {
                MessageBox.Show("error");
            }
            con.Close();
        }

        private void movingToOpenTasksButton_Click(object sender, EventArgs e)
        {

        }

        private void movingToClosedTaskButton_Click(object sender, EventArgs e)
        {

        }

        private void movingFromClosedToTasksInPorgressButton_Click(object sender, EventArgs e)
        {

        }

        private void openDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            fillingTable();
        }

        private void inProgressDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            fillingTable();
        }

        private void closedDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            fillingTable();
        }

        private void ManagementToolDesktop_Activated(object sender, EventArgs e)
        {
            fillingTable();
        }
    }
}
