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

        public Department Delete(int Id)
        {
            try
            {
                Department tempDepartment = departmentRepository.Get(d => d.Id == Id);
                if (tempDepartment != null)
                {
                    departmentRepository.Delete(tempDepartment);
                    return tempDepartment;
                }
                return null;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public Department Get(int id)
        {
            throw new NotImplementedException();
        }

        public Department Get(string name)
        {
            throw new NotImplementedException();
        }

        public List<Department> GetAllByName(string name)
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

        public List<Department> GetALL()
        {
            try
            {
                List<Department> departments = departmentRepository.GetAll();
                return departments;
            }
            catch (Exception)
            {

                return null;
            }
        }

        public List<Department> GetAllByCapacity(int capacity)
        {
            try
            {
                List<Department> department = departmentRepository.GetAll(d => d.Capacity == capacity);
                return department;
            }
            catch (Exception)
            {

                return null;
            }
        }
    }
}
