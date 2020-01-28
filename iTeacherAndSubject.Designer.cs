namespace eSchool
{
    partial class iTeacherAndSubject
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
            this.labelID = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxID = new System.Windows.Forms.ComboBox();
            this.comboBoxfkT = new System.Windows.Forms.ComboBox();
            this.comboBoxfkS = new System.Windows.Forms.ComboBox();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonReload = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonFullinfo = new System.Windows.Forms.Button();
            this.buttonPrintWord = new System.Windows.Forms.Button();
            this.buttonPrintExcel = new System.Windows.Forms.Button();
            this.buttonPrintText = new System.Windows.Forms.Button();
            this.buttonSearcher = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(445, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 15;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(877, 587);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(12, 57);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(45, 23);
            this.labelID.TabIndex = 1;
            this.labelID.Text = "Код";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(12, 117);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(135, 23);
            this.label.TabIndex = 2;
            this.label.Text = "Код учителья";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Название предмета";
            // 
            // comboBoxID
            // 
            this.comboBoxID.FormattingEnabled = true;
            this.comboBoxID.Location = new System.Drawing.Point(211, 54);
            this.comboBoxID.Name = "comboBoxID";
            this.comboBoxID.Size = new System.Drawing.Size(100, 31);
            this.comboBoxID.TabIndex = 6;
            // 
            // comboBoxfkT
            // 
            this.comboBoxfkT.FormattingEnabled = true;
            this.comboBoxfkT.Location = new System.Drawing.Point(211, 114);
            this.comboBoxfkT.Name = "comboBoxfkT";
            this.comboBoxfkT.Size = new System.Drawing.Size(228, 31);
            this.comboBoxfkT.TabIndex = 7;
            // 
            // comboBoxfkS
            // 
            this.comboBoxfkS.FormattingEnabled = true;
            this.comboBoxfkS.Location = new System.Drawing.Point(211, 168);
            this.comboBoxfkS.Name = "comboBoxfkS";
            this.comboBoxfkS.Size = new System.Drawing.Size(228, 31);
            this.comboBoxfkS.TabIndex = 8;
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackgroundImage = global::eSchool.Properties.Resources.edit;
            this.buttonEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonEdit.Location = new System.Drawing.Point(262, 429);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(55, 50);
            this.buttonEdit.TabIndex = 12;
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackgroundImage = global::eSchool.Properties.Resources.delete;
            this.buttonDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonDelete.Location = new System.Drawing.Point(323, 429);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(55, 50);
            this.buttonDelete.TabIndex = 11;
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackgroundImage = global::eSchool.Properties.Resources.add;
            this.buttonAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonAdd.Location = new System.Drawing.Point(201, 429);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(55, 50);
            this.buttonAdd.TabIndex = 10;
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonReload
            // 
            this.buttonReload.BackgroundImage = global::eSchool.Properties.Resources.refresh;
            this.buttonReload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonReload.Location = new System.Drawing.Point(384, 429);
            this.buttonReload.Name = "buttonReload";
            this.buttonReload.Size = new System.Drawing.Size(55, 50);
            this.buttonReload.TabIndex = 9;
            this.buttonReload.UseVisualStyleBackColor = true;
            this.buttonReload.Click += new System.EventHandler(this.buttonReload_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonPrintText);
            this.groupBox1.Controls.Add(this.buttonPrintExcel);
            this.groupBox1.Controls.Add(this.buttonPrintWord);
            this.groupBox1.Location = new System.Drawing.Point(16, 498);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(423, 101);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Сохранить как";
            // 
            // buttonFullinfo
            // 
            this.buttonFullinfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonFullinfo.Location = new System.Drawing.Point(27, 429);
            this.buttonFullinfo.Name = "buttonFullinfo";
            this.buttonFullinfo.Size = new System.Drawing.Size(135, 50);
            this.buttonFullinfo.TabIndex = 15;
            this.buttonFullinfo.Text = "Развернуть";
            this.buttonFullinfo.UseVisualStyleBackColor = true;
            this.buttonFullinfo.Click += new System.EventHandler(this.buttonFullinfo_Click);
            // 
            // buttonPrintWord
            // 
            this.buttonPrintWord.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonPrintWord.Location = new System.Drawing.Point(11, 29);
            this.buttonPrintWord.Name = "buttonPrintWord";
            this.buttonPrintWord.Size = new System.Drawing.Size(120, 50);
            this.buttonPrintWord.TabIndex = 18;
            this.buttonPrintWord.Text = "Word";
            this.buttonPrintWord.UseVisualStyleBackColor = true;
            this.buttonPrintWord.Click += new System.EventHandler(this.buttonPrintWord_Click);
            // 
            // buttonPrintExcel
            // 
            this.buttonPrintExcel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonPrintExcel.Location = new System.Drawing.Point(157, 29);
            this.buttonPrintExcel.Name = "buttonPrintExcel";
            this.buttonPrintExcel.Size = new System.Drawing.Size(120, 50);
            this.buttonPrintExcel.TabIndex = 19;
            this.buttonPrintExcel.Text = "Excel";
            this.buttonPrintExcel.UseVisualStyleBackColor = true;
            this.buttonPrintExcel.Click += new System.EventHandler(this.buttonPrintExcel_Click);
            // 
            // buttonPrintText
            // 
            this.buttonPrintText.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonPrintText.Location = new System.Drawing.Point(297, 29);
            this.buttonPrintText.Name = "buttonPrintText";
            this.buttonPrintText.Size = new System.Drawing.Size(120, 50);
            this.buttonPrintText.TabIndex = 20;
            this.buttonPrintText.Text = "Text";
            this.buttonPrintText.UseVisualStyleBackColor = true;
            this.buttonPrintText.Click += new System.EventHandler(this.buttonPrintText_Click);
            // 
            // buttonSearcher
            // 
            this.buttonSearcher.BackgroundImage = global::eSchool.Properties.Resources.loupe;
            this.buttonSearcher.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSearcher.Location = new System.Drawing.Point(409, 234);
            this.buttonSearcher.Name = "buttonSearcher";
            this.buttonSearcher.Size = new System.Drawing.Size(30, 30);
            this.buttonSearcher.TabIndex = 17;
            this.buttonSearcher.UseVisualStyleBackColor = true;
            this.buttonSearcher.Click += new System.EventHandler(this.buttonSearcher_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(12, 234);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(378, 30);
            this.textBoxSearch.TabIndex = 16;
            // 
            // iTeacherAndSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1334, 611);
            this.Controls.Add(this.buttonSearcher);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.buttonFullinfo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonReload);
            this.Controls.Add(this.comboBoxfkS);
            this.Controls.Add(this.comboBoxfkT);
            this.Controls.Add(this.comboBoxID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "iTeacherAndSubject";
            this.Text = "iTeacherAndSubject";
            this.Load += new System.EventHandler(this.iTeacherAndSubject_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxID;
        private System.Windows.Forms.ComboBox comboBoxfkT;
        private System.Windows.Forms.ComboBox comboBoxfkS;
        private System.Windows.Forms.Button buttonReload;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonFullinfo;
        private System.Windows.Forms.Button buttonPrintWord;
        private System.Windows.Forms.Button buttonPrintText;
        private System.Windows.Forms.Button buttonPrintExcel;
        private System.Windows.Forms.Button buttonSearcher;
        public System.Windows.Forms.TextBox textBoxSearch;
    }
}