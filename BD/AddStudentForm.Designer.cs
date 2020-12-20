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
            this.AddStudentButton.Location = new System.Drawing.Point(15, 88);
            this.AddStudentButton.Name = "AddStudentButton";
            this.AddStudentButton.Size = new System.Drawing.Size(159, 23);
            this.AddStudentButton.TabIndex = 7;
            this.AddStudentButton.Text = "Добавить ученика";
            this.AddStudentButton.UseVisualStyleBackColor = true;
            this.AddStudentButton.Click += new System.EventHandler(this.AddStudentButton_Click);
            // 
            // AddStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(190, 116);
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
            this.Text = "AddStudentForm";
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
    }
}