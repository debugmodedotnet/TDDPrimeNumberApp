using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrimeNumberApp.Core;
using PrimeNumberApp.Operations;

namespace PrimeNumberApp.Tests
{
    [TestClass]
    public class PrimeNumberGeneratorClassShould
    { 
        private PrimeNumberGenerator _primeNumberGenerator = null;
        private readonly int _expectedResultCount = 25;
        private readonly int _maxRangeToFindPrimeNumbers = 100;
        private readonly int _expectedNumberOfOperationsCount = 98;
        private readonly int _numberToVerify = 61; 

       [TestInitialize]
        public void TestSetup()
        {
            _primeNumberGenerator = new PrimeNumberGenerator();
           
            
        }
        [TestMethod]
        public void  ReturnExpectedResultCount()
        {
            var result = _primeNumberGenerator.GetNumbers(_maxRangeToFindPrimeNumbers);
            Assert.IsNotNull(result);
            Assert.AreEqual(_expectedResultCount, result.PrimeNumbers.Count);

        }

        [TestMethod]
        public void ReturnExpectedOperationsCount()
        {
            var result = _primeNumberGenerator.GetNumbers(_maxRangeToFindPrimeNumbers);
            Assert.IsNotNull(result);
            Assert.AreEqual(_expectedNumberOfOperationsCount, result.NumberOfOperations);
        }

        [TestMethod]
        public void ResturnNumberIsPrimeOrNot()
        {
            var result = _primeNumberGenerator.IsPrime(_numberToVerify);
            Assert.AreEqual(true, result);
        }

    }
}
