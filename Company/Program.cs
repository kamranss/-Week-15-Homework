// See https://aka.ms/new-console-template for more information

using Domain.Models;
using Service.Service;
using Utilities.Helpers;

//Console.ForegroundColor = ConsoleColor.DarkMagenta;
//Console.WriteLine("Please choose one of the option from Menu bar");
//Console.Write(
//    "1 - Create Department:\n" +
//    "2 - Update:\n" +
//    "3 - Delete:\n" +
//    "4 - GetbyId:\n" +
//    "5 - GetbyName:\n" +
//    "6 - GetAllbyMaxsize\n" +
//    "7 - GetAll\n" +
//    "8 - GetAllbyName\n" +
//    "9 - ExitProgram");
//Console.ResetColor();

Helper.consolemessage(ConsoleColor.DarkMagenta, ConsoleMessages.Options);

string menuoption = Console.ReadLine();
int selectedbutton;
bool selection = int.TryParse(menuoption, out selectedbutton);

DepartmentService departmentService = new DepartmentService();

bool whileresult = true;
while (whileresult)
{
    if (selectedbutton > 0 && selectedbutton < 10)
    {
        switch (selectedbutton)
        {
            case 1:
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
                    $"Following Department Created\n ${newdepartment.Id} {newdepartment.Name}  {newdepartment.Capacity}");

                }
                else
                {
                    Helper.consolemessage(ConsoleColor.DarkRed, ConsoleMessages.wrongCapacity);
                    goto Departmentcapacityagain;
                }
                break;
            case 7:
                foreach (var item in departmentService.GetALL())
                {
                    Helper.consolemessage(ConsoleColor.DarkGray, $"{item.Id} {item.Name} {item.Capacity}");
                }
                break;
            case 9:
                whileresult = false;
                break;
                
            default:
                break;
        }
        
    }
    else
    {
        Console.WriteLine("Choose correct option");
    }
}