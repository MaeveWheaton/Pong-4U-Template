using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginScreen
{
    public partial class LoginScreen : UserControl
    {
        string enteredUsername;
        string enteredPassword;

        public LoginScreen()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            enteredUsername = usernameInput.Text;
            enteredPassword = passwordInput.Text;

            if (enteredUsername == Form1.correctUsername && enteredPassword == Form1.correctPassword)
            {
                Form f = this.FindForm();
                f.Controls.Remove(this);

                MainScreen newscreen = new MainScreen();
                f.Controls.Add(newscreen);
            }
            else
            {
                errorLabel.Text = "Incorrect Login";
                errorLabel.Visible = true;

                usernameInput.Clear();
                passwordInput.Clear();
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
