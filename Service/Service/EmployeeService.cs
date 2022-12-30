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
            Employee tempemployee = employeeRepository.Get(e => e.Name == employee.Name && e.Surname == employee.Surname);
            if (tempemployee ==null)
            {
                tempemployee.Id = Id;
                if (employeeRepository.Create(tempemployee))
                {
                    Id++;
                    return tempemployee;
                }
                return null;
            }
            return null;

        }

        public Employee Delete(int id, Employee employee)
        {
            throw new NotImplementedException();
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
