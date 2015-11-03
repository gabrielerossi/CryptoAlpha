using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AlphaCypher;
using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;

namespace AlphaCyperTest
{   
    [TestClass]
    public class CaesarTests
    {
        [TestMethod]
        public void TestCaesarEncryptNumber()
        {
            string text = "ABBA";
            int cypher = 3;
            string ris = "DEED";
            Caesar crypt = new Caesar();
            string encoder = crypt.Encode(text, cypher);
            Assert.AreEqual(encoder, ris);
        }

        [TestMethod]
        public void TestCaesarEncryptLetter()
        {
            string text = "ABBA";
            string cypher = "D";
            string ris = "DEED";
            Caesar crypt = new Caesar();
            string encoder = crypt.Encode(text, cypher);
            Assert.AreEqual(encoder, ris);
        }

        [TestMethod]
        public void TestCaesarDecryptNumber()
        {
            string text = "EDDS";
            int cypher = 4;
            string ris = "AZZO";
            Caesar crypt = new Caesar();
            string decoder = crypt.Decode(text, cypher);
            Assert.AreEqual(decoder, ris);
        }

        [TestMethod]
        public void TestCaesarDecryptLetter()
        {
            string text = "EDDS";
            string cypher = "E";
            string ris = "AZZO";
            Caesar crypt = new Caesar();
            string decoder = crypt.Decode(text, cypher);
            Assert.AreEqual(decoder, ris);
        }
    }
}
