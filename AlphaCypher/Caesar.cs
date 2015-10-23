using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlphaCypher
{
    public class Caesar : CypherBase, ICypher
    {
        public string Decode(string text, string cypher)
        {
            string resp = "";
            resp = base.Decode(text, cypher);
            return resp;
        }

        public string Encode(string text, string cypher)
        {
            string resp = "";
            resp = base.Encode(text, cypher);
            return resp;
        }

        public Task<string> DecodeAsync(string text, string cypher)
        {
            throw new NotImplementedException();
        }

        public Task<string> EncodeAsync(string text, string cypher)
        {
            throw new NotImplementedException();
        }
    }
}
