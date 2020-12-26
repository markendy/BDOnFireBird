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
            this.ThingLabel = new System.Windows.Forms.Label();
            this.ClassLabel = new System.Windows.Forms.Label();
            this.ShoolGradeLabel = new System.Windows.Forms.Label();
            this.DateLabel = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.StudentaNameLabel = new System.Windows.Forms.Label();
            this.ThingComboBox = new System.Windows.Forms.ComboBox();
            this.ClassComboBox = new System.Windows.Forms.ComboBox();
            this.ShoolGradeomboBox = new System.Windows.Forms.ComboBox();
            this.Calendar = new System.Windows.Forms.MonthCalendar();
            this.DataTextBox = new System.Windows.Forms.TextBox();
            this.StudentComboBox = new System.Windows.Forms.ComboBox();
            this.dataGridViewEdit = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEdit)).BeginInit();
            this.SuspendLayout();
            // 
            // ThingLabel
            // 
            this.ThingLabel.AutoSize = true;
            this.ThingLabel.Location = new System.Drawing.Point(87, 10);
            this.ThingLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ThingLabel.Name = "ThingLabel";
            this.ThingLabel.Size = new System.Drawing.Size(52, 13);
            this.ThingLabel.TabIndex = 1;
            this.ThingLabel.Text = "Предмет";
            // 
            // ClassLabel
            // 
            this.ClassLabel.AutoSize = true;
            this.ClassLabel.Location = new System.Drawing.Point(279, 9);
            this.ClassLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ClassLabel.Name = "ClassLabel";
            this.ClassLabel.Size = new System.Drawing.Size(38, 13);
            this.ClassLabel.TabIndex = 3;
            this.ClassLabel.Text = "Класс";
            // 
            // ShoolGradeLabel
            // 
            this.ShoolGradeLabel.AutoSize = true;
            this.ShoolGradeLabel.Location = new System.Drawing.Point(535, 9);
            this.ShoolGradeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ShoolGradeLabel.Name = "ShoolGradeLabel";
            this.ShoolGradeLabel.Size = new System.Drawing.Size(45, 13);
            this.ShoolGradeLabel.TabIndex = 5;
            this.ShoolGradeLabel.Text = "Оценка";
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Location = new System.Drawing.Point(8, 12);
            this.DateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(33, 13);
            this.DateLabel.TabIndex = 7;
            this.DateLabel.Text = "Дата";
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(601, 23);
            this.AddButton.Margin = new System.Windows.Forms.Padding(2);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(150, 24);
            this.AddButton.TabIndex = 9;
            this.AddButton.Text = "Поставить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButtonClick);
            // 
            // StudentaNameLabel
            // 
            this.StudentaNameLabel.AutoSize = true;
            this.StudentaNameLabel.Location = new System.Drawing.Point(343, 9);
            this.StudentaNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.StudentaNameLabel.Name = "StudentaNameLabel";
            this.StudentaNameLabel.Size = new System.Drawing.Size(44, 13);
            this.StudentaNameLabel.TabIndex = 12;
            this.StudentaNameLabel.Text = "Ученик";
            // 
            // ThingComboBox
            // 
            this.ThingComboBox.FormattingEnabled = true;
            this.ThingComboBox.Location = new System.Drawing.Point(90, 26);
            this.ThingComboBox.Name = "ThingComboBox";
            this.ThingComboBox.Size = new System.Drawing.Size(186, 21);
            this.ThingComboBox.TabIndex = 15;
            this.ThingComboBox.SelectedIndexChanged += new System.EventHandler(this.ThingComboBoxSelectedIndexChanged);
            // 
            // ClassComboBox
            // 
            this.ClassComboBox.FormattingEnabled = true;
            this.ClassComboBox.Location = new System.Drawing.Point(282, 26);
            this.ClassComboBox.Name = "ClassComboBox";
            this.ClassComboBox.Size = new System.Drawing.Size(58, 21);
            this.ClassComboBox.TabIndex = 16;
            this.ClassComboBox.SelectedIndexChanged += new System.EventHandler(this.ClassComboBoxSelectedIndexChanged);
            // 
            // ShoolGradeomboBox
            // 
            this.ShoolGradeomboBox.FormattingEnabled = true;
            this.ShoolGradeomboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.ShoolGradeomboBox.Location = new System.Drawing.Point(538, 26);
            this.ShoolGradeomboBox.Name = "ShoolGradeomboBox";
            this.ShoolGradeomboBox.Size = new System.Drawing.Size(58, 21);
            this.ShoolGradeomboBox.TabIndex = 17;
            this.ShoolGradeomboBox.SelectedIndexChanged += new System.EventHandler(this.ShoolGradeLabelComboBoxSelectedIndexChanged);
            // 
            // Calendar
            // 
            this.Calendar.Location = new System.Drawing.Point(586, 265);
            this.Calendar.MaxSelectionCount = 1;
            this.Calendar.Name = "Calendar";
            this.Calendar.TabIndex = 20;
            this.Calendar.TodayDate = new System.DateTime(2020, 11, 28, 0, 0, 0, 0);
            this.Calendar.Visible = false;
            this.Calendar.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.CalendarDateSelected);
            // 
            // DataTextBox
            // 
            this.DataTextBox.Location = new System.Drawing.Point(12, 26);
            this.DataTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.DataTextBox.Name = "DataTextBox";
            this.DataTextBox.ReadOnly = true;
            this.DataTextBox.Size = new System.Drawing.Size(66, 20);
            this.DataTextBox.TabIndex = 19;
            this.DataTextBox.Text = "20.20.2020";
            this.DataTextBox.Click += new System.EventHandler(this.DataTextBoxClick);
            // 
            // StudentComboBox
            // 
            this.StudentComboBox.FormattingEnabled = true;
            this.StudentComboBox.Location = new System.Drawing.Point(346, 26);
            this.StudentComboBox.Name = "StudentComboBox";
            this.StudentComboBox.Size = new System.Drawing.Size(186, 21);
            this.StudentComboBox.TabIndex = 21;
            this.StudentComboBox.SelectedIndexChanged += new System.EventHandler(this.StudentComboBoxSelectedIndexChanged);
            // 
            // dataGridViewEdit
            // 
            this.dataGridViewEdit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEdit.Location = new System.Drawing.Point(12, 83);
            this.dataGridViewEdit.Name = "dataGridViewEdit";
            this.dataGridViewEdit.Size = new System.Drawing.Size(739, 213);
            this.dataGridViewEdit.TabIndex = 23;
            this.dataGridViewEdit.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewEdit_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Для изменения оценки выберете необходимую строку";
            // 
            // AddShoolGradeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 317);
            this.Controls.Add(this.Calendar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewEdit);
            this.Controls.Add(this.StudentaNameLabel);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.ShoolGradeLabel);
            this.Controls.Add(this.ClassLabel);
            this.Controls.Add(this.ThingLabel);
            this.Controls.Add(this.DataTextBox);
            this.Controls.Add(this.ShoolGradeomboBox);
            this.Controls.Add(this.StudentComboBox);
            this.Controls.Add(this.ClassComboBox);
            this.Controls.Add(this.ThingComboBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "AddShoolGradeForm";
            this.Text = "Поставить/именить оценку";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEdit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label ThingLabel;
        private System.Windows.Forms.Label ClassLabel;
        private System.Windows.Forms.Label ShoolGradeLabel;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Label StudentaNameLabel;
        private System.Windows.Forms.ComboBox ThingComboBox;
        private System.Windows.Forms.ComboBox ClassComboBox;
        private System.Windows.Forms.ComboBox ShoolGradeomboBox;
        private System.Windows.Forms.MonthCalendar Calendar;
        private System.Windows.Forms.TextBox DataTextBox;
        private System.Windows.Forms.ComboBox StudentComboBox;
        private System.Windows.Forms.DataGridView dataGridViewEdit;
        private System.Windows.Forms.Label label1;
    }
}