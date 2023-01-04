using DomainLayer.Models;
using ServiceLayer.Helpers.Constants;
using ServiceLayer.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services
{
    public class StudentService : IStudentService
    {
        public Student[] GetStudentAddressByFiltered(string address)
        {
            var students = GetAll();

            Student[] result = new Student[students.Length];

            int count = 0;

            bool check = false;

            foreach (Student item in students)
            {

                if (item.Address == address)
                {
                    result[count] = item;
                    count++;
                    check = true;
                }
                if (!check)
                {
                    Console.WriteLine(Error.NoteFound);
                }

                
            }
            return result;


        }




        public double GetStudentAverageByAges()
        {
            var students = GetAll();

            double sumAge = 0;

            foreach (var item in students)
            {
                sumAge += item.Age;

            }

            return sumAge / students.Length;

        }

        public int GetStudentCountByFiltered()
        {
            var students = GetAll();

            int count = 0;

            foreach (var item in students)
            {

                count++;
            }

            return count;



        }

        public Student[] GetStudentEmailByFiltered(string email)
        {
            var students = GetAll();

            Student[] result = new Student[students.Length];

            int count = 0;
            bool check = false;
            foreach (var item in students)
            {
                if (item.Email.Substring(0,1) == email)
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

        public Student[] GetStudentNameSurnameByFiltered(string name, string surname)
        {
            var students = GetAll();

            Student[] result = new Student[students.Length];

            int count = 0;

            bool check = false;

            foreach (var item in students)
            {

                if (item.Name == name && item.Surname == surname)
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

        public Student[] GetStudentSameNamesByFiltered(string name)
        {
            
            var students = GetAll();


            Student[] result = new Student[students.Length];

            int count = 0;

            bool check = false;

            foreach (var item in students)
            {
                if (item.Name == name)
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

        private Student[] GetAll()
        {


            Student s1 = new Student
            {

                Id = 1,
                Name = "Cahandar",
                Surname = "Kazimov",
                Age = 25,
                Education = "Code Academyy",
                Address = "Ehmedli",
                Email = "cahandar@code.edu.az"



            };

            Student s2 = new Student
            {

                Id = 2,
                Name = "Pervin",
                Surname = "Rahimli",
                Age = 25,
                Education = "Code Academyy",
                Address = "Sumqayit",
                Email = "pervin@code.edu.az"

            };


            Student s3 = new Student
            {

                Id = 3,
                Name = "Aqsin",
                Surname = "Hummatov",
                Age = 27,
                Education = "Code Academyy",
                Address = "Xirdalan",
                Email = "aqsin@code.edu.az"

            };


            Student s4 = new Student
            {

                Id = 4,
                Name = "Roya",
                Surname = "Rahimli",
                Age = 25,
                Education = "Code Academyy",
                Address = "Sumqayit",
                Email = "roya@code.edu.az"


            };

            Student s5 = new Student
            {

                Id = 4,
                Name = "Aqsin",
                Surname = "Asgarov",
                Age = 25,
                Education = "Code Academyy",
                Address = "Sumqayit",
                Email = "asgarov@code.edu.az"


            };




            Student[] students = { s1, s2, s3, s4 , s5};

            return students;



        }


    }
}
