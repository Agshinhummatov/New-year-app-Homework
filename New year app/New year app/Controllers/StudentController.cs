using DomainLayer.Models;
using ServiceLayer.Services;
using ServiceLayer.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_year_app.Controllers
{
    internal class StudentController
    {

        private readonly IStudentService _service;

        public StudentController()
        {
            _service= new StudentService(); 

        }

        public void GetStudentCountByFiltered()
        {
            Console.WriteLine(_service.GetStudentCountByFiltered());
        }


       public void GetStudentAverageByAges()
        {

            Console.WriteLine(_service.GetStudentAverageByAges());
        }


        public void GetStudentEmailByFiltered()
        {


            string n = "a";

            var result = _service.GetStudentEmailByFiltered(n);

            foreach (var item in result)
            {
                if (item != null)
                {

                    Console.WriteLine($" {item.Name} {item.Surname} {item.Age} {item.Email}");
                }


            }

        }


         public void GetStudentAddressByFiltered()
         {
            string address = "Ehmedli";

            var result = _service.GetStudentAddressByFiltered(address);

            foreach (var item in result)
            {
                if (item != null)
                {
                    Console.WriteLine($"{item.Name} {item.Surname} {item.Address}");
                }
               
            }

         }


        public void GetStudentNameSurnameByFiltered()
        {

            string name = "Aqsin";
            string surname = "Hummatov";

            var result = _service.GetStudentNameSurnameByFiltered(name, surname);

            foreach (var item in result)
            {
                if (item != null)
                {
                    Console.WriteLine($"{item.Name} {item.Surname} ");

                }
            }
        }

        public void GetStudentSameNamesByFiltered()
        {

            string name = "Aqsin";

            var result = _service.GetStudentSameNamesByFiltered(name);

            foreach (var item in result)
            {

                if (item != null)
                {
                    Console.WriteLine($"{item.Name} {item.Surname}");
                }

            }

        }
    }
}
