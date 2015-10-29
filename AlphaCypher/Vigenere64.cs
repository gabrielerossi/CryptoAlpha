using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WallF.BaseNEncodings;

namespace AlphaCypher
{
    public class Vigenere64 : Vigenere
    {
        public override string Encode(string text, string cypher)
        {
            string resp = "";
            string tmp = base.Encode(text, cypher);
            char[] charEncoded = BaseEncoding.Base64.Encode(Encoding.UTF8.GetBytes(tmp));
            resp = new string(charEncoded);
            return resp;
        }

        public override string Decode(string text, string cypher)
        {
            string resp = "";
            byte[] byteDecoded = BaseEncoding.Base64.Decode(text.ToCharArray());
            resp = base.Decode(Encoding.UTF8.GetString(byteDecoded, 0, byteDecoded.Length), cypher);
            return resp;
        }
    }
}
