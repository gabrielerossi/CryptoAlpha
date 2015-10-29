using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlphaCypher
{
    public class Caesar : CypherBase
    {
        public override string Decode(string text, string cypher)
        {
            string resp = "";
            char[] s = text.ToCharArray();
            for (int i = 0; i < s.Length; i++)
            {
                resp += Decode(s[i], cypher[0]);
            }
            return resp;
        }

        public virtual string Decode(string text, int cypher)
        {
            string resp = "";
            resp = Decode(text, Convert.ToString(_alphabetList[cypher % 26]));
            return resp;
        }

        public override string Encode(string text, string cypher)
        {
            string resp = "";
            char[] s = text.ToCharArray();
            for (int i = 0; i < s.Length; i++)
            {
                resp += Encode(s[i], cypher[0]);
            }
            return resp;
        }

        public virtual string Encode(string text, int cypher)
        {
            string resp = "";
            resp = Encode(text, Convert.ToString(_alphabetList[cypher % 26]));            
            return resp;
        }

        public override Task<string> EncodeAsync(string text, string cypher)
        {
            return Task.Factory.StartNew(() => Encode(text, cypher));
        }

        public Task<string> EncodeAsync(string text, int cypher)
        {
            return Task.Factory.StartNew(() => Encode(text, cypher));
        }

        public override Task<string> DecodeAsync(string text, string cypher)
        {
            return Task.Factory.StartNew(() => Decode(text, cypher));
        }

        public Task<string> DecodeAsync(string text, int cypher)
        {
            return Task.Factory.StartNew(() => Decode(text, cypher));
        }
    }
}
