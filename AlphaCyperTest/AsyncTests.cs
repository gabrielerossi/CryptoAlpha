using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AlphaCypher;
using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;
using System.Threading.Tasks;

namespace AlphaCyperTest
{   
    [TestClass]
    public class AsyncTests
    {
        [TestMethod]
        public async Task TestEncodeAsync()
        {
            string text = "AZZO";
            string cypher = "DFS";
            string ris = "DERR";
            Vigenere crypt = new Vigenere();
            string encoder = await crypt.EncodeAsync(text, cypher);
            Assert.AreEqual(encoder, ris);
        }

        [TestMethod]
        public async Task TestDecodeAsync()
        {
            string text = "DERR";
            string cypher = "DFS";
            string ris = "AZZO";
            Vigenere crypt = new Vigenere();
            string decoder = await crypt.DecodeAsync(text, cypher);
            Assert.AreEqual(decoder, ris);
        }
    }
}
