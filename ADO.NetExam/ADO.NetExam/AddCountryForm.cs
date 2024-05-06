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
    public partial class AddCountryForm : Form
    {
        public Country NewCountry { get; set; }
        public AddCountryForm()
        {
            InitializeComponent();
        }

        private void AddCityButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(CountryTextBox.Text))
            {
                MessageBox.Show("You have not entered country name");
            }
            else
            {
                NewCountry = new Country()
                {
                    Id = 0,
                    Name = CountryTextBox.Text,
                };
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
