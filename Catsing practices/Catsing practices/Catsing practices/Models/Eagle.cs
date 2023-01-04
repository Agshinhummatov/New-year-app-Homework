using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catsing_practices.Models
{
    internal class Eagle : Bird
    {
        public int Speed { get; set; }

        public override void Sound()
        {
            Console.WriteLine("Eagle sound");
        }


    }
}
