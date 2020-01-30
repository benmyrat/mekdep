namespace eSchool
{
    partial class manageStudentForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelALL = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButtonBdateYes = new System.Windows.Forms.RadioButton();
            this.radioButtonBdateNo = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButtonClassYes = new System.Windows.Forms.RadioButton();
            this.radioButtonClassNo = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxClassName2 = new System.Windows.Forms.ComboBox();
            this.comboBoxClassName1 = new System.Windows.Forms.ComboBox();
            this.buttonSearcher = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonPrintXlsx = new System.Windows.Forms.Button();
            this.buttonPrintTXT = new System.Windows.Forms.Button();
            this.buttonPrintDocx = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.button = new System.Windows.Forms.Button();
            this.radioButtonMale = new System.Windows.Forms.RadioButton();
            this.radioButtonFemale = new System.Windows.Forms.RadioButton();
            this.radioButtonALL = new System.Windows.Forms.RadioButton();
            this.buttonSort = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 244);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1160, 455);
            this.dataGridView1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelALL);
            this.panel1.Location = new System.Drawing.Point(12, 178);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(507, 60);
            this.panel1.TabIndex = 1;
            // 
            // labelALL
            // 
            this.labelALL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelALL.Font = new System.Drawing.Font("Century Schoolbook", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelALL.Location = new System.Drawing.Point(0, 0);
            this.labelALL.Name = "labelALL";
            this.labelALL.Size = new System.Drawing.Size(507, 60);
            this.labelALL.TabIndex = 0;
            this.labelALL.Text = "Количество учеников: ";
            this.labelALL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.radioButtonBdateYes);
            this.groupBox1.Controls.Add(this.radioButtonBdateNo);
            this.groupBox1.Location = new System.Drawing.Point(685, 138);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(487, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Сортировка по дате рождению";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = " dd–MM–yyyy";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(324, 63);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(157, 30);
            this.dateTimePicker2.TabIndex = 28;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = " dd–MM–yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(16, 63);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(157, 30);
            this.dateTimePicker1.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(213, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 23);
            this.label2.TabIndex = 25;
            this.label2.Text = "Между";
            // 
            // radioButtonBdateYes
            // 
            this.radioButtonBdateYes.AutoSize = true;
            this.radioButtonBdateYes.Location = new System.Drawing.Point(175, 29);
            this.radioButtonBdateYes.Name = "radioButtonBdateYes";
            this.radioButtonBdateYes.Size = new System.Drawing.Size(54, 27);
            this.radioButtonBdateYes.TabIndex = 26;
            this.radioButtonBdateYes.Text = "Да";
            this.radioButtonBdateYes.UseVisualStyleBackColor = true;
            this.radioButtonBdateYes.CheckedChanged += new System.EventHandler(this.radioButtonBdateYes_CheckedChanged);
            // 
            // radioButtonBdateNo
            // 
            this.radioButtonBdateNo.AutoSize = true;
            this.radioButtonBdateNo.Checked = true;
            this.radioButtonBdateNo.Location = new System.Drawing.Point(266, 29);
            this.radioButtonBdateNo.Name = "radioButtonBdateNo";
            this.radioButtonBdateNo.Size = new System.Drawing.Size(63, 27);
            this.radioButtonBdateNo.TabIndex = 25;
            this.radioButtonBdateNo.TabStop = true;
            this.radioButtonBdateNo.Text = "Нет";
            this.radioButtonBdateNo.UseVisualStyleBackColor = true;
            this.radioButtonBdateNo.CheckedChanged += new System.EventHandler(this.radioButtonBdateNo_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButtonClassYes);
            this.groupBox2.Controls.Add(this.radioButtonClassNo);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.comboBoxClassName2);
            this.groupBox2.Controls.Add(this.comboBoxClassName1);
            this.groupBox2.Location = new System.Drawing.Point(685, 24);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(487, 100);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Сортировка по классам";
            // 
            // radioButtonClassYes
            // 
            this.radioButtonClassYes.AutoSize = true;
            this.radioButtonClassYes.Location = new System.Drawing.Point(175, 30);
            this.radioButtonClassYes.Name = "radioButtonClassYes";
            this.radioButtonClassYes.Size = new System.Drawing.Size(54, 27);
            this.radioButtonClassYes.TabIndex = 24;
            this.radioButtonClassYes.Text = "Да";
            this.radioButtonClassYes.UseVisualStyleBackColor = true;
            this.radioButtonClassYes.CheckedChanged += new System.EventHandler(this.radioButtonClassYes_CheckedChanged);
            // 
            // radioButtonClassNo
            // 
            this.radioButtonClassNo.AutoSize = true;
            this.radioButtonClassNo.Checked = true;
            this.radioButtonClassNo.Location = new System.Drawing.Point(266, 30);
            this.radioButtonClassNo.Name = "radioButtonClassNo";
            this.radioButtonClassNo.Size = new System.Drawing.Size(63, 27);
            this.radioButtonClassNo.TabIndex = 23;
            this.radioButtonClassNo.TabStop = true;
            this.radioButtonClassNo.Text = "Нет";
            this.radioButtonClassNo.UseVisualStyleBackColor = true;
            this.radioButtonClassNo.CheckedChanged += new System.EventHandler(this.radioButtonClassNo_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(213, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Между";
            // 
            // comboBoxClassName2
            // 
            this.comboBoxClassName2.FormattingEnabled = true;
            this.comboBoxClassName2.Location = new System.Drawing.Point(324, 63);
            this.comboBoxClassName2.Name = "comboBoxClassName2";
            this.comboBoxClassName2.Size = new System.Drawing.Size(100, 31);
            this.comboBoxClassName2.TabIndex = 1;
            // 
            // comboBoxClassName1
            // 
            this.comboBoxClassName1.FormattingEnabled = true;
            this.comboBoxClassName1.Location = new System.Drawing.Point(73, 63);
            this.comboBoxClassName1.Name = "comboBoxClassName1";
            this.comboBoxClassName1.Size = new System.Drawing.Size(100, 31);
            this.comboBoxClassName1.TabIndex = 0;
            // 
            // buttonSearcher
            // 
            this.buttonSearcher.BackgroundImage = global::eSchool.Properties.Resources.loupe;
            this.buttonSearcher.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSearcher.Location = new System.Drawing.Point(489, 24);
            this.buttonSearcher.Name = "buttonSearcher";
            this.buttonSearcher.Size = new System.Drawing.Size(30, 30);
            this.buttonSearcher.TabIndex = 12;
            this.buttonSearcher.UseVisualStyleBackColor = true;
            this.buttonSearcher.Click += new System.EventHandler(this.buttonSearcher_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(19, 24);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(450, 30);
            this.textBoxSearch.TabIndex = 11;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonPrintXlsx);
            this.groupBox3.Controls.Add(this.buttonPrintTXT);
            this.groupBox3.Controls.Add(this.buttonPrintDocx);
            this.groupBox3.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(19, 72);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(387, 90);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Сохранить как";
            // 
            // buttonPrintXlsx
            // 
            this.buttonPrintXlsx.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPrintXlsx.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPrintXlsx.Location = new System.Drawing.Point(258, 44);
            this.buttonPrintXlsx.Name = "buttonPrintXlsx";
            this.buttonPrintXlsx.Size = new System.Drawing.Size(120, 40);
            this.buttonPrintXlsx.TabIndex = 19;
            this.buttonPrintXlsx.Text = "Excel";
            this.buttonPrintXlsx.UseVisualStyleBackColor = true;
            this.buttonPrintXlsx.Click += new System.EventHandler(this.buttonPrintXlsx_Click);
            // 
            // buttonPrintTXT
            // 
            this.buttonPrintTXT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPrintTXT.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPrintTXT.Location = new System.Drawing.Point(6, 44);
            this.buttonPrintTXT.Name = "buttonPrintTXT";
            this.buttonPrintTXT.Size = new System.Drawing.Size(120, 40);
            this.buttonPrintTXT.TabIndex = 17;
            this.buttonPrintTXT.Text = "Текст";
            this.buttonPrintTXT.UseVisualStyleBackColor = true;
            this.buttonPrintTXT.Click += new System.EventHandler(this.buttonPrintTXT_Click);
            // 
            // buttonPrintDocx
            // 
            this.buttonPrintDocx.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPrintDocx.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPrintDocx.Location = new System.Drawing.Point(132, 44);
            this.buttonPrintDocx.Name = "buttonPrintDocx";
            this.buttonPrintDocx.Size = new System.Drawing.Size(120, 40);
            this.buttonPrintDocx.TabIndex = 18;
            this.buttonPrintDocx.Text = "Word";
            this.buttonPrintDocx.UseVisualStyleBackColor = true;
            this.buttonPrintDocx.Click += new System.EventHandler(this.buttonPrintDocx_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReset.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReset.Location = new System.Drawing.Point(539, 192);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(140, 40);
            this.buttonReset.TabIndex = 20;
            this.buttonReset.Text = "Сбросить";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // button
            // 
            this.button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button.Location = new System.Drawing.Point(539, 138);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(140, 40);
            this.button.TabIndex = 21;
            this.button.Text = "Развернуть";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // radioButtonMale
            // 
            this.radioButtonMale.AutoSize = true;
            this.radioButtonMale.ForeColor = System.Drawing.Color.Navy;
            this.radioButtonMale.Location = new System.Drawing.Point(539, 59);
            this.radioButtonMale.Name = "radioButtonMale";
            this.radioButtonMale.Size = new System.Drawing.Size(112, 27);
            this.radioButtonMale.TabIndex = 23;
            this.radioButtonMale.Text = "Мужской";
            this.radioButtonMale.UseVisualStyleBackColor = true;
            // 
            // radioButtonFemale
            // 
            this.radioButtonFemale.AutoSize = true;
            this.radioButtonFemale.ForeColor = System.Drawing.Color.Crimson;
            this.radioButtonFemale.Location = new System.Drawing.Point(539, 97);
            this.radioButtonFemale.Name = "radioButtonFemale";
            this.radioButtonFemale.Size = new System.Drawing.Size(112, 27);
            this.radioButtonFemale.TabIndex = 24;
            this.radioButtonFemale.Text = "Женский";
            this.radioButtonFemale.UseVisualStyleBackColor = true;
            // 
            // radioButtonALL
            // 
            this.radioButtonALL.AutoSize = true;
            this.radioButtonALL.Checked = true;
            this.radioButtonALL.Location = new System.Drawing.Point(539, 26);
            this.radioButtonALL.Name = "radioButtonALL";
            this.radioButtonALL.Size = new System.Drawing.Size(60, 27);
            this.radioButtonALL.TabIndex = 22;
            this.radioButtonALL.TabStop = true;
            this.radioButtonALL.Text = "Все";
            this.radioButtonALL.UseVisualStyleBackColor = true;
            // 
            // buttonSort
            // 
            this.buttonSort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSort.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSort.Location = new System.Drawing.Point(423, 116);
            this.buttonSort.Name = "buttonSort";
            this.buttonSort.Size = new System.Drawing.Size(96, 40);
            this.buttonSort.TabIndex = 25;
            this.buttonSort.Text = "Сорт";
            this.buttonSort.UseVisualStyleBackColor = true;
            this.buttonSort.Click += new System.EventHandler(this.buttonSort_Click);
            // 
            // manageStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1184, 711);
            this.Controls.Add(this.buttonSort);
            this.Controls.Add(this.radioButtonFemale);
            this.Controls.Add(this.radioButtonMale);
            this.Controls.Add(this.radioButtonALL);
            this.Controls.Add(this.button);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.buttonSearcher);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "manageStudentForm";
            this.Text = "Управление студентами";
            this.Load += new System.EventHandler(this.manageStudentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelALL;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonSearcher;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonPrintXlsx;
        private System.Windows.Forms.Button buttonPrintTXT;
        private System.Windows.Forms.Button buttonPrintDocx;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.RadioButton radioButtonMale;
        private System.Windows.Forms.RadioButton radioButtonFemale;
        private System.Windows.Forms.ComboBox comboBoxClassName1;
        private System.Windows.Forms.ComboBox comboBoxClassName2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButtonClassNo;
        private System.Windows.Forms.RadioButton radioButtonALL;
        private System.Windows.Forms.RadioButton radioButtonClassYes;
        private System.Windows.Forms.RadioButton radioButtonBdateYes;
        private System.Windows.Forms.RadioButton radioButtonBdateNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button buttonSort;
    }
}