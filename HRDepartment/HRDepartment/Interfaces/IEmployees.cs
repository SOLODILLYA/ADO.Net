using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRDepartment.Models;

namespace HRDepartment.Interfaces
{
    public interface IEmployees
    {
        List<Employee> GetAllEmployees();
        List<Employee> GetEmployeesByDep(int depId);
        Employee GetEmpInfo(int empId);
        void AddNewEmp(Employee employee);
        void RemoveExistEmp(int empId);
        void EditExistEmp(Employee emp);
    }
}
