using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AlphaCypher;

namespace CyperTest
{
    [TestClass]
    public class Cyphertests
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

        //[TestMethod]
        //public void TestVigenereDecrypt()
        //{
        //    string text = "DERR";
        //    string cypher = "DFS";
        //    string ris = "AZZO";
        //    Vigenere crypt = new Vigenere();
        //    string decoder = crypt.Decode(text, cypher);
        //    Assert.AreEqual(decoder, ris);
        //}
    }
}
