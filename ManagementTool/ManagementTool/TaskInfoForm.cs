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
    public partial class TaskInfoForm : Form
    {
        public TaskInfoForm(string columnId)
        {
            InitializeComponent();
            fillingForm(columnId);
        }
        public string connectionString = @"Data Source=(LocalDb)\MSSQLLocalDB;Initial Catalog=ManagementToolDatabase;Integrated Security=True";
        public string columnId = "";

        public void settingColumnId(string id)
        {
            columnId = id;
        }
        public string whichTable(string columnId)
        {
            string databaseName = "";
            if(seachingIdInTable(columnId, "[ManagementToolDatabase].[dbo].[OpenTasks]").Equals(true))
            {
                databaseName = "[ManagementToolDatabase].[dbo].[OpenTasks]";
            }
            else if(seachingIdInTable(columnId, "[ManagementToolDatabase].[dbo].[InProgressTasks]").Equals(true))
            {
                databaseName = "[ManagementToolDatabase].[dbo].[InProgressTasks]";
            }
            else if (seachingIdInTable(columnId, "[ManagementToolDatabase].[dbo].[ClosedTasks]").Equals(true))
            {
                databaseName = "[ManagementToolDatabase].[dbo].[ClosedTasks]";
            }
            else
            {
                MessageBox.Show("Choose task");
            }
            return databaseName;
        }
        public bool seachingIdInTable(string columnId, string fromWhichTable)
        {
            bool foundId = false;
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM " + fromWhichTable + " WHERE taskId = @id", con);
                cmd.Parameters.AddWithValue("@id", columnId);
                SqlDataReader dataReader = cmd.ExecuteReader();
                foundId = true;
            }
            catch (Exception)
            {
                foundId = false;
            }
            con.Close();
            return foundId;
        }
        public void fillingForm(string columnId)
        {
            settingColumnId(columnId);
            string fromWhichTable = whichTable(columnId);
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM " + fromWhichTable + " WHERE taskId = @id", con);
                cmd.Parameters.AddWithValue("@id", columnId);
                SqlDataReader dataReader = cmd.ExecuteReader();
                string taskName = "";
                string taskDescription = "";
                string recurring = "";
                string timeSpentOnTask = "";
                if (dataReader.Read())
                {
                    taskName = (dataReader["taskName"].ToString());
                    taskDescription = (dataReader["taskDescription"].ToString());
                    recurring = (dataReader["recurring"].ToString());
                    timeSpentOnTask = (dataReader["timeSpentOnTask"].ToString());
                }
                taskNametextBox.Text = taskName;
                taskDescriptionrichTextBox.Text = taskDescription;
                timeSpentOnTasktextBox.Text = timeSpentOnTask;
                if(recurring.Equals("true"))
                {
                    recurringcheckBox.Checked = true;
                }
                else
                {
                    recurringcheckBox.Checked = false;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Cannot fill form");
            }
            con.Close();
        }
        private void editButton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionString);
            try
            {
                bool taskNameAndTimeSpentOnTaskLenght = true;
                System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Connection = con;
               
                if (taskNametextBox.Text.Length < 3)
                {
                    MessageBox.Show("Task name is too short");
                    taskNameAndTimeSpentOnTaskLenght = false;
                }
                if(timeSpentOnTasktextBox.Text.Length < 1)
                {
                    MessageBox.Show("Set time");
                    taskNameAndTimeSpentOnTaskLenght = false;
                }
                con.Open();
                if (taskNameAndTimeSpentOnTaskLenght.Equals(true))
                {   
                    try
                    {
                        string recurringcheck = "";
                        string taskName = taskNametextBox.Text;
                        string taskDescription = taskDescriptionrichTextBox.Text;
                        string timeSpentOnTask = timeSpentOnTasktextBox.Text;
                        if(recurringcheckBox.Checked.Equals(true))
                        {
                            recurringcheck = "true";
                        }
                        else
                        {
                            recurringcheck = "false";
                        }

                        string fromWhichTable = whichTable(columnId);

                        cmd.Parameters.AddWithValue("@taskName", taskName);
                        cmd.Parameters.AddWithValue("@taskDescription", taskDescription);
                        cmd.Parameters.AddWithValue("@recurring", recurringcheck);
                        cmd.Parameters.AddWithValue("@timeSpentOnTask", timeSpentOnTask);

                        cmd.CommandText = "UPDATE " + fromWhichTable + " SET taskName = @taskName, " +
                            "taskDescription = @taskDescription, recurring = @recurring, " +
                            "timeSpentOnTask = @timeSpentOnTask";
                        cmd.ExecuteNonQuery();
                        this.Hide();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Cannot edit task");
                    }
                }
                con.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Not connected to database");
            }
        }
    }
}
