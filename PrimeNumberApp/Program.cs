using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrimeNumberApp.Operations;
using PrimeNumberApp.Core;
using System.Diagnostics;
namespace PrimeNumberApp
{
    class Program
    {
        static void Main(string[] args)
        {

            Stopwatch sw = new Stopwatch();
            PrimeNumberGenerator _primeNumberGenerator = null; 
            Console.WriteLine("Enter Limit to find Prime numbers");
            int limit = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Press 1 to find Prime numbers using Divideby PrimeNumbers in Loop algorithm");
            Console.WriteLine("Press 2 to find Prime numbers using sieve of eratosthenes algorithm");
            int option = Convert.ToInt32(Console.ReadLine().Trim());
            if(option ==1)
            {
                _primeNumberGenerator = new PrimeNumberGenerator(new DivideByPrimeNumbersInLoopMethod());
            }
            else if(option ==2)
            {
                _primeNumberGenerator = new PrimeNumberGenerator(new SieveOfEratosthenes());
            }
            else
            {
                Console.WriteLine("wrong selection !");

            }

            if (limit < 1)
            {
                Console.WriteLine("Enter number greater than 0");
            }
            else
            {
                sw.Reset();
                sw.Start();         
                var result = _primeNumberGenerator.GetNumbers(limit);
                Console.WriteLine("Total number of Operations : " + result.NumberOfOperations);
                Console.WriteLine("Total number of Prime Numbers : " + result.PrimeNumbers.Count());
                var resultToPrint =  string.Join(",", result.PrimeNumbers.Select(n => n.ToString()).ToArray());
                Console.WriteLine(resultToPrint);
                sw.Stop();              
                Console.WriteLine("Time taken={0}", sw.Elapsed);
                Console.ReadKey(true);
            }

        }
    }
}
