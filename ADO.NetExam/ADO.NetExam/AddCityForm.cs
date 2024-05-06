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
    public partial class AddCityForm : Form
    {

        public List<Country> Countries { get; set; }
        public City NewCity { get; set; }
        public AddCityForm()
        {
            InitializeComponent();
        }

        private void AddCity_Load(object sender, EventArgs e)
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
        }

        private void AddCityButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(CityTextBox.Text) ||
               CountryComboBox.Items.Count <= 0)
            {
                MessageBox.Show("You have not entered city name or selected country");
            }
            else
            {
                NewCity = new City()
                {
                    Id = 0,
                    Name = CityTextBox.Text,
                    CountryId = (CountryComboBox.SelectedItem as Country).Id
                };
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
