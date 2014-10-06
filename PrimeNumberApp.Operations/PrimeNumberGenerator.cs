using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrimeNumberApp.Core;

namespace PrimeNumberApp.Operations
{
    public class PrimeNumberGenerator
    {
        ITestPrime _testAlgorithm;
        public PrimeNumberGenerator(ITestPrime testAlgorithm)
        {

            _testAlgorithm = testAlgorithm;
        }
        public PrimeNumberResult GetNumbers(int count)
        {

            PrimeNumberResult result = _testAlgorithm.FindPrimeNumbers(count);
            return result;

        }

    }
}

