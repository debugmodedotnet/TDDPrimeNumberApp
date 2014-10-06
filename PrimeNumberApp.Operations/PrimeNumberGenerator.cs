using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrimeNumberApp.Core;

namespace PrimeNumberApp.Operations
{
    public class PrimeNumberGenerator : IPrimeNumberGenerator
    {

        PrimeNumberResult result;
        int noOfOperations = 0; 
        public PrimeNumberResult GetNumbers(int count)
        {
            int i;
            result = new PrimeNumberResult { PrimeNumbers = new List<int>(), NumberOfOperations = 0 };
            result.PrimeNumbers.Add(2);

            for (i = 2; i <= count; i++)
            {
                if (!IsDivisebleByFoundPrimeFactor(result.PrimeNumbers, i))
                {
                    if (IsPrime(i))
                    {
                        result.PrimeNumbers.Add(i);
                    }
                }
            }
            result.NumberOfOperations += noOfOperations;
            return result;

        }

        public bool IsPrime(int number)
        {

            if (number == 1) return false;
          

            for (int i = 2; i <= Math.Ceiling(Math.Sqrt(number)); ++i)
            {
                noOfOperations = noOfOperations + 1;                
                if (number % i == 0) return false;
            }

            return true;
        }

        public bool IsDivisebleByFoundPrimeFactor(IEnumerable<int> primes, int number)
        {
            foreach (var prime in primes) // count this loop per iteration
            {
                if (number % prime == 0)
                {
                    // todo: increment operation count
                    noOfOperations = noOfOperations + 1; 
                    return true;
                }
            }
            return false;
        }

    }
}

