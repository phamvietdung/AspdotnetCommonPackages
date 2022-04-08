using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using AspdotnetCommonPackages.Test.Helpers;
using System.Globalization;

namespace AspdotnetCommonPackages.Test
{
    [TestClass]
    public class UnitTestDateTimeExtensions
    {
        [TestMethod]
        //[ExpectedException(typeof(NotImplementedException), "NotImplementedException")]
        public void IsValidDateTimeString_Success()
        {
            string inputDatetimeString = "1/1/2012";
                //Const.DateTimeCorrectFormat;

            var parseable = inputDatetimeString.GetParseableToDateTimeFormat();



            Assert.IsTrue(parseable.IsNotNulAndNotDefault());



            //Assert.IsTrue(isValid);

            //DateTime result = inputDatetimeString.FromString();

            //Assert.IsTrue(result.IsNotNull() && result != DateTime.MinValue);
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
