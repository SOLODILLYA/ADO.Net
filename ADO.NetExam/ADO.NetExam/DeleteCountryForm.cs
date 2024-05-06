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
    public partial class DeleteCountryForm : Form
    {
        public List<Country> DeleteCountries { get; set; }
        public List<Country> Countries { get; set; }
        public DeleteCountryForm()
        {
            InitializeComponent();
        }

        private void DeleteCountryForm_Load(object sender, EventArgs e)
        {
            DeleteCountries = new List<Country>();
            UpdateCountries();
        }

        private void DeleteCountryButton_Click(object sender, EventArgs e)
        {
            DeleteCountries.Add(CountryToDeleteComboBox.SelectedItem as Country);
            Countries.Remove(CountryToDeleteComboBox.SelectedItem as Country);
            UpdateCountries();
            MessageBox.Show("Country was deleted succesfully");
        }

        private void FinishButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void UpdateCountries()
        {
            CountryToDeleteComboBox.Items.Clear();
            foreach (Country country in Countries)
            {
                CountryToDeleteComboBox.Items.Add(country);
            }
            CountryToDeleteComboBox.DisplayMember = "Name";
            CountryToDeleteComboBox.SelectedIndex = 0;
        }
    }
}
