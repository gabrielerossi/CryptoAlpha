using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WallF.BaseNEncodings;

namespace AlphaCypher
{
    public class Caesar32 : Caesar
    {
        public override string Encode(string text, string cypher)
        {
            string resp = "";
            string tmp = base.Encode(text, cypher);
            char[] charEncoded = BaseEncoding.Base32.Encode(Encoding.UTF8.GetBytes(tmp));
            resp = new string(charEncoded);
            return resp;
        }

        public override string Decode(string text, string cypher)
        {
            string resp = "";
            byte[] byteDecoded = BaseEncoding.Base32.Decode(text.ToCharArray());
            //string ciao = byteDecoded.ToString();
            resp = base.Decode(Encoding.UTF8.GetString(byteDecoded, 0, byteDecoded.Length), cypher);
            return resp;
        }
    }
}
