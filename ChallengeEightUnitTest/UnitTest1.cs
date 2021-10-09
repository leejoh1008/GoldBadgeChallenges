using ChallengeEightRepo;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ChallengeEightUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AddInsurance_IsFalse()
        {
            Insurance no = null;
            InsuranceMethods _method = new InsuranceMethods();
            bool result = _method.AddInsurance(no);
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void AddInsurance_IsTrue()
        {
            Insurance amy = new Insurance("Amy Blanc", 12, 10, 3, 1);
            InsuranceMethods _method = new InsuranceMethods();
            bool result=_method.AddInsurance(amy);
            Assert.IsTrue(result);
        }
    }
}
