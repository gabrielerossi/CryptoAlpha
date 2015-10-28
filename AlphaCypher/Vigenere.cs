using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlphaCypher
{
    public class Vigenere : CypherBase
    {
        public new string Encode(string text, string cypher)
        {
            string resp = "";
            for (int i = 0; i < text.Length; i++)
                resp += Encode(text[i], cypher[i % cypher.Length]);
            return resp;
        }

        public new string Decode(string text, string cypher)
        {
            string resp = "";
            for (int i = 0; i < text.Length; i++)
                resp += Decode(text[i], cypher[i % cypher.Length]);
            return resp;
        }
    }
}
