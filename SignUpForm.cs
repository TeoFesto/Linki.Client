using Linki.SharedResources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Linki.Client
{
    public partial class SignUpForm : Form, INavigable
    {
        public SignUpForm(Form previousForm)
        {
            PreviousForm = previousForm;
            InitializeComponent();
        }

        public Form PreviousForm { get; set; }

        private void previousFormButton_Click(object sender, EventArgs e)
        {
            this.Close();
            PreviousForm.Show();
        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            signUpStatusLabel.Text = "";
            SignUpRequest signUpRequest = new SignUpRequest();
            signUpRequest.Login = loginInput.Text;
            signUpRequest.Nickname = nicknameInput.Text;
            signUpRequest.Email = emailInput.Text;
            signUpRequest.Password = passwordInput.Text;
            signUpRequest.ConfirmPassword = confirmPasswordInput.Text;

            var validationErrors = new List<ValidationResult>();
            var validationContext = new ValidationContext(signUpRequest);
            if (!Validator.TryValidateObject(signUpRequest, validationContext, validationErrors, true))
            {
                signUpStatusLabel.ForeColor = Color.Red;
                foreach(var error in validationErrors)
                {
                    signUpStatusLabel.Text += ("- " + error.ErrorMessage + "\n");
                }
            }
            else
            {
                ServerCommunicator.AddRequest(signUpRequest);
                signUpStatusLabel.ForeColor = Color.DarkGray;
                signUpStatusLabel.Text = "Регистрация...";

            }
        }

        private void SignUpForm_Load(object sender, EventArgs e)
        {
            Program.RunnedForms.Add(this);
            ServerCommunicator.AddConnectionLabel(connectionStatusLabel);
        }

        private void SignUpForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.RunnedForms.Remove(this);
            PreviousForm.Show();
        }
    }
}
