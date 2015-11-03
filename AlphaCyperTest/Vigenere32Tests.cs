using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AlphaCypher;
using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;

namespace AlphaCyperTest
{
    [TestClass]
    public class Vigenere32Tests
    {
        [TestMethod]
        public void TestVigenere32Encode()
        {
            string text = "ABBA";
            string cypher = "DFS";
            string ris = "QWEJKPH7";
            Vigenere32 crypt = new Vigenere32();
            string encoder = crypt.Encode(text, cypher);
            Assert.AreEqual(encoder, ris);
        }

        [TestMethod]
        public void TestVigenere32Decode()
        {
            string text = "QWEJKPH7";
            string cypher = "DFS";
            string ris = "ABBA";
            Vigenere32 crypt = new Vigenere32();
            string decoder = crypt.Decode(text, cypher);
            Assert.AreEqual(decoder, ris);
        }
    }
}
