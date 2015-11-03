using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AlphaCypher;
using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;

namespace AlphaCyperTest
{
    [TestClass]
    public class VigenereTests
    {
        [TestMethod]
        public void TestVigenereEncrypt()
        {
            string text = "AZZO";
            string cypher = "DFS";
            string ris = "DERR";
            Vigenere crypt = new Vigenere();
            string encoder = crypt.Encode(text, cypher);
            Assert.AreEqual(encoder, ris);
        }

        [TestMethod]
        public void TestVigenereDecrypt()
        {
            string text = "DERR";
            string cypher = "DFS";
            string ris = "AZZO";
            Vigenere crypt = new Vigenere();
            string decoder = crypt.Decode(text, cypher);
            Assert.AreEqual(decoder, ris);
        }
    }
}
