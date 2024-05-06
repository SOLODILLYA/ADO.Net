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
    public partial class DeleteCityForm : Form
    {
        public List<City> Cities { get; set; }
        public List<City> CitiesToDelete { get; set; }
        public List<Country> Countries { get; set; }
        public DeleteCityForm()
        {
            InitializeComponent();
        }

        private void DeleteCityForm_Load(object sender, EventArgs e)
        {
            UpdateCountries();
            CitiesToDelete = new List<City>();
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
            }
        }

        private void DeleteCityButton_Click(object sender, EventArgs e)
        {
            CitiesToDelete.Add(CityComboBox.SelectedItem as City);
            Cities.Remove(CityComboBox.SelectedItem as City);
            UpdateCities((CountryComboBox.SelectedItem as Country).Id);
            MessageBox.Show("City was deleted succesfully");
        }

        private void FinishButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void CountryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateCities((CountryComboBox.SelectedItem as Country).Id);
        }
    }
}
