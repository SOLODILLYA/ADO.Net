using ADO.NetExam.EF_ORM;
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

namespace ADO.NetExam
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            _dbManager = new RentalAgencyDb();
        }

        private readonly RentalAgencyDb _dbManager;
        private void Form1_Load(object sender, EventArgs e)
        {
            var entryForm = new Entry();
            if (entryForm.ShowDialog() == DialogResult.OK)
            {
                string login = entryForm.LoginTransit;
                string password = GetMD5Hash(entryForm.PasswordTransit);

                var user = _dbManager.Users
                    .Where(u => u.Login == login && u.Password == password)
                    .FirstOrDefault();

                if (user == null)
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
                            var userWindow = new UserWindow();
                            userWindow.Flats = _dbManager.Flats.ToList();
                            userWindow.Cities = _dbManager.Cities.ToList();
                            userWindow.Districts = _dbManager.Districts.ToList();
                            userWindow.Countries = _dbManager.Countries.ToList();

                            if(userWindow.ShowDialog() == DialogResult.OK)
                            {
                                foreach (var flatId in userWindow.FlatsId)
                                {
                                    var flat = _dbManager.Flats.FirstOrDefault(f => f.Id == flatId);
                                    if (flat != null)
                                    {
                                        flat.IsAvailable = false;
                                    }
                                    _dbManager.Contracts.Add(new Models.Contract
                                    {
                                        UserId = user.Id,
                                        FlatId = flatId
                                    });
                                }
                                _dbManager.SaveChanges();
                                MessageBox.Show("Contract has been sent successfuly");
                                this.Close();
                            }
                            break;
                        case "Admin":
                            var adminka = new Adminka();
                            adminka.Users = _dbManager.Users.ToList();
                            adminka.Flats = _dbManager.Flats.ToList();
                            adminka.Cities = _dbManager.Cities.ToList();
                            adminka.Districts = _dbManager.Districts.ToList();
                            adminka.Countries = _dbManager.Countries.ToList();
                            adminka.Contracts = _dbManager.Contracts.ToList();
                            adminka.Roles = _dbManager.Roles.ToList();
                            if (adminka.ShowDialog() == DialogResult.OK)
                            {
                                foreach (var countries in adminka.NewCountries)
                                {
                                    _dbManager.Countries.Add(countries);
                                }
                                foreach (var city in adminka.NewCities)
                                {
                                    _dbManager.Cities.Add(city);
                                }
                                foreach (var district in adminka.NewDistricts)
                                {
                                    _dbManager.Districts.Add(district);
                                }
                                foreach (var flat in adminka.NewFlats)
                                {
                                    _dbManager.Flats.Add(flat);
                                }
                                foreach (var newUser in adminka.NewUsers)
                                {
                                    newUser.Password = GetMD5Hash(newUser.Password);
                                    _dbManager.Users.Add(newUser);
                                }
                                _dbManager.Countries.RemoveRange(adminka.DeleteCountries);
                                _dbManager.Cities.RemoveRange(adminka.DeleteCities);
                                _dbManager.Districts.RemoveRange(adminka.DeleteDistricts);
                                _dbManager.Flats.RemoveRange(adminka.DeleteFlats);
                                _dbManager.Users.RemoveRange(adminka.DeleteUsers);
                                _dbManager.SaveChanges();
                            }
                            this.Close();
                            break;
                    }
                    this.Close();
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
