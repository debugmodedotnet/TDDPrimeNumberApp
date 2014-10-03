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
        public PrimeNumberResult GetNumbers(int count)
        {
            int i;
            result = new PrimeNumberResult { Result = new List<int>(), NumberOfOperations = 0 };
            result.Result.Add(2);

            for (i = 3; i <= count; i++)
            {
                if (i % 2 != 0)
                {
                    if (!IsDivisebleByThreeFiveSeven(i))
                    {

                        if (IsPrime(i))
                        {
                            result.Result.Add(i);

                        }
                    }

                }

            }
            return result;

        }

        public bool IsPrime(int number)
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

        public bool IsDivisebleByThreeFiveSeven(int number)
        {
            bool flag = false;
            for (int i = 3; i <= 7; i += 2)
            {
                if (number % i == 0)
                {
                    flag = true;
                }
            }

            return flag;
        }

    }
}

