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
    public partial class DeleteFlatForm : Form
    {
        public List<City> Cities { get; set; }
        public List<Country> Countries { get; set; }
        public List<District> Districts { get; set; }
        public List<Flat> Flats { get; set; }
        public List<Flat> FlatsToDelete { get; set; }

        public DeleteFlatForm()
        {
            InitializeComponent();
        }

        private void DeleteFlatForm_Load(object sender, EventArgs e)
        {
            UpdateCountries();
            FlatsToDelete = new List<Flat>();
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
                UpdateFlats((DistrictComboBox.SelectedItem as District).Id);
            }
        }

        private void UpdateFlats(int districtId)
        {
            FlatComboBox.Items.Clear();
            foreach (Flat flat in Flats)
            {
                if (flat.DistrictId == districtId)
                {
                    FlatComboBox.Items.Add(flat);
                }
            }
            FlatComboBox.DisplayMember = "Name";
            if (FlatComboBox.Items.Count > 0)
            {
                FlatComboBox.SelectedIndex = 0;
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

        private void DistrictComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateFlats((DistrictComboBox.SelectedItem as District).Id);
        }

        private void DeleteFlatButton_Click(object sender, EventArgs e)
        {
            if((FlatComboBox.SelectedItem as Flat).IsAvailable)
            {
                FlatsToDelete.Add(FlatComboBox.SelectedItem as Flat);
                Flats.Remove(FlatComboBox.SelectedItem as Flat);
                UpdateFlats((DistrictComboBox.SelectedItem as District).Id);
                MessageBox.Show("Flat was deleted successfully");
            }
            else
            {
                MessageBox.Show("Flat belongs to a user", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void FinishButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
