﻿namespace ManagementTool
{
    partial class TaskCreateForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.taskNametextBox = new System.Windows.Forms.TextBox();
            this.recurringCheckBox = new System.Windows.Forms.CheckBox();
            this.taskDescriptionRichTextBox = new System.Windows.Forms.RichTextBox();
            this.createButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Task name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Task description";
            // 
            // taskNametextBox
            // 
            this.taskNametextBox.Location = new System.Drawing.Point(24, 52);
            this.taskNametextBox.Name = "taskNametextBox";
            this.taskNametextBox.Size = new System.Drawing.Size(247, 22);
            this.taskNametextBox.TabIndex = 3;
            // 
            // recurringCheckBox
            // 
            this.recurringCheckBox.AutoSize = true;
            this.recurringCheckBox.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recurringCheckBox.Location = new System.Drawing.Point(24, 222);
            this.recurringCheckBox.Name = "recurringCheckBox";
            this.recurringCheckBox.Size = new System.Drawing.Size(90, 22);
            this.recurringCheckBox.TabIndex = 5;
            this.recurringCheckBox.Text = "Recurring";
            this.recurringCheckBox.UseVisualStyleBackColor = true;
            // 
            // taskDescriptionRichTextBox
            // 
            this.taskDescriptionRichTextBox.Location = new System.Drawing.Point(24, 103);
            this.taskDescriptionRichTextBox.Name = "taskDescriptionRichTextBox";
            this.taskDescriptionRichTextBox.Size = new System.Drawing.Size(543, 99);
            this.taskDescriptionRichTextBox.TabIndex = 6;
            this.taskDescriptionRichTextBox.Text = "";
            // 
            // createButton
            // 
            this.createButton.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createButton.Location = new System.Drawing.Point(419, 221);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(148, 23);
            this.createButton.TabIndex = 7;
            this.createButton.Text = "Create";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // TaskCreateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 265);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.taskDescriptionRichTextBox);
            this.Controls.Add(this.recurringCheckBox);
            this.Controls.Add(this.taskNametextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "TaskCreateForm";
            this.Text = "TaskCreateForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox taskNametextBox;
        private System.Windows.Forms.CheckBox recurringCheckBox;
        private System.Windows.Forms.RichTextBox taskDescriptionRichTextBox;
        private System.Windows.Forms.Button createButton;
    }
}