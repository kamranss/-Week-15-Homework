using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Interfaces
{
    public interface IEmployeeService
    {
        Employee Create(Employee employee, string departmentName);
        Employee Update(Employee employee);
        Employee Delete(int id, Employee employee);
        Employee GetById(int id);
        Employee GetByAge(int age);
        Employee GetByName(string name);
        Employee GetBySurname(string surname);

        List<Employee> GetAll(string name);
        List<Employee> GetAll();
        Employee GetByDepartmentId(string departmentId);
        Employee GetByDepartmentName(string departmentName);

        int GetAllEmployeeCount();
        int GetEmployeeCountByDepartment();

    }
}
