using ServiceLayer.Services;
using ServiceLayer.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_year_app.Controllers
{
    public class FibonacciController
    {

        private readonly IFibonacciService _service;
       
        public FibonacciController()
        {
            _service = new FibonacciService();
        }


        public void Fibonacci()
        {
            int number = 10;
            var result = _service.Fibonacci(number);

            
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

        }

    }
}
