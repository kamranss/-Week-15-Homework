﻿using System;
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
       "11 - UpdateEmployee:\n" +
       "12 - ExitProgram:";

        #region Messages for Department
        public const string writeDepartmentName =
            " Please Write Department Name\n" +
            "Note: For your information first we will check whether this Department exist in DataBase or not";

        public const string writeDepartmentId = "Write Department Id which you want to delete";
        public const string writeDepartmentCapacity = "Please write Department capacity";
        public const string departmentDeleted = "Department deleted";
        public const string departmentNotExist = "Given Department is not exist within the Database";
        public const string departmentWithThisIdNotExist = "Department with given Id not wxist in Database";

        public static string wrongCapacity = "The capacity which you have given is wrong you shoud try again";
        public static string wrongId = " The Id whihc you have written was wrong you should write again";
        #endregion

        #region messages for Employees
        public const string employeesList = "Following Employees exist in the Database";
        public const string writeEmployeeIdForUpdate = "Please write Employee Id which you want to update";
        public const string writeEmployeeName = "Please write employee Name\n";
        public const string writeEmployeeSurname = "Please write employee Surname\n";
        public const string writeEmployeeAge = "Please write employee Age\n";
        public const string writeEmployeeAddress = "Please write employee Address";
        public const string writeEmployeeDepartmentName = "Please write Department name which employee will be assigned";

        public const string employeeAgeWrong = "Given age is wrong use digits intead of letters";
        public const string employeeIdWrong = "Given Id is wrong you should use digits";
        public const string employeeNotExist = "There is not any Employee which assoiated with provided id";
        public const string employeeNotCreated = "Something Went Wrong --- > Employee not created";
        public const string writeEmployeeIdForDelete = "Write Department Id which you want to delete";       
        public const string employeeDeleted = "Department deleted";
        public const string employeeUpdated = "Employee Updated";
        
        #endregion


    }
}
