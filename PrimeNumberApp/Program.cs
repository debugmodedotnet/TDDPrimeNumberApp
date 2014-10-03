using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrimeNumberApp.Operations;
using PrimeNumberApp.Core;


namespace PrimeNumberApp
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter Limit to find Prime numbers");
            int limit = Convert.ToInt32(Console.ReadLine());
            if (limit < 1)
            {
                Console.WriteLine("Enter number greater than 0");
            }
            else
            {

                IPrimeNumberGenerator _primeNumberGenerator = new PrimeNumberGenerator();
                var result = _primeNumberGenerator.GetNumbers(limit);
                Console.WriteLine("Total number of Operations : " + result.NumberOfOperations);
                Console.WriteLine("Total number of Prime Numbers : " + result.Result.Count());
                
                foreach(var r in result.Result)
                {
                    Console.Write(r + ",");
                }
                Console.ReadKey(true);
            }

            
        }
    }
}
