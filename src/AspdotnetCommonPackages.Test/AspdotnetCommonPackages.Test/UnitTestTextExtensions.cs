using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using AspdotnetCommonPackages.Test.Helpers;
using System.Linq;

namespace AspdotnetCommonPackages.Test
{
    [TestClass]
    public class UnitTestTextExtensions
    {

        [TestMethod]
        public void ReplaceASII_Test()
        {
            string input = Const.UnicodeString;

            Assert.AreEqual(input.ReplaceUnicodeCharacterByTheASIICharacter(), Const.AsiiString.ToLower());

            Assert.AreEqual(input.ReplaceUnicodeCharacterByTheASIICharacter(false), Const.AsiiString.ToUpper());

            Assert.AreEqual(input.ToAlias(), Const.AsiiAliasString.ToLower());

            Assert.AreEqual(input.ToAlias(false), Const.AsiiAliasString.ToUpper());
        }

        [TestMethod]
        public void Masking_Test()
        {
            string input = "ndklfnbkldfnbldknfbldkfnbldkfnbldkfnbldknfblkdnfblkdnflbknowieioncwiencopwienvskldnlvkndflkbnoeinbd8";

            string maskingCharacter = "*";

            int hiddenRatio = 98;

            string masking = input.Masking(maskingCharacter, hiddenRatio);

            Assert.IsTrue(masking.ToCharArray().Select(s => s.ToString()).Count(c => c == maskingCharacter) >= hiddenRatio);
        }

    }
}
