using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Configuration;
using System.Data.SqlClient;
using ContactsManager.Repos;
namespace ContactsManager
{
    public partial class Form1 : Form
    {
        private readonly UsersRepo _usersRepo;
        private readonly CategoriesRepo _categoriesRepo;
        public Form1()
        {
            InitializeComponent();
            _usersRepo = new UsersRepo();
            _categoriesRepo = new CategoriesRepo();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Load_Version1()
        {
            bool success1 = false;
            bool success2 = false;
            var registryForm = new RegistryForm();
            if (registryForm.ShowDialog() == DialogResult.OK)
            {

                string login = registryForm.LoginDto;
                string password = _usersRepo.GetMd5Hash(registryForm.PasswordDto);

                if (_usersRepo.SignUp(login, password))
                {
                    success1 = true;
                    var loginForm = new LoginForm();
                    if (loginForm.ShowDialog() == DialogResult.OK)
                    {
                        // ...
                    }
                }
            }
            if (!success1 || !success2)
            {
                this.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bool success1 = false;
            var loginForm = new LoginForm();
            if (loginForm.ShowDialog() == DialogResult.OK)
            {

                string login = loginForm.LoginDto;
                string password = _usersRepo.GetMd5Hash(loginForm.PasswordDto);

                if(_usersRepo.SignIn(login, password))
                {
                    success1 = true;
                    CategoriesList.DataSource = _categoriesRepo.GetAllCategories(1);
                }
            }
            if (!success1)
            {
                this.Close();
            }
        }
    }
}
