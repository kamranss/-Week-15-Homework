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
            Employee deleteemployee = employeeRepository.Get(e => e.Id == Id);
            if (deleteemployee != null)
            {
                employeeRepository.Delete(deleteemployee);
                return deleteemployee;
            }
            return null;
        }

        public Employee GetById(int id)
        {
            try
            {
                Employee employee = employeeRepository.Get(e => e.Id == id);
                return employee;
            }
            catch (Exception)
            {

                return null;
            }
        }

        public Employee GetByAge(int age)
        {
            try
            {
                Employee employee = employeeRepository.Get(e => e.Age == age);
                return employee;
            }
            catch (Exception)
            {

                return null;
            }
        }

        public Employee GetByName(string name)
        {
            try
            {
                Employee employee = employeeRepository.Get(e => e.Name == name);
                return employee;
            }
            catch (Exception)
            {

                return null;
            }
        }

        public Employee GetBySurname(string surname)
        {
            try
            {
                Employee employee = employeeRepository.Get(e => e.Surname == surname);
                return employee;
            }
            catch (Exception)
            {

                return null;
            }
        }

        public List<Employee> GetAll(string name)
        {
            try
            {
                List<Employee> employees = employeeRepository.GetAll(e => e.Name == name);
                return employees;
            }
            catch (Exception)
            {

                return null;
            }
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

        public List<Employee> GetByDepartmentId(int departmentId)
        {
            try
            {
                List<Employee> employee = employeeRepository.GetAll(e => e.Department.Id == departmentId);
                return employee;
            }
            catch (Exception)
            {

                return null;
            }
        }

        public List<Employee> GetByDepartmentName(Department departmentName)
        {
            try
            {
                List<Employee> employees = employeeRepository.GetAll(e => e.Department == departmentName);
                return employees;
            }
            catch (Exception)
            {

                return null;
            }
        }

        public int GetAllEmployeeCount()
        {
            try
            {
                return employeeRepository.Count();
                 
            }
            catch (Exception)
            {

                throw;
            }
        }

        public int GetEmployeeCountByDepartment()
        {
            throw new NotImplementedException();
        }
    }
}
