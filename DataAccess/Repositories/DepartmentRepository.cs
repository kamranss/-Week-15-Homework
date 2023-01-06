using DataAccess.Interfaces;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public class DepartmentRepository : IRepository<Department>
    {
      

        public int Count(List<Department> entity)
        {
            throw new NotImplementedException();
        }
        #region I repository Methods Implemented
        public bool Create(Department entity)
        {
            try
            {
                AppDbContext.Departments.Add(entity);
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool Delete(Department entity)
        {
            try
            {
                AppDbContext.Departments.Remove(entity);
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Department Get(Predicate<Department> filter = null)
        {
            try
            {
                return filter != null ? AppDbContext.Departments.Find(filter) : AppDbContext.Departments[0];
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Department> GetAll(Predicate<Department> filter = null)
        {
            try
            {
                return filter != null ? AppDbContext.Departments.FindAll(filter) : AppDbContext.Departments;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool Update(Department entity)
        {
            try
            {
                Department department = Get(dept => dept.Id == entity.Id);
                if (department != null)
                {
                    department = entity;
                    return true;
                }
                return false;
            }
            catch (Exception)
            {

                throw;
            }
        }
        #endregion
    }
}
