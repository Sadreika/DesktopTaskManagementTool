﻿namespace ManagementTool
{
    partial class ManagementToolDesktop
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.addTaskButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.showTaskButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.openDataGridView = new System.Windows.Forms.DataGridView();
            this.openTaskId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taskNameOpenTasks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inProgressDataGridView = new System.Windows.Forms.DataGridView();
            this.taskInProgressId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TasksInProgressTaskName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.closedDataGridView = new System.Windows.Forms.DataGridView();
            this.ClosedTasksId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClosedTasksTaskName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.movingToTasksInProgressbutton = new System.Windows.Forms.Button();
            this.movingToOpenTasksButton = new System.Windows.Forms.Button();
            this.movingToClosedTaskButton = new System.Windows.Forms.Button();
            this.movingFromClosedToTasksInPorgressButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.openDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inProgressDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closedDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // addTaskButton
            // 
            this.addTaskButton.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addTaskButton.Location = new System.Drawing.Point(38, 22);
            this.addTaskButton.Name = "addTaskButton";
            this.addTaskButton.Size = new System.Drawing.Size(98, 23);
            this.addTaskButton.TabIndex = 0;
            this.addTaskButton.Text = "Add task";
            this.addTaskButton.UseVisualStyleBackColor = true;
            this.addTaskButton.Click += new System.EventHandler(this.addTaskButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.Location = new System.Drawing.Point(326, 22);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(116, 23);
            this.deleteButton.TabIndex = 1;
            this.deleteButton.Text = "Delete task";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // showTaskButton
            // 
            this.showTaskButton.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showTaskButton.Location = new System.Drawing.Point(177, 22);
            this.showTaskButton.Name = "showTaskButton";
            this.showTaskButton.Size = new System.Drawing.Size(105, 23);
            this.showTaskButton.TabIndex = 2;
            this.showTaskButton.Text = "Show task";
            this.showTaskButton.UseVisualStyleBackColor = true;
            this.showTaskButton.Click += new System.EventHandler(this.showTaskButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(126, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = " Open tasks";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(504, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tasks in progress";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(903, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Closed tasks";
            // 
            // openDataGridView
            // 
            this.openDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.openDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.openTaskId,
            this.taskNameOpenTasks});
            this.openDataGridView.Location = new System.Drawing.Point(16, 116);
            this.openDataGridView.Name = "openDataGridView";
            this.openDataGridView.RowHeadersWidth = 51;
            this.openDataGridView.RowTemplate.Height = 24;
            this.openDataGridView.Size = new System.Drawing.Size(304, 532);
            this.openDataGridView.TabIndex = 6;
            this.openDataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.openDataGridView_CellEndEdit);
            this.openDataGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.openDataGridView_CellMouseClick);
            // 
            // openTaskId
            // 
            this.openTaskId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.openTaskId.DataPropertyName = "taskId";
            this.openTaskId.HeaderText = "ID";
            this.openTaskId.MinimumWidth = 6;
            this.openTaskId.Name = "openTaskId";
            this.openTaskId.Width = 50;
            // 
            // taskNameOpenTasks
            // 
            this.taskNameOpenTasks.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.taskNameOpenTasks.DataPropertyName = "taskName";
            this.taskNameOpenTasks.HeaderText = "Task Name";
            this.taskNameOpenTasks.MinimumWidth = 6;
            this.taskNameOpenTasks.Name = "taskNameOpenTasks";
            this.taskNameOpenTasks.Width = 200;
            // 
            // inProgressDataGridView
            // 
            this.inProgressDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.inProgressDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.taskInProgressId,
            this.TasksInProgressTaskName});
            this.inProgressDataGridView.Location = new System.Drawing.Point(407, 116);
            this.inProgressDataGridView.Name = "inProgressDataGridView";
            this.inProgressDataGridView.RowHeadersWidth = 51;
            this.inProgressDataGridView.RowTemplate.Height = 24;
            this.inProgressDataGridView.Size = new System.Drawing.Size(306, 532);
            this.inProgressDataGridView.TabIndex = 7;
            this.inProgressDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.inProgressDataGridView_CellContentClick);
            this.inProgressDataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.inProgressDataGridView_CellEndEdit);
            // 
            // taskInProgressId
            // 
            this.taskInProgressId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.taskInProgressId.DataPropertyName = "taskId";
            this.taskInProgressId.HeaderText = "ID";
            this.taskInProgressId.MinimumWidth = 6;
            this.taskInProgressId.Name = "taskInProgressId";
            this.taskInProgressId.Width = 50;
            // 
            // TasksInProgressTaskName
            // 
            this.TasksInProgressTaskName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.TasksInProgressTaskName.DataPropertyName = "taskName";
            this.TasksInProgressTaskName.HeaderText = "Task Name";
            this.TasksInProgressTaskName.MinimumWidth = 6;
            this.TasksInProgressTaskName.Name = "TasksInProgressTaskName";
            this.TasksInProgressTaskName.Width = 200;
            // 
            // closedDataGridView
            // 
            this.closedDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.closedDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClosedTasksId,
            this.ClosedTasksTaskName});
            this.closedDataGridView.Location = new System.Drawing.Point(800, 116);
            this.closedDataGridView.Name = "closedDataGridView";
            this.closedDataGridView.RowHeadersWidth = 51;
            this.closedDataGridView.RowTemplate.Height = 24;
            this.closedDataGridView.Size = new System.Drawing.Size(303, 532);
            this.closedDataGridView.TabIndex = 8;
            this.closedDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.closedDataGridView_CellContentClick);
            this.closedDataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.closedDataGridView_CellEndEdit);
            // 
            // ClosedTasksId
            // 
            this.ClosedTasksId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ClosedTasksId.DataPropertyName = "taskId";
            this.ClosedTasksId.HeaderText = "ID";
            this.ClosedTasksId.MinimumWidth = 6;
            this.ClosedTasksId.Name = "ClosedTasksId";
            this.ClosedTasksId.Width = 50;
            // 
            // ClosedTasksTaskName
            // 
            this.ClosedTasksTaskName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ClosedTasksTaskName.DataPropertyName = "taskName";
            this.ClosedTasksTaskName.HeaderText = "Task Name";
            this.ClosedTasksTaskName.MinimumWidth = 6;
            this.ClosedTasksTaskName.Name = "ClosedTasksTaskName";
            this.ClosedTasksTaskName.Width = 200;
            // 
            // movingToTasksInProgressbutton
            // 
            this.movingToTasksInProgressbutton.Location = new System.Drawing.Point(326, 329);
            this.movingToTasksInProgressbutton.Name = "movingToTasksInProgressbutton";
            this.movingToTasksInProgressbutton.Size = new System.Drawing.Size(75, 23);
            this.movingToTasksInProgressbutton.TabIndex = 9;
            this.movingToTasksInProgressbutton.Text = ">";
            this.movingToTasksInProgressbutton.UseVisualStyleBackColor = true;
            this.movingToTasksInProgressbutton.Click += new System.EventHandler(this.movingToTasksInProgressbutton_Click);
            // 
            // movingToOpenTasksButton
            // 
            this.movingToOpenTasksButton.Location = new System.Drawing.Point(326, 358);
            this.movingToOpenTasksButton.Name = "movingToOpenTasksButton";
            this.movingToOpenTasksButton.Size = new System.Drawing.Size(75, 23);
            this.movingToOpenTasksButton.TabIndex = 10;
            this.movingToOpenTasksButton.Text = "<";
            this.movingToOpenTasksButton.UseVisualStyleBackColor = true;
            this.movingToOpenTasksButton.Click += new System.EventHandler(this.movingToOpenTasksButton_Click);
            // 
            // movingToClosedTaskButton
            // 
            this.movingToClosedTaskButton.Location = new System.Drawing.Point(719, 329);
            this.movingToClosedTaskButton.Name = "movingToClosedTaskButton";
            this.movingToClosedTaskButton.Size = new System.Drawing.Size(75, 23);
            this.movingToClosedTaskButton.TabIndex = 11;
            this.movingToClosedTaskButton.Text = ">";
            this.movingToClosedTaskButton.UseVisualStyleBackColor = true;
            this.movingToClosedTaskButton.Click += new System.EventHandler(this.movingToClosedTaskButton_Click);
            // 
            // movingFromClosedToTasksInPorgressButton
            // 
            this.movingFromClosedToTasksInPorgressButton.Location = new System.Drawing.Point(719, 358);
            this.movingFromClosedToTasksInPorgressButton.Name = "movingFromClosedToTasksInPorgressButton";
            this.movingFromClosedToTasksInPorgressButton.Size = new System.Drawing.Size(75, 23);
            this.movingFromClosedToTasksInPorgressButton.TabIndex = 12;
            this.movingFromClosedToTasksInPorgressButton.Text = "<";
            this.movingFromClosedToTasksInPorgressButton.UseVisualStyleBackColor = true;
            this.movingFromClosedToTasksInPorgressButton.Click += new System.EventHandler(this.movingFromClosedToTasksInPorgressButton_Click);
            // 
            // ManagementToolDesktop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 702);
            this.Controls.Add(this.movingFromClosedToTasksInPorgressButton);
            this.Controls.Add(this.movingToClosedTaskButton);
            this.Controls.Add(this.movingToOpenTasksButton);
            this.Controls.Add(this.movingToTasksInProgressbutton);
            this.Controls.Add(this.closedDataGridView);
            this.Controls.Add(this.inProgressDataGridView);
            this.Controls.Add(this.openDataGridView);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.showTaskButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.addTaskButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ManagementToolDesktop";
            this.Text = "ManagementToolDesktop";
            this.Activated += new System.EventHandler(this.ManagementToolDesktop_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.openDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inProgressDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closedDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.Button addTaskButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button showTaskButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView openDataGridView;
        private System.Windows.Forms.DataGridView inProgressDataGridView;
        private System.Windows.Forms.DataGridView closedDataGridView;
        private System.Windows.Forms.Button movingToTasksInProgressbutton;
        private System.Windows.Forms.Button movingToOpenTasksButton;
        private System.Windows.Forms.Button movingToClosedTaskButton;
        private System.Windows.Forms.Button movingFromClosedToTasksInPorgressButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn openTaskId;
        private System.Windows.Forms.DataGridViewTextBoxColumn taskNameOpenTasks;
        private System.Windows.Forms.DataGridViewTextBoxColumn taskInProgressId;
        private System.Windows.Forms.DataGridViewTextBoxColumn TasksInProgressTaskName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClosedTasksId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClosedTasksTaskName;
    }
}

