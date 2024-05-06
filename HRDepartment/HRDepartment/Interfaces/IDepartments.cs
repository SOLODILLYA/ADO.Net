using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRDepartment.Models;

namespace HRDepartment.Interfaces
{
    public interface IDepartments
    {
        List<Department> GetAllDepartments();
        Department GetDepInfo(int depId);
        void AddNewDep(Department newDep);
        void RemoveExistDep(int depId);
        void EditExistDep(Department editDep);
    }
}
