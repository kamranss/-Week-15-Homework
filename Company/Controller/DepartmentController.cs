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
    public class DepartmentController
    {
        
        DepartmentService departmentService;
        EmployeeService employeeService;
        public DepartmentController()
        {
            departmentService = new DepartmentService();
            employeeService = new EmployeeService();
        }

        public  void CreateDepartment()
        {
            DepartmentNameAgain:  Helper.consolemessage(ConsoleColor.Green, ConsoleMessages.writeDepartmentName);
            string name = Console.ReadLine();
            Departmentcapacityagain: Helper.consolemessage(ConsoleColor.Cyan, ConsoleMessages.writeDepartmentCapacity);
            string selectedCapacity = Console.ReadLine();
            int capacity;
            bool checkCapacity = int.TryParse(selectedCapacity, out capacity);
            if (checkCapacity)
            {
                Department department = new Department();
                department.Name = name;
                department.Capacity = capacity;
                Department newdepartment = departmentService.Create(department);
                if (newdepartment == null)
                {
                    Helper.consolemessage(ConsoleColor.DarkRed, "Within the database same Department already exist");
                    goto DepartmentNameAgain;
                }
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
        public void DeleteDepartment()
        {
            GetAllDepartments();
            try
            {
                WriteidAgain: Helper.consolemessage(ConsoleColor.Green, ConsoleMessages.writeDepartmentId);
                string selectedId = Console.ReadLine();
                int departmentId;
                bool checkId = int.TryParse(selectedId, out departmentId);
                if (checkId)
                {
                    Department department = departmentService.Get(departmentId);
                    if ( department!= null)
                    {
                        List<Employee> employeeList = employeeService.GetAll();
                        int count = 0;
                        foreach (var item in employeeList)
                        {
                            if (item.Department == department)
                            {
                                count++;
                            }
                        }
                        if (count == 0)
                        {
                            departmentService.Delete(departmentId);
                            Helper.consolemessage(ConsoleColor.Green, $" id {departmentId} {ConsoleMessages.departmentDeleted}");
                            return;
                        }
                        else
                        {
                            Helper.consolemessage(ConsoleColor.DarkRed, ConsoleMessages.cannotDeleteDepartment);
                        }
                    }
                    else
                    {
                        Helper.consolemessage(ConsoleColor.DarkRed, ConsoleMessages.departmentWithThisIdNotExist);
                    }
                }
                else
                {
                    Helper.consolemessage(ConsoleColor.DarkRed, ConsoleMessages.wrongId);
                    goto WriteidAgain;
                }
            }
            catch (Exception)
            {

                throw;
            }
            
        }
        public void UpdateDepartment()
        {
            DepartmentIdAgain: Helper.consolemessage(ConsoleColor.Green, ConsoleMessages.writedepartmentIdForUpdate);
            string selectedId = Console.ReadLine();
            int departmentId;
            bool checkId = int.TryParse(selectedId, out departmentId);
            
            if (checkId)
            {
                Department updateDepartment = departmentService.Get(departmentId);
                if (updateDepartment != null)
                {
                    Departmentcapacityagain: Helper.consolemessage(ConsoleColor.Cyan, ConsoleMessages.writeDepartmentCapacity);
                    string selectedCapacity = Console.ReadLine();
                    int departmentCapacity = 0;
                    bool checkCapacity = int.TryParse(selectedCapacity, out departmentCapacity);
                    
                    
                    if (checkCapacity)
                    {
                        DepartmentNameAgain: Helper.consolemessage(ConsoleColor.Cyan, ConsoleMessages.writeDepartmentName);
                        string departmentName = Console.ReadLine();
                        Department checkDepartmentName = departmentService.Get(departmentName);
                        if (checkDepartmentName == null)
                        {
                            updateDepartment.Name = string.IsNullOrEmpty(departmentName) ? updateDepartment.Name: departmentName;
                            updateDepartment.Capacity = departmentCapacity == 0 ? updateDepartment.Capacity : departmentCapacity;
                            
                            Department newdepartment = departmentService.Update(updateDepartment, departmentId);
                            
                            Helper.consolemessage
                            (ConsoleColor.Blue,
                            $"Following Department Created\n {newdepartment.Id} {newdepartment.Name}  {newdepartment.Capacity}");
                        }
                        else
                        {
                            Helper.consolemessage(ConsoleColor.DarkRed, ConsoleMessages.sameDepartmentExist);
                            goto DepartmentNameAgain;
                        }

                        
                    }
                    else
                    {
                        Helper.consolemessage(ConsoleColor.DarkRed, ConsoleMessages.wrongCapacity);
                        goto Departmentcapacityagain;
                    }
                    
                }
                else
                {
                    Helper.consolemessage(ConsoleColor.DarkRed, ConsoleMessages.departmentWithThisIdNotExist);
                    goto DepartmentIdAgain;
                }

            }
            else
            {
                Helper.consolemessage(ConsoleColor.DarkRed, ConsoleMessages.wrongId);
                goto DepartmentIdAgain;
            }
        }
        public void GetDepartmentById()
        {
            WriteDepartmentIDAgain: Helper.consolemessage(ConsoleColor.Green, ConsoleMessages.writedepartmentIdForUpdate);
            string selectedId = Console.ReadLine();
            int departmentId;
            bool checkId = int.TryParse(selectedId, out departmentId);
            if (checkId)
            {

                Department department = departmentService.Get(departmentId);
                if (departmentId != null)
                {
                    department.ShowDepartmentInfo();
                }
                else
                {
                    Helper.consolemessage(ConsoleColor.Green, ConsoleMessages.writedepartmentIdAgain);
                    goto WriteDepartmentIDAgain;
                }
                
            }
            else
            {
                Helper.consolemessage(ConsoleColor.Green, ConsoleMessages.departmentNotExist);
                goto WriteDepartmentIDAgain;
            }

        }
        public void GetDepartmentByName()
        {
            WriteDepartmentNameAgain: Helper.consolemessage(ConsoleColor.Green, ConsoleMessages.writedepartmentIdForUpdate);
            string departmentname = Console.ReadLine();

            Department department = departmentService.Get(departmentname);
            if (department != null)
            {
                department.ShowDepartmentInfo();
            }
            else
            {
                Helper.consolemessage(ConsoleColor.Green, ConsoleMessages.WriteDepartmentNameAgain);
                goto WriteDepartmentNameAgain;
            }

        }
        public void GetDepartmentByCapacity()
        {
            WriteDepartmentCapacityAgain: Helper.consolemessage(ConsoleColor.Green, ConsoleMessages.writedepartmentIdForUpdate);
            string selectedCapacity = Console.ReadLine();
            int departmentCapacity;
            bool checkCapacity = int.TryParse(selectedCapacity, out departmentCapacity);
            if (checkCapacity)
            {

                Department department = departmentService.Get(departmentCapacity);
                if (departmentCapacity != null)
                {
                    department.ShowDepartmentInfo();
                }
                else
                {
                    Helper.consolemessage(ConsoleColor.Green, ConsoleMessages.writeDepartmentCapacityAgain);
                    goto WriteDepartmentCapacityAgain;
                }

            }
            else
            {
                Helper.consolemessage(ConsoleColor.Green, ConsoleMessages.departmentNotExist);
                goto WriteDepartmentCapacityAgain;
            }
        }
        public void GetAllDepartments()
        {
            
            List<Department> departmentListInfo =  departmentService.GetALL();
            int count = 0;
            foreach (var item in departmentListInfo)
            {
                count++;
            }
            if (count!=0) 
            {
                Helper.consolemessage(ConsoleColor.DarkCyan, "Following Departments exist in DataBase");
                foreach (var item in departmentService.GetALL())
                {
                    Helper.consolemessage(ConsoleColor.DarkGray, $"{item.Id} {item.Name} {item.Capacity}");
                }
            }
            else
            {
                Helper.consolemessage(ConsoleColor.DarkGray, $"There is no department in Database");
            }

            
        }
        public void GetAllDepartmentsName()
        {
            Helper.consolemessage(ConsoleColor.DarkCyan, "Following Departments exist in DataBase");
            foreach (var item in departmentService.GetALL())
            {
                Helper.consolemessage(ConsoleColor.DarkGray, $"{item.Name}");
            }
        }
        public void GetAllDepartmentbyCapacity()
        {
            try
            {
                WriteCapacityAgain: WriteidAgain: Helper.consolemessage(ConsoleColor.Green, ConsoleMessages.writeDepartmentCapacity);
                string stringcapacity = Console.ReadLine();
                int size;
                bool selectedcapacity = int.TryParse(stringcapacity, out size);
                Helper.consolemessage(ConsoleColor.DarkCyan, "Following Departments exist in DataBase");
                if (selectedcapacity)
                {
                    if (departmentService.GetAllByCapacity(size) != null)
                    {
                        foreach (var item in departmentService.GetAllByCapacity(size))
                        {
                            Helper.consolemessage(ConsoleColor.DarkGray, $"{item.Id} {item.Name}");
                        }
                        Helper.consolemessage(ConsoleColor.Blue, $"Department not found with given capacity");
                    }
                    else
                    {

                    }
                }
                else
                {
                    Helper.consolemessage(ConsoleColor.Green, "You should use digits not letters");
                    goto WriteCapacityAgain;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void GetDepartmentbyName()
        {

            Helper.consolemessage(ConsoleColor.DarkCyan, "Please write Department Name");
            string departmentName = Console.ReadLine();

            foreach (var item in departmentService.GetAllByName(departmentName))
            {
                Helper.consolemessage(ConsoleColor.DarkGray, $"{item.Id} {item.Name} {item.Capacity}");
            }
        }
    }
}
