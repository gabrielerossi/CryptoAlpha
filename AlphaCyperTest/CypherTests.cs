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
            string testo = "ABBA";
            int codice = 3;
            string ris = "DEED";
            Caesar crypt = new Caesar();
            string codifica = crypt.Encode(testo, codice);
            Assert.AreEqual(codifica,ris);
        }

        [TestMethod]
        public void TestCaesarEncryptLetter()
        {
            string testo = "ABBA";
            string codice = "D";
            string ris = "DEED";
            Caesar crypt = new Caesar();
            string codifica = crypt.Encode(testo, codice);
            Assert.AreEqual(codifica, ris);
        }

        [TestMethod]
        public void TestCaesarDecryptNumber()
        {
            string testo = "EDDS";
            int codice = 4;
            string ris = "AZZO";
            Caesar crypt = new Caesar();
            string decodifica = crypt.Decode(testo, codice);
            Assert.AreEqual(decodifica, ris);
        }

        [TestMethod]
        public void TestCaesarDecryptLetter()
        {
            string testo = "EDDS";
            string codice = "E";
            string ris = "AZZO";
            Caesar crypt = new Caesar();
            string decodifica = crypt.Decode(testo, codice);
            Assert.AreEqual(decodifica, ris);
        }
    }
}
