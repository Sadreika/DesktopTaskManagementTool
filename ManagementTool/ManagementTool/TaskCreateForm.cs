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
    public partial class TaskCreateForm : Form 
    {
        public TaskCreateForm()
        {
            InitializeComponent();
        }
        public string connectionString = @"Data Source=(LocalDb)\MSSQLLocalDB;Initial Catalog=ManagementToolDatabase;Integrated Security=True";
        private void createButton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionString);
            try
            {
                bool taskNameCorrectLenght = true;
                System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Connection = con;
                string id = searchingForMaxId();
                string taskName = taskNametextBox.Text.ToString();
                if (taskName.Length < 3)
                {
                    MessageBox.Show("Task name is too short");
                    taskNameCorrectLenght = false;
                }
                string taskDescription = taskDescriptionRichTextBox.Text.ToString();
                if(taskDescription.Length < 1)
                {
                    taskDescription = " ";
                }
                string isChecked = "false";
                if(recurringCheckBox.Checked.Equals(true))
                {
                    isChecked = "true";
                }
                if (taskNameCorrectLenght.Equals(true))
                {
                    con.Open();

                    try
                    {
                        cmd.Parameters.AddWithValue("@taskId", (Int16.Parse(id) + 1).ToString());
                        cmd.Parameters.AddWithValue("@taskName", taskName);
                        cmd.Parameters.AddWithValue("@taskDescription", taskDescription);
                        cmd.Parameters.AddWithValue("@status", "open");
                        cmd.Parameters.AddWithValue("@recurring", isChecked);
                        cmd.Parameters.AddWithValue("@timeSpentOnTask", "0");

                        cmd.CommandText = "INSERT [ManagementToolDatabase].[dbo].[OpenTasks] (taskId, taskName, taskDescription, status, recurring, timeSpentOnTask)" +
                            " VALUES (@taskId, @taskName, @taskDescription, @status, @recurring, @timeSpentOnTask)";
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Task created");
                        this.Hide();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Registration is unavailable");
                    }

                    con.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Not connected to database");
            }
        }
        public string searchingForMaxId()
        {
            SqlConnection con = new SqlConnection(connectionString);
            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Connection = con;
            con.Open();
            
            cmd.CommandText = "SELECT MAX(taskId) FROM [ManagementToolDatabase].[dbo].[OpenTasks]";
            string idOpenTable = cmd.ExecuteScalar().ToString();
            string id = idOpenTable;
            if(id.Equals(""))
            {
                id = "0";
            }
            cmd.CommandText = "SELECT MAX(taskId) FROM [ManagementToolDatabase].[dbo].[InProgressTasks]";
            string idProgressTable = cmd.ExecuteScalar().ToString();
            if(idProgressTable.Equals(""))
            {
                idProgressTable = "0";
            }
            if(Int16.Parse(id) < Int16.Parse(idProgressTable))
            {
                id = idProgressTable;
            }
            cmd.CommandText = "SELECT MAX(taskId) FROM [ManagementToolDatabase].[dbo].[ClosedTasks]";
            string idClosedTable = cmd.ExecuteScalar().ToString();
            if(idClosedTable.Equals(""))
            {
                idClosedTable = "0";
            }
            if(Int16.Parse(id) < Int16.Parse(idClosedTable))
            {
                id = idClosedTable;
            }
            con.Close();
            return id;
        }
    }
}
