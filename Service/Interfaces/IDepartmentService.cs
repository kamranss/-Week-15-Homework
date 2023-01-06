using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Interfaces
{
    public interface IDepartmentService
    {
        Department Create(Department department);
        Department Update(Department department, int id);
        Department Delete(int Id);
        Department Get(int id);
        Department Get(string name);
        List<Department> GetAllByName(string name);
        List<Department> GetALL();
        List<Department> GetAllByCapacity(int capacity);
    }
}
