using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using AspdotnetCommonPackages.Test.Helpers;

namespace AspdotnetCommonPackages.Test
{
    [TestClass]
    public class UnitTestDateTimeExtensions
    {
        [TestMethod]
        //[ExpectedException(typeof(NotImplementedException), "NotImplementedException")]
        public void IsValidDateTimeString_Success()
        {
            string inputDatetimeString = Const.DateTimeCorrectFormat;

            DateTime result = inputDatetimeString.FromString();

            Assert.IsTrue(result.IsNotNull() && result != DateTime.MinValue);
        }

        [TestMethod]
        //[ExpectedException(typeof(NotImplementedException), "NotImplementedException")]
        public void IsValidDateTimeString_Fail_Input_String_InCorrect()
        {
            string inputDatetimeString = Const.DateTimeWrongFormat;

            DateTime result = inputDatetimeString.FromString();

            Assert.IsTrue(result.IsNotNull() && result != DateTime.MinValue);
        }
    }
}
