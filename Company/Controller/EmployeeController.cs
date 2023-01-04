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
            writeEmployeeName: Helper.consolemessage(ConsoleColor.Green, ConsoleMessages.writeEmployeeName);
            string name = Console.ReadLine();
            Helper.consolemessage(ConsoleColor.Cyan, ConsoleMessages.writeEmployeeSurname);
            string surname = Console.ReadLine();
            Helper.consolemessage(ConsoleColor.Cyan, ConsoleMessages.writeEmployeeAddress);
            string address = Console.ReadLine();
            Helper.consolemessage(ConsoleColor.Cyan, ConsoleMessages.writeEmployeeAge);
            string selectedAge = Console.ReadLine();
            int Age;
            bool endage = int.TryParse(selectedAge, out Age);
            departmentNameAgain: Helper.consolemessage(ConsoleColor.Green, ConsoleMessages.writeEmployeeDepartmentName);
            string departmentName = Console.ReadLine();

            if (endage)
            {
                Employee newemployee = new Employee();
                newemployee.Name = name;
                newemployee.Surname = surname;
                newemployee.Age = Age;
                newemployee.Address = address;
                employeeService.Create(newemployee, departmentName);
                if (newemployee.Id == null)
                {
                    Helper.consolemessage(ConsoleColor.DarkRed, "Given Department is not exist within the Database");
                    goto departmentNameAgain;
                }
                else
                {
                    Helper.consolemessage(ConsoleColor.Blue,
                    $"Following Employee Created\n " +
                    $"{newemployee.Id} " +
                    $"{newemployee.Name}  " +
                    $"{newemployee.Surname} " +
                    $"{newemployee.Department} " +
                    $"{newemployee.Address}");
                }               
            }
            else
            {
                Helper.consolemessage(ConsoleColor.DarkRed, ConsoleMessages.employeeNotCreated);
                goto writeEmployeeName;
                return;
            }
            
        }
    }
}
