namespace BD
{
    partial class QuestForm
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
            this.Quest1Lable = new System.Windows.Forms.Label();
            this.DayOfWeekLable = new System.Windows.Forms.Label();
            this.NumLessonLable = new System.Windows.Forms.Label();
            this.Q1Button = new System.Windows.Forms.Button();
            this.Q1ClassComboBox = new System.Windows.Forms.ComboBox();
            this.Q1WeekComboBox = new System.Windows.Forms.ComboBox();
            this.Q1NumberComboBox = new System.Windows.Forms.ComboBox();
            this.Q2ClassComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Q2Button = new System.Windows.Forms.Button();
            this.Q3Button = new System.Windows.Forms.Button();
            this.Q3TeacherComboBox = new System.Windows.Forms.ComboBox();
            this.Q3ThingComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Q4Button = new System.Windows.Forms.Button();
            this.Q4WeekComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Q4ClassComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
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
            // NumLessonLable
            // 
            this.NumLessonLable.AutoSize = true;
            this.NumLessonLable.Location = new System.Drawing.Point(12, 61);
            this.NumLessonLable.Name = "NumLessonLable";
            this.NumLessonLable.Size = new System.Drawing.Size(73, 13);
            this.NumLessonLable.TabIndex = 5;
            this.NumLessonLable.Text = "Номер урока";
            // 
            // Q1Button
            // 
            this.Q1Button.Location = new System.Drawing.Point(12, 90);
            this.Q1Button.Name = "Q1Button";
            this.Q1Button.Size = new System.Drawing.Size(188, 23);
            this.Q1Button.TabIndex = 6;
            this.Q1Button.Text = "Узнать предмет";
            this.Q1Button.UseVisualStyleBackColor = true;
            this.Q1Button.Click += new System.EventHandler(this.Q1Button_Click);
            // 
            // Q1ClassComboBox
            // 
            this.Q1ClassComboBox.FormattingEnabled = true;
            this.Q1ClassComboBox.Location = new System.Drawing.Point(89, 6);
            this.Q1ClassComboBox.Name = "Q1ClassComboBox";
            this.Q1ClassComboBox.Size = new System.Drawing.Size(111, 21);
            this.Q1ClassComboBox.TabIndex = 7;
            // 
            // Q1WeekComboBox
            // 
            this.Q1WeekComboBox.FormattingEnabled = true;
            this.Q1WeekComboBox.Location = new System.Drawing.Point(89, 32);
            this.Q1WeekComboBox.Name = "Q1WeekComboBox";
            this.Q1WeekComboBox.Size = new System.Drawing.Size(111, 21);
            this.Q1WeekComboBox.TabIndex = 8;
            // 
            // Q1NumberComboBox
            // 
            this.Q1NumberComboBox.FormattingEnabled = true;
            this.Q1NumberComboBox.Location = new System.Drawing.Point(89, 59);
            this.Q1NumberComboBox.Name = "Q1NumberComboBox";
            this.Q1NumberComboBox.Size = new System.Drawing.Size(111, 21);
            this.Q1NumberComboBox.TabIndex = 9;
            // 
            // Q2ClassComboBox
            // 
            this.Q2ClassComboBox.FormattingEnabled = true;
            this.Q2ClassComboBox.Location = new System.Drawing.Point(306, 7);
            this.Q2ClassComboBox.Name = "Q2ClassComboBox";
            this.Q2ClassComboBox.Size = new System.Drawing.Size(111, 21);
            this.Q2ClassComboBox.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(229, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Класс";
            // 
            // Q2Button
            // 
            this.Q2Button.Location = new System.Drawing.Point(232, 33);
            this.Q2Button.Name = "Q2Button";
            this.Q2Button.Size = new System.Drawing.Size(188, 23);
            this.Q2Button.TabIndex = 12;
            this.Q2Button.Text = "Узнать учителя";
            this.Q2Button.UseVisualStyleBackColor = true;
            this.Q2Button.Click += new System.EventHandler(this.Q2Button_Click);
            // 
            // Q3Button
            // 
            this.Q3Button.Location = new System.Drawing.Point(7, 181);
            this.Q3Button.Name = "Q3Button";
            this.Q3Button.Size = new System.Drawing.Size(188, 23);
            this.Q3Button.TabIndex = 13;
            this.Q3Button.Text = "Узнать классы";
            this.Q3Button.UseVisualStyleBackColor = true;
            this.Q3Button.Click += new System.EventHandler(this.Q3Button_Click);
            // 
            // Q3TeacherComboBox
            // 
            this.Q3TeacherComboBox.FormattingEnabled = true;
            this.Q3TeacherComboBox.Location = new System.Drawing.Point(84, 127);
            this.Q3TeacherComboBox.Name = "Q3TeacherComboBox";
            this.Q3TeacherComboBox.Size = new System.Drawing.Size(111, 21);
            this.Q3TeacherComboBox.TabIndex = 14;
            this.Q3TeacherComboBox.SelectedIndexChanged += new System.EventHandler(this.Q3TeacherComboBox_SelectedIndexChanged);
            // 
            // Q3ThingComboBox
            // 
            this.Q3ThingComboBox.FormattingEnabled = true;
            this.Q3ThingComboBox.Location = new System.Drawing.Point(84, 154);
            this.Q3ThingComboBox.Name = "Q3ThingComboBox";
            this.Q3ThingComboBox.Size = new System.Drawing.Size(111, 21);
            this.Q3ThingComboBox.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Предмет";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Учитель";
            // 
            // Q4Button
            // 
            this.Q4Button.Location = new System.Drawing.Point(232, 190);
            this.Q4Button.Name = "Q4Button";
            this.Q4Button.Size = new System.Drawing.Size(188, 23);
            this.Q4Button.TabIndex = 18;
            this.Q4Button.Text = "Узнать рассписание";
            this.Q4Button.UseVisualStyleBackColor = true;
            this.Q4Button.Click += new System.EventHandler(this.Q4Button_Click);
            // 
            // Q4WeekComboBox
            // 
            this.Q4WeekComboBox.FormattingEnabled = true;
            this.Q4WeekComboBox.Location = new System.Drawing.Point(309, 127);
            this.Q4WeekComboBox.Name = "Q4WeekComboBox";
            this.Q4WeekComboBox.Size = new System.Drawing.Size(111, 21);
            this.Q4WeekComboBox.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(232, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "День недели";
            // 
            // Q4ClassComboBox
            // 
            this.Q4ClassComboBox.FormattingEnabled = true;
            this.Q4ClassComboBox.Location = new System.Drawing.Point(309, 158);
            this.Q4ClassComboBox.Name = "Q4ClassComboBox";
            this.Q4ClassComboBox.Size = new System.Drawing.Size(111, 21);
            this.Q4ClassComboBox.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(232, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Класс";
            // 
            // QuestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 287);
            this.Controls.Add(this.Q4ClassComboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Q4WeekComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Q4Button);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Q3ThingComboBox);
            this.Controls.Add(this.Q3TeacherComboBox);
            this.Controls.Add(this.Q3Button);
            this.Controls.Add(this.Q2Button);
            this.Controls.Add(this.Q2ClassComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Q1NumberComboBox);
            this.Controls.Add(this.Q1WeekComboBox);
            this.Controls.Add(this.Q1ClassComboBox);
            this.Controls.Add(this.Q1Button);
            this.Controls.Add(this.NumLessonLable);
            this.Controls.Add(this.DayOfWeekLable);
            this.Controls.Add(this.Quest1Lable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "QuestForm";
            this.Text = "Quest1Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Quest1Lable;
        private System.Windows.Forms.Label DayOfWeekLable;
        private System.Windows.Forms.Label NumLessonLable;
        private System.Windows.Forms.Button Q1Button;
        private System.Windows.Forms.ComboBox Q1ClassComboBox;
        private System.Windows.Forms.ComboBox Q1WeekComboBox;
        private System.Windows.Forms.ComboBox Q1NumberComboBox;
        private System.Windows.Forms.ComboBox Q2ClassComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Q2Button;
        private System.Windows.Forms.Button Q3Button;
        private System.Windows.Forms.ComboBox Q3TeacherComboBox;
        private System.Windows.Forms.ComboBox Q3ThingComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Q4Button;
        private System.Windows.Forms.ComboBox Q4WeekComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox Q4ClassComboBox;
        private System.Windows.Forms.Label label5;
    }
}