using ADO.NetExam.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADO.NetExam
{
    public partial class AddFlatForm : Form
    {
        public Flat newFlat { get; set; }
        public List<City> Cities { get; set; }
        public List<Country> Countries { get; set; }
        public List<District> Districts { get; set; }
        public AddFlatForm()
        {
            InitializeComponent();
        }
        private void UpdateCountries()
        {
            CountryComboBox.Items.Clear();
            foreach (Country country in Countries)
            {
                CountryComboBox.Items.Add(country);
            }
            CountryComboBox.DisplayMember = "Name";
            CountryComboBox.SelectedIndex = 0;
            UpdateCities((CountryComboBox.SelectedItem as Country).Id);
        }

        private void UpdateCities(int countryId)
        {
            CityComboBox.Items.Clear();
            foreach (City city in Cities)
            {
                if (city.CountryId == countryId)
                {
                    CityComboBox.Items.Add(city);
                }
            }
            CityComboBox.DisplayMember = "Name";
            if (CityComboBox.Items.Count > 0)
            {
                CityComboBox.SelectedIndex = 0;
                UpdateDistricts((CityComboBox.SelectedItem as City).Id);
            }
        }
        private void UpdateDistricts(int CityId)
        {
            DistrictComboBox.Items.Clear();
            foreach (District district in Districts)
            {
                if (district.CityId == CityId)
                {
                    DistrictComboBox.Items.Add(district);
                }
            }
            DistrictComboBox.DisplayMember = "Name";
            if (DistrictComboBox.Items.Count > 0)
            {
                DistrictComboBox.SelectedIndex = 0;
            }
        }

        private void AddFlatButton_Click(object sender, EventArgs e)
        {
            if(
                string.IsNullOrEmpty(FlatNameTextBox.Text) ||
                string.IsNullOrEmpty(AdressTextBox.Text) ||
                int.Parse(FloorNumberTextBox.Text) <= 0 ||
                int.Parse(SizeTextBox.Text) <= 0 ||
                int.Parse(PeopleTextBox.Text) <= 0 ||
                decimal.Parse(PriceTextBox.Text) <= 0 ||
                CityComboBox.Items.Count <= 0 || 
                DistrictComboBox.Items.Count <= 0) 
            {
                MessageBox.Show("Some data was entered incorectly or not entered");
            }
            else
            {
                bool pets;
                if (IsPetsAllowedComboBox.SelectedItem.ToString() == "true")
                {
                    pets = true;
                }
                else
                {
                    pets = false;
                }
                newFlat = new Flat()
                {
                    Id = 0,
                    Name = FlatNameTextBox.Text,
                    IsPetsAllowed = pets,
                    Adress = AdressTextBox.Text,
                    Floors = int.Parse(FloorNumberTextBox.Text),
                    Size = int.Parse(SizeTextBox.Text),
                    HowManyPeopleSuits = int.Parse(PeopleTextBox.Text),
                    Price = decimal.Parse(PriceTextBox.Text),
                    DistrictId = (DistrictComboBox.SelectedItem as District).Id,
                    IsAvailable = true,
                };
                this.DialogResult = DialogResult.OK;
            }
           
        }

        private void AddFlatForm_Load(object sender, EventArgs e)
        {
            UpdateCountries();
        }

        private void CountryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateCities((CountryComboBox.SelectedItem as Country).Id);
        }

        private void CityComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateDistricts((CityComboBox.SelectedItem as City).Id);
        }
    }
}
