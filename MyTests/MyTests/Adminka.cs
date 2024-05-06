using MyTests.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyTests
{
    public partial class Adminka : Form
    {
        public List<User> Users { get; set; }
        public List<User> NewUsers { get; set; }
        public List<User> DeleteUsers { get; set; }
        public List<User> EditUser { get; set; }

        public Adminka()
        {
            InitializeComponent();
            NewUsers = new List<User>();
            DeleteUsers = new List<User>();
            EditUser = new List<User>();
        }

        static string GetMd5Hash(MD5 md5Hash, string input)
        {
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            StringBuilder sBuilder = new StringBuilder();

            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            return sBuilder.ToString();
        }

        private void UpdateUsers()
        {
            UsersList.Items.Clear();
            foreach (User user in Users)
            {
                UsersList.Items.Add(user);
            }
            UsersList.DisplayMember = "Name";
        }

        private void Adminka_Load(object sender, EventArgs e)
        {
            UpdateUsers();
        }

        private void Adminka_Leave(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void Adminka_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void AddSubjectButton_Click(object sender, EventArgs e)
        {
            string name = UserName.Text;
            string login = UserLogin.Text;
            string password = UserPassword.Text;
            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(login) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Not all data was entered");
            }
            else
            {
                if (Users.Where(s => s.Login == login).FirstOrDefault() != null)
                {
                    MessageBox.Show("Such user already exists");
                }
                else
                {
                    string hash;
                    using (MD5 md5Hash = MD5.Create())
                    {
                       hash = GetMd5Hash(md5Hash, password); 
                    }

                        var newUser = new User()
                    {
                        Id = 0,
                        Name = name,
                        Login = login,
                        Password = hash,
                        RoleId = 1
                    };
                    Users.Add(newUser);
                    UpdateUsers();
                    UserName.Clear();
                    UserLogin.Clear();
                    UserPassword.Clear();
                    NewUsers.Add(newUser);
                }
            }
        }

        private void UsersList_SelectedIndexChanged(object sender, EventArgs e)
        {
            UserLogin.Text = (UsersList.SelectedItem as User).Login;
            UserName.Text = (UsersList.SelectedItem as User).Name;
            UserPassword.Text = (UsersList.SelectedItem as User).Password;

        }

        private void ClearSubjectButton_Click(object sender, EventArgs e)
        {
            UserLogin.Clear();
            UserName.Clear();
            UserPassword.Clear();
        }

        private void DelSubjectButton_Click(object sender, EventArgs e)
        {
            string name = UserName.Text;
            string login = UserLogin.Text;
            string password = UserPassword.Text;
            if (Users.Where(s => s.Login == login).FirstOrDefault() == null)
            {
                MessageBox.Show("No such user already exists");
            }
            else
            {
                DeleteUsers.Add(UsersList.SelectedItem as User);
                Users.Remove(UsersList.SelectedItem as User);
                UpdateUsers();
                UserName.Clear();
                UserLogin.Clear();
                UserPassword.Clear();
            }
        }

        private void EditSubjectButton_Click(object sender, EventArgs e)
        {
            string name = UserName.Text;
            string login = UserLogin.Text;
            string password = UserPassword.Text;
            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(login) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Not all data was entered");
            }
            else
            {
                if (Users.Count(s => s.Login == login) > 1)
                {
                    MessageBox.Show("Another user with such login already exists");
                }
                else
                {
                    string hash;
                    using (MD5 md5Hash = MD5.Create())
                    {
                        hash = GetMd5Hash(md5Hash, password);
                    }

                    var newUser = new User()
                    {
                        Id = (UsersList.SelectedItem as User).Id,
                        Name = name,
                        Login = login,
                        Password = hash,
                        RoleId = (UsersList.SelectedItem as User).RoleId
                    };
                    Users.Remove(UsersList.SelectedItem as User);
                    Users.Add(newUser);
                    UpdateUsers();
                    UserName.Clear();
                    UserLogin.Clear();
                    UserPassword.Clear();
                    EditUser.Add(newUser);
                }
            }
        }
    }
}
