using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrimeNumberApp.Core;
using PrimeNumberApp.Operations;

namespace PrimeNumberApp.Tests
{
    [TestClass]
    public class SieveOfEratosthenesClassShould
    {
        private ITestPrime _testPrime;
        private int _maxLimitToFindPrimeNumbers = 100;
        private int _expectedCountOfPrimeNumbers = 26;
        private PrimeNumberResult _returnedPrimeNumbers;

        [TestInitialize]
        public void TestSetup()
        {
            _testPrime = new SieveOfEratosthenes ();
        }

        [TestMethod]
        public void ReturnValidCountOfPrimeNumbers()
        {
            _returnedPrimeNumbers = _testPrime.FindPrimeNumbers(_maxLimitToFindPrimeNumbers);
            Assert.IsNotNull(_returnedPrimeNumbers);
            Assert.AreEqual(_expectedCountOfPrimeNumbers, _returnedPrimeNumbers.PrimeNumbers.Count);

        }
    }
}
