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
    public class EmployeeService : IEmployeeService
    {
        private readonly EmployeeRepository employeeRepository;
        private readonly DepartmentService departmentService;
        private static int Id { get; set; }
        public EmployeeService()
        {
            employeeRepository = new EmployeeRepository();
            departmentService = new DepartmentService();
        }

        public Employee Create(Employee employee, string departmentName)
        {
            try
            {
                Department department = departmentService.Get(departmentName);
                if (department != null)
                {
                    if (employeeRepository.Create(employee))
                    {
                        Id++;
                        employee.Id = Id;
                        employee.Department = department;
                        return employee;
                    }
                    return null;
                }
                else
                {
                    Console.WriteLine("Given Department is not exist within the Database");
                    return null;
                }
                
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Employee Update(Employee employee)
        {
            throw new NotImplementedException();
        }

        public Employee Delete(int id, Employee employee)
        {
            Employee employee2 = employeeRepository.Get(e => e.Id == Id);
            if (employee2 != null)
            {
                employeeRepository.Delete(employee2);
                return employee2;
            }
            return null;
        }

        public Employee GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Employee GetByAge(int age)
        {
            throw new NotImplementedException();
        }

        public Employee GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public Employee GetBySurname(string surname)
        {
            throw new NotImplementedException();
        }

        public List<Employee> GetAll(string name)
        {
            throw new NotImplementedException();
        }

        public List<Employee> GetAll()
        {
            throw new NotImplementedException();
        }

        public Employee GetByDepartmentId(string departmentId)
        {
            throw new NotImplementedException();
        }

        public Employee GetByDepartmentName(string departmentName)
        {
            throw new NotImplementedException();
        }

        public int GetAllEmployeeCount()
        {
            throw new NotImplementedException();
        }

        public int GetEmployeeCountByDepartment()
        {
            throw new NotImplementedException();
        }
    }
}
