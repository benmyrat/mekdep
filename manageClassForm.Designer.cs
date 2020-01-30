namespace eSchool
{
    partial class manageClassForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numericUpDownClass2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownClass1 = new System.Windows.Forms.NumericUpDown();
            this.radioButtonNo = new System.Windows.Forms.RadioButton();
            this.radioButtonYES = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.numericUpDownNumberP2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownNumberP1 = new System.Windows.Forms.NumericUpDown();
            this.radioButtonNumberPupilNo = new System.Windows.Forms.RadioButton();
            this.radioButtonNumberPupilYES = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonSort = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelAllClass = new System.Windows.Forms.Label();
            this.buttonSearcher = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.buttonPrintWord = new System.Windows.Forms.Button();
            this.buttonPrintExcel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownClass2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownClass1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumberP2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumberP1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 324);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1060, 425);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numericUpDownClass2);
            this.groupBox1.Controls.Add(this.numericUpDownClass1);
            this.groupBox1.Controls.Add(this.radioButtonNo);
            this.groupBox1.Controls.Add(this.radioButtonYES);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(677, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(395, 150);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Сортировать по номеру класса";
            // 
            // numericUpDownClass2
            // 
            this.numericUpDownClass2.Enabled = false;
            this.numericUpDownClass2.Location = new System.Drawing.Point(245, 96);
            this.numericUpDownClass2.Name = "numericUpDownClass2";
            this.numericUpDownClass2.Size = new System.Drawing.Size(100, 30);
            this.numericUpDownClass2.TabIndex = 4;
            // 
            // numericUpDownClass1
            // 
            this.numericUpDownClass1.Enabled = false;
            this.numericUpDownClass1.Location = new System.Drawing.Point(59, 96);
            this.numericUpDownClass1.Name = "numericUpDownClass1";
            this.numericUpDownClass1.Size = new System.Drawing.Size(100, 30);
            this.numericUpDownClass1.TabIndex = 3;
            // 
            // radioButtonNo
            // 
            this.radioButtonNo.AutoSize = true;
            this.radioButtonNo.Checked = true;
            this.radioButtonNo.Location = new System.Drawing.Point(105, 47);
            this.radioButtonNo.Name = "radioButtonNo";
            this.radioButtonNo.Size = new System.Drawing.Size(63, 27);
            this.radioButtonNo.TabIndex = 2;
            this.radioButtonNo.TabStop = true;
            this.radioButtonNo.Text = "Нет";
            this.radioButtonNo.UseVisualStyleBackColor = true;
            this.radioButtonNo.CheckedChanged += new System.EventHandler(this.radioButtonNo_CheckedChanged);
            // 
            // radioButtonYES
            // 
            this.radioButtonYES.AutoSize = true;
            this.radioButtonYES.Location = new System.Drawing.Point(245, 47);
            this.radioButtonYES.Name = "radioButtonYES";
            this.radioButtonYES.Size = new System.Drawing.Size(54, 27);
            this.radioButtonYES.TabIndex = 1;
            this.radioButtonYES.Text = "Да";
            this.radioButtonYES.UseVisualStyleBackColor = true;
            this.radioButtonYES.CheckedChanged += new System.EventHandler(this.radioButtonYES_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(165, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Между";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.numericUpDownNumberP2);
            this.groupBox2.Controls.Add(this.numericUpDownNumberP1);
            this.groupBox2.Controls.Add(this.radioButtonNumberPupilNo);
            this.groupBox2.Controls.Add(this.radioButtonNumberPupilYES);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(677, 168);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(395, 150);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Сортировать по количество учеников";
            // 
            // numericUpDownNumberP2
            // 
            this.numericUpDownNumberP2.Enabled = false;
            this.numericUpDownNumberP2.Location = new System.Drawing.Point(245, 96);
            this.numericUpDownNumberP2.Name = "numericUpDownNumberP2";
            this.numericUpDownNumberP2.Size = new System.Drawing.Size(100, 30);
            this.numericUpDownNumberP2.TabIndex = 4;
            // 
            // numericUpDownNumberP1
            // 
            this.numericUpDownNumberP1.Enabled = false;
            this.numericUpDownNumberP1.Location = new System.Drawing.Point(59, 96);
            this.numericUpDownNumberP1.Name = "numericUpDownNumberP1";
            this.numericUpDownNumberP1.Size = new System.Drawing.Size(100, 30);
            this.numericUpDownNumberP1.TabIndex = 3;
            // 
            // radioButtonNumberPupilNo
            // 
            this.radioButtonNumberPupilNo.AutoSize = true;
            this.radioButtonNumberPupilNo.Checked = true;
            this.radioButtonNumberPupilNo.Location = new System.Drawing.Point(105, 47);
            this.radioButtonNumberPupilNo.Name = "radioButtonNumberPupilNo";
            this.radioButtonNumberPupilNo.Size = new System.Drawing.Size(63, 27);
            this.radioButtonNumberPupilNo.TabIndex = 2;
            this.radioButtonNumberPupilNo.TabStop = true;
            this.radioButtonNumberPupilNo.Text = "Нет";
            this.radioButtonNumberPupilNo.UseVisualStyleBackColor = true;
            this.radioButtonNumberPupilNo.CheckedChanged += new System.EventHandler(this.radioButtonNumberPupilNo_CheckedChanged);
            // 
            // radioButtonNumberPupilYES
            // 
            this.radioButtonNumberPupilYES.AutoSize = true;
            this.radioButtonNumberPupilYES.Location = new System.Drawing.Point(245, 47);
            this.radioButtonNumberPupilYES.Name = "radioButtonNumberPupilYES";
            this.radioButtonNumberPupilYES.Size = new System.Drawing.Size(54, 27);
            this.radioButtonNumberPupilYES.TabIndex = 1;
            this.radioButtonNumberPupilYES.Text = "Да";
            this.radioButtonNumberPupilYES.UseVisualStyleBackColor = true;
            this.radioButtonNumberPupilYES.CheckedChanged += new System.EventHandler(this.radioButtonNumberPupilYES_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(165, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Между";
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(168, 151);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(135, 40);
            this.buttonReset.TabIndex = 6;
            this.buttonReset.Text = "Сбросить";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonSort
            // 
            this.buttonSort.Location = new System.Drawing.Point(27, 151);
            this.buttonSort.Name = "buttonSort";
            this.buttonSort.Size = new System.Drawing.Size(135, 40);
            this.buttonSort.TabIndex = 7;
            this.buttonSort.Text = "Сортировать";
            this.buttonSort.UseVisualStyleBackColor = true;
            this.buttonSort.Click += new System.EventHandler(this.buttonSort_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelAllClass);
            this.panel1.Location = new System.Drawing.Point(20, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 86);
            this.panel1.TabIndex = 8;
            // 
            // labelAllClass
            // 
            this.labelAllClass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelAllClass.Font = new System.Drawing.Font("Comic Sans MS", 22F);
            this.labelAllClass.Location = new System.Drawing.Point(0, 0);
            this.labelAllClass.Name = "labelAllClass";
            this.labelAllClass.Size = new System.Drawing.Size(500, 86);
            this.labelAllClass.TabIndex = 0;
            this.labelAllClass.Text = "Общая количество классов";
            this.labelAllClass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonSearcher
            // 
            this.buttonSearcher.BackgroundImage = global::eSchool.Properties.Resources.loupe;
            this.buttonSearcher.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSearcher.Location = new System.Drawing.Point(490, 12);
            this.buttonSearcher.Name = "buttonSearcher";
            this.buttonSearcher.Size = new System.Drawing.Size(30, 30);
            this.buttonSearcher.TabIndex = 10;
            this.buttonSearcher.UseVisualStyleBackColor = true;
            this.buttonSearcher.Click += new System.EventHandler(this.buttonSearcher_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(20, 12);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(450, 30);
            this.textBoxSearch.TabIndex = 9;
            // 
            // buttonPrintWord
            // 
            this.buttonPrintWord.Location = new System.Drawing.Point(309, 151);
            this.buttonPrintWord.Name = "buttonPrintWord";
            this.buttonPrintWord.Size = new System.Drawing.Size(135, 40);
            this.buttonPrintWord.TabIndex = 11;
            this.buttonPrintWord.Text = "Word";
            this.buttonPrintWord.UseVisualStyleBackColor = true;
            this.buttonPrintWord.Click += new System.EventHandler(this.buttonPrintWord_Click);
            // 
            // buttonPrintExcel
            // 
            this.buttonPrintExcel.Location = new System.Drawing.Point(450, 151);
            this.buttonPrintExcel.Name = "buttonPrintExcel";
            this.buttonPrintExcel.Size = new System.Drawing.Size(135, 40);
            this.buttonPrintExcel.TabIndex = 12;
            this.buttonPrintExcel.Text = "Excel";
            this.buttonPrintExcel.UseVisualStyleBackColor = true;
            this.buttonPrintExcel.Click += new System.EventHandler(this.buttonPrintExcel_Click);
            // 
            // manageClassForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1081, 761);
            this.Controls.Add(this.buttonPrintExcel);
            this.Controls.Add(this.buttonPrintWord);
            this.Controls.Add(this.buttonSearcher);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonSort);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "manageClassForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Управление классами";
            this.Load += new System.EventHandler(this.manageClassForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownClass2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownClass1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumberP2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumberP1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButtonYES;
        private System.Windows.Forms.NumericUpDown numericUpDownClass1;
        private System.Windows.Forms.RadioButton radioButtonNo;
        private System.Windows.Forms.NumericUpDown numericUpDownClass2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown numericUpDownNumberP2;
        private System.Windows.Forms.NumericUpDown numericUpDownNumberP1;
        private System.Windows.Forms.RadioButton radioButtonNumberPupilNo;
        private System.Windows.Forms.RadioButton radioButtonNumberPupilYES;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonSort;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelAllClass;
        private System.Windows.Forms.Button buttonSearcher;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button buttonPrintWord;
        private System.Windows.Forms.Button buttonPrintExcel;
    }
}