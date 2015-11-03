using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AlphaCypher;
using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;

namespace AlphaCyperTest
{
    [TestClass]
    public class Caesar64Tests
    {
        [TestMethod]
        public void TestCaesar64EncodeNumber()
        {
            string text = "ABBA";
            int cypher = 3;
            string ris = "hUIBhQ//";
            Caesar64 crypt = new Caesar64();
            string encoder = crypt.Encode(text, cypher);
            Assert.AreEqual(encoder, ris);
        }

        [TestMethod]
        public void TestCaesar64DecodeNumber()
        {
            string text = "hUIBhQ//";
            int cypher = 3;
            string ris = "ABBA";
            Caesar64 crypt = new Caesar64();
            string decoder = crypt.Decode(text, cypher);
            Assert.AreEqual(decoder, ris);
        }

        [TestMethod]
        public void TestCaesar64EncodeLetter()
        {
            string text = "ABBA";
            string cypher = "D";
            string ris = "hUIBhQ//";
            Caesar64 crypt = new Caesar64();
            string encoder = crypt.Encode(text, cypher);
            Assert.AreEqual(encoder, ris);
        }

        [TestMethod]
        public void TestCaesar64DecodeLetter()
        {
            string text = "hUIBhQ//";
            string cypher = "D";
            string ris = "ABBA";
            Caesar64 crypt = new Caesar64();
            string decoder = crypt.Decode(text, cypher);
            Assert.AreEqual(decoder, ris);
        }
    }
}
