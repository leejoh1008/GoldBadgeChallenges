using ChallengeTwoRepo;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ChallengeTwoUnitTest
{
    [TestClass]
    public class UnitTestChallengeTwo
    {
        [TestMethod]
        public void CreateClaim_False()
        {
            //arange - creating variables we need to test this method
            Claim claim = null;
            ClaimMethods _methods = new ClaimMethods();

            //act - calling the method
            bool result = _methods.AddClaim(claim);
            //Assert - making sure the method did what it was suppose to do 
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void CreateClaim_True()
        {
            DateTime date = DateTime.Today;
            Claim claim = new Claim(4, "Hannah Hope", "home", "broken door", 300.00, date, date);
            ClaimMethods _methods = new ClaimMethods();
            bool result =_methods.AddClaim(claim);
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void DeleteClaim_False()
        {
            Claim claim = null;
            ClaimMethods _methods = new ClaimMethods();
            bool result = _methods.DeleteClaim(claim);
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void DeleteClaim_True()
        {
            DateTime date = DateTime.Today;
            Claim claim = new Claim(4, "Hannah Hope", "home", "broken door", 300.00, date, date);
            ClaimMethods _methods = new ClaimMethods();
            _methods.AddClaim(claim);
            bool result = _methods.DeleteClaim(claim);
            Assert.IsTrue(result);
        }
    }
}
