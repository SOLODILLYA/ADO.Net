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
    public partial class DeleteUserForm : Form
    {
        public List<User> Users { get; set; }
        public List<User> UsersToDelete { get; set; }
        public DeleteUserForm()
        {
            InitializeComponent();
        }

        private void DeleteUserForm_Load(object sender, EventArgs e)
        {
            UsersToDelete= new List<User>();
            UpdateUsers();
        }

        private void UpdateUsers()
        {
            UserComboBox.Items.Clear();
            foreach (User user in Users)
            {
                UserComboBox.Items.Add(user);
            }
            if(UserComboBox.Items.Count > 0)
            {
                UserComboBox.DisplayMember = "Name";
                UserComboBox.SelectedIndex = 0;
            }
        }

        private void DeleteUserButton_Click(object sender, EventArgs e)
        {
            UsersToDelete.Add(UserComboBox.SelectedItem as User);
            Users.Remove(UserComboBox.SelectedItem as User);
            UpdateUsers();
            MessageBox.Show("User was deleted successfuly");
        }

        private void FinishButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
