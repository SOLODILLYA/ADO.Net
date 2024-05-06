using ADO.NetExam.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADO.NetExam
{
    public partial class AddUserForm : Form
    {
        public User NewUser { get; set; }
        public List<Role> Roles { get; set; }

        public AddUserForm()
        {
            InitializeComponent();
        }

        private void AddUserForm_Load(object sender, EventArgs e)
        {
            RolesComboBox.Items.Clear();
            foreach (Role role in Roles)
            {
                RolesComboBox.Items.Add(role);
            }
            RolesComboBox.DisplayMember = "Name";
            RolesComboBox.SelectedIndex = 0;
        }

        private void AddUserButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(UserNameTextBox.Text) ||
                string.IsNullOrEmpty(LoginTextBox.Text) ||
                string.IsNullOrEmpty(PasswordTextBox.Text))
            {
                MessageBox.Show("You have not entered all data");
            }
            else
            {
                NewUser = new User() { 
                    Id = 0,
                    Name = UserNameTextBox.Text,
                    Password = LoginTextBox.Text,
                    Login = LoginTextBox.Text,
                    RoleId = (RolesComboBox.SelectedItem as Role).Id,
                };
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
