using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HRDepartment.Repos;

namespace HRDepartment
{
    public partial class Form1 : Form
    {
        private readonly EmployeesRepo _empsRepo;
        public Form1()
        {
            InitializeComponent();
            _empsRepo = new EmployeesRepo();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.DataSource = _empsRepo.GetAllEmployees();
            listBox1.DisplayMember = "EmpName";
        }
    }
}
