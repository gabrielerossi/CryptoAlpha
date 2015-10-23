using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AlphaCypher
{
    public abstract class CypherBase : ICypher
    {
        protected List<Char> _alphabetList;
        protected int _crowding;

        public CypherBase()
        {
            _alphabetList = new List<char>();
            AlphabetInitializer();
        }

        protected virtual void AlphabetInitializer()
        {
            for (int i = 0; i < 26; i++)
            {
                char tmp = (char)(i + 65);
                _alphabetList.Add(tmp);
            }
        }

        private int ResearchLetterPosition(char tmp)
        {
            int resp = 0;
            for (int i = 0; i < _alphabetList.Count; i++)
            {
                if (tmp == _alphabetList[i])
                {
                    resp = i;
                }
            }
            return resp;
        }

        public Task<string> DecodeAsync(string text, string cypher)
        {
            throw new NotImplementedException();
        }

        #region EncodeMethods

        public virtual string Encode(string text, string cypher)
        {
            string resp = "";
            int crowding = ResearchLetterPosition(cypher.ToUpper()[0]) + 1;
            resp = Decode(text.ToUpper(), crowding);
            return resp;
        }

        public string Encode(string text)
        {
            string resp = "";
            resp = Decode(text, _crowding);
            return resp;
        }

        public string Encode(char text, char cypher)
        {
            string resp = "";
            resp = Decode(text.ToString(), cypher.ToString());
            return resp;
        }

        public virtual string Encode(string text, int crowding)
        {
            string resp = "";
            char[] s = text.ToCharArray();
            for (int i = 0; i < s.Length; i++)
            {
                char tmp = s[i];
                int pos = ResearchLetterPosition(tmp);             //Restituisce la posizione della lettera nell'alfabeto.
                int decodedPos = (pos - crowding + 26) % 26;      //Calcola la posizione della lettera decodificata.
                resp += _alphabetList[decodedPos];
            }
            return resp;
        }

        #endregion

        #region DecodeMethods

        public virtual string Decode(string text, string cypher)
        {
            string resp = "";
            int crowding = ResearchLetterPosition(cypher.ToUpper()[0]);
            resp = Decode(text.ToUpper(), crowding);
            return resp;
        }

        public string Decode(string text)
        {
            string resp = "";
            resp = Decode(text, _crowding);
            return resp;
        }

        public string Decode(char text, char cypher)
        {
            string resp = "";
            resp = Decode(text.ToString(), cypher.ToString());
            return resp;
        }

        public virtual string Decode(string text, int crowding)
        {
            string resp = "";
            char[] s = text.ToCharArray();
            for (int i = 0; i < s.Length; i++)
            {
                char tmp = s[i];
                int pos = ResearchLetterPosition(tmp);             //Restituisce la posizione della lettera nell'alfabeto.
                int encodedPos = (pos + crowding) % 26;      //Calcola la posizione della lettera codificata.
                resp += _alphabetList[encodedPos];
            }
            return resp;
        }
        
        #endregion

        public Task<string> EncodeAsync(string text, string cypher)
        {
            throw new NotImplementedException();
        }
    }
}
