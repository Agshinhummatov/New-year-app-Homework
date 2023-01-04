using ServiceLayer.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services
{
    public class FibonacciService : IFibonacciService
    {

        public int[] Fibonacci(int number)
        {
            int[] result = new int[number];
            result[0] = 0;
            result[1] = 1;
            for (int i = 2; i < number; i++)
            {
                result[i] = result[i - 2] + result[i - 1];


            }
            return result;


        }
    }    
}
