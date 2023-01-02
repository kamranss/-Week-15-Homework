using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities.Helpers
{
    public static class Helper
    {

        public static string message1 = "Please choose one of the option from Menu bar";
        public static string message2 =
        "1 - Create Department:\n" +
        "2 - Update:\n" +
        "3 - Delete:\n" +
        "4 - GetbyId:\n" +
        "5 - GetbyName:\n" +
        "6 - GetAllbyMaxsize\n" +
        "7 - GetAll\n" +
        "8 - GetAllbyName\n" +
        "9 - ExitProgram";
        public static void consolemessage(ConsoleColor color, string message1, string mesage2)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message1);
            Console.WriteLine(mesage2);
            Console.ResetColor();
        }
    }
}
