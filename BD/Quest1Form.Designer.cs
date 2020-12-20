namespace BD
{
    partial class Quest1Form
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
            this.Quest1Lable = new System.Windows.Forms.Label();
            this.DayOfWeekLable = new System.Windows.Forms.Label();
            this.DayOfWeekTextBox = new System.Windows.Forms.TextBox();
            this.NumLessonLable = new System.Windows.Forms.Label();
            this.NumLessonTextBox = new System.Windows.Forms.TextBox();
            this.ThingButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ClassTextBox
            // 
            this.ClassTextBox.Location = new System.Drawing.Point(91, 6);
            this.ClassTextBox.Name = "ClassTextBox";
            this.ClassTextBox.Size = new System.Drawing.Size(100, 20);
            this.ClassTextBox.TabIndex = 0;
            // 
            // Quest1Lable
            // 
            this.Quest1Lable.AutoSize = true;
            this.Quest1Lable.Location = new System.Drawing.Point(12, 9);
            this.Quest1Lable.Name = "Quest1Lable";
            this.Quest1Lable.Size = new System.Drawing.Size(38, 13);
            this.Quest1Lable.TabIndex = 1;
            this.Quest1Lable.Text = "Класс";
            // 
            // DayOfWeekLable
            // 
            this.DayOfWeekLable.AutoSize = true;
            this.DayOfWeekLable.Location = new System.Drawing.Point(12, 35);
            this.DayOfWeekLable.Name = "DayOfWeekLable";
            this.DayOfWeekLable.Size = new System.Drawing.Size(73, 13);
            this.DayOfWeekLable.TabIndex = 3;
            this.DayOfWeekLable.Text = "День недели";
            // 
            // DayOfWeekTextBox
            // 
            this.DayOfWeekTextBox.Location = new System.Drawing.Point(91, 32);
            this.DayOfWeekTextBox.Name = "DayOfWeekTextBox";
            this.DayOfWeekTextBox.Size = new System.Drawing.Size(100, 20);
            this.DayOfWeekTextBox.TabIndex = 2;
            // 
            // NumLessonLable
            // 
            this.NumLessonLable.AutoSize = true;
            this.NumLessonLable.Location = new System.Drawing.Point(12, 61);
            this.NumLessonLable.Name = "NumLessonLable";
            this.NumLessonLable.Size = new System.Drawing.Size(73, 13);
            this.NumLessonLable.TabIndex = 5;
            this.NumLessonLable.Text = "Номер урока";
            // 
            // NumLessonTextBox
            // 
            this.NumLessonTextBox.Location = new System.Drawing.Point(91, 58);
            this.NumLessonTextBox.Name = "NumLessonTextBox";
            this.NumLessonTextBox.Size = new System.Drawing.Size(100, 20);
            this.NumLessonTextBox.TabIndex = 4;
            // 
            // ThingButton
            // 
            this.ThingButton.Location = new System.Drawing.Point(12, 90);
            this.ThingButton.Name = "ThingButton";
            this.ThingButton.Size = new System.Drawing.Size(179, 23);
            this.ThingButton.TabIndex = 6;
            this.ThingButton.Text = "Узнать предмет";
            this.ThingButton.UseVisualStyleBackColor = true;
            this.ThingButton.Click += new System.EventHandler(this.ThingButton_Click);
            // 
            // Quest1Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(212, 129);
            this.Controls.Add(this.ThingButton);
            this.Controls.Add(this.NumLessonLable);
            this.Controls.Add(this.NumLessonTextBox);
            this.Controls.Add(this.DayOfWeekLable);
            this.Controls.Add(this.DayOfWeekTextBox);
            this.Controls.Add(this.Quest1Lable);
            this.Controls.Add(this.ClassTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Quest1Form";
            this.Text = "Quest1Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ClassTextBox;
        private System.Windows.Forms.Label Quest1Lable;
        private System.Windows.Forms.Label DayOfWeekLable;
        private System.Windows.Forms.TextBox DayOfWeekTextBox;
        private System.Windows.Forms.Label NumLessonLable;
        private System.Windows.Forms.TextBox NumLessonTextBox;
        private System.Windows.Forms.Button ThingButton;
    }
}