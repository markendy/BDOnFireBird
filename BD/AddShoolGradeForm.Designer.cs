namespace BD
{
    partial class AddShoolGradeForm
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
            this.ClassTextBox = new System.Windows.Forms.TextBox();
            this.ThingLabel = new System.Windows.Forms.Label();
            this.ClassLabel = new System.Windows.Forms.Label();
            this.ThingTextBox = new System.Windows.Forms.TextBox();
            this.ShoolGradeLabel = new System.Windows.Forms.Label();
            this.ShoolGradeTextBox = new System.Windows.Forms.TextBox();
            this.DateLabel = new System.Windows.Forms.Label();
            this.DateTextBox = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.CanelButton = new System.Windows.Forms.Button();
            this.StudentaNameLabel = new System.Windows.Forms.Label();
            this.StudentNameTextBox = new System.Windows.Forms.TextBox();
            this.NumberOfLessonTextBox = new System.Windows.Forms.TextBox();
            this.NumberOfLessonLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ClassTextBox
            // 
            this.ClassTextBox.Location = new System.Drawing.Point(91, 40);
            this.ClassTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.ClassTextBox.Name = "ClassTextBox";
            this.ClassTextBox.Size = new System.Drawing.Size(127, 20);
            this.ClassTextBox.TabIndex = 0;
            // 
            // ThingLabel
            // 
            this.ThingLabel.AutoSize = true;
            this.ThingLabel.Location = new System.Drawing.Point(9, 12);
            this.ThingLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ThingLabel.Name = "ThingLabel";
            this.ThingLabel.Size = new System.Drawing.Size(52, 13);
            this.ThingLabel.TabIndex = 1;
            this.ThingLabel.Text = "Предмет";
            // 
            // ClassLabel
            // 
            this.ClassLabel.AutoSize = true;
            this.ClassLabel.Location = new System.Drawing.Point(9, 42);
            this.ClassLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ClassLabel.Name = "ClassLabel";
            this.ClassLabel.Size = new System.Drawing.Size(38, 13);
            this.ClassLabel.TabIndex = 3;
            this.ClassLabel.Text = "Класс";
            // 
            // ThingTextBox
            // 
            this.ThingTextBox.Location = new System.Drawing.Point(91, 12);
            this.ThingTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.ThingTextBox.Name = "ThingTextBox";
            this.ThingTextBox.Size = new System.Drawing.Size(127, 20);
            this.ThingTextBox.TabIndex = 4;
            // 
            // ShoolGradeLabel
            // 
            this.ShoolGradeLabel.AutoSize = true;
            this.ShoolGradeLabel.Location = new System.Drawing.Point(9, 102);
            this.ShoolGradeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ShoolGradeLabel.Name = "ShoolGradeLabel";
            this.ShoolGradeLabel.Size = new System.Drawing.Size(45, 13);
            this.ShoolGradeLabel.TabIndex = 5;
            this.ShoolGradeLabel.Text = "Оценка";
            // 
            // ShoolGradeTextBox
            // 
            this.ShoolGradeTextBox.Location = new System.Drawing.Point(91, 100);
            this.ShoolGradeTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.ShoolGradeTextBox.Name = "ShoolGradeTextBox";
            this.ShoolGradeTextBox.Size = new System.Drawing.Size(127, 20);
            this.ShoolGradeTextBox.TabIndex = 6;
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Location = new System.Drawing.Point(9, 132);
            this.DateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(33, 13);
            this.DateLabel.TabIndex = 7;
            this.DateLabel.Text = "Дата";
            // 
            // DateTextBox
            // 
            this.DateTextBox.Location = new System.Drawing.Point(91, 130);
            this.DateTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.DateTextBox.Name = "DateTextBox";
            this.DateTextBox.Size = new System.Drawing.Size(127, 20);
            this.DateTextBox.TabIndex = 8;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(12, 187);
            this.AddButton.Margin = new System.Windows.Forms.Padding(2);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(204, 24);
            this.AddButton.TabIndex = 9;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButtonClick);
            // 
            // CanelButton
            // 
            this.CanelButton.Location = new System.Drawing.Point(12, 214);
            this.CanelButton.Margin = new System.Windows.Forms.Padding(2);
            this.CanelButton.Name = "CanelButton";
            this.CanelButton.Size = new System.Drawing.Size(204, 24);
            this.CanelButton.TabIndex = 10;
            this.CanelButton.Text = "Отменить";
            this.CanelButton.UseVisualStyleBackColor = true;
            this.CanelButton.Click += new System.EventHandler(this.CanelButtonClick);
            // 
            // StudentaNameLabel
            // 
            this.StudentaNameLabel.AutoSize = true;
            this.StudentaNameLabel.Location = new System.Drawing.Point(9, 73);
            this.StudentaNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.StudentaNameLabel.Name = "StudentaNameLabel";
            this.StudentaNameLabel.Size = new System.Drawing.Size(81, 13);
            this.StudentaNameLabel.TabIndex = 12;
            this.StudentaNameLabel.Text = "Фамилия Имя";
            // 
            // StudentNameTextBox
            // 
            this.StudentNameTextBox.Location = new System.Drawing.Point(91, 71);
            this.StudentNameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.StudentNameTextBox.Name = "StudentNameTextBox";
            this.StudentNameTextBox.Size = new System.Drawing.Size(127, 20);
            this.StudentNameTextBox.TabIndex = 11;
            // 
            // NumberOfLessonTextBox
            // 
            this.NumberOfLessonTextBox.Location = new System.Drawing.Point(91, 159);
            this.NumberOfLessonTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.NumberOfLessonTextBox.Name = "NumberOfLessonTextBox";
            this.NumberOfLessonTextBox.Size = new System.Drawing.Size(127, 20);
            this.NumberOfLessonTextBox.TabIndex = 14;
            // 
            // NumberOfLessonLabel
            // 
            this.NumberOfLessonLabel.AutoSize = true;
            this.NumberOfLessonLabel.Location = new System.Drawing.Point(9, 161);
            this.NumberOfLessonLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NumberOfLessonLabel.Name = "NumberOfLessonLabel";
            this.NumberOfLessonLabel.Size = new System.Drawing.Size(73, 13);
            this.NumberOfLessonLabel.TabIndex = 13;
            this.NumberOfLessonLabel.Text = "Номер урока";
            // 
            // AddShoolGrade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 270);
            this.Controls.Add(this.NumberOfLessonTextBox);
            this.Controls.Add(this.NumberOfLessonLabel);
            this.Controls.Add(this.StudentaNameLabel);
            this.Controls.Add(this.StudentNameTextBox);
            this.Controls.Add(this.CanelButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.DateTextBox);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.ShoolGradeTextBox);
            this.Controls.Add(this.ShoolGradeLabel);
            this.Controls.Add(this.ThingTextBox);
            this.Controls.Add(this.ClassLabel);
            this.Controls.Add(this.ThingLabel);
            this.Controls.Add(this.ClassTextBox);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AddShoolGrade";
            this.Text = "AddShoolGrade";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ClassTextBox;
        private System.Windows.Forms.Label ThingLabel;
        private System.Windows.Forms.Label ClassLabel;
        private System.Windows.Forms.TextBox ThingTextBox;
        private System.Windows.Forms.Label ShoolGradeLabel;
        private System.Windows.Forms.TextBox ShoolGradeTextBox;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.TextBox DateTextBox;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button CanelButton;
        private System.Windows.Forms.Label StudentaNameLabel;
        private System.Windows.Forms.TextBox StudentNameTextBox;
        private System.Windows.Forms.TextBox NumberOfLessonTextBox;
        private System.Windows.Forms.Label NumberOfLessonLabel;
    }
}