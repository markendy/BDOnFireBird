namespace BD
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
            this.Quest1Button = new System.Windows.Forms.Button();
            this.ClassAddButton = new System.Windows.Forms.Button();
            this.ClassStudentButton = new System.Windows.Forms.Button();
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
            this.DataGridView.Size = new System.Drawing.Size(1137, 369);
            this.DataGridView.TabIndex = 0;
            // 
            // AddShoolGradeButton
            // 
            this.AddShoolGradeButton.Location = new System.Drawing.Point(467, 58);
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
            // Quest1Button
            // 
            this.Quest1Button.Location = new System.Drawing.Point(165, 12);
            this.Quest1Button.Name = "Quest1Button";
            this.Quest1Button.Size = new System.Drawing.Size(227, 52);
            this.Quest1Button.TabIndex = 3;
            this.Quest1Button.Text = "Какой предмет в определенный день в определенном уроке";
            this.Quest1Button.UseVisualStyleBackColor = true;
            this.Quest1Button.Click += new System.EventHandler(this.Quest1Button_Click);
            // 
            // ClassAddButton
            // 
            this.ClassAddButton.Location = new System.Drawing.Point(8, 41);
            this.ClassAddButton.Name = "ClassAddButton";
            this.ClassAddButton.Size = new System.Drawing.Size(151, 23);
            this.ClassAddButton.TabIndex = 4;
            this.ClassAddButton.Text = "Добавить класс";
            this.ClassAddButton.UseVisualStyleBackColor = true;
            this.ClassAddButton.Click += new System.EventHandler(this.ClassAddButton_Click);
            // 
            // ClassStudentButton
            // 
            this.ClassStudentButton.Location = new System.Drawing.Point(8, 70);
            this.ClassStudentButton.Name = "ClassStudentButton";
            this.ClassStudentButton.Size = new System.Drawing.Size(151, 23);
            this.ClassStudentButton.TabIndex = 5;
            this.ClassStudentButton.Text = "Добавить ученика";
            this.ClassStudentButton.UseVisualStyleBackColor = true;
            this.ClassStudentButton.Click += new System.EventHandler(this.StudentAddButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 551);
            this.Controls.Add(this.ClassStudentButton);
            this.Controls.Add(this.ClassAddButton);
            this.Controls.Add(this.Quest1Button);
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
        private System.Windows.Forms.Button Quest1Button;
        private System.Windows.Forms.Button ClassAddButton;
        private System.Windows.Forms.Button ClassStudentButton;
    }
}