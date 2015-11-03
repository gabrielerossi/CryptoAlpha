using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlphaCypher
{
    public class Caesar : Vigenere
    {
        public string Decode(string text, int cypher)
        {
            string resp = "";
            resp = base.Decode(text, Convert.ToString(_alphabetList[cypher % Letters.Length]));
            return resp;
        }

        public string Encode(string text, int cypher)
        {
            string resp = "";
            resp = Encode(text, Convert.ToString(_alphabetList[cypher % Letters.Length]));            
            return resp;
        }
    }
}
