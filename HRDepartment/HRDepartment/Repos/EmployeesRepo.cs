using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRDepartment.Models;
using HRDepartment.Interfaces;
using HRDepartment.DapperORM;
using Dapper;

namespace HRDepartment.Repos
{
    public class EmployeesRepo : IEmployees
    {
        public void AddNewEmp(Employee employee)
        {
            var paramList = new DynamicParameters();
            paramList.Add("@empName", employee.EmpName);
            paramList.Add("@birthDay", employee.BirthDay);
            paramList.Add("@position", employee.Position);
            paramList.Add("@salary", employee.Salary);
            paramList.Add("@imagePath", employee.ImagePath);
            paramList.Add("@departmentId", employee.DepartmentId);
            QueryManager.ExecuteDmlQuery("AddNewEmpProc",paramList);
        }

        public void EditExistEmp(Employee emp)
        {
            throw new NotImplementedException();
        }

        public List<Employee> GetAllEmployees()
        {
            return QueryManager.ExecuteSelectQuery<Employee>("GetAllEmployeesProc").ToList();
        }

        public Employee GetEmpInfo(int empId)
        {
            throw new NotImplementedException();
        }

        public List<Employee> GetEmployeesByDep(int depId)
        {
            throw new NotImplementedException();
        }

        public void RemoveExistEmp(int empId)
        {
            throw new NotImplementedException();
        }
    }
}
