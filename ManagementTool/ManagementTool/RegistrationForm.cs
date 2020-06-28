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
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }
        public string connectionString = @"Data Source=(LocalDb)\MSSQLLocalDB;Initial Catalog=ManagementToolDatabase;Integrated Security=True";
        private void submitButton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionString);
            try
            {
                con.Open();
                System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Connection = con;
                string id = searchingForMaxId();
                string username = usernameTextbox.Text.ToString();
                string password = passwordTextbox.Text.ToString();
                string email = emailTextbox.Text.ToString();

                if(seachingIfSameValueExists("username", username).Equals(false))
                {
                    if(seachingIfSameValueExists("email", email).Equals(false))
                    {
                        try
                        {
                            cmd.Parameters.AddWithValue("@id", id + 1);
                            cmd.Parameters.AddWithValue("@username", username);
                            cmd.Parameters.AddWithValue("@password", password);
                            cmd.Parameters.AddWithValue("@email", email);
                            cmd.Parameters.AddWithValue("@isActive", "active");

                            cmd.CommandText = "INSERT [ManagementToolDatabase].[dbo].[UserRegistrationTable] (id, username, password, email, isActive)" +
                                " VALUES (@id, @username, @password, @email, @isActive)";
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Registration is unavailable");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Email is already taken");
                    }
                }
                else
                {
                    MessageBox.Show("Name is already taken");
                }
                con.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Not connected to database");
            }
        }
        public bool seachingIfSameValueExists(string whichColumnToCheck, string givenValue)
        {
            bool doesExist = false;
            SqlConnection con = new SqlConnection(connectionString);
            try
            {
                con.Open();
                System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Connection = con;
                try
                {
                    cmd.Parameters.AddWithValue("@" + whichColumnToCheck, givenValue);
                    cmd.CommandText = "SELECT isActive FROM [ManagementToolDatabase].[dbo].[UserRegistrationTable]" +
                        " WHERE " + whichColumnToCheck + " = @" + whichColumnToCheck;
                    try
                    {
                        string isActive = cmd.ExecuteScalar().ToString();

                        if (isActive.Equals(true) || isActive.Equals(false))
                        {
                            doesExist = true;
                        }
                    }
                    catch(Exception)
                    {

                    }
                }
                catch(Exception)
                {
                    MessageBox.Show("Can't check value");
                }
                con.Close();
            }
            catch(Exception)
            {
                MessageBox.Show("Unable to open database");
            }
            return doesExist;
        }
        public string searchingForMaxId()
        {
            SqlConnection con = new SqlConnection(connectionString);
            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = "SELECT MAX(id) FROM [ManagementToolDatabase].[dbo].[UserRegistrationTable]";
            string id = cmd.ExecuteScalar().ToString();
            if (id.Equals(""))
            {
                id = "0";
            }
            con.Close();
            return id;
        }
    }
}
