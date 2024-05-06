using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyTests
{
    public partial class Entry : Form
    {
        public string LoginTransit {  get; set; }
        public string PasswordTransit { get; set; }
        public Entry()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            LoginTransit = LoginField.Text;
            PasswordTransit = PasswordField.Text;
            this.DialogResult = DialogResult.OK;
        }

        private void Entry_Load(object sender, EventArgs e)
        {

        }
    }
}
