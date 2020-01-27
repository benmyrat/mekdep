namespace eSchool
{
    partial class manageSubjectForm
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
            this.buttonEditSubject = new System.Windows.Forms.Button();
            this.buttonDeleteSubject = new System.Windows.Forms.Button();
            this.labelDescription = new System.Windows.Forms.Label();
            this.richTextBoxSdescription = new System.Windows.Forms.RichTextBox();
            this.textBoxSname = new System.Windows.Forms.TextBox();
            this.labelNameSubject = new System.Windows.Forms.Label();
            this.listBoxSubjects = new System.Windows.Forms.ListBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.panelSub = new System.Windows.Forms.Panel();
            this.labelSub = new System.Windows.Forms.Label();
            this.buttonFirst = new System.Windows.Forms.Button();
            this.buttonPrevious = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonLast = new System.Windows.Forms.Button();
            this.comboBoxSubjcets = new System.Windows.Forms.ComboBox();
            this.panelSub.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonEditSubject
            // 
            this.buttonEditSubject.BackColor = System.Drawing.Color.Navy;
            this.buttonEditSubject.ForeColor = System.Drawing.Color.Snow;
            this.buttonEditSubject.Location = new System.Drawing.Point(135, 289);
            this.buttonEditSubject.Name = "buttonEditSubject";
            this.buttonEditSubject.Size = new System.Drawing.Size(116, 38);
            this.buttonEditSubject.TabIndex = 15;
            this.buttonEditSubject.Text = "Изменить";
            this.buttonEditSubject.UseVisualStyleBackColor = false;
            this.buttonEditSubject.Click += new System.EventHandler(this.buttonEditSubject_Click);
            // 
            // buttonDeleteSubject
            // 
            this.buttonDeleteSubject.BackColor = System.Drawing.Color.Crimson;
            this.buttonDeleteSubject.ForeColor = System.Drawing.Color.Snow;
            this.buttonDeleteSubject.Location = new System.Drawing.Point(17, 289);
            this.buttonDeleteSubject.Name = "buttonDeleteSubject";
            this.buttonDeleteSubject.Size = new System.Drawing.Size(116, 38);
            this.buttonDeleteSubject.TabIndex = 14;
            this.buttonDeleteSubject.Text = "Удалить";
            this.buttonDeleteSubject.UseVisualStyleBackColor = false;
            this.buttonDeleteSubject.Click += new System.EventHandler(this.buttonDeleteSubject_Click);
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(13, 146);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(102, 23);
            this.labelDescription.TabIndex = 13;
            this.labelDescription.Text = "Описание";
            // 
            // richTextBoxSdescription
            // 
            this.richTextBoxSdescription.Location = new System.Drawing.Point(257, 139);
            this.richTextBoxSdescription.Name = "richTextBoxSdescription";
            this.richTextBoxSdescription.Size = new System.Drawing.Size(300, 250);
            this.richTextBoxSdescription.TabIndex = 12;
            this.richTextBoxSdescription.Text = "";
            // 
            // textBoxSname
            // 
            this.textBoxSname.Location = new System.Drawing.Point(257, 93);
            this.textBoxSname.Name = "textBoxSname";
            this.textBoxSname.Size = new System.Drawing.Size(300, 30);
            this.textBoxSname.TabIndex = 11;
            // 
            // labelNameSubject
            // 
            this.labelNameSubject.AutoSize = true;
            this.labelNameSubject.Location = new System.Drawing.Point(12, 96);
            this.labelNameSubject.Name = "labelNameSubject";
            this.labelNameSubject.Size = new System.Drawing.Size(101, 23);
            this.labelNameSubject.TabIndex = 10;
            this.labelNameSubject.Text = "Название";
            // 
            // listBoxSubjects
            // 
            this.listBoxSubjects.FormattingEnabled = true;
            this.listBoxSubjects.ItemHeight = 23;
            this.listBoxSubjects.Location = new System.Drawing.Point(563, 24);
            this.listBoxSubjects.Name = "listBoxSubjects";
            this.listBoxSubjects.Size = new System.Drawing.Size(409, 303);
            this.listBoxSubjects.TabIndex = 16;
            this.listBoxSubjects.Click += new System.EventHandler(this.listBoxSubjects_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.DarkSlateGray;
            this.buttonAdd.ForeColor = System.Drawing.Color.Snow;
            this.buttonAdd.Location = new System.Drawing.Point(135, 245);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(116, 38);
            this.buttonAdd.TabIndex = 17;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.Silver;
            this.buttonClear.ForeColor = System.Drawing.Color.Black;
            this.buttonClear.Location = new System.Drawing.Point(17, 245);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(116, 38);
            this.buttonClear.TabIndex = 18;
            this.buttonClear.Text = "Сбросить";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // panelSub
            // 
            this.panelSub.Controls.Add(this.labelSub);
            this.panelSub.Location = new System.Drawing.Point(563, 333);
            this.panelSub.Name = "panelSub";
            this.panelSub.Size = new System.Drawing.Size(409, 60);
            this.panelSub.TabIndex = 19;
            // 
            // labelSub
            // 
            this.labelSub.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelSub.Location = new System.Drawing.Point(0, 0);
            this.labelSub.Name = "labelSub";
            this.labelSub.Size = new System.Drawing.Size(409, 60);
            this.labelSub.TabIndex = 0;
            this.labelSub.Text = "Общая количество предметов: ";
            this.labelSub.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonFirst
            // 
            this.buttonFirst.Location = new System.Drawing.Point(17, 199);
            this.buttonFirst.Name = "buttonFirst";
            this.buttonFirst.Size = new System.Drawing.Size(50, 40);
            this.buttonFirst.TabIndex = 20;
            this.buttonFirst.Text = "<<";
            this.buttonFirst.UseVisualStyleBackColor = true;
            this.buttonFirst.Click += new System.EventHandler(this.buttonFirst_Click);
            // 
            // buttonPrevious
            // 
            this.buttonPrevious.Location = new System.Drawing.Point(79, 199);
            this.buttonPrevious.Name = "buttonPrevious";
            this.buttonPrevious.Size = new System.Drawing.Size(50, 40);
            this.buttonPrevious.TabIndex = 21;
            this.buttonPrevious.Text = "<";
            this.buttonPrevious.UseVisualStyleBackColor = true;
            this.buttonPrevious.Click += new System.EventHandler(this.buttonPrevious_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(135, 199);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(50, 40);
            this.buttonNext.TabIndex = 22;
            this.buttonNext.Text = ">";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonLast
            // 
            this.buttonLast.Location = new System.Drawing.Point(201, 199);
            this.buttonLast.Name = "buttonLast";
            this.buttonLast.Size = new System.Drawing.Size(50, 40);
            this.buttonLast.TabIndex = 23;
            this.buttonLast.Text = ">>";
            this.buttonLast.UseVisualStyleBackColor = true;
            this.buttonLast.Click += new System.EventHandler(this.buttonLast_Click);
            // 
            // comboBoxSubjcets
            // 
            this.comboBoxSubjcets.FormattingEnabled = true;
            this.comboBoxSubjcets.Location = new System.Drawing.Point(257, 24);
            this.comboBoxSubjcets.Name = "comboBoxSubjcets";
            this.comboBoxSubjcets.Size = new System.Drawing.Size(300, 31);
            this.comboBoxSubjcets.TabIndex = 24;
            // 
            // manageSubjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(984, 401);
            this.Controls.Add(this.comboBoxSubjcets);
            this.Controls.Add(this.buttonLast);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonPrevious);
            this.Controls.Add(this.buttonFirst);
            this.Controls.Add(this.panelSub);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.listBoxSubjects);
            this.Controls.Add(this.buttonEditSubject);
            this.Controls.Add(this.buttonDeleteSubject);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.richTextBoxSdescription);
            this.Controls.Add(this.textBoxSname);
            this.Controls.Add(this.labelNameSubject);
            this.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "manageSubjectForm";
            this.Text = "manageSubjectForm";
            this.Load += new System.EventHandler(this.manageSubjectForm_Load);
            this.panelSub.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonEditSubject;
        private System.Windows.Forms.Button buttonDeleteSubject;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.RichTextBox richTextBoxSdescription;
        private System.Windows.Forms.TextBox textBoxSname;
        private System.Windows.Forms.Label labelNameSubject;
        private System.Windows.Forms.ListBox listBoxSubjects;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Panel panelSub;
        private System.Windows.Forms.Label labelSub;
        private System.Windows.Forms.Button buttonFirst;
        private System.Windows.Forms.Button buttonPrevious;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonLast;
        private System.Windows.Forms.ComboBox comboBoxSubjcets;
    }
}