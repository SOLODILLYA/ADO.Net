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
    public partial class AddDistrictForm : Form
    {
        public List<City> Cities { get; set; }
        public List<Country> Countries { get; set; }
        public District NewDistrict { get; set; }
        public AddDistrictForm()
        {
            InitializeComponent();
        }

        private void AddDistrictForm_Load(object sender, EventArgs e)
        {
            UpdateCountries();
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
            CityComboBox.SelectedIndex = 0;
        }

        private void AddDistrictButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(DistrictTextBox.Text) ||
                CityComboBox.Items.Count <= 0)
            {
                MessageBox.Show("You have not entered district name or selected city");
            }
            else
            {
                NewDistrict = new District()
                {
                    Id = 0,
                    Name = DistrictTextBox.Text,
                    CityId = (CityComboBox.SelectedItem as City).Id
                };
                this.DialogResult = DialogResult.OK;
            }

        }

        private void CountryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateCities((CountryComboBox.SelectedItem as Country).Id);
        }
    }
}
