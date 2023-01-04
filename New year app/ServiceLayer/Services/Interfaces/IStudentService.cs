using DomainLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services.Interfaces
{
    public interface IStudentService
    {
        int GetStudentCountByFiltered();

        double GetStudentAverageByAges();

        public Student[] GetStudentEmailByFiltered(string email);

        public Student[] GetStudentAddressByFiltered(string address);

        public Student[] GetStudentNameSurnameByFiltered(string name, string surname);

        public Student[] GetStudentSameNamesByFiltered(string name);

    }
}
