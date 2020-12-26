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
            this.QuestButton = new System.Windows.Forms.Button();
            this.ClassAddButton = new System.Windows.Forms.Button();
            this.AddStudentButton = new System.Windows.Forms.Button();
            this.AddLessonButton = new System.Windows.Forms.Button();
            this.OBSLesson = new System.Windows.Forms.Button();
            this.OBSStudent = new System.Windows.Forms.Button();
            this.OBSClass = new System.Windows.Forms.Button();
            this.OBSTeacher = new System.Windows.Forms.Button();
            this.OBSScore = new System.Windows.Forms.Button();
            this.ReqView = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridView
            // 
            this.DataGridView.AllowUserToAddRows = false;
            this.DataGridView.AllowUserToDeleteRows = false;
            this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView.Location = new System.Drawing.Point(8, 185);
            this.DataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.ReadOnly = true;
            this.DataGridView.RowTemplate.Height = 28;
            this.DataGridView.Size = new System.Drawing.Size(622, 339);
            this.DataGridView.TabIndex = 0;
            // 
            // AddShoolGradeButton
            // 
            this.AddShoolGradeButton.Location = new System.Drawing.Point(322, 128);
            this.AddShoolGradeButton.Name = "AddShoolGradeButton";
            this.AddShoolGradeButton.Size = new System.Drawing.Size(151, 23);
            this.AddShoolGradeButton.TabIndex = 1;
            this.AddShoolGradeButton.Text = "Проставление оценок";
            this.AddShoolGradeButton.UseVisualStyleBackColor = true;
            this.AddShoolGradeButton.Visible = false;
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
            this.AddTeacherButton.Visible = false;
            this.AddTeacherButton.Click += new System.EventHandler(this.AddTeacherButtonClick);
            // 
            // QuestButton
            // 
            this.QuestButton.Location = new System.Drawing.Point(8, 128);
            this.QuestButton.Name = "QuestButton";
            this.QuestButton.Size = new System.Drawing.Size(151, 23);
            this.QuestButton.TabIndex = 3;
            this.QuestButton.Text = "Задания, справки, отчеты";
            this.QuestButton.UseVisualStyleBackColor = true;
            this.QuestButton.Visible = false;
            this.QuestButton.Click += new System.EventHandler(this.QuestButton_Click);
            // 
            // ClassAddButton
            // 
            this.ClassAddButton.Location = new System.Drawing.Point(8, 41);
            this.ClassAddButton.Name = "ClassAddButton";
            this.ClassAddButton.Size = new System.Drawing.Size(151, 23);
            this.ClassAddButton.TabIndex = 4;
            this.ClassAddButton.Text = "Добавить класс";
            this.ClassAddButton.UseVisualStyleBackColor = true;
            this.ClassAddButton.Visible = false;
            this.ClassAddButton.Click += new System.EventHandler(this.ClassAddButton_Click);
            // 
            // AddStudentButton
            // 
            this.AddStudentButton.Location = new System.Drawing.Point(8, 70);
            this.AddStudentButton.Name = "AddStudentButton";
            this.AddStudentButton.Size = new System.Drawing.Size(151, 23);
            this.AddStudentButton.TabIndex = 5;
            this.AddStudentButton.Text = "Добавить ученика";
            this.AddStudentButton.UseVisualStyleBackColor = true;
            this.AddStudentButton.Visible = false;
            this.AddStudentButton.Click += new System.EventHandler(this.StudentAddButton_Click);
            // 
            // AddLessonButton
            // 
            this.AddLessonButton.Location = new System.Drawing.Point(8, 99);
            this.AddLessonButton.Name = "AddLessonButton";
            this.AddLessonButton.Size = new System.Drawing.Size(151, 23);
            this.AddLessonButton.TabIndex = 7;
            this.AddLessonButton.Text = "Добавить урок";
            this.AddLessonButton.UseVisualStyleBackColor = true;
            this.AddLessonButton.Visible = false;
            this.AddLessonButton.Click += new System.EventHandler(this.AddLessonButton_Click);
            // 
            // OBSLesson
            // 
            this.OBSLesson.Location = new System.Drawing.Point(479, 128);
            this.OBSLesson.Name = "OBSLesson";
            this.OBSLesson.Size = new System.Drawing.Size(151, 23);
            this.OBSLesson.TabIndex = 14;
            this.OBSLesson.Text = "Просмотреть уроки";
            this.OBSLesson.UseVisualStyleBackColor = true;
            this.OBSLesson.Visible = false;
            this.OBSLesson.Click += new System.EventHandler(this.OBSLesson_Click);
            // 
            // OBSStudent
            // 
            this.OBSStudent.Location = new System.Drawing.Point(479, 70);
            this.OBSStudent.Name = "OBSStudent";
            this.OBSStudent.Size = new System.Drawing.Size(151, 23);
            this.OBSStudent.TabIndex = 13;
            this.OBSStudent.Text = "Просмотреть учеников";
            this.OBSStudent.UseVisualStyleBackColor = true;
            this.OBSStudent.Visible = false;
            this.OBSStudent.Click += new System.EventHandler(this.OBSStudent_Click);
            // 
            // OBSClass
            // 
            this.OBSClass.Location = new System.Drawing.Point(479, 41);
            this.OBSClass.Name = "OBSClass";
            this.OBSClass.Size = new System.Drawing.Size(151, 23);
            this.OBSClass.TabIndex = 12;
            this.OBSClass.Text = "Просмотреть классы";
            this.OBSClass.UseVisualStyleBackColor = true;
            this.OBSClass.Visible = false;
            this.OBSClass.Click += new System.EventHandler(this.OBSClass_Click);
            // 
            // OBSTeacher
            // 
            this.OBSTeacher.Location = new System.Drawing.Point(479, 12);
            this.OBSTeacher.Name = "OBSTeacher";
            this.OBSTeacher.Size = new System.Drawing.Size(151, 23);
            this.OBSTeacher.TabIndex = 10;
            this.OBSTeacher.Text = "Просмотреть учителей";
            this.OBSTeacher.UseVisualStyleBackColor = true;
            this.OBSTeacher.Visible = false;
            this.OBSTeacher.Click += new System.EventHandler(this.OBSTeacher_Click);
            // 
            // OBSScore
            // 
            this.OBSScore.Location = new System.Drawing.Point(479, 99);
            this.OBSScore.Name = "OBSScore";
            this.OBSScore.Size = new System.Drawing.Size(151, 23);
            this.OBSScore.TabIndex = 9;
            this.OBSScore.Text = "Просмотреть оценки";
            this.OBSScore.UseVisualStyleBackColor = true;
            this.OBSScore.Visible = false;
            this.OBSScore.Click += new System.EventHandler(this.OBSScore_Click);
            // 
            // ReqView
            // 
            this.ReqView.Location = new System.Drawing.Point(8, 529);
            this.ReqView.Multiline = true;
            this.ReqView.Name = "ReqView";
            this.ReqView.ReadOnly = true;
            this.ReqView.Size = new System.Drawing.Size(622, 89);
            this.ReqView.TabIndex = 15;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 630);
            this.Controls.Add(this.ReqView);
            this.Controls.Add(this.OBSLesson);
            this.Controls.Add(this.OBSStudent);
            this.Controls.Add(this.OBSClass);
            this.Controls.Add(this.OBSTeacher);
            this.Controls.Add(this.OBSScore);
            this.Controls.Add(this.AddLessonButton);
            this.Controls.Add(this.AddStudentButton);
            this.Controls.Add(this.ClassAddButton);
            this.Controls.Add(this.QuestButton);
            this.Controls.Add(this.AddTeacherButton);
            this.Controls.Add(this.AddShoolGradeButton);
            this.Controls.Add(this.DataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Главная форма";
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridView;
        private System.Windows.Forms.Button AddShoolGradeButton;
        private System.Windows.Forms.Button AddTeacherButton;
        private System.Windows.Forms.Button QuestButton;
        private System.Windows.Forms.Button ClassAddButton;
        private System.Windows.Forms.Button AddStudentButton;
        private System.Windows.Forms.Button AddLessonButton;
        private System.Windows.Forms.Button OBSLesson;
        private System.Windows.Forms.Button OBSStudent;
        private System.Windows.Forms.Button OBSClass;
        private System.Windows.Forms.Button OBSTeacher;
        private System.Windows.Forms.Button OBSScore;
        private System.Windows.Forms.TextBox ReqView;
    }
}