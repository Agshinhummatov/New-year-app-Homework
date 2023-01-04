using ServiceLayer.Services;
using ServiceLayer.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_year_app.Controllers
{
    public class CalculateController 
    {

     
        public double Calculate()
        {
            Console.WriteLine("Reqem daxil edin");
            double x = double.Parse(Console.ReadLine());

            Console.WriteLine("Opareation daxil edin");
            string operation = Console.ReadLine();

            Console.WriteLine("Reqem daxil edin");
            double y = double.Parse(Console.ReadLine());    

            ICalculateService calculateService = new CalculateService();

            var result = calculateService.Calculate(x, y, operation);

            Console.WriteLine($"Netice : {result}");


            return result;

           
        }

       
    }
}
