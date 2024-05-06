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
    public partial class DeleteDistrictForm : Form
    {
        public List<City> Cities { get; set; }
        public List<Country> Countries { get; set; }
        public List<District> Districts { get; set; }
        public List<District> DistrictsToDelete { get; set; }
        public DeleteDistrictForm()
        {
            InitializeComponent();
        }

        private void DeleteDistrictForm_Load(object sender, EventArgs e)
        {
            DistrictsToDelete = new List<District>();
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

        private void CountryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateCities((CountryComboBox.SelectedItem as Country).Id);
        }

        private void CityComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateDistricts((CityComboBox.SelectedItem as City).Id);
        }

        private void SeleteDistrictButton_Click(object sender, EventArgs e)
        {
            DistrictsToDelete.Add(DistrictComboBox.SelectedItem as District);
            Districts.Remove(DistrictComboBox.SelectedItem as District);
            UpdateDistricts((CityComboBox.SelectedItem as City).Id);
            MessageBox.Show("District was deleted successfully");
        }

        private void FinishButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
