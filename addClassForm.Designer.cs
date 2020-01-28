namespace eSchool
{
    partial class addClassForm
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
            this.textBoxClassName = new System.Windows.Forms.TextBox();
            this.numericUpDownNumberPupil = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonClean = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.numericUpDownClassRoom = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumberPupil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownClassRoom)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxClassName
            // 
            this.textBoxClassName.Location = new System.Drawing.Point(245, 31);
            this.textBoxClassName.Name = "textBoxClassName";
            this.textBoxClassName.Size = new System.Drawing.Size(100, 30);
            this.textBoxClassName.TabIndex = 0;
            // 
            // numericUpDownNumberPupil
            // 
            this.numericUpDownNumberPupil.Location = new System.Drawing.Point(248, 142);
            this.numericUpDownNumberPupil.Name = "numericUpDownNumberPupil";
            this.numericUpDownNumberPupil.Size = new System.Drawing.Size(100, 30);
            this.numericUpDownNumberPupil.TabIndex = 2;
            this.numericUpDownNumberPupil.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Класс";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Аудиотория";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(207, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Количество учеников";
            // 
            // buttonClean
            // 
            this.buttonClean.BackColor = System.Drawing.Color.Crimson;
            this.buttonClean.ForeColor = System.Drawing.Color.Snow;
            this.buttonClean.Location = new System.Drawing.Point(19, 194);
            this.buttonClean.Name = "buttonClean";
            this.buttonClean.Size = new System.Drawing.Size(110, 50);
            this.buttonClean.TabIndex = 6;
            this.buttonClean.Text = "Стирать";
            this.buttonClean.UseVisualStyleBackColor = false;
            this.buttonClean.Click += new System.EventHandler(this.buttonClean_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.Navy;
            this.buttonAdd.ForeColor = System.Drawing.Color.Snow;
            this.buttonAdd.Location = new System.Drawing.Point(235, 194);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(110, 50);
            this.buttonAdd.TabIndex = 7;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // numericUpDownClassRoom
            // 
            this.numericUpDownClassRoom.Location = new System.Drawing.Point(245, 87);
            this.numericUpDownClassRoom.Name = "numericUpDownClassRoom";
            this.numericUpDownClassRoom.Size = new System.Drawing.Size(100, 30);
            this.numericUpDownClassRoom.TabIndex = 8;
            this.numericUpDownClassRoom.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // addClassForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(366, 280);
            this.Controls.Add(this.numericUpDownClassRoom);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonClean);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDownNumberPupil);
            this.Controls.Add(this.textBoxClassName);
            this.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "addClassForm";
            this.Text = "Добавить класс";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumberPupil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownClassRoom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxClassName;
        private System.Windows.Forms.NumericUpDown numericUpDownNumberPupil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonClean;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.NumericUpDown numericUpDownClassRoom;
    }
}