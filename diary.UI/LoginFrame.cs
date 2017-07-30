using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using diary.BLL;
using diary.DAL;

namespace diary.UI
{
    public partial class LoginFrame : MetroForm
    {
        public static string un,ps;
        public LoginFrame()
        {
            InitializeComponent();

        }

        private void buttonSignIn_Click(object sender, EventArgs e)
        {
         
            BaseAccess sd = new BaseAccess();

            if (sd.compare(textName.Text, textPassword.Text))
            {

                DiaryFrame d = new DiaryFrame(this,textName.Text);
                this.Hide();
                d.Show();
                textName.Clear();
                textPassword.Clear();
            }
            else
            {
                MessageBox.Show("Username and Password Do Not Match");
                textName.Clear();
                textPassword.Clear();
            }
        }




        private void LoginFrame_Load(object sender, EventArgs e)
        {
            this.FocusMe();
        }

        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            SignUp s = new SignUp(this);
            s.Show();
            this.Enabled = false;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            string h = MessageBox.Show("Are you Sure?", "Exit Application", MessageBoxButtons.YesNo).ToString();
            if (h == "Yes")
            {
                this.Close();
                Application.Exit();
            }    
        }
        public void setTextBox(string un, string ps)
        {
            textName.Text = un;
            textPassword.Text = ps;
        }

        private void linkForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgetPassword f = new ForgetPassword(this);
            f.Show();
            this.Enabled = false;
        }

        private void LoginFrame_Enter(object sender, EventArgs e)
        {
            buttonSignIn.PerformClick();
        }

        private void LoginFrame_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        }
    }
