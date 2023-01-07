using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Department : IBaseInterface
    {
        public int? Id { get ; set ; }
        public string Name { get; set; }
        public int Capacity { get; set; }

        public void ShowDepartmentInfo()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Id: {Id} || Name: {Name} || Capacity: {Capacity} ");
            Console.ResetColor();


        }
    }
}
