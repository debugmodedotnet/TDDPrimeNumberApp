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


        PrimeNumberResult IPrimeNumberGenerator.GetNumbers(int count)
        {
            int i, j;
            PrimeNumberResult result = new PrimeNumberResult{Result = new List<int>(), NumberOfOperations=0};
            // List<int> lstPrimeNumbers = new List<int>();
            //lstPrimeNumbers.Add(1);
          //  result.Result.Add(1);
            result.Result.Add(2);

            for (i = 3; i <= count; i++)
            {
                result.NumberOfOperations = result.NumberOfOperations + 1;

                if (i % 2 != 0)
                 {
                //    for (j = 2; j <= Math.Ceiling( Math.Sqrt(i)); j++)
                //    {
                //        result.NumberOfOperations = result.NumberOfOperations + 1;
                //        if (i % j == 0)
                //        {
                //            // result.NumberOfOperations = result.NumberOfOperations + 1;
                //            break;
                //        }

                //    }

                //    if (j == i)
                //    {
                //        // result.NumberOfOperations = result.NumberOfOperations + 1;
                //        result.Result.Add(i);
                //    }
                //}

                if(isPrime(i))
                {
                    result.Result.Add(i);

                }
            }
                
            }

                return result;

            }




        bool isPrime(int number)
        {

            if (number == 1) return false;
            if (number == 2) return true;

            for (int i = 2; i <= Math.Ceiling(Math.Sqrt(number)); ++i)
            {
                if (number % i == 0) return false;
            }

            return true;
        }

}
}

