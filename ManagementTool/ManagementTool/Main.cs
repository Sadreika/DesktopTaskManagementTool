﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        }

        private void addTaskButton_Click(object sender, EventArgs e)
        {
            TaskCreateForm taskCreation = new TaskCreateForm();
            taskCreation.Show();
        }
    }
}
