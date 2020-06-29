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
        public void fillingTable()
        {
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlDataAdapter sqlData = new SqlDataAdapter("SELECT taskName FROM [ManagementToolDatabase].[dbo].[OpenTasks]", con);
            DataTable data = new DataTable();
            sqlData.Fill(data);
            openDataGridView.DataSource = data;

            SqlDataAdapter sqlDataForSecondGrid = new SqlDataAdapter("SELECT taskName FROM [ManagementToolDatabase].[dbo].[InProgressTasks]", con);
            DataTable dataForSecondGrid = new DataTable();
            sqlDataForSecondGrid.Fill(dataForSecondGrid);
            inProgressDataGridView.DataSource = dataForSecondGrid;

            SqlDataAdapter sqlDataForThirdGrid = new SqlDataAdapter("SELECT taskName FROM [ManagementToolDatabase].[dbo].[ClosedTasks]", con);
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

        private void ManagementToolDesktop_Load(object sender, EventArgs e)
        {

        }
    }
}
