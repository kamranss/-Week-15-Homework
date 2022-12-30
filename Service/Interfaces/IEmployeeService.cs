using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Interfaces
{
    public interface IStudentService
    {
        Employee Create(Employee department);
        Employee Update(Employee department);
        Employee Delete(int id, Employee department);
        Employee Get(int id);
        Employee Get(string name);
        List<Employee> GetAll(string name);

    }
}
