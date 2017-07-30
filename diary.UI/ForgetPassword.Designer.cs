namespace diary.UI
{
    partial class ForgetPassword
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
            this.textUsername = new MetroFramework.Controls.MetroTextBox();
            this.labelUsername = new System.Windows.Forms.Label();
            this.labelAnswer = new System.Windows.Forms.Label();
            this.labelSecurity = new System.Windows.Forms.Label();
            this.textAnswer = new MetroFramework.Controls.MetroTextBox();
            this.btnCancel = new MetroFramework.Controls.MetroButton();
            this.btnConfirm = new MetroFramework.Controls.MetroButton();
            this.textRepeatPassword = new MetroFramework.Controls.MetroTextBox();
            this.textPassword = new MetroFramework.Controls.MetroTextBox();
            this.labelRepeatPassword = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelQuestion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textUsername
            // 
            this.textUsername.BackColor = System.Drawing.Color.White;
            this.textUsername.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.textUsername.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.textUsername.ForeColor = System.Drawing.Color.Indigo;
            this.textUsername.Lines = new string[0];
            this.textUsername.Location = new System.Drawing.Point(282, 101);
            this.textUsername.MaxLength = 32767;
            this.textUsername.Name = "textUsername";
            this.textUsername.PasswordChar = '\0';
            this.textUsername.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textUsername.SelectedText = "";
            this.textUsername.Size = new System.Drawing.Size(174, 23);
            this.textUsername.TabIndex = 1;
            this.textUsername.UseSelectable = true;
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.BackColor = System.Drawing.Color.Transparent;
            this.labelUsername.Font = new System.Drawing.Font("Siyam Rupali", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.Location = new System.Drawing.Point(81, 95);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(113, 29);
            this.labelUsername.TabIndex = 11;
            this.labelUsername.Text = "Username";
            // 
            // labelAnswer
            // 
            this.labelAnswer.AutoSize = true;
            this.labelAnswer.BackColor = System.Drawing.Color.Transparent;
            this.labelAnswer.Font = new System.Drawing.Font("Siyam Rupali", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAnswer.Location = new System.Drawing.Point(72, 232);
            this.labelAnswer.Name = "labelAnswer";
            this.labelAnswer.Size = new System.Drawing.Size(84, 29);
            this.labelAnswer.TabIndex = 15;
            this.labelAnswer.Text = "Answer";
            // 
            // labelSecurity
            // 
            this.labelSecurity.AutoSize = true;
            this.labelSecurity.BackColor = System.Drawing.Color.Transparent;
            this.labelSecurity.Font = new System.Drawing.Font("Siyam Rupali", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSecurity.Location = new System.Drawing.Point(72, 171);
            this.labelSecurity.Name = "labelSecurity";
            this.labelSecurity.Size = new System.Drawing.Size(185, 29);
            this.labelSecurity.TabIndex = 14;
            this.labelSecurity.Text = "Security Question";
            // 
            // textAnswer
            // 
            this.textAnswer.BackColor = System.Drawing.Color.White;
            this.textAnswer.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.textAnswer.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.textAnswer.ForeColor = System.Drawing.Color.Indigo;
            this.textAnswer.Lines = new string[0];
            this.textAnswer.Location = new System.Drawing.Point(273, 238);
            this.textAnswer.MaxLength = 32767;
            this.textAnswer.Name = "textAnswer";
            this.textAnswer.PasswordChar = '\0';
            this.textAnswer.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textAnswer.SelectedText = "";
            this.textAnswer.Size = new System.Drawing.Size(174, 23);
            this.textAnswer.TabIndex = 2;
            this.textAnswer.UseSelectable = true;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Indigo;
            this.btnCancel.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Highlight = true;
            this.btnCancel.Location = new System.Drawing.Point(287, 342);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(0);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(128, 38);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseCustomBackColor = true;
            this.btnCancel.UseCustomForeColor = true;
            this.btnCancel.UseSelectable = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.Indigo;
            this.btnConfirm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnConfirm.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnConfirm.ForeColor = System.Drawing.Color.White;
            this.btnConfirm.Highlight = true;
            this.btnConfirm.Location = new System.Drawing.Point(86, 342);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(0);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(128, 38);
            this.btnConfirm.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnConfirm.TabIndex = 6;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnConfirm.UseCustomBackColor = true;
            this.btnConfirm.UseCustomForeColor = true;
            this.btnConfirm.UseSelectable = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // textRepeatPassword
            // 
            this.textRepeatPassword.BackColor = System.Drawing.Color.White;
            this.textRepeatPassword.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.textRepeatPassword.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.textRepeatPassword.ForeColor = System.Drawing.Color.Indigo;
            this.textRepeatPassword.Lines = new string[0];
            this.textRepeatPassword.Location = new System.Drawing.Point(273, 232);
            this.textRepeatPassword.MaxLength = 32767;
            this.textRepeatPassword.Name = "textRepeatPassword";
            this.textRepeatPassword.PasswordChar = '●';
            this.textRepeatPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textRepeatPassword.SelectedText = "";
            this.textRepeatPassword.Size = new System.Drawing.Size(174, 25);
            this.textRepeatPassword.Style = MetroFramework.MetroColorStyle.Black;
            this.textRepeatPassword.TabIndex = 5;
            this.textRepeatPassword.UseCustomBackColor = true;
            this.textRepeatPassword.UseCustomForeColor = true;
            this.textRepeatPassword.UseSelectable = true;
            this.textRepeatPassword.UseSystemPasswordChar = true;
            // 
            // textPassword
            // 
            this.textPassword.BackColor = System.Drawing.Color.White;
            this.textPassword.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.textPassword.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.textPassword.ForeColor = System.Drawing.Color.Indigo;
            this.textPassword.Lines = new string[0];
            this.textPassword.Location = new System.Drawing.Point(273, 190);
            this.textPassword.MaxLength = 32767;
            this.textPassword.Name = "textPassword";
            this.textPassword.PasswordChar = '●';
            this.textPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textPassword.SelectedText = "";
            this.textPassword.Size = new System.Drawing.Size(174, 25);
            this.textPassword.Style = MetroFramework.MetroColorStyle.Black;
            this.textPassword.TabIndex = 3;
            this.textPassword.UseCustomBackColor = true;
            this.textPassword.UseCustomForeColor = true;
            this.textPassword.UseSelectable = true;
            this.textPassword.UseSystemPasswordChar = true;
            // 
            // labelRepeatPassword
            // 
            this.labelRepeatPassword.AutoSize = true;
            this.labelRepeatPassword.BackColor = System.Drawing.Color.Transparent;
            this.labelRepeatPassword.Font = new System.Drawing.Font("Siyam Rupali", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRepeatPassword.Location = new System.Drawing.Point(72, 228);
            this.labelRepeatPassword.Name = "labelRepeatPassword";
            this.labelRepeatPassword.Size = new System.Drawing.Size(179, 29);
            this.labelRepeatPassword.TabIndex = 21;
            this.labelRepeatPassword.Text = "Repeat Password";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.BackColor = System.Drawing.Color.Transparent;
            this.labelPassword.Font = new System.Drawing.Font("Siyam Rupali", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.Location = new System.Drawing.Point(72, 186);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(155, 29);
            this.labelPassword.TabIndex = 19;
            this.labelPassword.Text = "New Password";
            // 
            // labelQuestion
            // 
            this.labelQuestion.AutoSize = true;
            this.labelQuestion.BackColor = System.Drawing.Color.Transparent;
            this.labelQuestion.Font = new System.Drawing.Font("Siyam Rupali", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuestion.ForeColor = System.Drawing.Color.DarkBlue;
            this.labelQuestion.Location = new System.Drawing.Point(72, 203);
            this.labelQuestion.Name = "labelQuestion";
            this.labelQuestion.Size = new System.Drawing.Size(154, 29);
            this.labelQuestion.TabIndex = 23;
            this.labelQuestion.Text = "Question Here";
            // 
            // ForgetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackImage = global::diary.UI.Properties.Resources.colorAll___Copy;
            this.BackMaxSize = 1000;
            this.ClientSize = new System.Drawing.Size(519, 415);
            this.Controls.Add(this.labelQuestion);
            this.Controls.Add(this.textRepeatPassword);
            this.Controls.Add(this.textPassword);
            this.Controls.Add(this.labelRepeatPassword);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.labelAnswer);
            this.Controls.Add(this.labelSecurity);
            this.Controls.Add(this.textAnswer);
            this.Controls.Add(this.textUsername);
            this.Controls.Add(this.labelUsername);
            this.MaximizeBox = false;
            this.Name = "ForgetPassword";
            this.Resizable = false;
            this.Text = "ForgetPassword";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ForgetPassword_FormClosing);
            this.Load += new System.EventHandler(this.ForgetPassword_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox textUsername;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label labelAnswer;
        private System.Windows.Forms.Label labelSecurity;
        private MetroFramework.Controls.MetroTextBox textAnswer;
        private MetroFramework.Controls.MetroButton btnCancel;
        private MetroFramework.Controls.MetroButton btnConfirm;
        private MetroFramework.Controls.MetroTextBox textRepeatPassword;
        private MetroFramework.Controls.MetroTextBox textPassword;
        private System.Windows.Forms.Label labelRepeatPassword;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelQuestion;
    }
}