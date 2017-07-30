namespace diary.UI
{
    partial class LoginFrame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginFrame));
            this.pictureHappy = new System.Windows.Forms.PictureBox();
            this.labelDiary = new System.Windows.Forms.Label();
            this.labelElite = new System.Windows.Forms.Label();
            this.buttonSignIn = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonSignUp = new System.Windows.Forms.Button();
            this.linkForgotPassword = new System.Windows.Forms.LinkLabel();
            this.textPassword = new MetroFramework.Controls.MetroTextBox();
            this.textName = new MetroFramework.Controls.MetroTextBox();
            this.groupEnter = new System.Windows.Forms.GroupBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureHappy)).BeginInit();
            this.groupEnter.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureHappy
            // 
            this.pictureHappy.BackColor = System.Drawing.Color.Transparent;
            this.pictureHappy.Image = global::diary.UI.Properties.Resources.icon_happy;
            this.pictureHappy.Location = new System.Drawing.Point(122, 63);
            this.pictureHappy.Name = "pictureHappy";
            this.pictureHappy.Size = new System.Drawing.Size(24, 20);
            this.pictureHappy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureHappy.TabIndex = 10;
            this.pictureHappy.TabStop = false;
            // 
            // labelDiary
            // 
            this.labelDiary.AutoEllipsis = true;
            this.labelDiary.AutoSize = true;
            this.labelDiary.BackColor = System.Drawing.Color.Transparent;
            this.labelDiary.Font = new System.Drawing.Font("Buxton Sketch", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDiary.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.labelDiary.Location = new System.Drawing.Point(75, 57);
            this.labelDiary.Name = "labelDiary";
            this.labelDiary.Size = new System.Drawing.Size(162, 79);
            this.labelDiary.TabIndex = 0;
            this.labelDiary.Text = "Diary";
            this.labelDiary.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelElite
            // 
            this.labelElite.AutoEllipsis = true;
            this.labelElite.AutoSize = true;
            this.labelElite.BackColor = System.Drawing.Color.Transparent;
            this.labelElite.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.labelElite.Font = new System.Drawing.Font("Old English Text MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelElite.ForeColor = System.Drawing.Color.Crimson;
            this.labelElite.Location = new System.Drawing.Point(208, 55);
            this.labelElite.Name = "labelElite";
            this.labelElite.Size = new System.Drawing.Size(56, 26);
            this.labelElite.TabIndex = 0;
            this.labelElite.Text = "Elite";
            this.labelElite.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // buttonSignIn
            // 
            this.buttonSignIn.BackColor = System.Drawing.Color.Transparent;
            this.buttonSignIn.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.buttonSignIn.FlatAppearance.BorderSize = 0;
            this.buttonSignIn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonSignIn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Thistle;
            this.buttonSignIn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSignIn.Font = new System.Drawing.Font("Chiller", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSignIn.ForeColor = System.Drawing.Color.Indigo;
            this.buttonSignIn.Location = new System.Drawing.Point(75, 379);
            this.buttonSignIn.Name = "buttonSignIn";
            this.buttonSignIn.Size = new System.Drawing.Size(162, 47);
            this.buttonSignIn.TabIndex = 4;
            this.buttonSignIn.Text = "Sign In";
            this.buttonSignIn.UseCompatibleTextRendering = true;
            this.buttonSignIn.UseVisualStyleBackColor = false;
            this.buttonSignIn.Click += new System.EventHandler(this.buttonSignIn_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.Transparent;
            this.buttonExit.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.buttonExit.FlatAppearance.BorderSize = 0;
            this.buttonExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Pink;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonExit.Font = new System.Drawing.Font("Chiller", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.ForeColor = System.Drawing.Color.Crimson;
            this.buttonExit.Location = new System.Drawing.Point(76, 525);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(160, 47);
            this.buttonExit.TabIndex = 6;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseCompatibleTextRendering = true;
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonSignUp
            // 
            this.buttonSignUp.BackColor = System.Drawing.Color.Transparent;
            this.buttonSignUp.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.buttonSignUp.FlatAppearance.BorderSize = 0;
            this.buttonSignUp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonSignUp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Tan;
            this.buttonSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSignUp.Font = new System.Drawing.Font("Chiller", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSignUp.ForeColor = System.Drawing.Color.DarkRed;
            this.buttonSignUp.Location = new System.Drawing.Point(76, 452);
            this.buttonSignUp.Name = "buttonSignUp";
            this.buttonSignUp.Size = new System.Drawing.Size(160, 47);
            this.buttonSignUp.TabIndex = 5;
            this.buttonSignUp.Text = "Sign Up";
            this.buttonSignUp.UseCompatibleTextRendering = true;
            this.buttonSignUp.UseVisualStyleBackColor = false;
            this.buttonSignUp.Click += new System.EventHandler(this.buttonSignUp_Click);
            // 
            // linkForgotPassword
            // 
            this.linkForgotPassword.ActiveLinkColor = System.Drawing.Color.Crimson;
            this.linkForgotPassword.AutoSize = true;
            this.linkForgotPassword.BackColor = System.Drawing.Color.Transparent;
            this.linkForgotPassword.Font = new System.Drawing.Font("Buxton Sketch", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkForgotPassword.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkForgotPassword.LinkColor = System.Drawing.Color.Teal;
            this.linkForgotPassword.Location = new System.Drawing.Point(54, 666);
            this.linkForgotPassword.Name = "linkForgotPassword";
            this.linkForgotPassword.Size = new System.Drawing.Size(193, 19);
            this.linkForgotPassword.TabIndex = 7;
            this.linkForgotPassword.TabStop = true;
            this.linkForgotPassword.Text = "Forgot Password?  Click here";
            this.linkForgotPassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkForgotPassword_LinkClicked);
            // 
            // textPassword
            // 
            this.textPassword.BackColor = System.Drawing.Color.White;
            this.textPassword.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.textPassword.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.textPassword.ForeColor = System.Drawing.Color.Indigo;
            this.textPassword.Lines = new string[0];
            this.textPassword.Location = new System.Drawing.Point(126, 104);
            this.textPassword.MaxLength = 32767;
            this.textPassword.Name = "textPassword";
            this.textPassword.PasswordChar = '●';
            this.textPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textPassword.SelectedText = "";
            this.textPassword.Size = new System.Drawing.Size(131, 25);
            this.textPassword.Style = MetroFramework.MetroColorStyle.Black;
            this.textPassword.TabIndex = 2;
            this.textPassword.UseCustomBackColor = true;
            this.textPassword.UseCustomForeColor = true;
            this.textPassword.UseSelectable = true;
            this.textPassword.UseSystemPasswordChar = true;
            // 
            // textName
            // 
            this.textName.BackColor = System.Drawing.Color.White;
            this.textName.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.textName.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.textName.ForeColor = System.Drawing.Color.Indigo;
            this.textName.Lines = new string[0];
            this.textName.Location = new System.Drawing.Point(126, 34);
            this.textName.MaxLength = 32767;
            this.textName.Name = "textName";
            this.textName.PasswordChar = '\0';
            this.textName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textName.SelectedText = "";
            this.textName.Size = new System.Drawing.Size(131, 25);
            this.textName.Style = MetroFramework.MetroColorStyle.Black;
            this.textName.TabIndex = 1;
            this.textName.UseCustomBackColor = true;
            this.textName.UseCustomForeColor = true;
            this.textName.UseSelectable = true;
            // 
            // groupEnter
            // 
            this.groupEnter.BackColor = System.Drawing.Color.Transparent;
            this.groupEnter.Controls.Add(this.labelPassword);
            this.groupEnter.Controls.Add(this.textName);
            this.groupEnter.Controls.Add(this.labelUsername);
            this.groupEnter.Controls.Add(this.textPassword);
            this.groupEnter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupEnter.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupEnter.ForeColor = System.Drawing.Color.Black;
            this.groupEnter.Location = new System.Drawing.Point(12, 166);
            this.groupEnter.Name = "groupEnter";
            this.groupEnter.Size = new System.Drawing.Size(275, 155);
            this.groupEnter.TabIndex = 1;
            this.groupEnter.TabStop = false;
            this.groupEnter.Text = "Enter";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.BackColor = System.Drawing.Color.Transparent;
            this.labelPassword.Font = new System.Drawing.Font("Bauhaus 93", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.labelPassword.Location = new System.Drawing.Point(33, 107);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(89, 21);
            this.labelPassword.TabIndex = 12;
            this.labelPassword.Text = "Password";
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.BackColor = System.Drawing.Color.Transparent;
            this.labelUsername.Font = new System.Drawing.Font("Bauhaus 93", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.labelUsername.Location = new System.Drawing.Point(31, 38);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(92, 21);
            this.labelUsername.TabIndex = 11;
            this.labelUsername.Text = "Username";
            // 
            // LoginFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BackImage = global::diary.UI.Properties.Resources.colorAll___Copy;
            this.BackLocation = MetroFramework.Forms.BackLocation.BottomLeft;
            this.BackMaxSize = 700;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(302, 707);
            this.Controls.Add(this.labelElite);
            this.Controls.Add(this.linkForgotPassword);
            this.Controls.Add(this.buttonSignUp);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonSignIn);
            this.Controls.Add(this.pictureHappy);
            this.Controls.Add(this.groupEnter);
            this.Controls.Add(this.labelDiary);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "LoginFrame";
            this.Padding = new System.Windows.Forms.Padding(20, 65, 20, 22);
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Welcome";
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoginFrame_FormClosing);
            this.Load += new System.EventHandler(this.LoginFrame_Load);
            this.Enter += new System.EventHandler(this.LoginFrame_Enter);
            ((System.ComponentModel.ISupportInitialize)(this.pictureHappy)).EndInit();
            this.groupEnter.ResumeLayout(false);
            this.groupEnter.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureHappy;
        private System.Windows.Forms.Label labelDiary;
        private System.Windows.Forms.Label labelElite;
        private System.Windows.Forms.Button buttonSignIn;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonSignUp;
        private System.Windows.Forms.LinkLabel linkForgotPassword;
        private MetroFramework.Controls.MetroTextBox textPassword;
        private MetroFramework.Controls.MetroTextBox textName;
        private System.Windows.Forms.GroupBox groupEnter;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelUsername;
    }
}