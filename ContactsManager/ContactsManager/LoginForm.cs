using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactsManager
{
    public partial class LoginForm : Form
    {
        public string LoginDto { get; set; }
        public string PasswordDto { get; set; }
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string login = LoginField.Text;
            if (string.IsNullOrWhiteSpace(login))
            {
                MessageBox.Show("You have not entered login field");
            }
            else
            {
                string password = PasswordField.Text;
                if (string.IsNullOrWhiteSpace(password))
                {
                    MessageBox.Show("You have not entered password field");
                }
                else
                {
                    LoginDto = login;
                    PasswordDto = password;
                    this.DialogResult = DialogResult.OK;
                }
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            LoginField.Clear();
            PasswordField.Clear();
        }
    }
}
