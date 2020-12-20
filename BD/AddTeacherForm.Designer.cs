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
            this.ThingTextBox = new System.Windows.Forms.TextBox();
            this.ThingLabel = new System.Windows.Forms.Label();
            this.CabinetLabelTextBox = new System.Windows.Forms.TextBox();
            this.CabinetLabel = new System.Windows.Forms.Label();
            this.ThingComboBox = new System.Windows.Forms.ComboBox();
            this.CabinetLabelComboBox = new System.Windows.Forms.ComboBox();
            this.AddButton = new System.Windows.Forms.Button();
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
            // ThingTextBox
            // 
            this.ThingTextBox.Location = new System.Drawing.Point(218, 131);
            this.ThingTextBox.Name = "ThingTextBox";
            this.ThingTextBox.Size = new System.Drawing.Size(132, 20);
            this.ThingTextBox.TabIndex = 2;
            // 
            // ThingLabel
            // 
            this.ThingLabel.AutoSize = true;
            this.ThingLabel.Location = new System.Drawing.Point(9, 134);
            this.ThingLabel.Name = "ThingLabel";
            this.ThingLabel.Size = new System.Drawing.Size(52, 13);
            this.ThingLabel.TabIndex = 3;
            this.ThingLabel.Text = "Предмет";
            // 
            // CabinetLabelTextBox
            // 
            this.CabinetLabelTextBox.Location = new System.Drawing.Point(218, 158);
            this.CabinetLabelTextBox.Name = "CabinetLabelTextBox";
            this.CabinetLabelTextBox.Size = new System.Drawing.Size(132, 20);
            this.CabinetLabelTextBox.TabIndex = 4;
            // 
            // CabinetLabel
            // 
            this.CabinetLabel.AutoSize = true;
            this.CabinetLabel.Location = new System.Drawing.Point(9, 161);
            this.CabinetLabel.Name = "CabinetLabel";
            this.CabinetLabel.Size = new System.Drawing.Size(49, 13);
            this.CabinetLabel.TabIndex = 5;
            this.CabinetLabel.Text = "Кабинет";
            // 
            // ThingComboBox
            // 
            this.ThingComboBox.FormattingEnabled = true;
            this.ThingComboBox.Location = new System.Drawing.Point(67, 131);
            this.ThingComboBox.Name = "ThingComboBox";
            this.ThingComboBox.Size = new System.Drawing.Size(145, 21);
            this.ThingComboBox.TabIndex = 6;
            // 
            // CabinetLabelComboBox
            // 
            this.CabinetLabelComboBox.FormattingEnabled = true;
            this.CabinetLabelComboBox.Location = new System.Drawing.Point(67, 158);
            this.CabinetLabelComboBox.Name = "CabinetLabelComboBox";
            this.CabinetLabelComboBox.Size = new System.Drawing.Size(145, 21);
            this.CabinetLabelComboBox.TabIndex = 7;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(15, 205);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(336, 23);
            this.AddButton.TabIndex = 8;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButtonClick);
            // 
            // AddTeacherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 240);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.CabinetLabelComboBox);
            this.Controls.Add(this.ThingComboBox);
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
        private System.Windows.Forms.TextBox ThingTextBox;
        private System.Windows.Forms.Label ThingLabel;
        private System.Windows.Forms.TextBox CabinetLabelTextBox;
        private System.Windows.Forms.Label CabinetLabel;
        private System.Windows.Forms.ComboBox ThingComboBox;
        private System.Windows.Forms.ComboBox CabinetLabelComboBox;
        private System.Windows.Forms.Button AddButton;
    }
}