using DataAccess.Repositories;
using Domain.Models;
using Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using Utilities.Exceptions;
using Utilities.Helpers;

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
                    throw new EmployeeException(ConsoleMessages.departmentNotExist);
                    return null;
                }
                
            }
            catch (EmployeeException message)
            {

                Console.WriteLine(message.Message);
                return null;
            }
        }

        public Employee Update(int id, Employee employee, string departmentName)
        {
            Employee updatedemployee = employeeRepository.Get(e => e.Id == id);
            if (updatedemployee != null)
            {
                Department department = departmentService.Get(departmentName);
                if (department != null)
                {
                    updatedemployee.Name = employee.Name;
                    updatedemployee.Surname = employee.Surname;
                    updatedemployee.Age = employee.Age;
                    updatedemployee.Address = employee.Address;
                    updatedemployee.Department = department;
                    employeeRepository.Update(updatedemployee);
                    return updatedemployee;
                }
                return null;
            }
            return null;
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
            try
            {
                List<Employee> employees = employeeRepository.GetAll();
                return employees;
            }
            catch (Exception)
            {

                return null;
            }
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
