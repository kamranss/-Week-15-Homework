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

        public void CreateEmployee()
        {
            Helper.consolemessage(ConsoleColor.Green, ConsoleMessages.writeEmployeeName);
            string name = Console.ReadLine();
            Helper.consolemessage(ConsoleColor.Cyan, ConsoleMessages.writeEmployeeSurname);
            string surname = Console.ReadLine();
            Helper.consolemessage(ConsoleColor.Cyan, ConsoleMessages.writeEmployeeAge);
            string age = Console.ReadLine();
            int selectedage;
            bool endage = int.TryParse(age ,out  selectedage);
            if (endage)
            {
                Employee newemployee = new Employee();
                newdepartment.Name = name;
                newemployee.Capacity = selectedcapacity;
                Department newdepartment = departmentService.Create(department);
                Helper.consolemessage
                (ConsoleColor.Blue,
                $"Following Department Created\n {newdepartment.Id} {newdepartment.Name}  {newdepartment.Capacity}");

            }
            else
            {
                Helper.consolemessage(ConsoleColor.DarkRed, ConsoleMessages.wrongCapacity);
                goto Departmentcapacityagain;
            }
        }
    }
}
