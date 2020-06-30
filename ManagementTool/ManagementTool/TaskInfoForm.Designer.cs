namespace ManagementTool
{
    partial class TaskInfoForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.taskNamelabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timeSpentOnTasklabel = new System.Windows.Forms.Label();
            this.editButton = new System.Windows.Forms.Button();
            this.taskNametextBox = new System.Windows.Forms.TextBox();
            this.taskDescriptionrichTextBox = new System.Windows.Forms.RichTextBox();
            this.recurringcheckBox = new System.Windows.Forms.CheckBox();
            this.timeSpentOnTasktextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // taskNamelabel
            // 
            this.taskNamelabel.AutoSize = true;
            this.taskNamelabel.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskNamelabel.Location = new System.Drawing.Point(52, 56);
            this.taskNamelabel.Name = "taskNamelabel";
            this.taskNamelabel.Size = new System.Drawing.Size(73, 18);
            this.taskNamelabel.TabIndex = 0;
            this.taskNamelabel.Text = "Task name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(52, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Task description";
            // 
            // timeSpentOnTasklabel
            // 
            this.timeSpentOnTasklabel.AutoSize = true;
            this.timeSpentOnTasklabel.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeSpentOnTasklabel.Location = new System.Drawing.Point(52, 312);
            this.timeSpentOnTasklabel.Name = "timeSpentOnTasklabel";
            this.timeSpentOnTasklabel.Size = new System.Drawing.Size(128, 18);
            this.timeSpentOnTasklabel.TabIndex = 3;
            this.timeSpentOnTasklabel.Text = "Time spent on task";
            // 
            // editButton
            // 
            this.editButton.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editButton.Location = new System.Drawing.Point(430, 363);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(90, 29);
            this.editButton.TabIndex = 4;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // taskNametextBox
            // 
            this.taskNametextBox.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskNametextBox.Location = new System.Drawing.Point(157, 50);
            this.taskNametextBox.Name = "taskNametextBox";
            this.taskNametextBox.Size = new System.Drawing.Size(363, 24);
            this.taskNametextBox.TabIndex = 5;
            // 
            // taskDescriptionrichTextBox
            // 
            this.taskDescriptionrichTextBox.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskDescriptionrichTextBox.Location = new System.Drawing.Point(55, 142);
            this.taskDescriptionrichTextBox.Name = "taskDescriptionrichTextBox";
            this.taskDescriptionrichTextBox.Size = new System.Drawing.Size(465, 145);
            this.taskDescriptionrichTextBox.TabIndex = 6;
            this.taskDescriptionrichTextBox.Text = "";
            // 
            // recurringcheckBox
            // 
            this.recurringcheckBox.AutoSize = true;
            this.recurringcheckBox.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recurringcheckBox.Location = new System.Drawing.Point(430, 311);
            this.recurringcheckBox.Name = "recurringcheckBox";
            this.recurringcheckBox.Size = new System.Drawing.Size(90, 22);
            this.recurringcheckBox.TabIndex = 7;
            this.recurringcheckBox.Text = "Recurring";
            this.recurringcheckBox.UseVisualStyleBackColor = true;
            // 
            // timeSpentOnTasktextBox
            // 
            this.timeSpentOnTasktextBox.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeSpentOnTasktextBox.Location = new System.Drawing.Point(222, 309);
            this.timeSpentOnTasktextBox.Name = "timeSpentOnTasktextBox";
            this.timeSpentOnTasktextBox.Size = new System.Drawing.Size(100, 24);
            this.timeSpentOnTasktextBox.TabIndex = 8;
            // 
            // TaskInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 441);
            this.Controls.Add(this.timeSpentOnTasktextBox);
            this.Controls.Add(this.recurringcheckBox);
            this.Controls.Add(this.taskDescriptionrichTextBox);
            this.Controls.Add(this.taskNametextBox);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.timeSpentOnTasklabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.taskNamelabel);
            this.Name = "TaskInfoForm";
            this.Text = "TaskInfoForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label taskNamelabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label timeSpentOnTasklabel;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.TextBox taskNametextBox;
        private System.Windows.Forms.RichTextBox taskDescriptionrichTextBox;
        private System.Windows.Forms.CheckBox recurringcheckBox;
        private System.Windows.Forms.TextBox timeSpentOnTasktextBox;
    }
}