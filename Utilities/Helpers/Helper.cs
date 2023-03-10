using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities.Helpers
{
    public static class Helper
    {

        #region Case options
        public enum  Buttons
        {
        CreateDepartment =1,
        UpdateDepartment,
        DeleteDepartment,
        GetDepartmentById,
        GetDepartmentByName,
        GetDepartmentByCapacity,
        GetAllDepartment,
        CreateEmployee,
        GetAllEmployeesList,
        UpdateEmployee,
        DeleteEmployee,
        CountAllEmployee,
        GetEmployeeById,
        ExitProgram
        }
        #endregion
        public static void MenuOption()
        {
            string menuoption = Console.ReadLine();
            int selectedbutton;
            bool selection = int.TryParse(menuoption, out selectedbutton);
        }

        public static void consolemessage(ConsoleColor color,string message)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}
