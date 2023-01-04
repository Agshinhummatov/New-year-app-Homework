using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catsing_practices.Models
{
    public class Animal
    {
        public string Name { get; set; }

        //public Animal()
        //{
        //    Console.WriteLine("Animal constructor");
        //}
        public  virtual void Sound()
        {
            Console.WriteLine("Animal sound");
        }

    }
}
