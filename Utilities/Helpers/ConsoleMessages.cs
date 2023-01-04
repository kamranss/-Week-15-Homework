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
       "2 - UpdateDepartment:\n" +
       "3 - DeleteDepartment:\n" +
       "4 - GetDepartmentbyId:\n" +
       "5 - GetDepartmentbyName:\n" +
       "6 - GetDepartmentbyCapacity:\n" +
       "7 - GetAllDepartment:\n" +
       "8 - GetdepartmentbyName:\n" +
       "9 - CreateEmployee:\n"+
       "10 - GetAllEmployeesList:\n" +
       "10 - ExitProgram:";

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
        public const string employeesList = "Following Employees exist in the Database";
        public const string writeEmployeeName = "Please write employee Name\n";
        public const string writeEmployeeSurname = "Please write employee Surname\n";
        public const string writeEmployeeAge = "Please write employee Age\n";
        public const string writeEmployeeAddress = "Please write employee Address";
        public const string writeEmployeeDepartmentName = "Please write Department name which employee will be assigned";
        public const string departmentNotExist = "Given Department is not exist within the Database";

        public const string employeeNotCreated = "Something Went Wrong --- > Employee not created";

        public static string writeEmployeeId = "Write Department Id which you want to delete";       
        public static string employeeDeleted = "Department deleted";
        
        #endregion


    }
}
