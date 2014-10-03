using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrimeNumberApp.Core;
using PrimeNumberApp.Operations;

namespace PrimeNumberApp.Tests
{
    [TestClass]
    public class PrimeNumberGeneratorClassShould
    {
   
        private IPrimeNumberGenerator _primeNumberGenerator = null;
        private readonly int _expectedCount = 9;
        private readonly int _targetNumber = 20;
        private readonly int _numberOfOperations = 30;
        

       [TestInitialize]
        public void TestSetup()
        {
            _primeNumberGenerator = new PrimeNumberGenerator();
           
            
        }
        [TestMethod]
        public void ReturnsExpectedCount()
        {
            var result = _primeNumberGenerator.GetNumbers(_targetNumber);
            Assert.IsNotNull(result);
            Assert.AreEqual(_expectedCount, result.Result.Count);

        }

        [TestMethod]
        public void ReturnsExpectedOperationCount()
        {
            var result = _primeNumberGenerator.GetNumbers(_targetNumber);
            Assert.IsNotNull(result);
            Assert.AreEqual(_numberOfOperations, result.NumberOfOperations);
        }

    }
}
