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
            this.CabinetTextBox = new System.Windows.Forms.TextBox();
            this.CabinetLabel = new System.Windows.Forms.Label();
            this.CabinetComboBox = new System.Windows.Forms.ComboBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.LoginTextBox = new System.Windows.Forms.TextBox();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.ThingListBox = new System.Windows.Forms.ListBox();
            this.ThingTextBox = new System.Windows.Forms.TextBox();
            this.AddThingButton = new System.Windows.Forms.Button();
            this.AddCabinetButton = new System.Windows.Forms.Button();
            this.LastNameСomboBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.DelTeacherLabel = new System.Windows.Forms.Label();
            this.MiddleNameСomboBox = new System.Windows.Forms.ComboBox();
            this.FirstNameСomboBox = new System.Windows.Forms.ComboBox();
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
            // CabinetTextBox
            // 
            this.CabinetTextBox.Location = new System.Drawing.Point(218, 167);
            this.CabinetTextBox.Name = "CabinetTextBox";
            this.CabinetTextBox.Size = new System.Drawing.Size(132, 20);
            this.CabinetTextBox.TabIndex = 4;
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
            this.CabinetComboBox.SelectedIndexChanged += new System.EventHandler(this.CabinetComboBox_SelectedIndexChanged);
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
            this.PasswordTextBox.PasswordChar = '&';
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
            // AddThingButton
            // 
            this.AddThingButton.Location = new System.Drawing.Point(216, 129);
            this.AddThingButton.Name = "AddThingButton";
            this.AddThingButton.Size = new System.Drawing.Size(132, 23);
            this.AddThingButton.TabIndex = 14;
            this.AddThingButton.Text = "Новый предмет";
            this.AddThingButton.UseVisualStyleBackColor = true;
            this.AddThingButton.Click += new System.EventHandler(this.AddNewButton_Click);
            // 
            // AddCabinetButton
            // 
            this.AddCabinetButton.Location = new System.Drawing.Point(216, 194);
            this.AddCabinetButton.Name = "AddCabinetButton";
            this.AddCabinetButton.Size = new System.Drawing.Size(132, 23);
            this.AddCabinetButton.TabIndex = 15;
            this.AddCabinetButton.Text = "Новый кабинет";
            this.AddCabinetButton.UseVisualStyleBackColor = true;
            this.AddCabinetButton.Click += new System.EventHandler(this.AddCabinetButton_Click);
            // 
            // LastNameСomboBox
            // 
            this.LastNameСomboBox.FormattingEnabled = true;
            this.LastNameСomboBox.Location = new System.Drawing.Point(395, 226);
            this.LastNameСomboBox.Name = "LastNameСomboBox";
            this.LastNameСomboBox.Size = new System.Drawing.Size(110, 21);
            this.LastNameСomboBox.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(393, 265);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(344, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Удалить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // DelTeacherLabel
            // 
            this.DelTeacherLabel.AutoSize = true;
            this.DelTeacherLabel.Location = new System.Drawing.Point(548, 199);
            this.DelTeacherLabel.Name = "DelTeacherLabel";
            this.DelTeacherLabel.Size = new System.Drawing.Size(49, 13);
            this.DelTeacherLabel.TabIndex = 20;
            this.DelTeacherLabel.Text = "Учитель";
            // 
            // MiddleNameСomboBox
            // 
            this.MiddleNameСomboBox.FormattingEnabled = true;
            this.MiddleNameСomboBox.Location = new System.Drawing.Point(511, 226);
            this.MiddleNameСomboBox.Name = "MiddleNameСomboBox";
            this.MiddleNameСomboBox.Size = new System.Drawing.Size(110, 21);
            this.MiddleNameСomboBox.TabIndex = 21;
            // 
            // FirstNameСomboBox
            // 
            this.FirstNameСomboBox.FormattingEnabled = true;
            this.FirstNameСomboBox.Location = new System.Drawing.Point(627, 226);
            this.FirstNameСomboBox.Name = "FirstNameСomboBox";
            this.FirstNameСomboBox.Size = new System.Drawing.Size(110, 21);
            this.FirstNameСomboBox.TabIndex = 22;
            // 
            // AddTeacherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 300);
            this.Controls.Add(this.FirstNameСomboBox);
            this.Controls.Add(this.MiddleNameСomboBox);
            this.Controls.Add(this.DelTeacherLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LastNameСomboBox);
            this.Controls.Add(this.AddCabinetButton);
            this.Controls.Add(this.AddThingButton);
            this.Controls.Add(this.ThingListBox);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.LoginLabel);
            this.Controls.Add(this.LoginTextBox);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.CabinetComboBox);
            this.Controls.Add(this.CabinetLabel);
            this.Controls.Add(this.CabinetTextBox);
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
        private System.Windows.Forms.TextBox CabinetTextBox;
        private System.Windows.Forms.Label CabinetLabel;
        private System.Windows.Forms.ComboBox CabinetComboBox;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.TextBox LoginTextBox;
        private System.Windows.Forms.Label LoginLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.ListBox ThingListBox;
        private System.Windows.Forms.TextBox ThingTextBox;
        private System.Windows.Forms.Button AddThingButton;
        private System.Windows.Forms.Button AddCabinetButton;
        private System.Windows.Forms.ComboBox LastNameСomboBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label DelTeacherLabel;
        private System.Windows.Forms.ComboBox MiddleNameСomboBox;
        private System.Windows.Forms.ComboBox FirstNameСomboBox;
    }
}