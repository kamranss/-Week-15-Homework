using DataAccess.Interfaces;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public class EmployeeRepository : IRepository<Employee>
    {
       

        public bool Create(Employee entity)
        {
            try
            {
                AppDbContext.Employees.Add(entity);
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool Delete(Employee entity)
        {
            AppDbContext.Employees.Remove(entity);
            return true;
        }

        public Employee Get(Predicate<Employee> filter = null)
        {
            try
            {
                Employee fakeEmployee = new Employee();
                return filter != null ? AppDbContext.Employees.Find(filter) : fakeEmployee;
                
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Employee> GetAll(Predicate<Employee> filter = null)
        {
            try
            {
                return filter != null ? AppDbContext.Employees.FindAll(filter) : AppDbContext.Employees;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool Update(Employee entity)
        {
            try
            {
                Employee employee = Get(emp => emp.Id == entity.Id);
                if (entity != null)
                {
                    employee = entity;
                    return true;
                }
                return false;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public int Count()
        {
            try
            {
                return AppDbContext.Employees.Count();
            }
            catch (Exception)
            {

                throw;
            }
        }

      
    }
}
