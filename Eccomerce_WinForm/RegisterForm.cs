using BLL;
using Business.Models;
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

    public partial class RegisterForm : Form
    {
        private readonly UsersServices user;

        public RegisterForm(UsersServices user)
        {
            InitializeComponent();
            btnRegister.Click += (s, e) => HandleRegister(Adress.Text, txtFullName.Text, txtEmail.Text, txtPassword.Text, txtConfirmPassword.Text);
            this.user = user;
        }
        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }

        private void link_SignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
             new Login().Show();
        }


        private void HandleRegister(string Adress,string fullName, string email, string password, string confirmPassword)
        {
            if (string.IsNullOrWhiteSpace(fullName) || string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(confirmPassword))
            {
                MessageBox.Show("All fields are required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            UserVM userVM = new UserVM();
            userVM.Name = fullName;
            userVM.Email = email;
            userVM.Password = password;
            userVM.age = 0;
            userVM.Address = Adress;
            user.Register(userVM);
            MessageBox.Show("Registration Successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();
             new Login().Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }

}
