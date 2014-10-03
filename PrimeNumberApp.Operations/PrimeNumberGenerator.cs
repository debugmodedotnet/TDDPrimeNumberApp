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
        PrimeNumberResult IPrimeNumberGenerator.GetNumbers(int count)
        {
            int i, j;
             result = new PrimeNumberResult{Result = new List<int>(), NumberOfOperations=0};
            // List<int> lstPrimeNumbers = new List<int>();
            //lstPrimeNumbers.Add(1);
          //  result.Result.Add(1);
            result.Result.Add(2);

            for (i = 3; i <= count; i++)
            {
               

                //if (i % 2 == 0) 
                //{
                //    continue; 
                //}
                //  else if (i % 3 ==0)
                //{
                //      continue; 
                // }
                //  else if (i % 5 ==0)
                //{
                //      continue; 
                // }
                //  else if (i % 7 ==0)
                //{
                //      continue; 
                // }
               
                //else
                //{
                    if(isPrime(i))
                    {
                        result.Result.Add(i);

                    }
               //}
            }
                
            

                return result;

            }




        bool isPrime(int number)
        {

            if (number == 1) return false;
            if (number == 2) return true;

            for (int i = 2; i <= Math.Ceiling(Math.Sqrt(number)); ++i)
            {
                result.NumberOfOperations = result.NumberOfOperations + 1; 
                if (number % i == 0) return false;
            }

            return true;
        }

}
}

