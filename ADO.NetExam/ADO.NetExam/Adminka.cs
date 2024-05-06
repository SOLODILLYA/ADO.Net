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
    public partial class Adminka : Form
    {
        public List<Contract> Contracts { get; set; }
        public List<Country> Countries { get; set; }
        public List<Country> NewCountries { get; set; }
        public List<Country> DeleteCountries { get; set; }
        public List<City> Cities { get; set; }
        public List<City> NewCities { get; set; }
        public List<City> DeleteCities { get; set; }
        public List<District> Districts { get; set; }
        public List<District> NewDistricts { get; set; }
        public List<District> DeleteDistricts { get; set; }
        public List<Flat> Flats { get; set; }
        public List<Flat> NewFlats { get; set; }
        public List<Flat> DeleteFlats { get; set; }
        public List<User> Users { get; set; }
        public List<User> NewUsers { get; set; }
        public List<User> DeleteUsers { get; set; }

        public List<Role> Roles { get; set; }
        public Adminka()
        {
            InitializeComponent();
        }

        private void Adminka_Load(object sender, EventArgs e)
        {
            ContractsList.Items.Clear();
            foreach (Contract contract in Contracts)
            {
                var flat =
                ContractsList.Items.Add(Flats.FirstOrDefault(f => f.Id == contract.FlatId).Name + " belongs to " +
                Users.FirstOrDefault(u => u.Id == contract.UserId).Name);
            }
            NewCountries = new List<Country>();
            NewCities = new List<City>();
            NewDistricts = new List<District>();
            NewFlats = new List<Flat>();
            NewUsers = new List<User>();
            DeleteCountries = new List<Country>();
            DeleteCities = new List<City>();
            DeleteDistricts = new List<District>();
            DeleteFlats = new List<Flat>();
            DeleteUsers = new List<User>();
        }

        private void AddCountry_Click(object sender, EventArgs e)
        {
            var addCountry = new AddCountryForm();
            if (addCountry.ShowDialog() == DialogResult.OK && addCountry.NewCountry != null)
            {
                NewCountries.Add(addCountry.NewCountry);
                MessageBox.Show("Country was added successfuly");
                Countries.Add(addCountry.NewCountry);
            }
        }

        private void AddFlat_Click(object sender, EventArgs e)
        {
            var addFlat = new AddFlatForm();
            addFlat.Countries = Countries;
            addFlat.Cities = Cities;
            addFlat.Districts = Districts;
            if (addFlat.ShowDialog() == DialogResult.OK && addFlat.newFlat != null)
            {
                NewFlats.Add(addFlat.newFlat);
                MessageBox.Show("Flat was added successfuly");
                Flats.Add(addFlat.newFlat);
            }
        }

        private void FinishButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void AddDistrict_Click(object sender, EventArgs e)
        {
            var addDistrict = new AddDistrictForm();
            addDistrict.Cities = Cities;
            addDistrict.Countries = Countries;
            if(addDistrict.ShowDialog() == DialogResult.OK && addDistrict.NewDistrict != null)
            {
                NewDistricts.Add(addDistrict.NewDistrict);
                MessageBox.Show("District was added successfuly");
                Districts.Add(addDistrict.NewDistrict);
            }
        }

        private void AddCity_Click(object sender, EventArgs e)
        {
            var addCity = new AddCityForm();
            addCity.Countries = Countries;
            if (addCity.ShowDialog() == DialogResult.OK && addCity.NewCity != null)
            {
                NewCities.Add(addCity.NewCity);
                MessageBox.Show("City was added successfuly");
                Cities.Add(addCity.NewCity);
            }
        }

        private void AddUserButton_Click(object sender, EventArgs e)
        {
            var addUsers = new AddUserForm();
            addUsers.Roles = Roles;
            if(addUsers.ShowDialog() == DialogResult.OK && addUsers.NewUser != null)
            {
                NewUsers.Add(addUsers.NewUser);
                MessageBox.Show("User was added successfuly");
                Users.Add(addUsers.NewUser);
            }
        }

        private void DeleteCountryButton_Click(object sender, EventArgs e)
        {
            var deleteCountry = new DeleteCountryForm();
            deleteCountry.Countries = Countries;
            if(deleteCountry.ShowDialog() == DialogResult.OK)
            {
                DeleteCountries.AddRange(deleteCountry.DeleteCountries);
                MessageBox.Show("Changes was sucessfully saved");
                Countries = deleteCountry.Countries;
            }
        }

        private void DeleteCityButton_Click(object sender, EventArgs e)
        {
            var deleteCity = new DeleteCityForm();
            deleteCity.Countries = Countries;
            deleteCity.Cities = Cities;
            if(deleteCity.ShowDialog() == DialogResult.OK)
            {
                DeleteCities.AddRange(deleteCity.CitiesToDelete);
                MessageBox.Show("Changes was sucessfully saved");
                Cities= deleteCity.Cities;
            }
        }

        private void DeleteDistrictButton_Click(object sender, EventArgs e)
        {
            var deleteDistrict = new DeleteDistrictForm();
            deleteDistrict.Districts = Districts;
            deleteDistrict.Countries = Countries;
            deleteDistrict.Cities = Cities;
            if(deleteDistrict.ShowDialog() == DialogResult.OK)
            {
                DeleteDistricts.AddRange(deleteDistrict.DistrictsToDelete);
                MessageBox.Show("Changes was sucessfully saved");
                Districts = deleteDistrict.Districts;
            }
        }

        private void DeleteFlatButton_Click(object sender, EventArgs e)
        {
            var deleteFlat = new DeleteFlatForm();
            deleteFlat.Flats = Flats;
            deleteFlat.Countries = Countries;
            deleteFlat.Cities = Cities;
            deleteFlat.Districts = Districts;
            deleteFlat.Flats = Flats;
            if(deleteFlat.ShowDialog() == DialogResult.OK)
            {
                DeleteFlats.AddRange(deleteFlat.FlatsToDelete);
                MessageBox.Show("Changes was sucessfully saved");
                Flats = deleteFlat.Flats;
            }
        }

        private void DeleteUser_Click(object sender, EventArgs e)
        {
            var deleteUser = new DeleteUserForm();
            deleteUser.Users = Users;
            if(deleteUser.ShowDialog() == DialogResult.OK)
            {
                DeleteUsers.AddRange(deleteUser.UsersToDelete);
                MessageBox.Show("Changes was sucessfully saved");
                Users = deleteUser.Users;
            }
        }
    }
}
