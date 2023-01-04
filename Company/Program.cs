// See https://aka.ms/new-console-template for more information

using Company.Controller;
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


DepartmentService departmentService = new DepartmentService();
DepartmentController departmentController = new DepartmentController();
EmployeeController employeeController = new EmployeeController();

bool whileresult = true;
while (whileresult)
{
    Helper.consolemessage(ConsoleColor.DarkMagenta, ConsoleMessages.Options);
    string menuoption = Console.ReadLine();
    int selectedbutton;
    bool selection = int.TryParse(menuoption, out selectedbutton);

    if (selectedbutton > 0 && selectedbutton < 12)
    {
        switch (selectedbutton)
        {
            case (int)Helper.Buttons.CreateDepartment:               
                departmentController.CreateDepartment();
                break;
            case (int)Helper.Buttons.DeleteDepartment:
                departmentController.DeleteDepartment();
                break;
            case (int)Helper.Buttons.GetAllDepartment:
                departmentController.GetAllDepartments();
                break;
            case (int)Helper.Buttons.ExitProgram:
                whileresult = false;
                break;
            case (int)Helper.Buttons.GetDepartmentbyCapacity:
                departmentController.GetAllDepartmentbyCapacity();
                break;
            case (int)Helper.Buttons.CreateEmployee:
                employeeController.CreateEmployee();
                break;
                
            default:
                break;
        }       
    }
    else
    {
        Helper.consolemessage(ConsoleColor.DarkGreen, "Choose correct option");
    }
}