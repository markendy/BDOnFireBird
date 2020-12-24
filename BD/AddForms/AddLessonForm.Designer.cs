namespace BD
{
    partial class AddLessonForm
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
            this.NumberComboBox = new System.Windows.Forms.ComboBox();
            this.NumberLabel = new System.Windows.Forms.Label();
            this.CabinetLabel = new System.Windows.Forms.Label();
            this.CabinetComboBox = new System.Windows.Forms.ComboBox();
            this.TeacherLabel = new System.Windows.Forms.Label();
            this.TeacherComboBox = new System.Windows.Forms.ComboBox();
            this.ClassLabel = new System.Windows.Forms.Label();
            this.ClassComboBox = new System.Windows.Forms.ComboBox();
            this.ThingLabel = new System.Windows.Forms.Label();
            this.ThingComboBox = new System.Windows.Forms.ComboBox();
            this.AddLessonButton = new System.Windows.Forms.Button();
            this.Calendar = new System.Windows.Forms.MonthCalendar();
            this.DateLabel = new System.Windows.Forms.Label();
            this.DataTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // NumberComboBox
            // 
            this.NumberComboBox.FormattingEnabled = true;
            this.NumberComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.NumberComboBox.Location = new System.Drawing.Point(109, 6);
            this.NumberComboBox.Name = "NumberComboBox";
            this.NumberComboBox.Size = new System.Drawing.Size(165, 21);
            this.NumberComboBox.TabIndex = 0;
            // 
            // NumberLabel
            // 
            this.NumberLabel.AutoSize = true;
            this.NumberLabel.Location = new System.Drawing.Point(12, 9);
            this.NumberLabel.Name = "NumberLabel";
            this.NumberLabel.Size = new System.Drawing.Size(73, 13);
            this.NumberLabel.TabIndex = 1;
            this.NumberLabel.Text = "Номер урока";
            // 
            // CabinetLabel
            // 
            this.CabinetLabel.AutoSize = true;
            this.CabinetLabel.Location = new System.Drawing.Point(12, 90);
            this.CabinetLabel.Name = "CabinetLabel";
            this.CabinetLabel.Size = new System.Drawing.Size(91, 13);
            this.CabinetLabel.TabIndex = 3;
            this.CabinetLabel.Text = "Номер кабинета";
            // 
            // CabinetComboBox
            // 
            this.CabinetComboBox.FormattingEnabled = true;
            this.CabinetComboBox.Location = new System.Drawing.Point(109, 87);
            this.CabinetComboBox.Name = "CabinetComboBox";
            this.CabinetComboBox.Size = new System.Drawing.Size(165, 21);
            this.CabinetComboBox.TabIndex = 2;
            // 
            // TeacherLabel
            // 
            this.TeacherLabel.AutoSize = true;
            this.TeacherLabel.Location = new System.Drawing.Point(12, 63);
            this.TeacherLabel.Name = "TeacherLabel";
            this.TeacherLabel.Size = new System.Drawing.Size(49, 13);
            this.TeacherLabel.TabIndex = 5;
            this.TeacherLabel.Text = "Учитель";
            // 
            // TeacherComboBox
            // 
            this.TeacherComboBox.FormattingEnabled = true;
            this.TeacherComboBox.Location = new System.Drawing.Point(109, 60);
            this.TeacherComboBox.Name = "TeacherComboBox";
            this.TeacherComboBox.Size = new System.Drawing.Size(165, 21);
            this.TeacherComboBox.TabIndex = 4;
            this.TeacherComboBox.SelectedIndexChanged += new System.EventHandler(this.TeacherComboBox_SelectedIndexChanged);
            // 
            // ClassLabel
            // 
            this.ClassLabel.AutoSize = true;
            this.ClassLabel.Location = new System.Drawing.Point(12, 117);
            this.ClassLabel.Name = "ClassLabel";
            this.ClassLabel.Size = new System.Drawing.Size(38, 13);
            this.ClassLabel.TabIndex = 7;
            this.ClassLabel.Text = "Класс";
            // 
            // ClassComboBox
            // 
            this.ClassComboBox.FormattingEnabled = true;
            this.ClassComboBox.Location = new System.Drawing.Point(109, 114);
            this.ClassComboBox.Name = "ClassComboBox";
            this.ClassComboBox.Size = new System.Drawing.Size(165, 21);
            this.ClassComboBox.TabIndex = 6;
            // 
            // ThingLabel
            // 
            this.ThingLabel.AutoSize = true;
            this.ThingLabel.Location = new System.Drawing.Point(12, 36);
            this.ThingLabel.Name = "ThingLabel";
            this.ThingLabel.Size = new System.Drawing.Size(52, 13);
            this.ThingLabel.TabIndex = 9;
            this.ThingLabel.Text = "Предмет";
            // 
            // ThingComboBox
            // 
            this.ThingComboBox.FormattingEnabled = true;
            this.ThingComboBox.Location = new System.Drawing.Point(109, 33);
            this.ThingComboBox.Name = "ThingComboBox";
            this.ThingComboBox.Size = new System.Drawing.Size(165, 21);
            this.ThingComboBox.TabIndex = 8;
            this.ThingComboBox.SelectedIndexChanged += new System.EventHandler(this.ThingComboBox_SelectedIndexChanged);
            // 
            // AddLessonButton
            // 
            this.AddLessonButton.Location = new System.Drawing.Point(15, 172);
            this.AddLessonButton.Name = "AddLessonButton";
            this.AddLessonButton.Size = new System.Drawing.Size(259, 23);
            this.AddLessonButton.TabIndex = 10;
            this.AddLessonButton.Text = "Добавить урок";
            this.AddLessonButton.UseVisualStyleBackColor = true;
            this.AddLessonButton.Click += new System.EventHandler(this.AddLessonButton_Click);
            // 
            // Calendar
            // 
            this.Calendar.Location = new System.Drawing.Point(228, 207);
            this.Calendar.MaxSelectionCount = 1;
            this.Calendar.Name = "Calendar";
            this.Calendar.TabIndex = 23;
            this.Calendar.TodayDate = new System.DateTime(2020, 11, 28, 0, 0, 0, 0);
            this.Calendar.Visible = false;
            this.Calendar.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.CalendarDateSelected);
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Location = new System.Drawing.Point(12, 143);
            this.DateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(33, 13);
            this.DateLabel.TabIndex = 21;
            this.DateLabel.Text = "Дата";
            // 
            // DataTextBox
            // 
            this.DataTextBox.Location = new System.Drawing.Point(109, 140);
            this.DataTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.DataTextBox.Name = "DataTextBox";
            this.DataTextBox.ReadOnly = true;
            this.DataTextBox.Size = new System.Drawing.Size(165, 20);
            this.DataTextBox.TabIndex = 22;
            this.DataTextBox.Click += new System.EventHandler(this.DataTextBoxClick);
            // 
            // AddLessonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 215);
            this.Controls.Add(this.Calendar);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.DataTextBox);
            this.Controls.Add(this.AddLessonButton);
            this.Controls.Add(this.ThingLabel);
            this.Controls.Add(this.ThingComboBox);
            this.Controls.Add(this.ClassLabel);
            this.Controls.Add(this.ClassComboBox);
            this.Controls.Add(this.TeacherLabel);
            this.Controls.Add(this.TeacherComboBox);
            this.Controls.Add(this.CabinetLabel);
            this.Controls.Add(this.CabinetComboBox);
            this.Controls.Add(this.NumberLabel);
            this.Controls.Add(this.NumberComboBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AddLessonForm";
            this.Text = "Добавление урок";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox NumberComboBox;
        private System.Windows.Forms.Label NumberLabel;
        private System.Windows.Forms.Label CabinetLabel;
        private System.Windows.Forms.ComboBox CabinetComboBox;
        private System.Windows.Forms.Label TeacherLabel;
        private System.Windows.Forms.ComboBox TeacherComboBox;
        private System.Windows.Forms.Label ClassLabel;
        private System.Windows.Forms.ComboBox ClassComboBox;
        private System.Windows.Forms.Label ThingLabel;
        private System.Windows.Forms.ComboBox ThingComboBox;
        private System.Windows.Forms.Button AddLessonButton;
        private System.Windows.Forms.MonthCalendar Calendar;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.TextBox DataTextBox;
    }
}