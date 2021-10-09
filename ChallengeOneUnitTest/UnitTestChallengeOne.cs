using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ChallengeOneRepo;
namespace ChallengeOneConsoleApp
{
    [TestClass]
    public class UnitTestChallengeOne

    {
        [TestMethod]
        public void AddClaim_IsFalse()
        {
            MenuItems item = null;
            MenuMethods menu = new MenuMethods();
            bool result = menu.AddMenu(item);
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void AddClaim_IsTrue()
        {
            MenuItems item = new MenuItems(2, "spicy chicken", 5.99, "chicken", "Deep fried");
            MenuMethods menu = new MenuMethods();
            bool result = menu.AddMenu(item);
            Assert.IsTrue(result);
        }
    }
}
