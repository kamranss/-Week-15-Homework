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
    internal class EmployeeService : IEmployeeService
    {
        EmployeeRepository employeeRepository;
        private static int Id { get; set; }
        public EmployeeService()
        {
            employeeRepository = new EmployeeRepository();
        }
        public Employee Create(Employee employee)
        {
            Employee employee1 = employeeRepository.Get(e => e.Name == employee.Name && e.Surname == employee.Surname);
            if (employee1 ==null)
            {
                employee1.Id = Id;
                if (employeeRepository.Create(employee1))
                {
                    Id++;
                    return employee1;
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

        public Employee Get(int id)
        {
            throw new NotImplementedException();
        }

        public Employee Get(string name)
        {
            throw new NotImplementedException();
        }

        public List<Employee> GetAll(string name)
        {
            throw new NotImplementedException();
        }

        public Employee Update(Employee employee)
        {
            throw new NotImplementedException();
        }
    }
}
