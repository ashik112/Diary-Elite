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
using diary.Entities;
using System.Data.SqlClient;
using System.IO;


namespace diary.UI
{
    public partial class SignUp : MetroForm
    {
        UserInfo u = new UserInfo();
        LoginFrame l = new LoginFrame();
        public SignUp()
        {
            InitializeComponent();
        }
        public SignUp(LoginFrame l)
        {
            InitializeComponent();
            this.l = l;
        }

        private void SignUp_Load(object sender, EventArgs e)
        {
            this.FocusMe();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (textPassword.Text == "" || textName.Text == "" || textAnswer.Text == "" || textRepeatPassword.Text == "" || textUsername.Text == "" || comboQuestion.Text == "(Choose a Question)")
            {
                MessageBox.Show("Blank Field");
            }
            else if(textPassword.Text==textRepeatPassword.Text)
            {
               BaseAccess b = new BaseAccess();
               
               u.Username = textUsername.Text;
               u.Password=textPassword.Text;
               u.Name = textName.Text;
               u.Question = comboQuestion.Text;
               u.Answer = textAnswer.Text;
               bool m=b.Insert(u);

               if(m)
               {
                   MessageBox.Show("Sign Up Complete!");
                   //LoginFrame l = new LoginFrame();
                   l.setTextBox(textUsername.Text,textPassword.Text);
                   l.Enabled = true;
                   this.Hide();

                   textAnswer.Clear();
                   textName.Clear();
                   textPassword.Clear();
                   textRepeatPassword.Clear();
                   textUsername.Clear();
                   comboQuestion.ResetText();                   

               }
               else
               {
                   MessageBox.Show("Try Again (Username Not Available)");
                   textAnswer.Clear();
                   textName.Clear();
                   textPassword.Clear();
                   textRepeatPassword.Clear();
                   textUsername.Clear();
                   comboQuestion.ResetText(); 
               }
            }
            else
            {
                MessageBox.Show("Passwords do not match");
                textPassword.Text = "";
                textRepeatPassword.Text = "";
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            l.Enabled = true;
            this.Hide();
            l.BringToFront();
            l.Focus();
        }

        private void comboQuestion_SelectedIndexChanged(object sender, EventArgs e)
        {
            u.Question = comboQuestion.Text;
        }

        private void SignUp_FormClosing(object sender, FormClosingEventArgs e)
        {
            l.Enabled = true;
            l.BringToFront();
            l.FocusMe();
        }  
    }
}
