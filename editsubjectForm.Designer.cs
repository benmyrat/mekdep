namespace eSchool
{
    partial class editsubjectForm
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
            this.labelCombobox = new System.Windows.Forms.Label();
            this.comboBoxSubjcets = new System.Windows.Forms.ComboBox();
            this.labelNameSubject = new System.Windows.Forms.Label();
            this.textBoxSname = new System.Windows.Forms.TextBox();
            this.richTextBoxSdescription = new System.Windows.Forms.RichTextBox();
            this.labelDescription = new System.Windows.Forms.Label();
            this.buttonDeleteSubject = new System.Windows.Forms.Button();
            this.buttonEditSubject = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelCombobox
            // 
            this.labelCombobox.AutoSize = true;
            this.labelCombobox.Location = new System.Drawing.Point(12, 28);
            this.labelCombobox.Name = "labelCombobox";
            this.labelCombobox.Size = new System.Drawing.Size(223, 23);
            this.labelCombobox.TabIndex = 0;
            this.labelCombobox.Text = "Выберите дисцпилину:";
            // 
            // comboBoxSubjcets
            // 
            this.comboBoxSubjcets.FormattingEnabled = true;
            this.comboBoxSubjcets.Location = new System.Drawing.Point(257, 25);
            this.comboBoxSubjcets.Name = "comboBoxSubjcets";
            this.comboBoxSubjcets.Size = new System.Drawing.Size(300, 31);
            this.comboBoxSubjcets.TabIndex = 1;
            this.comboBoxSubjcets.SelectedIndexChanged += new System.EventHandler(this.comboBoxSubjcets_SelectedIndexChanged);
            // 
            // labelNameSubject
            // 
            this.labelNameSubject.AutoSize = true;
            this.labelNameSubject.Location = new System.Drawing.Point(12, 109);
            this.labelNameSubject.Name = "labelNameSubject";
            this.labelNameSubject.Size = new System.Drawing.Size(101, 23);
            this.labelNameSubject.TabIndex = 2;
            this.labelNameSubject.Text = "Название";
            // 
            // textBoxSname
            // 
            this.textBoxSname.Location = new System.Drawing.Point(257, 106);
            this.textBoxSname.Name = "textBoxSname";
            this.textBoxSname.Size = new System.Drawing.Size(300, 30);
            this.textBoxSname.TabIndex = 3;
            // 
            // richTextBoxSdescription
            // 
            this.richTextBoxSdescription.Location = new System.Drawing.Point(257, 160);
            this.richTextBoxSdescription.Name = "richTextBoxSdescription";
            this.richTextBoxSdescription.Size = new System.Drawing.Size(300, 250);
            this.richTextBoxSdescription.TabIndex = 4;
            this.richTextBoxSdescription.Text = "";
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(12, 163);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(102, 23);
            this.labelDescription.TabIndex = 5;
            this.labelDescription.Text = "Описание";
            // 
            // buttonDeleteSubject
            // 
            this.buttonDeleteSubject.BackColor = System.Drawing.Color.Crimson;
            this.buttonDeleteSubject.ForeColor = System.Drawing.Color.Snow;
            this.buttonDeleteSubject.Location = new System.Drawing.Point(16, 372);
            this.buttonDeleteSubject.Name = "buttonDeleteSubject";
            this.buttonDeleteSubject.Size = new System.Drawing.Size(116, 38);
            this.buttonDeleteSubject.TabIndex = 6;
            this.buttonDeleteSubject.Text = "Удалить";
            this.buttonDeleteSubject.UseVisualStyleBackColor = false;
            this.buttonDeleteSubject.Click += new System.EventHandler(this.buttonDeleteSubject_Click);
            // 
            // buttonEditSubject
            // 
            this.buttonEditSubject.BackColor = System.Drawing.Color.Navy;
            this.buttonEditSubject.ForeColor = System.Drawing.Color.Snow;
            this.buttonEditSubject.Location = new System.Drawing.Point(135, 372);
            this.buttonEditSubject.Name = "buttonEditSubject";
            this.buttonEditSubject.Size = new System.Drawing.Size(116, 38);
            this.buttonEditSubject.TabIndex = 7;
            this.buttonEditSubject.Text = "Изменить";
            this.buttonEditSubject.UseVisualStyleBackColor = false;
            this.buttonEditSubject.Click += new System.EventHandler(this.buttonEditSubject_Click);
            // 
            // editsubjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(574, 425);
            this.Controls.Add(this.buttonEditSubject);
            this.Controls.Add(this.buttonDeleteSubject);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.richTextBoxSdescription);
            this.Controls.Add(this.textBoxSname);
            this.Controls.Add(this.labelNameSubject);
            this.Controls.Add(this.comboBoxSubjcets);
            this.Controls.Add(this.labelCombobox);
            this.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "editsubjectForm";
            this.Text = "Изменить дисциплину";
            this.Load += new System.EventHandler(this.editsubjectForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCombobox;
        private System.Windows.Forms.ComboBox comboBoxSubjcets;
        private System.Windows.Forms.Label labelNameSubject;
        private System.Windows.Forms.TextBox textBoxSname;
        private System.Windows.Forms.RichTextBox richTextBoxSdescription;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Button buttonDeleteSubject;
        private System.Windows.Forms.Button buttonEditSubject;
    }
}