namespace ManagementTool
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
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.openDataGridView = new System.Windows.Forms.DataGridView();
            this.inProgressDataGridView = new System.Windows.Forms.DataGridView();
            this.closedDataGridView = new System.Windows.Forms.DataGridView();
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
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(326, 22);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Delete task";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(177, 22);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(105, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Show task";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(127, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = " Open tasks";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(394, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tasks in progress";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(681, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Closed tasks";
            // 
            // openDataGridView
            // 
            this.openDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.openDataGridView.Location = new System.Drawing.Point(64, 116);
            this.openDataGridView.Name = "openDataGridView";
            this.openDataGridView.RowHeadersWidth = 51;
            this.openDataGridView.RowTemplate.Height = 24;
            this.openDataGridView.Size = new System.Drawing.Size(203, 532);
            this.openDataGridView.TabIndex = 6;
            // 
            // inProgressDataGridView
            // 
            this.inProgressDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.inProgressDataGridView.Location = new System.Drawing.Point(343, 116);
            this.inProgressDataGridView.Name = "inProgressDataGridView";
            this.inProgressDataGridView.RowHeadersWidth = 51;
            this.inProgressDataGridView.RowTemplate.Height = 24;
            this.inProgressDataGridView.Size = new System.Drawing.Size(211, 532);
            this.inProgressDataGridView.TabIndex = 7;
            // 
            // closedDataGridView
            // 
            this.closedDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.closedDataGridView.Location = new System.Drawing.Point(628, 116);
            this.closedDataGridView.Name = "closedDataGridView";
            this.closedDataGridView.RowHeadersWidth = 51;
            this.closedDataGridView.RowTemplate.Height = 24;
            this.closedDataGridView.Size = new System.Drawing.Size(213, 532);
            this.closedDataGridView.TabIndex = 8;
            // 
            // ManagementToolDesktop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 703);
            this.Controls.Add(this.closedDataGridView);
            this.Controls.Add(this.inProgressDataGridView);
            this.Controls.Add(this.openDataGridView);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.addTaskButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ManagementToolDesktop";
            this.Text = "ManagementToolDesktop";
            ((System.ComponentModel.ISupportInitialize)(this.openDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inProgressDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closedDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.Button addTaskButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView openDataGridView;
        private System.Windows.Forms.DataGridView inProgressDataGridView;
        private System.Windows.Forms.DataGridView closedDataGridView;
    }
}

