namespace eSchool
{
    partial class printSubjects
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
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.buttonSearcher = new System.Windows.Forms.Button();
            this.buttonPrintDocx = new System.Windows.Forms.Button();
            this.buttonPrintXlsx = new System.Windows.Forms.Button();
            this.buttonPrintTXT = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelAll = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(12, 28);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(460, 30);
            this.textBoxSearch.TabIndex = 0;
            // 
            // buttonSearcher
            // 
            this.buttonSearcher.BackgroundImage = global::eSchool.Properties.Resources.loupe;
            this.buttonSearcher.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSearcher.Location = new System.Drawing.Point(480, 28);
            this.buttonSearcher.Name = "buttonSearcher";
            this.buttonSearcher.Size = new System.Drawing.Size(30, 30);
            this.buttonSearcher.TabIndex = 3;
            this.buttonSearcher.UseVisualStyleBackColor = true;
            this.buttonSearcher.Click += new System.EventHandler(this.buttonSearcher_Click);
            // 
            // buttonPrintDocx
            // 
            this.buttonPrintDocx.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPrintDocx.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPrintDocx.Location = new System.Drawing.Point(12, 78);
            this.buttonPrintDocx.Name = "buttonPrintDocx";
            this.buttonPrintDocx.Size = new System.Drawing.Size(120, 40);
            this.buttonPrintDocx.TabIndex = 19;
            this.buttonPrintDocx.Text = "Word";
            this.buttonPrintDocx.UseVisualStyleBackColor = true;
            this.buttonPrintDocx.Click += new System.EventHandler(this.buttonPrintDocx_Click);
            // 
            // buttonPrintXlsx
            // 
            this.buttonPrintXlsx.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPrintXlsx.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPrintXlsx.Location = new System.Drawing.Point(264, 78);
            this.buttonPrintXlsx.Name = "buttonPrintXlsx";
            this.buttonPrintXlsx.Size = new System.Drawing.Size(120, 40);
            this.buttonPrintXlsx.TabIndex = 21;
            this.buttonPrintXlsx.Text = "Excel";
            this.buttonPrintXlsx.UseVisualStyleBackColor = true;
            this.buttonPrintXlsx.Click += new System.EventHandler(this.buttonPrintXlsx_Click);
            // 
            // buttonPrintTXT
            // 
            this.buttonPrintTXT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPrintTXT.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPrintTXT.Location = new System.Drawing.Point(138, 78);
            this.buttonPrintTXT.Name = "buttonPrintTXT";
            this.buttonPrintTXT.Size = new System.Drawing.Size(120, 40);
            this.buttonPrintTXT.TabIndex = 20;
            this.buttonPrintTXT.Text = "Text";
            this.buttonPrintTXT.UseVisualStyleBackColor = true;
            this.buttonPrintTXT.Click += new System.EventHandler(this.buttonPrintTXT_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(390, 78);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 40);
            this.button1.TabIndex = 22;
            this.button1.Text = "Очистка";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelAll);
            this.panel1.Location = new System.Drawing.Point(12, 140);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(498, 50);
            this.panel1.TabIndex = 23;
            // 
            // labelAll
            // 
            this.labelAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelAll.Font = new System.Drawing.Font("Century Schoolbook", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAll.Location = new System.Drawing.Point(0, 0);
            this.labelAll.Name = "labelAll";
            this.labelAll.Size = new System.Drawing.Size(498, 50);
            this.labelAll.TabIndex = 0;
            this.labelAll.Text = "Общая количество пердметов:";
            this.labelAll.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(525, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(647, 330);
            this.dataGridView1.TabIndex = 24;
            // 
            // printSubjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1184, 369);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonPrintXlsx);
            this.Controls.Add(this.buttonPrintTXT);
            this.Controls.Add(this.buttonPrintDocx);
            this.Controls.Add(this.buttonSearcher);
            this.Controls.Add(this.textBoxSearch);
            this.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "printSubjects";
            this.Text = "Экспорт Предметов";
            this.Load += new System.EventHandler(this.printSubjects_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonSearcher;
        private System.Windows.Forms.Button buttonPrintDocx;
        private System.Windows.Forms.Button buttonPrintXlsx;
        private System.Windows.Forms.Button buttonPrintTXT;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelAll;
        private System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.SaveFileDialog sFileDialog;
    }
}