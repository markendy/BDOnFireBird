namespace BD
{
    partial class AddClassForm
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
            this.ClassNameLable = new System.Windows.Forms.Label();
            this.AddClassButton = new System.Windows.Forms.Button();
            this.ClassNameTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ClassNameLable
            // 
            this.ClassNameLable.AutoSize = true;
            this.ClassNameLable.Location = new System.Drawing.Point(12, 24);
            this.ClassNameLable.Name = "ClassNameLable";
            this.ClassNameLable.Size = new System.Drawing.Size(124, 13);
            this.ClassNameLable.TabIndex = 1;
            this.ClassNameLable.Text = "Название класса (11А)";
            // 
            // AddClassButton
            // 
            this.AddClassButton.Location = new System.Drawing.Point(15, 57);
            this.AddClassButton.Name = "AddClassButton";
            this.AddClassButton.Size = new System.Drawing.Size(248, 23);
            this.AddClassButton.TabIndex = 2;
            this.AddClassButton.Text = "Добавить";
            this.AddClassButton.UseVisualStyleBackColor = true;
            this.AddClassButton.Click += new System.EventHandler(this.AddClassButton_Click);
            // 
            // ClassNameTextBox
            // 
            this.ClassNameTextBox.Location = new System.Drawing.Point(143, 21);
            this.ClassNameTextBox.Name = "ClassNameTextBox";
            this.ClassNameTextBox.Size = new System.Drawing.Size(120, 20);
            this.ClassNameTextBox.TabIndex = 3;
            // 
            // AddClassForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 92);
            this.Controls.Add(this.ClassNameTextBox);
            this.Controls.Add(this.AddClassButton);
            this.Controls.Add(this.ClassNameLable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AddClassForm";
            this.Text = "Добавление класса";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label ClassNameLable;
        private System.Windows.Forms.Button AddClassButton;
        private System.Windows.Forms.TextBox ClassNameTextBox;
    }
}