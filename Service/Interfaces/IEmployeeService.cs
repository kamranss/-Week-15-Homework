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
        Employee Get(int id);
        Employee Get(string name);
        List<Employee> GetAll(string name);

    }
}
