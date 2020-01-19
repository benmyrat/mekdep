namespace eSchool
{
    partial class authorizationForm
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
            this.aLabelPanel = new System.Windows.Forms.Panel();
            this.aTitile = new System.Windows.Forms.Label();
            this.aBackgroundPanel = new System.Windows.Forms.Panel();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.textBoxPass = new System.Windows.Forms.TextBox();
            this.signInButton = new System.Windows.Forms.Button();
            this.showPass = new System.Windows.Forms.CheckBox();
            this.passPic = new System.Windows.Forms.PictureBox();
            this.userPic = new System.Windows.Forms.PictureBox();
            this.aLabelPanel.SuspendLayout();
            this.aBackgroundPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.passPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userPic)).BeginInit();
            this.SuspendLayout();
            // 
            // aLabelPanel
            // 
            this.aLabelPanel.Controls.Add(this.aTitile);
            this.aLabelPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.aLabelPanel.Location = new System.Drawing.Point(0, 0);
            this.aLabelPanel.Name = "aLabelPanel";
            this.aLabelPanel.Size = new System.Drawing.Size(434, 154);
            this.aLabelPanel.TabIndex = 0;
            // 
            // aTitile
            // 
            this.aTitile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.aTitile.Font = new System.Drawing.Font("Century Schoolbook", 44.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aTitile.Location = new System.Drawing.Point(0, 0);
            this.aTitile.Name = "aTitile";
            this.aTitile.Size = new System.Drawing.Size(434, 154);
            this.aTitile.TabIndex = 0;
            this.aTitile.Text = "Авторизация";
            this.aTitile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // aBackgroundPanel
            // 
            this.aBackgroundPanel.BackColor = System.Drawing.Color.SeaShell;
            this.aBackgroundPanel.Controls.Add(this.signInButton);
            this.aBackgroundPanel.Controls.Add(this.showPass);
            this.aBackgroundPanel.Controls.Add(this.textBoxPass);
            this.aBackgroundPanel.Controls.Add(this.textBoxLogin);
            this.aBackgroundPanel.Controls.Add(this.passPic);
            this.aBackgroundPanel.Controls.Add(this.userPic);
            this.aBackgroundPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.aBackgroundPanel.Location = new System.Drawing.Point(0, 154);
            this.aBackgroundPanel.Name = "aBackgroundPanel";
            this.aBackgroundPanel.Size = new System.Drawing.Size(434, 407);
            this.aBackgroundPanel.TabIndex = 1;
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLogin.Location = new System.Drawing.Point(100, 67);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(322, 40);
            this.textBoxLogin.TabIndex = 6;
            // 
            // textBoxPass
            // 
            this.textBoxPass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPass.Location = new System.Drawing.Point(100, 207);
            this.textBoxPass.Name = "textBoxPass";
            this.textBoxPass.Size = new System.Drawing.Size(258, 40);
            this.textBoxPass.TabIndex = 7;
            this.textBoxPass.UseSystemPasswordChar = true;
            // 
            // signInButton
            // 
            this.signInButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.signInButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signInButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.signInButton.FlatAppearance.BorderSize = 3;
            this.signInButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lavender;
            this.signInButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Window;
            this.signInButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signInButton.Font = new System.Drawing.Font("Georgia", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signInButton.ForeColor = System.Drawing.Color.Black;
            this.signInButton.Location = new System.Drawing.Point(147, 304);
            this.signInButton.Name = "signInButton";
            this.signInButton.Size = new System.Drawing.Size(160, 60);
            this.signInButton.TabIndex = 9;
            this.signInButton.Text = "Войти";
            this.signInButton.UseVisualStyleBackColor = true;
            this.signInButton.Click += new System.EventHandler(this.signInButton_Click);
            // 
            // showPass
            // 
            this.showPass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.showPass.AutoSize = true;
            this.showPass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.showPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showPass.Image = global::eSchool.Properties.Resources.closed_eye;
            this.showPass.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.showPass.Location = new System.Drawing.Point(364, 204);
            this.showPass.Name = "showPass";
            this.showPass.Size = new System.Drawing.Size(58, 43);
            this.showPass.TabIndex = 8;
            this.showPass.UseVisualStyleBackColor = true;
            this.showPass.CheckedChanged += new System.EventHandler(this.showPass_CheckedChanged);
            // 
            // passPic
            // 
            this.passPic.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passPic.BackgroundImage = global::eSchool.Properties.Resources._lock;
            this.passPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.passPic.Location = new System.Drawing.Point(12, 188);
            this.passPic.Name = "passPic";
            this.passPic.Size = new System.Drawing.Size(82, 80);
            this.passPic.TabIndex = 5;
            this.passPic.TabStop = false;
            // 
            // userPic
            // 
            this.userPic.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.userPic.BackgroundImage = global::eSchool.Properties.Resources.user;
            this.userPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.userPic.Location = new System.Drawing.Point(12, 43);
            this.userPic.Name = "userPic";
            this.userPic.Size = new System.Drawing.Size(82, 80);
            this.userPic.TabIndex = 4;
            this.userPic.TabStop = false;
            // 
            // authorizationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(434, 561);
            this.Controls.Add(this.aBackgroundPanel);
            this.Controls.Add(this.aLabelPanel);
            this.Font = new System.Drawing.Font("Century Schoolbook", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.SeaShell;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "authorizationForm";
            this.Text = "Авторизация";
            this.aLabelPanel.ResumeLayout(false);
            this.aBackgroundPanel.ResumeLayout(false);
            this.aBackgroundPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.passPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel aLabelPanel;
        private System.Windows.Forms.Panel aBackgroundPanel;
        private System.Windows.Forms.Label aTitile;
        private System.Windows.Forms.PictureBox passPic;
        private System.Windows.Forms.PictureBox userPic;
        private System.Windows.Forms.TextBox textBoxPass;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.CheckBox showPass;
        private System.Windows.Forms.Button signInButton;
    }
}