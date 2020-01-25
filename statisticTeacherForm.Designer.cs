namespace eSchool
{
    partial class statisticTeacherForm
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
            this.panelBackground = new System.Windows.Forms.Panel();
            this.panelFemale = new System.Windows.Forms.Panel();
            this.labelFemale = new System.Windows.Forms.Label();
            this.panelMale = new System.Windows.Forms.Panel();
            this.labelMale = new System.Windows.Forms.Label();
            this.panelTotal = new System.Windows.Forms.Panel();
            this.labelTotal = new System.Windows.Forms.Label();
            this.panelBackground.SuspendLayout();
            this.panelFemale.SuspendLayout();
            this.panelMale.SuspendLayout();
            this.panelTotal.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBackground
            // 
            this.panelBackground.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panelBackground.Controls.Add(this.panelFemale);
            this.panelBackground.Controls.Add(this.panelMale);
            this.panelBackground.Controls.Add(this.panelTotal);
            this.panelBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBackground.Location = new System.Drawing.Point(0, 0);
            this.panelBackground.Name = "panelBackground";
            this.panelBackground.Size = new System.Drawing.Size(884, 761);
            this.panelBackground.TabIndex = 0;
            // 
            // panelFemale
            // 
            this.panelFemale.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelFemale.BackColor = System.Drawing.Color.Crimson;
            this.panelFemale.Controls.Add(this.labelFemale);
            this.panelFemale.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.panelFemale.Location = new System.Drawing.Point(434, 325);
            this.panelFemale.Name = "panelFemale";
            this.panelFemale.Size = new System.Drawing.Size(450, 436);
            this.panelFemale.TabIndex = 2;
            // 
            // labelFemale
            // 
            this.labelFemale.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelFemale.Location = new System.Drawing.Point(0, 0);
            this.labelFemale.Name = "labelFemale";
            this.labelFemale.Size = new System.Drawing.Size(450, 436);
            this.labelFemale.TabIndex = 0;
            this.labelFemale.Text = "Женщины: 50%";
            this.labelFemale.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelFemale.MouseEnter += new System.EventHandler(this.labelFemale_MouseEnter);
            this.labelFemale.MouseLeave += new System.EventHandler(this.labelFemale_MouseLeave);
            // 
            // panelMale
            // 
            this.panelMale.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelMale.BackColor = System.Drawing.Color.Navy;
            this.panelMale.Controls.Add(this.labelMale);
            this.panelMale.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.panelMale.Location = new System.Drawing.Point(0, 325);
            this.panelMale.Name = "panelMale";
            this.panelMale.Size = new System.Drawing.Size(450, 436);
            this.panelMale.TabIndex = 1;
            // 
            // labelMale
            // 
            this.labelMale.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelMale.Location = new System.Drawing.Point(0, 0);
            this.labelMale.Name = "labelMale";
            this.labelMale.Size = new System.Drawing.Size(450, 436);
            this.labelMale.TabIndex = 0;
            this.labelMale.Text = "Мужчины: 50%";
            this.labelMale.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelMale.MouseEnter += new System.EventHandler(this.labelMale_MouseEnter);
            this.labelMale.MouseLeave += new System.EventHandler(this.labelMale_MouseLeave);
            // 
            // panelTotal
            // 
            this.panelTotal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelTotal.BackColor = System.Drawing.Color.Snow;
            this.panelTotal.Controls.Add(this.labelTotal);
            this.panelTotal.Location = new System.Drawing.Point(0, 0);
            this.panelTotal.Name = "panelTotal";
            this.panelTotal.Size = new System.Drawing.Size(884, 325);
            this.panelTotal.TabIndex = 0;
            // 
            // labelTotal
            // 
            this.labelTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTotal.Location = new System.Drawing.Point(0, 0);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(884, 325);
            this.labelTotal.TabIndex = 0;
            this.labelTotal.Text = "Общая количество учителей: 100";
            this.labelTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelTotal.MouseEnter += new System.EventHandler(this.labelTotal_MouseEnter);
            this.labelTotal.MouseLeave += new System.EventHandler(this.labelTotal_MouseLeave);
            // 
            // statisticTeacherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(30F, 51F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 761);
            this.Controls.Add(this.panelBackground);
            this.Font = new System.Drawing.Font("Century Schoolbook", 33F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(15, 12, 15, 12);
            this.Name = "statisticTeacherForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "statisticTeacherForm";
            this.Load += new System.EventHandler(this.statisticTeacherForm_Load);
            this.panelBackground.ResumeLayout(false);
            this.panelFemale.ResumeLayout(false);
            this.panelMale.ResumeLayout(false);
            this.panelTotal.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBackground;
        private System.Windows.Forms.Panel panelTotal;
        private System.Windows.Forms.Panel panelFemale;
        private System.Windows.Forms.Panel panelMale;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label labelFemale;
        private System.Windows.Forms.Label labelMale;
    }
}