namespace BD
{
    partial class AddStudentForm
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
            this.StudentFirstNameTextBox = new System.Windows.Forms.TextBox();
            this.StudentFirstNameLable = new System.Windows.Forms.Label();
            this.StudentLastNameLable = new System.Windows.Forms.Label();
            this.StudentLastNameTextBox = new System.Windows.Forms.TextBox();
            this.StudentClassLable = new System.Windows.Forms.Label();
            this.StudentClassComboBox = new System.Windows.Forms.ComboBox();
            this.AddStudentButton = new System.Windows.Forms.Button();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.LoginTextBox = new System.Windows.Forms.TextBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.DelFirstNameComboBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // StudentFirstNameTextBox
            // 
            this.StudentFirstNameTextBox.Location = new System.Drawing.Point(74, 6);
            this.StudentFirstNameTextBox.Name = "StudentFirstNameTextBox";
            this.StudentFirstNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.StudentFirstNameTextBox.TabIndex = 0;
            // 
            // StudentFirstNameLable
            // 
            this.StudentFirstNameLable.AutoSize = true;
            this.StudentFirstNameLable.Location = new System.Drawing.Point(12, 9);
            this.StudentFirstNameLable.Name = "StudentFirstNameLable";
            this.StudentFirstNameLable.Size = new System.Drawing.Size(29, 13);
            this.StudentFirstNameLable.TabIndex = 1;
            this.StudentFirstNameLable.Text = "Имя";
            // 
            // StudentLastNameLable
            // 
            this.StudentLastNameLable.AutoSize = true;
            this.StudentLastNameLable.Location = new System.Drawing.Point(12, 35);
            this.StudentLastNameLable.Name = "StudentLastNameLable";
            this.StudentLastNameLable.Size = new System.Drawing.Size(56, 13);
            this.StudentLastNameLable.TabIndex = 3;
            this.StudentLastNameLable.Text = "Фамилия";
            // 
            // StudentLastNameTextBox
            // 
            this.StudentLastNameTextBox.Location = new System.Drawing.Point(74, 32);
            this.StudentLastNameTextBox.Name = "StudentLastNameTextBox";
            this.StudentLastNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.StudentLastNameTextBox.TabIndex = 2;
            // 
            // StudentClassLable
            // 
            this.StudentClassLable.AutoSize = true;
            this.StudentClassLable.Location = new System.Drawing.Point(12, 61);
            this.StudentClassLable.Name = "StudentClassLable";
            this.StudentClassLable.Size = new System.Drawing.Size(38, 13);
            this.StudentClassLable.TabIndex = 5;
            this.StudentClassLable.Text = "Класс";
            // 
            // StudentClassComboBox
            // 
            this.StudentClassComboBox.FormattingEnabled = true;
            this.StudentClassComboBox.Location = new System.Drawing.Point(74, 61);
            this.StudentClassComboBox.Name = "StudentClassComboBox";
            this.StudentClassComboBox.Size = new System.Drawing.Size(100, 21);
            this.StudentClassComboBox.TabIndex = 6;
            // 
            // AddStudentButton
            // 
            this.AddStudentButton.Location = new System.Drawing.Point(15, 158);
            this.AddStudentButton.Name = "AddStudentButton";
            this.AddStudentButton.Size = new System.Drawing.Size(159, 23);
            this.AddStudentButton.TabIndex = 7;
            this.AddStudentButton.Text = "Добавить ученика";
            this.AddStudentButton.UseVisualStyleBackColor = true;
            this.AddStudentButton.Click += new System.EventHandler(this.AddStudentButton_Click);
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.Location = new System.Drawing.Point(12, 91);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(38, 13);
            this.LoginLabel.TabIndex = 9;
            this.LoginLabel.Text = "Логин";
            // 
            // LoginTextBox
            // 
            this.LoginTextBox.Location = new System.Drawing.Point(74, 88);
            this.LoginTextBox.Name = "LoginTextBox";
            this.LoginTextBox.Size = new System.Drawing.Size(100, 20);
            this.LoginTextBox.TabIndex = 8;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(12, 117);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(45, 13);
            this.PasswordLabel.TabIndex = 11;
            this.PasswordLabel.Text = "Пароль";
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(74, 114);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '#';
            this.PasswordTextBox.Size = new System.Drawing.Size(100, 20);
            this.PasswordTextBox.TabIndex = 10;
            // 
            // DelFirstNameComboBox
            // 
            this.DelFirstNameComboBox.FormattingEnabled = true;
            this.DelFirstNameComboBox.Location = new System.Drawing.Point(219, 61);
            this.DelFirstNameComboBox.Name = "DelFirstNameComboBox";
            this.DelFirstNameComboBox.Size = new System.Drawing.Size(159, 21);
            this.DelFirstNameComboBox.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(219, 88);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Удалить ученика";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.DelStud);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(272, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Ученик";
            // 
            // AddStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 193);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DelFirstNameComboBox);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.LoginLabel);
            this.Controls.Add(this.LoginTextBox);
            this.Controls.Add(this.AddStudentButton);
            this.Controls.Add(this.StudentClassComboBox);
            this.Controls.Add(this.StudentClassLable);
            this.Controls.Add(this.StudentLastNameLable);
            this.Controls.Add(this.StudentLastNameTextBox);
            this.Controls.Add(this.StudentFirstNameLable);
            this.Controls.Add(this.StudentFirstNameTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AddStudentForm";
            this.Text = "Добавление ученика";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox StudentFirstNameTextBox;
        private System.Windows.Forms.Label StudentFirstNameLable;
        private System.Windows.Forms.Label StudentLastNameLable;
        private System.Windows.Forms.TextBox StudentLastNameTextBox;
        private System.Windows.Forms.Label StudentClassLable;
        private System.Windows.Forms.ComboBox StudentClassComboBox;
        private System.Windows.Forms.Button AddStudentButton;
        private System.Windows.Forms.Label LoginLabel;
        private System.Windows.Forms.TextBox LoginTextBox;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.ComboBox DelFirstNameComboBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}