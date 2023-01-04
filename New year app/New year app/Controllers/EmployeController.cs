using ServiceLayer.Services;
using ServiceLayer.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_year_app.Controllers
{
    public class EmployeController
    {
        private readonly IEmployeeService _services;

        public EmployeController()
        {
            _services = new EmployeeService();
        }

        public void GetSalaryByFiltered()
        {

            DateTime startTime = new DateTime(1995, 01, 01);
            DateTime endTime = new DateTime(2000, 01, 01);
            int salary = 2000;

            var result = _services.GetSalaryByFiltered(startTime, endTime, salary);

            foreach (var item in result)
            {
                if (item != null)
                {
                    Console.WriteLine($"{item.Name} {item.Surname} {item.Birthday} {item.Salary}");
                }
            }
        }

    }
}
