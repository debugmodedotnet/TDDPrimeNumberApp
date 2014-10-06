using PrimeNumberApp.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumberApp.Operations
{
   public class SieveOfEratosthenes : ITestPrime
    {
      
        PrimeNumberResult ITestPrime.FindPrimeNumbers(int MaxLimit)
        {
            int current = 1;
            PrimeNumberResult result = new PrimeNumberResult();
            var pc = Enumerable.Range(2, MaxLimit).ToList();
            while (current <= Math.Sqrt(MaxLimit))
            {
               // counter++;
                current = pc.First(i => i > current);
                pc.RemoveAll(i => i != current && i % current == 0);
            }

            result.PrimeNumbers = pc;
            result.NumberOfOperations = 0;
            return result; 

        }
    }
}
