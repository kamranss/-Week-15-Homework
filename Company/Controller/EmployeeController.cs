using Domain.Models;
using Service.Interfaces;
using Service.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities.Helpers;

namespace Company.Controller
{
    public class EmployeeController
    {
        EmployeeService employeeService;

        public EmployeeController()
        {
            employeeService = new EmployeeService();
        }

        //public void CreateEmployee()
        //{
        //    Helper.consolemessage(ConsoleColor.Green, ConsoleMessages.writeDepartmentName);
        //    string name = Console.ReadLine();
        //Departmentcapacityagain: Helper.consolemessage(ConsoleColor.Cyan, ConsoleMessages.writeDepartmentCapacity);
        //    string maxcapacity = Console.ReadLine();
        //    int selectedcapacity;
        //    bool endcapacity = int.TryParse(maxcapacity, out selectedcapacity);
        //    if (endcapacity)
        //    {
        //        Employee newemployee = new Employee();
        //        newdepartment.Name = name;
        //        newemployee.Capacity = selectedcapacity;
        //        Department newdepartment = departmentService.Create(department);
        //        Helper.consolemessage
        //        (ConsoleColor.Blue,
        //        $"Following Department Created\n {newdepartment.Id} {newdepartment.Name}  {newdepartment.Capacity}");

        //    }
        //    else
        //    {
        //        Helper.consolemessage(ConsoleColor.DarkRed, ConsoleMessages.wrongCapacity);
        //        goto Departmentcapacityagain;
        //    }
        //}
    }
}
