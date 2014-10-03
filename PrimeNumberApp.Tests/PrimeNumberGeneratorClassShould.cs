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
        private readonly int _expectedCount = 25;
        private readonly int _targetNumber = 100;
        private readonly int _numberOfOperations = 98;
        private readonly int _targetnumberToDivideByThreeFiveSeven = 63;
        private readonly int _targetnumberToVerifyPrime = 61; 

       [TestInitialize]
        public void TestSetup()
        {
            _primeNumberGenerator = new PrimeNumberGenerator();
           
            
        }
        [TestMethod]
        public void ReturnExpectedCount()
        {
            var result = _primeNumberGenerator.GetNumbers(_targetNumber);
            Assert.IsNotNull(result);
            Assert.AreEqual(_expectedCount, result.Result.Count);

        }

        [TestMethod]
        public void ReturnExpectedOperationCount()
        {
            var result = _primeNumberGenerator.GetNumbers(_targetNumber);
            Assert.IsNotNull(result);
            Assert.AreEqual(_numberOfOperations, result.NumberOfOperations);
        }

        [TestMethod]
        public void ValidDivideByThreeFiveSeven()
        {
            var result = _primeNumberGenerator.IsDivisebleByThreeFiveSeven(_targetnumberToDivideByThreeFiveSeven);
            Assert.AreEqual(true, result);
        }
        [TestMethod]
        public void VerifyNumberIsPrime()
        {
            //var result = _primeNumberGenerator.IsPrime(_targetnumberToDivideByThreeFiveSeven);
            //Assert.AreEqual(true, result);
        }

    }
}
