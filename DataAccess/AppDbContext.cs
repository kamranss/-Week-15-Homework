using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    internal class AppDbContext
    {
        public static List<Employee> Employees = new List<Employee>();
        public static List<Department> Departments = new List<Department>();

        public AppDbContext()
        {
            Employees = new List<Employee>();
            Departments = new List<Department>();
        }
    }
}
