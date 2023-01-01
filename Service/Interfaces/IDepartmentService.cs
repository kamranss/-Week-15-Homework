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
        Department Update(Department department);
        Department Delete(int Id, Department department);
        Department Get(int id);
        Department Get(string name);
        List<Department> GetALL(string name);
        List<Department> GetALL();
    }
}
