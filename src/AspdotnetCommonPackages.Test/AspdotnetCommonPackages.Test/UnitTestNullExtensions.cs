using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using AspdotnetCommonPackages.Test.Helpers;

namespace AspdotnetCommonPackages.Test
{
    [TestClass]
    public class UnitTestNullExtensions
    {

        [TestMethod]
        public void IsNull_Success()
        {
            string input = Const.NullString;

            Assert.IsTrue(input.IsNull());
        }

        [TestMethod]
        public void IsNull_Fail()
        {
            string input = Const.NotNullString;

            Assert.IsFalse(input.IsNull());
        }

        [TestMethod]
        public void IsNotNull_Success()
        {
            string input = Const.NotNullString;

            Assert.IsTrue(input.IsNotNull());
        }

        [TestMethod]
        public void IsNotNull_Fail()
        {
            string input = Const.NullString;

            Assert.IsFalse(input.IsNotNull());
        }


    }
}
