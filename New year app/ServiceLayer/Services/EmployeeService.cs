using DomainLayer.Models;
using ServiceLayer.Helpers.Constants;
using ServiceLayer.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services
{
    public class EmployeeService : IEmployeeService
    {
        public Employee[] GetSalaryByFiltered(DateTime startTime,DateTime endTime, int salary)
        {
            var employees = AllEmployees();

            Employee[] result = new Employee[employees.Length];

            int count = 0;

            bool check = false;
            foreach (var item in employees)
            {
                if (item.Birthday > startTime && item.Birthday < endTime && item.Salary > salary )
                {
                    result[count] = item;
                    count++;
                    check = true;

                }

            }
            if (!check)
            {
                Console.WriteLine(Error.NoteFound);
            }

            return result;


        }

        private Employee[] AllEmployees()
        {

            Employee employee1 = new Employee
            {
                Id = 1,
                Name = "Aqsin",
                Surname = "Hummatov",
                Birthday = new DateTime(1995, 11, 05),
                Salary = 3500

            };

            Employee employee2 = new Employee
            {
                Id = 2,
                Name = "Elcan",
                Surname = "Qasimov",
                Birthday = new DateTime(1996, 12, 07),
                Salary = 1800
            };

            Employee employee3 = new Employee
            {
                Id= 3,
                Name = "Feride",
                Surname = "Mustafazde",
                Birthday = new DateTime(1997, 08, 03),
                Salary = 2200

            };

            Employee employee4 = new Employee
            {
                Id= 4,
                Name = "Konul",
                Surname = "Hasanova",
                Birthday = new DateTime(1996, 05, 15),
                Salary = 2500
            };

            Employee employee5 = new Employee
            {
                Id= 5,
                Name = "Cavid",
                Surname = "Qasimzade",
                Birthday = new DateTime(1999, 09, 17),
                Salary = 2500
            };



            Employee employee6 = new Employee
            {
                Id = 5,
                Name = "Anar",
                Surname = "Hasanli",
                Birthday = new DateTime(2002, 09, 17),
                Salary = 2500
            };


            Employee[] employees = new Employee[] { employee1, employee2, employee3, employee4, employee5,employee6 };

            return employees;

        }
    }
}
