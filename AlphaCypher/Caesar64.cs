using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WallF.BaseNEncodings;

namespace AlphaCypher
{
    public class Caesar64 : Vigenere64
    {
        public string Encode(string text, int cypher)
        {
            string resp = "";
            resp = base.Encode(text, _alphabetList[cypher].ToString());
            return resp;
        }
        
        public string Decode(string text, int cypher)
        {
            string resp = "";
            resp = base.Decode(text, _alphabetList[cypher].ToString());
            return resp;
        }
    }
}
