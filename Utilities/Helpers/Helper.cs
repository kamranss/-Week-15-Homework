using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities.Helpers
{
    public static class Helper
    {

        public enum  Buttons
        {
        CreateDepartment =1,
        UpdateDepartment,
        DeleteDepartment,
        GetDepartmentbyId,
        GetDepartmentByName,
        GetDepartmentbyCapacity,
        GetAllDepartment,
        GetAllDepartmentbyName,
        CreateEmployee,
        ExitProgram
        }
        #region Console Messages for Department
        //public static string message1 =
        //"Please choose one of the option from Menu bar:\n" +
        //"1 - Create Department:\n" +
        //"2 - Update:\n" +
        //"3 - Delete:\n" +
        //"4 - GetbyId:\n" +
        //"5 - GetbyName:\n" +
        //"6 - GetAllbyMaxsize:\n" +
        //"7 - GetAll:\n" +
        //"8 - GetAllbyName:\n" +
        //"9 - ExitProgram:";

        //public  static string message2 =
        //    " Please Write Department Name\n" +
        //    "Note: For your information first we will check whether this Department exist in DataBase or not";

        //public static string message3 = "Please write Department capacity";
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
