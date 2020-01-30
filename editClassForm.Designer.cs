namespace eSchool
{
    partial class editClassForm
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
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownNumberPupil = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownClassRoom = new System.Windows.Forms.NumericUpDown();
            this.comboBoxClassName = new System.Windows.Forms.ComboBox();
            this.textBoxNewClassName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumberPupil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownClassRoom)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.Navy;
            this.buttonEdit.ForeColor = System.Drawing.Color.Snow;
            this.buttonEdit.Location = new System.Drawing.Point(232, 189);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(110, 50);
            this.buttonEdit.TabIndex = 15;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.BackColor = System.Drawing.Color.Crimson;
            this.buttonRemove.ForeColor = System.Drawing.Color.Snow;
            this.buttonRemove.Location = new System.Drawing.Point(16, 189);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(110, 50);
            this.buttonRemove.TabIndex = 14;
            this.buttonRemove.Text = "Удалить";
            this.buttonRemove.UseVisualStyleBackColor = false;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(207, 23);
            this.label3.TabIndex = 13;
            this.label3.Text = "Количество учеников";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 23);
            this.label2.TabIndex = 12;
            this.label2.Text = "Аудиотория";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 23);
            this.label1.TabIndex = 11;
            this.label1.Text = "Класс";
            // 
            // numericUpDownNumberPupil
            // 
            this.numericUpDownNumberPupil.Location = new System.Drawing.Point(245, 137);
            this.numericUpDownNumberPupil.Name = "numericUpDownNumberPupil";
            this.numericUpDownNumberPupil.Size = new System.Drawing.Size(100, 30);
            this.numericUpDownNumberPupil.TabIndex = 10;
            this.numericUpDownNumberPupil.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            // 
            // numericUpDownClassRoom
            // 
            this.numericUpDownClassRoom.Location = new System.Drawing.Point(245, 82);
            this.numericUpDownClassRoom.Name = "numericUpDownClassRoom";
            this.numericUpDownClassRoom.Size = new System.Drawing.Size(100, 30);
            this.numericUpDownClassRoom.TabIndex = 16;
            this.numericUpDownClassRoom.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // comboBoxClassName
            // 
            this.comboBoxClassName.FormattingEnabled = true;
            this.comboBoxClassName.Location = new System.Drawing.Point(245, 21);
            this.comboBoxClassName.Name = "comboBoxClassName";
            this.comboBoxClassName.Size = new System.Drawing.Size(97, 31);
            this.comboBoxClassName.TabIndex = 17;
            this.comboBoxClassName.SelectedIndexChanged += new System.EventHandler(this.comboBoxClassName_SelectedIndexChanged);
            // 
            // textBoxNewClassName
            // 
            this.textBoxNewClassName.Location = new System.Drawing.Point(175, 21);
            this.textBoxNewClassName.Name = "textBoxNewClassName";
            this.textBoxNewClassName.Size = new System.Drawing.Size(64, 30);
            this.textBoxNewClassName.TabIndex = 18;
            // 
            // editClassForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(366, 280);
            this.Controls.Add(this.textBoxNewClassName);
            this.Controls.Add(this.comboBoxClassName);
            this.Controls.Add(this.numericUpDownClassRoom);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDownNumberPupil);
            this.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "editClassForm";
            this.Text = "Изменить";
            this.Load += new System.EventHandler(this.editClassForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumberPupil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownClassRoom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNewClassName;
        internal System.Windows.Forms.NumericUpDown numericUpDownNumberPupil;
        internal System.Windows.Forms.NumericUpDown numericUpDownClassRoom;
        internal System.Windows.Forms.ComboBox comboBoxClassName;
    }
}