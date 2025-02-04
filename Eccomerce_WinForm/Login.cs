using BLL;
using Business.Models;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation
{
    public partial class Login : Form
    {
        private readonly UsersServices userService;

        public Login()
        {
            InitializeComponent();
            userService = new UsersServices();
            btn_login.Click += (s, e) => HandleEmail(text_email.Text, text_Passowrd.Text);
        }

        private void HandleEmail(string email, string password)
        {
            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("All fields are required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            UserVM userVM = new UserVM
            {
                Email = email,
                Password = password
            };

            var data = userService.Login(userVM);

            if (data.Rows.Count > 0)
            {
                string userRole = data.Rows[0]["Role"].ToString();
                int userId = (int)data.Rows[0]["UserId"];
                string UserName = data.Rows[0]["Username"].ToString();

                if (userRole.Contains("Admin"))
                {
                    MessageBox.Show("Welcome, Admin!", "Login Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    new Admin().Show();
                }
                else if (userRole.Contains("User"))
                {
                    MessageBox.Show("Welcome, User!", "Login Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    new User(userId, UserName).Show();
                }
            }
            else
            {
                MessageBox.Show("Invalid email or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void link_SignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new RegisterForm(userService).Show();
        }
    }
}
