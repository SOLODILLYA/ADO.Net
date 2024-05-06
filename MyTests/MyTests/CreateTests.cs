using MyTests.Models;
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
    public partial class CreateTests : Form
    {
        public List<Subject> Subjects { get; set; }
        public List<Subject> NewSubjects { get; set; }
        public CreateTests()
        {
            InitializeComponent();
            NewSubjects = new List<Subject>();
        }

        private void UpdateSubjects()
        {
            SubjectsList.Items.Clear();
            foreach (Subject subject in Subjects)
            {
                SubjectsList.Items.Add(subject);
            }
            SubjectsList.DisplayMember = "Name";
        }

        private void AddSubjectButton_Click(object sender, EventArgs e)
        {
            string name = SubjectName.Text;
            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("No subject name was entered");
            }
            else
            {
                if(Subjects.Where(s => s.Name == name).FirstOrDefault() != null)
                {
                    MessageBox.Show("Such subject already exists");
                }
                else
                {
                    var newSubject = new Subject()
                    {
                        Id = 0,
                        Name = name
                    };
                    Subjects.Add(newSubject);
                    UpdateSubjects();
                    SubjectName.Clear();
                    NewSubjects.Add(newSubject);
                }
            }
        }

        private void DelSubjectButton_Click(object sender, EventArgs e)
        {

        }

        private void EditSubjectButton_Click(object sender, EventArgs e)
        {

        }

        private void ClearSubjectButton_Click(object sender, EventArgs e)
        {

        }

        private void SubjectsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            SubjectName.Text = (SubjectsList.SelectedItem as Subject).Name;
        }

        private void CreateTests_Load(object sender, EventArgs e)
        {
            UpdateSubjects();
        }

        private void CreateTests_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
