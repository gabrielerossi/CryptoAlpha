using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AlphaCypher;
using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;

namespace AlphaCyperTest
{
    [TestClass]
    public class Vigenere64Tests
    {
        [TestMethod]
        public void TestVigenere64Encode()
        {
            string text = "ABBA";
            string cypher = "DFS";
            string ris = "hYiVhUYS";
            Vigenere64 crypt = new Vigenere64();
            string encoder = crypt.Encode(text, cypher);
            Assert.AreEqual(encoder, ris);
        }

        [TestMethod]
        public void TestVigenere64Decode()
        {
            string text = "hYiVhUYS";
            string cypher = "DFS";
            string ris = "ABBA";
            Vigenere64 crypt = new Vigenere64();
            string decoder = crypt.Decode(text, cypher);
            Assert.AreEqual(decoder, ris);
        }
    }
}
