namespace eSchool
{
    partial class fullMixAddForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxClassName = new System.Windows.Forms.ComboBox();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxTeacherSubject = new System.Windows.Forms.ComboBox();
            this.comboBoxScheduleD = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Класс";
            // 
            // comboBoxClassName
            // 
            this.comboBoxClassName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxClassName.FormattingEnabled = true;
            this.comboBoxClassName.Location = new System.Drawing.Point(306, 132);
            this.comboBoxClassName.Name = "comboBoxClassName";
            this.comboBoxClassName.Size = new System.Drawing.Size(101, 36);
            this.comboBoxClassName.TabIndex = 4;
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(135, 275);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(120, 50);
            this.buttonReset.TabIndex = 6;
            this.buttonReset.Text = "Очистить";
            this.buttonReset.UseVisualStyleBackColor = true;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(339, 275);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(120, 50);
            this.buttonAdd.TabIndex = 7;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(142, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 28);
            this.label4.TabIndex = 10;
            this.label4.Text = "ID учителя";
            // 
            // comboBoxTeacherSubject
            // 
            this.comboBoxTeacherSubject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTeacherSubject.FormattingEnabled = true;
            this.comboBoxTeacherSubject.Location = new System.Drawing.Point(306, 34);
            this.comboBoxTeacherSubject.Name = "comboBoxTeacherSubject";
            this.comboBoxTeacherSubject.Size = new System.Drawing.Size(153, 36);
            this.comboBoxTeacherSubject.TabIndex = 11;
            // 
            // comboBoxScheduleD
            // 
            this.comboBoxScheduleD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxScheduleD.FormattingEnabled = true;
            this.comboBoxScheduleD.Location = new System.Drawing.Point(306, 180);
            this.comboBoxScheduleD.Name = "comboBoxScheduleD";
            this.comboBoxScheduleD.Size = new System.Drawing.Size(200, 36);
            this.comboBoxScheduleD.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(51, 183);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(148, 28);
            this.label8.TabIndex = 12;
            this.label8.Text = "Расписание";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(306, 76);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(153, 36);
            this.comboBox1.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(142, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 28);
            this.label1.TabIndex = 14;
            this.label1.Text = "Предметы";
            // 
            // fullMixAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(562, 383);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.comboBoxScheduleD);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboBoxTeacherSubject);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.comboBoxClassName);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "fullMixAddForm";
            this.Text = "fullMixAddForm";
            this.Load += new System.EventHandler(this.fullMixAddForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxClassName;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxTeacherSubject;
        private System.Windows.Forms.ComboBox comboBoxScheduleD;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
    }
}