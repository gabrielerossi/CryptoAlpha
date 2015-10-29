using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AlphaCypher;
using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;

namespace AlphaCyperTest
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
        public void TestCaesar32EncodeNumber()
        {
            string text = "ABBA";
            int cypher = 3;
            string ris = "IRCUKRA=";
            Caesar32 crypt = new Caesar32();
            string encoder = crypt.Encode(text, cypher);
            Assert.AreEqual(encoder, ris);
        }

        [TestMethod]
        public void TestCaesar32DecodeNumber()
        {
            string text = "IRCUKRA=";
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
            string ris = "IRCUKRA=";
            Caesar32 crypt = new Caesar32();
            string encoder = crypt.Encode(text, cypher);
            Assert.AreEqual(encoder, ris);
        }

        [TestMethod]
        public void TestCaesar32DecodeLetter()
        {
            string text = "IRCUKRA=";
            string cypher = "D";
            string ris = "ABBA";
            Caesar32 crypt = new Caesar32();
            string decoder = crypt.Decode(text, cypher);
            Assert.AreEqual(decoder, ris);
        }

        [TestMethod]
        public void TestCaesar64EncodeNumber()
        {
            string text = "ABBA";
            int cypher = 3;
            string ris = "REVFRA==";
            Caesar64 crypt = new Caesar64();
            string encoder = crypt.Encode(text, cypher);
            Assert.AreEqual(encoder, ris);
        }

        [TestMethod]
        public void TestCaesar64DecodeNumber()
        {
            string text = "REVFRA==";
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
            string ris = "REVFRA==";
            Caesar64 crypt = new Caesar64();
            string encoder = crypt.Encode(text, cypher);
            Assert.AreEqual(encoder, ris);
        }

        [TestMethod]
        public void TestCaesar64DecodeLetter()
        {
            string text = "REVFRA==";
            string cypher = "D";
            string ris = "ABBA";
            Caesar64 crypt = new Caesar64();
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

        [TestMethod]
        public void TestVigenere32Encode()
        {
            string text = "AZZO";
            string cypher = "DFS";
            string ris = "IRCVEUQ=";
            Vigenere32 crypt = new Vigenere32();
            string encoder = crypt.Encode(text, cypher);
            Assert.AreEqual(encoder, ris);
        }

        [TestMethod]
        public void TestVigenere32Decode()
        {
            string text = "IRCVEUQ=";
            string cypher = "DFS";
            string ris = "AZZO";
            Vigenere32 crypt = new Vigenere32();
            string decoder = crypt.Decode(text, cypher);
            Assert.AreEqual(decoder, ris);
        }

        [TestMethod]
        public void TestVigenere64Encode()
        {
            string text = "AZZO";
            string cypher = "DFS";
            string ris = "REVSUg==";
            Vigenere64 crypt = new Vigenere64();
            string encoder = crypt.Encode(text, cypher);
            Assert.AreEqual(encoder, ris);
        }

        [TestMethod]
        public void TestVigenere64Decode()
        {
            string text = "REVSUg==";
            string cypher = "DFS";
            string ris = "AZZO";
            Vigenere64 crypt = new Vigenere64();
            string decoder = crypt.Decode(text, cypher);
            Assert.AreEqual(decoder, ris);
        }
    }
}
