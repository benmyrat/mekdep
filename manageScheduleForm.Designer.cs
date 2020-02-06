namespace eSchool
{
    partial class manageScheduleForm
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
            this.buttonSearcher = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButtonDayYes = new System.Windows.Forms.RadioButton();
            this.radioButtonDayNo = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxDay2 = new System.Windows.Forms.ComboBox();
            this.comboBoxDay1 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonTimeYes = new System.Windows.Forms.RadioButton();
            this.radioButtonTimeNo = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxTime2 = new System.Windows.Forms.ComboBox();
            this.comboBoxTime1 = new System.Windows.Forms.ComboBox();
            this.buttonSort = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonPrintXlsx = new System.Windows.Forms.Button();
            this.buttonPrintTXT = new System.Windows.Forms.Button();
            this.buttonPrintDocx = new System.Windows.Forms.Button();
            this.panelALL = new System.Windows.Forms.Panel();
            this.labelALL = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panelALL.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(572, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(500, 600);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // buttonSearcher
            // 
            this.buttonSearcher.BackgroundImage = global::eSchool.Properties.Resources.loupe;
            this.buttonSearcher.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSearcher.Location = new System.Drawing.Point(502, 12);
            this.buttonSearcher.Name = "buttonSearcher";
            this.buttonSearcher.Size = new System.Drawing.Size(30, 30);
            this.buttonSearcher.TabIndex = 14;
            this.buttonSearcher.UseVisualStyleBackColor = true;
            this.buttonSearcher.Click += new System.EventHandler(this.buttonSearcher_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(32, 12);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(450, 30);
            this.textBoxSearch.TabIndex = 13;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButtonDayYes);
            this.groupBox2.Controls.Add(this.radioButtonDayNo);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.comboBoxDay2);
            this.groupBox2.Controls.Add(this.comboBoxDay1);
            this.groupBox2.Location = new System.Drawing.Point(32, 84);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(500, 100);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Сортировка по дням";
            // 
            // radioButtonDayYes
            // 
            this.radioButtonDayYes.AutoSize = true;
            this.radioButtonDayYes.Location = new System.Drawing.Point(119, 29);
            this.radioButtonDayYes.Name = "radioButtonDayYes";
            this.radioButtonDayYes.Size = new System.Drawing.Size(54, 27);
            this.radioButtonDayYes.TabIndex = 24;
            this.radioButtonDayYes.Text = "Да";
            this.radioButtonDayYes.UseVisualStyleBackColor = true;
            this.radioButtonDayYes.CheckedChanged += new System.EventHandler(this.radioButtonDayYes_CheckedChanged);
            // 
            // radioButtonDayNo
            // 
            this.radioButtonDayNo.AutoSize = true;
            this.radioButtonDayNo.Checked = true;
            this.radioButtonDayNo.Location = new System.Drawing.Point(350, 29);
            this.radioButtonDayNo.Name = "radioButtonDayNo";
            this.radioButtonDayNo.Size = new System.Drawing.Size(63, 27);
            this.radioButtonDayNo.TabIndex = 23;
            this.radioButtonDayNo.TabStop = true;
            this.radioButtonDayNo.Text = "Нет";
            this.radioButtonDayNo.UseVisualStyleBackColor = true;
            this.radioButtonDayNo.CheckedChanged += new System.EventHandler(this.radioButtonDayNo_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(213, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Между";
            // 
            // comboBoxDay2
            // 
            this.comboBoxDay2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDay2.FormattingEnabled = true;
            this.comboBoxDay2.Location = new System.Drawing.Point(350, 60);
            this.comboBoxDay2.Name = "comboBoxDay2";
            this.comboBoxDay2.Size = new System.Drawing.Size(130, 31);
            this.comboBoxDay2.TabIndex = 1;
            // 
            // comboBoxDay1
            // 
            this.comboBoxDay1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDay1.FormattingEnabled = true;
            this.comboBoxDay1.Location = new System.Drawing.Point(43, 60);
            this.comboBoxDay1.Name = "comboBoxDay1";
            this.comboBoxDay1.Size = new System.Drawing.Size(130, 31);
            this.comboBoxDay1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonTimeYes);
            this.groupBox1.Controls.Add(this.radioButtonTimeNo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboBoxTime2);
            this.groupBox1.Controls.Add(this.comboBoxTime1);
            this.groupBox1.Location = new System.Drawing.Point(32, 207);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(500, 100);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Сортировка по занятиям";
            // 
            // radioButtonTimeYes
            // 
            this.radioButtonTimeYes.AutoSize = true;
            this.radioButtonTimeYes.Location = new System.Drawing.Point(119, 29);
            this.radioButtonTimeYes.Name = "radioButtonTimeYes";
            this.radioButtonTimeYes.Size = new System.Drawing.Size(54, 27);
            this.radioButtonTimeYes.TabIndex = 24;
            this.radioButtonTimeYes.Text = "Да";
            this.radioButtonTimeYes.UseVisualStyleBackColor = true;
            this.radioButtonTimeYes.CheckedChanged += new System.EventHandler(this.radioButtonTimeYes_CheckedChanged);
            // 
            // radioButtonTimeNo
            // 
            this.radioButtonTimeNo.AutoSize = true;
            this.radioButtonTimeNo.Checked = true;
            this.radioButtonTimeNo.Location = new System.Drawing.Point(350, 30);
            this.radioButtonTimeNo.Name = "radioButtonTimeNo";
            this.radioButtonTimeNo.Size = new System.Drawing.Size(63, 27);
            this.radioButtonTimeNo.TabIndex = 23;
            this.radioButtonTimeNo.TabStop = true;
            this.radioButtonTimeNo.Text = "Нет";
            this.radioButtonTimeNo.UseVisualStyleBackColor = true;
            this.radioButtonTimeNo.CheckedChanged += new System.EventHandler(this.radioButtonTimeNo_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(213, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Между";
            // 
            // comboBoxTime2
            // 
            this.comboBoxTime2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTime2.FormattingEnabled = true;
            this.comboBoxTime2.Location = new System.Drawing.Point(350, 63);
            this.comboBoxTime2.Name = "comboBoxTime2";
            this.comboBoxTime2.Size = new System.Drawing.Size(100, 31);
            this.comboBoxTime2.TabIndex = 1;
            // 
            // comboBoxTime1
            // 
            this.comboBoxTime1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTime1.FormattingEnabled = true;
            this.comboBoxTime1.Location = new System.Drawing.Point(59, 63);
            this.comboBoxTime1.Name = "comboBoxTime1";
            this.comboBoxTime1.Size = new System.Drawing.Size(100, 31);
            this.comboBoxTime1.TabIndex = 0;
            // 
            // buttonSort
            // 
            this.buttonSort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSort.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSort.Location = new System.Drawing.Point(32, 336);
            this.buttonSort.Name = "buttonSort";
            this.buttonSort.Size = new System.Drawing.Size(140, 40);
            this.buttonSort.TabIndex = 28;
            this.buttonSort.Text = "Сорт";
            this.buttonSort.UseVisualStyleBackColor = true;
            this.buttonSort.Click += new System.EventHandler(this.buttonSort_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReset.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReset.Location = new System.Drawing.Point(392, 336);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(140, 40);
            this.buttonReset.TabIndex = 26;
            this.buttonReset.Text = "Сбросить";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonPrintXlsx);
            this.groupBox3.Controls.Add(this.buttonPrintTXT);
            this.groupBox3.Controls.Add(this.buttonPrintDocx);
            this.groupBox3.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(32, 411);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(500, 90);
            this.groupBox3.TabIndex = 29;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Сохранить как";
            // 
            // buttonPrintXlsx
            // 
            this.buttonPrintXlsx.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPrintXlsx.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPrintXlsx.Location = new System.Drawing.Point(360, 44);
            this.buttonPrintXlsx.Name = "buttonPrintXlsx";
            this.buttonPrintXlsx.Size = new System.Drawing.Size(134, 40);
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
            this.buttonPrintTXT.Size = new System.Drawing.Size(134, 40);
            this.buttonPrintTXT.TabIndex = 17;
            this.buttonPrintTXT.Text = "Текст";
            this.buttonPrintTXT.UseVisualStyleBackColor = true;
            this.buttonPrintTXT.Click += new System.EventHandler(this.buttonPrintTXT_Click);
            // 
            // buttonPrintDocx
            // 
            this.buttonPrintDocx.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPrintDocx.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPrintDocx.Location = new System.Drawing.Point(181, 44);
            this.buttonPrintDocx.Name = "buttonPrintDocx";
            this.buttonPrintDocx.Size = new System.Drawing.Size(134, 40);
            this.buttonPrintDocx.TabIndex = 18;
            this.buttonPrintDocx.Text = "Word";
            this.buttonPrintDocx.UseVisualStyleBackColor = true;
            this.buttonPrintDocx.Click += new System.EventHandler(this.buttonPrintDocx_Click);
            // 
            // panelALL
            // 
            this.panelALL.Controls.Add(this.labelALL);
            this.panelALL.Location = new System.Drawing.Point(32, 528);
            this.panelALL.Name = "panelALL";
            this.panelALL.Size = new System.Drawing.Size(500, 84);
            this.panelALL.TabIndex = 30;
            // 
            // labelALL
            // 
            this.labelALL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelALL.Font = new System.Drawing.Font("Century Schoolbook", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelALL.Location = new System.Drawing.Point(0, 0);
            this.labelALL.Name = "labelALL";
            this.labelALL.Size = new System.Drawing.Size(500, 84);
            this.labelALL.TabIndex = 0;
            this.labelALL.Text = "Общая количество: ";
            this.labelALL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // manageScheduleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1084, 621);
            this.Controls.Add(this.panelALL);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.buttonSort);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.buttonSearcher);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "manageScheduleForm";
            this.Text = "manageScheduleForm";
            this.Load += new System.EventHandler(this.manageScheduleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.panelALL.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonSearcher;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButtonDayYes;
        private System.Windows.Forms.RadioButton radioButtonDayNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxDay2;
        private System.Windows.Forms.ComboBox comboBoxDay1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonTimeYes;
        private System.Windows.Forms.RadioButton radioButtonTimeNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxTime2;
        private System.Windows.Forms.ComboBox comboBoxTime1;
        private System.Windows.Forms.Button buttonSort;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonPrintXlsx;
        private System.Windows.Forms.Button buttonPrintTXT;
        private System.Windows.Forms.Button buttonPrintDocx;
        private System.Windows.Forms.Panel panelALL;
        private System.Windows.Forms.Label labelALL;
    }
}