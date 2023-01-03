using Domain.Models;
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
        public DepartmentController()
        {
            departmentService = new DepartmentService();
        }
        public  void CreateDepartment()
        {
            Helper.consolemessage(ConsoleColor.Green, ConsoleMessages.writeDepartmentName);
            string name = Console.ReadLine();
            Departmentcapacityagain: Helper.consolemessage(ConsoleColor.Cyan, ConsoleMessages.writeDepartmentCapacity);
            string maxcapacity = Console.ReadLine();
            int selectedcapacity;
            bool endcapacity = int.TryParse(maxcapacity, out selectedcapacity);
            if (endcapacity)
            {
                Department department = new Department();
                department.Name = name;
                department.Capacity = selectedcapacity;
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
        public void DeleteDepartment()
        {
            GetAllDepartments();
            try
            {
                WriteidAgain: Helper.consolemessage(ConsoleColor.Green, ConsoleMessages.writeDepartmentId);
                string id = Console.ReadLine();
                int endId;
                bool selectedId = int.TryParse(id, out endId);
                if (selectedId)
                {
                    if (departmentService.Delete(endId) != null)
                    {
                        departmentService.Delete(endId);
                        Helper.consolemessage(ConsoleColor.Green, $" id {endId} {ConsoleMessages.departmentDeleted}");
                        return;
                    }
                    else
                    {
                        Helper.consolemessage(ConsoleColor.Blue, "Given Id is not exist in DataBase");
                    }
                }
                else
                {
                    Helper.consolemessage(ConsoleColor.DarkGreen, ConsoleMessages.wrongId);
                    goto WriteidAgain;
                }
            }
            catch (Exception)
            {

                throw;
            }
            
        }

        public void GetAllDepartments()
        {
            Helper.consolemessage(ConsoleColor.DarkCyan, "Following Departments exist in DataBase");
            foreach (var item in departmentService.GetALL())
            {
                Helper.consolemessage(ConsoleColor.DarkGray, $"{item.Id} {item.Name} {item.Capacity}");
            }
        }
    }
}
