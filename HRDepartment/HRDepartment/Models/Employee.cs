using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRDepartment.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string EmpName { get; set; }
        public DateTime BirthDay { get; set; }
        public string Position { get; set; }
        public decimal Salary { get; set; }
        public string ImagePath { get; set; }
        public int DepartmentId { get; set; }
    }
}
