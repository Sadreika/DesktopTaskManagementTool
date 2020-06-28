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
                    if(isActive == "active")
                    {
                        ManagementToolDesktop mainWindow = new ManagementToolDesktop();
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

        private void registrationButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistrationForm registrationForm = new RegistrationForm();
            registrationForm.ShowDialog();
        }
    }
}
