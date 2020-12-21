namespace BD
{
    partial class AddTeacherForm
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
            this.TeacherFullNameLabelTextBox = new System.Windows.Forms.TextBox();
            this.TeacherFullNameLabel = new System.Windows.Forms.Label();
            this.ThingLabel = new System.Windows.Forms.Label();
            this.CabinetLabelTextBox = new System.Windows.Forms.TextBox();
            this.CabinetLabel = new System.Windows.Forms.Label();
            this.CabinetComboBox = new System.Windows.Forms.ComboBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.LoginTextBox = new System.Windows.Forms.TextBox();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.ThingListBox = new System.Windows.Forms.ListBox();
            this.ThingTextBox = new System.Windows.Forms.TextBox();
            this.AddNewButton = new System.Windows.Forms.Button();
            this.AddCabinetButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TeacherFullNameLabelTextBox
            // 
            this.TeacherFullNameLabelTextBox.Location = new System.Drawing.Point(67, 12);
            this.TeacherFullNameLabelTextBox.Name = "TeacherFullNameLabelTextBox";
            this.TeacherFullNameLabelTextBox.Size = new System.Drawing.Size(283, 20);
            this.TeacherFullNameLabelTextBox.TabIndex = 0;
            // 
            // TeacherFullNameLabel
            // 
            this.TeacherFullNameLabel.AutoSize = true;
            this.TeacherFullNameLabel.Location = new System.Drawing.Point(12, 15);
            this.TeacherFullNameLabel.Name = "TeacherFullNameLabel";
            this.TeacherFullNameLabel.Size = new System.Drawing.Size(34, 13);
            this.TeacherFullNameLabel.TabIndex = 1;
            this.TeacherFullNameLabel.Text = "ФИО";
            // 
            // ThingLabel
            // 
            this.ThingLabel.AutoSize = true;
            this.ThingLabel.Location = new System.Drawing.Point(7, 99);
            this.ThingLabel.Name = "ThingLabel";
            this.ThingLabel.Size = new System.Drawing.Size(52, 13);
            this.ThingLabel.TabIndex = 3;
            this.ThingLabel.Text = "Предмет";
            // 
            // CabinetLabelTextBox
            // 
            this.CabinetLabelTextBox.Location = new System.Drawing.Point(218, 167);
            this.CabinetLabelTextBox.Name = "CabinetLabelTextBox";
            this.CabinetLabelTextBox.Size = new System.Drawing.Size(132, 20);
            this.CabinetLabelTextBox.TabIndex = 4;
            // 
            // CabinetLabel
            // 
            this.CabinetLabel.AutoSize = true;
            this.CabinetLabel.Location = new System.Drawing.Point(9, 170);
            this.CabinetLabel.Name = "CabinetLabel";
            this.CabinetLabel.Size = new System.Drawing.Size(49, 13);
            this.CabinetLabel.TabIndex = 5;
            this.CabinetLabel.Text = "Кабинет";
            // 
            // CabinetComboBox
            // 
            this.CabinetComboBox.FormattingEnabled = true;
            this.CabinetComboBox.Location = new System.Drawing.Point(70, 167);
            this.CabinetComboBox.Name = "CabinetComboBox";
            this.CabinetComboBox.Size = new System.Drawing.Size(142, 21);
            this.CabinetComboBox.TabIndex = 7;
            this.CabinetComboBox.SelectedIndexChanged += new System.EventHandler(this.CabinetLabelComboBox_SelectedIndexChanged);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(14, 265);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(336, 23);
            this.AddButton.TabIndex = 8;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButtonClick);
            // 
            // LoginTextBox
            // 
            this.LoginTextBox.Location = new System.Drawing.Point(70, 61);
            this.LoginTextBox.Name = "LoginTextBox";
            this.LoginTextBox.Size = new System.Drawing.Size(132, 20);
            this.LoginTextBox.TabIndex = 9;
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.Location = new System.Drawing.Point(67, 45);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(38, 13);
            this.LoginLabel.TabIndex = 10;
            this.LoginLabel.Text = "Логин";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(213, 45);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(45, 13);
            this.PasswordLabel.TabIndex = 12;
            this.PasswordLabel.Text = "Пароль";
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(216, 61);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(132, 20);
            this.PasswordTextBox.TabIndex = 11;
            // 
            // ThingListBox
            // 
            this.ThingListBox.FormattingEnabled = true;
            this.ThingListBox.Location = new System.Drawing.Point(70, 96);
            this.ThingListBox.Name = "ThingListBox";
            this.ThingListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.ThingListBox.Size = new System.Drawing.Size(132, 56);
            this.ThingListBox.TabIndex = 13;
            // 
            // ThingTextBox
            // 
            this.ThingTextBox.Location = new System.Drawing.Point(216, 96);
            this.ThingTextBox.Name = "ThingTextBox";
            this.ThingTextBox.Size = new System.Drawing.Size(132, 20);
            this.ThingTextBox.TabIndex = 2;
            // 
            // AddNewButton
            // 
            this.AddNewButton.Location = new System.Drawing.Point(216, 129);
            this.AddNewButton.Name = "AddNewButton";
            this.AddNewButton.Size = new System.Drawing.Size(132, 23);
            this.AddNewButton.TabIndex = 14;
            this.AddNewButton.Text = "Новый предмет";
            this.AddNewButton.UseVisualStyleBackColor = true;
            this.AddNewButton.Click += new System.EventHandler(this.AddNewButton_Click);
            // 
            // AddCabinetButton
            // 
            this.AddCabinetButton.Location = new System.Drawing.Point(216, 194);
            this.AddCabinetButton.Name = "AddCabinetButton";
            this.AddCabinetButton.Size = new System.Drawing.Size(132, 23);
            this.AddCabinetButton.TabIndex = 15;
            this.AddCabinetButton.Text = "Новый кабинет";
            this.AddCabinetButton.UseVisualStyleBackColor = true;
            this.AddCabinetButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddTeacherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 300);
            this.Controls.Add(this.AddCabinetButton);
            this.Controls.Add(this.AddNewButton);
            this.Controls.Add(this.ThingListBox);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.LoginLabel);
            this.Controls.Add(this.LoginTextBox);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.CabinetComboBox);
            this.Controls.Add(this.CabinetLabel);
            this.Controls.Add(this.CabinetLabelTextBox);
            this.Controls.Add(this.ThingLabel);
            this.Controls.Add(this.ThingTextBox);
            this.Controls.Add(this.TeacherFullNameLabel);
            this.Controls.Add(this.TeacherFullNameLabelTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "AddTeacherForm";
            this.Text = "AddTeacher";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TeacherFullNameLabelTextBox;
        private System.Windows.Forms.Label TeacherFullNameLabel;
        private System.Windows.Forms.Label ThingLabel;
        private System.Windows.Forms.TextBox CabinetLabelTextBox;
        private System.Windows.Forms.Label CabinetLabel;
        private System.Windows.Forms.ComboBox CabinetComboBox;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.TextBox LoginTextBox;
        private System.Windows.Forms.Label LoginLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.ListBox ThingListBox;
        private System.Windows.Forms.TextBox ThingTextBox;
        private System.Windows.Forms.Button AddNewButton;
        private System.Windows.Forms.Button AddCabinetButton;
    }
}