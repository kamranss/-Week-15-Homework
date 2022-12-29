using DataAccess.Repositories;
using Domain.Models;
using Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Service
{
    public class DepartmentService : IDepartmentService
    {
        private readonly DepartmentRepository departmentRepository;
        public static int Id { get; set; }
        public DepartmentService()
        {
            departmentRepository = new DepartmentRepository();
        }
        public Department Create(Department department)
        {
            try
            {
                Department tempdepartment = departmentRepository.Get(d => d.Name == department.Name);
                if (tempdepartment==null)
                {
                    department.Id = Id;
                    if (departmentRepository.Create(department))
                    {
                        Id++;
                        return department;
                    }
                    return null;
                }
                return null;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Department Delete(int Id, Department department)
        {
            throw new NotImplementedException();
        }

        public Department Get(int id)
        {
            throw new NotImplementedException();
        }

        public Department Get(string name)
        {
            throw new NotImplementedException();
        }

        public List<Department> GetALL(string name)
        {
            try
            {
                List<Department> tempdepartment = departmentRepository.GetAll(d => d.Name == name);
                return tempdepartment;
            }
            catch (Exception)
            {

                return null;
            }
        }

        public Department Update(Department department)
        {
            throw new NotImplementedException();
        }
    }
}
