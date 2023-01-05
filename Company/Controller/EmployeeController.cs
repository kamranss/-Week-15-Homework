using DataAccess.Repositories;
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
        DepartmentController departmentController1;
        EmployeeRepository employeeRepository;
        DepartmentService departmentService1;

        public EmployeeController()
        {
            employeeService = new EmployeeService();
            employeeRepository = new EmployeeRepository();
            departmentController1 = new DepartmentController();
            departmentService1 = new DepartmentService();
        }

        public void CreateEmployee()
        {
            Helper.consolemessage(ConsoleColor.Green, ConsoleMessages.writeEmployeeName);
            string name = Console.ReadLine();
            Helper.consolemessage(ConsoleColor.Cyan, ConsoleMessages.writeEmployeeSurname);
            string surname = Console.ReadLine();
            Helper.consolemessage(ConsoleColor.Cyan, ConsoleMessages.writeEmployeeAddress);
            string address = Console.ReadLine();
            writeEmployeeAge: Helper.consolemessage(ConsoleColor.Cyan, ConsoleMessages.writeEmployeeAge);
            string selectedAge = Console.ReadLine();
            int Age;
            bool endage = int.TryParse(selectedAge, out Age);
            departmentController1 = new DepartmentController();
            departmentController1.GetAllDepartmentsName();
            departmentNameAgain: Helper.consolemessage(ConsoleColor.Green, ConsoleMessages.writeEmployeeDepartmentName);
            string departmentName = Console.ReadLine();

            if (endage)
            {
                Employee newemployee = new Employee();
                newemployee.Name = name;
                newemployee.Surname = surname;
                newemployee.Age = Age;
                newemployee.Address = address;
                Employee employee = employeeService.Create(newemployee, departmentName);
                if (employee.Name == name)
                {
                   Helper.consolemessage(ConsoleColor.Blue,
                   $"Following Employee Created\n " +
                   $"{newemployee.Id} " +
                   $"{newemployee.Name}  " +
                   $"{newemployee.Surname} " +
                   $"{newemployee.Age} " +
                   $"{newemployee.Department.Name} " +
                   $"{newemployee.Address}");
                   return;                   
                }
                else
                {                   
                    goto departmentNameAgain;
                    return;
                }               
            }
            else
            {
                Helper.consolemessage(ConsoleColor.DarkRed, ConsoleMessages.employeeNotCreated);
                goto writeEmployeeAge;
                return;
            }
            
        }

        public void GetAllEmployees()
        {
            Helper.consolemessage(ConsoleColor.Green, ConsoleMessages.employeesList);
            foreach (var item in employeeService.GetAll())
            {
                Helper.consolemessage(ConsoleColor.Blue,
                  $"Employee Id - {item.Id} " + 
                  $"Employee Name - {item.Name}  " +
                  $"Employee Surname - {item.Surname} " +
                  $"Department Name - {item.Department.Name} " +
                  $"Employee Address - {item.Address}");
            }
        }
        public void UpdateEmployee()
        {
            GetAllEmployees();
            WriteEmployeeIdAgain: Helper.consolemessage(ConsoleColor.Green, ConsoleMessages.writeEmployeeIdForUpdate);
            string selectedId = Console.ReadLine();
            int id;
            bool convertedId = int.TryParse(selectedId, out id);
            if (convertedId)
            {
                Employee updatedemployee = employeeRepository.Get(e => e.Id == id);
                if (updatedemployee != null)
                {
                    writeDepartmentNameagain: Helper.consolemessage(ConsoleColor.Green, ConsoleMessages.writeDepartmentName);
                    string departmentName = Console.ReadLine();
                    Department department = departmentService1.Get(departmentName);
                    if (department != null)
                    {
                        Helper.consolemessage(ConsoleColor.Green, ConsoleMessages.writeEmployeeName);
                        string name = Console.ReadLine();
                        Helper.consolemessage(ConsoleColor.Cyan, ConsoleMessages.writeEmployeeSurname);
                        string surname = Console.ReadLine();
                        Helper.consolemessage(ConsoleColor.Cyan, ConsoleMessages.writeEmployeeAddress);
                        string address = Console.ReadLine();
                        writeEmployeeAgeAgain: Helper.consolemessage(ConsoleColor.Cyan, ConsoleMessages.writeEmployeeAge);
                        string selectedAge = Console.ReadLine();
                        int Age;
                        bool convertedAge = int.TryParse(selectedAge, out Age);
                        if (convertedAge)
                        {
                            employeeService.Update(id, updatedemployee, departmentName);
                            Helper.consolemessage(ConsoleColor.Green, ConsoleMessages.employeeUpdated);
                            foreach (var item in employeeService.GetAll())
                            {
                                Helper.consolemessage(ConsoleColor.Blue,
                                $"Employee Id - {item.Id} " +
                                $"Employee Name - {item.Name}  " +
                                $"Employee Surname - {item.Surname} " +
                                $"Department Name - {item.Department.Name} " +
                                $"Employee Address - {item.Address}");
                            }

                        }
                        else
                        {
                            Helper.consolemessage(ConsoleColor.DarkRed, ConsoleMessages.employeeAgeWrong);
                            goto writeEmployeeAgeAgain;
                        }
                    }
                    else
                    {
                        Helper.consolemessage(ConsoleColor.DarkRed, ConsoleMessages.departmentNotExist);
                        goto writeDepartmentNameagain;
                    }
                    
                }
                else
                {
                    Helper.consolemessage(ConsoleColor.DarkRed, ConsoleMessages.employeeNotExist);
                    goto WriteEmployeeIdAgain;
                }
            }
            else
            {
                Helper.consolemessage(ConsoleColor.DarkRed, ConsoleMessages.employeeIdWrong);
                goto WriteEmployeeIdAgain;
            }
           
        }
    }
}
