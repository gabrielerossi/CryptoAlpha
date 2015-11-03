using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AlphaCypher;
using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;

namespace AlphaCyperTest
{
    [TestClass]
    public class Caesar32Tests
    {
        [TestMethod]
        public void TestCaesar32EncodeNumber()
        {
            string text = "ABBA";
            int cypher = 3;
            string ris = "QVADDPH7";
            Caesar32 crypt = new Caesar32();
            string encoder = crypt.Encode(text, cypher);
            Assert.AreEqual(encoder, ris);
        }

        [TestMethod]
        public void TestCaesar32DecodeNumber()
        {
            string text = "QVADDPH7";
            int cypher = 3;
            string ris = "ABBA";
            Caesar32 crypt = new Caesar32();
            string decoder = crypt.Decode(text, cypher);
            Assert.AreEqual(decoder, ris);
        }

        [TestMethod]
        public void TestCaesar32EncodeLetter()
        {
            string text = "ABBA";
            string cypher = "D";
            string ris = "QVADDPH7";
            Caesar32 crypt = new Caesar32();
            string encoder = crypt.Encode(text, cypher);
            Assert.AreEqual(encoder, ris);
        }

        [TestMethod]
        public void TestCaesar32DecodeLetter()
        {
            string text = "QVADDPH7";
            string cypher = "D";
            string ris = "ABBA";
            Caesar32 crypt = new Caesar32();
            string decoder = crypt.Decode(text, cypher);
            Assert.AreEqual(decoder, ris);
        }
    }
}
