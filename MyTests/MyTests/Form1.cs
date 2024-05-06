using MyTests.EF_ORM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyTests.Models;
using System.Data.Entity;

namespace MyTests
{
    public partial class Form1 : Form
    {
        private string userRole;
        private readonly MyTestsDbManager _dbManager;
        public Form1()
        {
            InitializeComponent();
            _dbManager = new MyTestsDbManager();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var entryForm = new Entry();
            if(entryForm.ShowDialog() == DialogResult.OK)
            {
                string login = entryForm.LoginTransit;
                string password = GetMD5Hash(entryForm.PasswordTransit);

                var user = _dbManager.Users
                    .Where(u => u.Login == login && u.Password == password)
                    .FirstOrDefault();

                if(user == null)
                {
                    MessageBox.Show("User is not found", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.Close();
                }
                else
                {
                    var roleName = _dbManager.Roles
                        .Where(r => r.Id == user.RoleId)
                        .First().Name;
                    switch (roleName)
                    {
                        case "User":
                            MessageBox.Show("Test window should open");
                            break;
                        case "Author":
                            var createTests = new CreateTests();
                            var allSubjects = _dbManager.Subjects
                                    .ToList();
                            createTests.Subjects = allSubjects;
                            if (createTests.ShowDialog() == DialogResult.OK)
                            {
                                if(createTests.NewSubjects.Count > 0)
                                {
                                    _dbManager.Subjects.AddRange(createTests.NewSubjects);
                                    _dbManager.SaveChanges();
                                }
                                
                            }
                            break;
                        case "Admin":
                            var adminka = new Adminka();
                            var allUsers = _dbManager.Users.ToList();
                            adminka.Users = allUsers;
                            if (adminka.ShowDialog() == DialogResult.OK)
                            {
                                if (adminka.NewUsers.Count > 0)
                                {
                                    _dbManager.Users.AddRange(adminka.NewUsers);
                                    
                                }
                                if(adminka.DeleteUsers.Count > 0)
                                {
                                    _dbManager.Users.RemoveRange(adminka.DeleteUsers);
                                }
                                foreach (var updatedUser in adminka.EditUser)
                                {
                                    var existingUser = _dbManager.Users.FirstOrDefault(u => u.Id == updatedUser.Id);

                                    if (existingUser != null)
                                    {
                                        existingUser.Name = updatedUser.Name;
                                        existingUser.Login = updatedUser.Login;
                                        existingUser.Password = updatedUser.Password;
                                    }
                                }
                                _dbManager.SaveChanges();
                            }
                            break;
                        case "Manager":
                            MessageBox.Show("Results window should open");
                            break;
                    }
                }
            }
        }

        public string GetMD5Hash(string text)
        {
            var md5 = MD5.Create();
            byte[] data = Encoding.UTF8.GetBytes(text);
            byte[] hash = md5.ComputeHash(data);
            var builder = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                builder.Append(hash[i].ToString("X2"));
            }
            return builder.ToString();
        }
    }
}
