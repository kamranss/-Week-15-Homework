// See https://aka.ms/new-console-template for more information

using Domain.Models;
using Service.Service;

Console.WriteLine("Please choose one of the option from Menu bar");
Console.WriteLine(
    "1 - Create Department: " +
    "2 - Update: " +
    "3 - Delete: " +
    "4 - GetbyId: " +
    "5 - GetbyName: " +
    "6 - GetAllbyMaxsize" +
    "7 - GetAll" +
    "8 - GetAllbyName");

string menuoption = Console.ReadLine();
int selectedbutton;
bool selection = int.TryParse(menuoption, out selectedbutton);

DepartmentService departmentService = new DepartmentService();

while (true)
{
    if (selectedbutton > 0 && selectedbutton < 10)
    {
        switch (selectedbutton)
        {
            case 1:
                Console.WriteLine(" Please Write Department Name-> Note:" +
                    "For your information first we will check whether this Department exist in DataBase or not");
                string name = Console.ReadLine();
                Departmentcapacityagain: Console.WriteLine("Please write Department capacity");
                string maxcapacity = Console.ReadLine();
                int selectedcapacity;
                bool endcapacity = int.TryParse(maxcapacity, out selectedcapacity);
                if (endcapacity)
                {
                    Department department = new Department();
                    department.Name = name;
                    department.Capacity = selectedcapacity;
                    Department newdepartment = departmentService.Create(department);
                    Console.WriteLine($"{newdepartment.Id}  {newdepartment.Name}  {newdepartment.Capacity}");
                    break;
                }
                else
                {
                    Console.WriteLine("The capacity whihc you have given is wrong you shoud try again");
                    goto Departmentcapacityagain;
                }
                
            default:
                break;
        }
    }
}
