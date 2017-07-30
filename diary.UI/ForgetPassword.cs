using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using diary.BLL;
using diary.DAL;

namespace diary.UI
{
    public partial class ForgetPassword : MetroForm
    {
        public string currentState;
        LoginFrame lf = new LoginFrame();
        public ForgetPassword()
        {
            InitializeComponent();
        }
        public ForgetPassword(LoginFrame lf)
        {
            InitializeComponent();
            this.lf = lf;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if(currentState==labelUsername.Text)
            {
                BaseAccess u = new BaseAccess();
                
                if(u.checkUsername(textUsername.Text))
                {
                    labelUsername.Hide();
                    textUsername.Hide();
                    currentState = labelSecurity.Text;
                    labelSecurity.Show();
                    labelAnswer.Show();
                    labelQuestion.Show();
                    textAnswer.Show();
                }
                else
                {
                    MessageBox.Show("Error: Username not found");
                }
            }
            if (currentState == labelSecurity.Text)
            {
                BaseAccess u = new BaseAccess();
                string temp;
                temp = u.getSecurityQuestion(textUsername.Text);
                if(temp==null)
                {
                    MessageBox.Show("Error:404");
                }
                else
                {
                    labelQuestion.Text = temp;
                    if (textAnswer.Text != "")
                    {
                        if (u.checkAnswer(textUsername.Text, textAnswer.Text))
                        {
                            labelSecurity.Hide();
                            labelAnswer.Hide();
                            labelQuestion.Hide();
                            textAnswer.Hide();
                            currentState = labelPassword.Text;
                            labelPassword.Show();
                            labelRepeatPassword.Show();
                            textPassword.Show();
                            textRepeatPassword.Show();
                        }
                        else
                        {
                            MessageBox.Show("Wrong Answer!!!");
                        }
                    }
                }
            }
            if (currentState == labelPassword.Text)
            {
                if (textPassword.Text != "" && textRepeatPassword.Text != "" && textRepeatPassword.Text == textPassword.Text)
                {
                    BaseAccess u = new BaseAccess();
                    u.updatePassword(textUsername.Text, textPassword.Text);
                    MessageBox.Show("Password Change Successful");
                
                    this.Hide();

                   // LoginFrame l = new LoginFrame();

                    lf.setTextBox(textUsername.Text,textPassword.Text);
                    lf.Enabled = true;
                    lf.Show();
                    lf.BringToFront();

                }
                else if (textPassword.Text != textRepeatPassword.Text)
                {
                    MessageBox.Show("Passwords Do Not Match/ Have Not Been Entered");
                }
            }
        }

        private void ForgetPassword_Load(object sender, EventArgs e)
        {
            labelSecurity.Hide();
            labelAnswer.Hide();
            labelQuestion.Hide();
            textAnswer.Hide();
            labelPassword.Hide();
            labelRepeatPassword.Hide();
            textPassword.Hide();
            textRepeatPassword.Hide();
            currentState = labelUsername.Text;


            //this.BringToFront();
            this.FocusMe();
          //  this.OnDoubleClick(e);
            //ForgetPassword.


        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            lf.Show();
            lf.BringToFront();
            lf.Enabled = true;
            lf.FocusMe();
            this.Hide();
        }

        private void ForgetPassword_Enter(object sender, EventArgs e)
        {
            btnConfirm.PerformClick();
        }

        private void ForgetPassword_FormClosing(object sender, FormClosingEventArgs e)
        {
            lf.Enabled = true;
            lf.Show();
            lf.BringToFront();
            lf.FocusMe();
            
        }
    }
}
