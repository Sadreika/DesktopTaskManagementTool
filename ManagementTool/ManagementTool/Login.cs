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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        public string connectionString = @"Data Source=(LocalDb)\MSSQLLocalDB;Initial Catalog=ManagementToolDatabase;Integrated Security=True";

        public string usersId = " ";

        public void settingUserId(string id)
        {
            usersId = id;
        }

        public string returningUserId()
        {
            return usersId;
        }
        
        private void loginButton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionString);
            try
            {
                con.Open();
                System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Connection = con;
                string username = usernameTextBox.Text.ToString();
                string password = passwordTextbox.Text.ToString();
                try
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);
                    cmd.CommandText = "SELECT isActive FROM [ManagementToolDatabase].[dbo].[UserRegistrationTable]" +
                        " WHERE username = @username AND @password = password";
                    string isActive = cmd.ExecuteScalar().ToString();
                    if(isActive.Equals("active"))
                    {
                        gettingUserId();
                        ManagementToolDesktop mainWindow = new ManagementToolDesktop(returningUserId());
                        mainWindow.Show();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Wrong username or password");
                }
                con.Close();
            } catch (Exception)
            {
                MessageBox.Show("Not connected to database");
            } 
        }

        public void gettingUserId()
        {
            SqlConnection con = new SqlConnection(connectionString);
            try
            {
                con.Open();
                System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Connection = con;
                string username = usernameTextBox.Text.ToString();
                string password = passwordTextbox.Text.ToString();
                try
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);
                    cmd.CommandText = "SELECT id FROM [ManagementToolDatabase].[dbo].[UserRegistrationTable]" +
                        " WHERE username = @username AND @password = password";
                    string userIdFromDatabase = cmd.ExecuteScalar().ToString();
                    settingUserId(userIdFromDatabase);
                }
                catch (Exception)
                {
                    MessageBox.Show("Cannot get user id");
                }
                con.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Not connected to database");
            }
        }

        private void registrationButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistrationForm registrationForm = new RegistrationForm();
            registrationForm.ShowDialog();
        }
    }
}
