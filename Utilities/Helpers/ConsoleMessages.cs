using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities.Helpers
{
    public static class ConsoleMessages
    {
        public static string Options =
       "Please choose one of the option from Menu bar:\n" +
       "1 - Create Department:\n" +
       "2 - Update:\n" +
       "3 - Delete:\n" +
       "4 - GetbyId:\n" +
       "5 - GetbyName:\n" +
       "6 - GetAllbyCapacity:\n" +
       "7 - GetAll:\n" +
       "8 - GetAllbyName:\n" +
       "9 - ExitProgram:";

        #region Messages for Department
        public static string writeDepartmentName =
            " Please Write Department Name\n" +
            "Note: For your information first we will check whether this Department exist in DataBase or not";
        public static string writeDepartmentId = "Write Department Id which you want to delete";
        public static string writeDepartmentCapacity = "Please write Department capacity";
        public static string departmentDeleted = "Department deleted";

        public static string wrongCapacity = "The capacity which you have given is wrong you shoud try again";
        public static string wrongId = " The Id whihc you have written was wrong you should write again";
        #endregion

        #region messages for Employees
        public const string writeEmployeeName = "Please write employee name\n";
        public const string writeEmployeeSurname = "Please write employee surname\n";
        public const string writeEmployeeAge = "Please write employee surname\n";
        public const string writeEmployeeAddress = "Please write employee address";
        public const string writeEmployeeDepartmentName = "Please write Department name which employee will be assigned";

        public static string writeEmployeeId = "Write Department Id which you want to delete";       
        public static string employeeDeleted = "Department deleted";
        
        #endregion


    }
}
