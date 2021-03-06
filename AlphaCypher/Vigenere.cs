﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlphaCypher
{
    public class Vigenere : CypherBase
    {
        protected override string Letters
        {
            get
            {
                return "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            }
        }

        public override string Encode(string text, string cypher)
        {
            string resp = "";
            for (int i = 0; i < text.Length; i++)
                resp += base.Encode(text[i], cypher[i % cypher.Length]);
            return resp;
        }

        public override string Decode(string text, string cypher)
        {
            string resp = "";
            for (int i = 0; i < text.Length; i++)
                resp += base.Decode(text[i], cypher[i % cypher.Length]);
            return resp;
        }

        public override Task<string> EncodeAsync(string text, string cypher)
        {
            return Task.Factory.StartNew(() => Encode(text, cypher));
        }

        public override Task<string> DecodeAsync(string text, string cypher)
        {
            return Task.Factory.StartNew(() => Decode(text, cypher));
        }
    }
}
