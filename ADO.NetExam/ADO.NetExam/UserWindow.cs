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
    public partial class UserWindow : Form
    {
        public List<City> Cities { get; set; }
        public List<Country> Countries { get; set; }
        public List<District> Districts { get; set; }
        public List<Flat> Flats { get; set; }
        public List<int> FlatsId { get; set; }
        public UserWindow()
        {
            InitializeComponent();
        }

        private void UserWindow_Load(object sender, EventArgs e)
        {
            UpdateCountries();
            FlatsId = new List<int>();
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
                if(city.CountryId == countryId)
                {
                    CityComboBox.Items.Add(city);
                }
            }
            CityComboBox.DisplayMember = "Name";
            if(CityComboBox.Items.Count > 0)
            {
                CityComboBox.SelectedIndex = 0;
                UpdateDistricts((CityComboBox.SelectedItem as City).Id);
            }
            else
            {
                CleanFlatInfo();
            }
        }
        private void UpdateDistricts(int CityId)
        {
            DistrictComboBox.Items.Clear();
            foreach (District district in Districts)
            {
                if(district.CityId == CityId)
                {
                    DistrictComboBox.Items.Add(district);
                }
            }
            DistrictComboBox.DisplayMember = "Name";
            if(DistrictComboBox.Items.Count > 0)
            {
                DistrictComboBox.SelectedIndex = 0;
                UpdateFlats((DistrictComboBox.SelectedItem as District).Id);
            }
            else
            {
                CleanFlatInfo();
            }
        }

        private void UpdateFlats(int districtId)
        {
            FlatComboBox.Items.Clear();
            foreach (Flat flat in Flats)
            {
                if(flat.DistrictId == districtId && flat.ContractId == null && flat.IsAvailable == true)
                {
                    FlatComboBox.Items.Add(flat);
                }
            }
            FlatComboBox.DisplayMember = "Name";
            if(FlatComboBox.Items.Count > 0)
            {
                FlatComboBox.SelectedIndex = 0;
            }
            else
            {
                CleanFlatInfo();
            }
        }

        private void FlatComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            FlatNameTextBox.Text = (FlatComboBox.SelectedItem as Flat).Name.ToString();
            AdressBox.Text = (FlatComboBox.SelectedItem as Flat).Adress;
            if((FlatComboBox.SelectedItem as Flat).IsPetsAllowed)
            {
                IsPetsAllowedBox.Text = "Yes";
            }
            else
            {
                IsPetsAllowedBox.Text = "No";
            }
            FloorNumberBox.Text = (FlatComboBox.SelectedItem as Flat).Floors.ToString();
            SizeBox.Text = (FlatComboBox.SelectedItem as Flat).Size.ToString() + "m2";
            PeopleBox.Text = (FlatComboBox.SelectedItem as Flat).HowManyPeopleSuits.ToString();
            PriceBox.Text = (FlatComboBox.SelectedItem as Flat).Price.ToString() + " UAH";
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

        private void AddButton_Click(object sender, EventArgs e)
        {
            if(FlatsId.Contains((FlatComboBox.SelectedItem as Flat).Id)){
                MessageBox.Show("Flat is already in your contract");
            }
            else
            {
                FlatsId.Add((FlatComboBox.SelectedItem as Flat).Id);
                MessageBox.Show("Flat was added to your contract");
            }
        }

        private void FinishButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        private void CleanFlatInfo()
        {
            FlatNameTextBox.Clear();
            AdressBox.Clear();
            IsPetsAllowedBox.Clear();
            FloorNumberBox.Clear();
            SizeBox.Clear() ;
            PeopleBox.Clear();
            PriceBox.Clear();
            FlatComboBox.Items.Clear();
        }
    }
}
