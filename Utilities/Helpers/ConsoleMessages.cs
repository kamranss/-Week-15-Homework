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
       "2 - Update:\n" +
       "3 - Delete:\n" +
       "4 - GetbyId:\n" +
       "5 - GetbyName:\n" +
       "6 - GetAllbyMaxsize:\n" +
       "7 - GetAll:\n" +
       "8 - GetAllbyName:\n" +
       "9 - ExitProgram:";

        public static string writeDepartmentName =
            " Please Write Department Name\n" +
            "Note: For your information first we will check whether this Department exist in DataBase or not";

        public static string writeDepartmentCapacity = "Please write Department capacity";

        public static string wrongCapacity = "The capacity which you have given is wrong you shoud try again";

        //public static string departmentsfullInfo = Console.WriteLine($"{newdepartment.Id} {newdepartment.Name}  {newdepartment.Capacity}");
    }
}
