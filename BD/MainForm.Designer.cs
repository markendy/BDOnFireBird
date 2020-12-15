﻿namespace BD
{
    partial class MainForm
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
            this.DataGridView = new System.Windows.Forms.DataGridView();
            this.AddShoolGradeButton = new System.Windows.Forms.Button();
            this.AddTeacherButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridView
            // 
            this.DataGridView.AllowUserToAddRows = false;
            this.DataGridView.AllowUserToDeleteRows = false;
            this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView.Location = new System.Drawing.Point(8, 155);
            this.DataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.ReadOnly = true;
            this.DataGridView.RowTemplate.Height = 28;
            this.DataGridView.Size = new System.Drawing.Size(1283, 444);
            this.DataGridView.TabIndex = 0;
            // 
            // AddShoolGradeButton
            // 
            this.AddShoolGradeButton.Location = new System.Drawing.Point(8, 41);
            this.AddShoolGradeButton.Name = "AddShoolGradeButton";
            this.AddShoolGradeButton.Size = new System.Drawing.Size(151, 23);
            this.AddShoolGradeButton.TabIndex = 1;
            this.AddShoolGradeButton.Text = "Поставить оценку";
            this.AddShoolGradeButton.UseVisualStyleBackColor = true;
            this.AddShoolGradeButton.Click += new System.EventHandler(this.AddShoolGradeClick);
            // 
            // AddTeacherButton
            // 
            this.AddTeacherButton.Location = new System.Drawing.Point(8, 12);
            this.AddTeacherButton.Name = "AddTeacherButton";
            this.AddTeacherButton.Size = new System.Drawing.Size(151, 23);
            this.AddTeacherButton.TabIndex = 2;
            this.AddTeacherButton.Text = "Добавить учителя";
            this.AddTeacherButton.UseVisualStyleBackColor = true;
            this.AddTeacherButton.Click += new System.EventHandler(this.AddTeacherButtonClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1302, 610);
            this.Controls.Add(this.AddTeacherButton);
            this.Controls.Add(this.AddShoolGradeButton);
            this.Controls.Add(this.DataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridView;
        private System.Windows.Forms.Button AddShoolGradeButton;
        private System.Windows.Forms.Button AddTeacherButton;
    }
}