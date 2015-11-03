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
        protected virtual string Letters
        {
            get
            {
                return "";
            }
        }

        public CypherBase()
        {
            _alphabetList = new List<char>();
            AlphabetInitializer();
        }

        protected virtual void AlphabetInitializer()
        {
            for (int i = 0; i < Letters.Length; i++)
            {
                _alphabetList.Add(Letters[i]);
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

        #region EncodeMethods

        public abstract string Encode(string text, string cypher);

        public string Encode(char text, char cypher)
        {
            string resp = "";

            int crowding = ResearchLetterPosition(cypher);
            int pos = ResearchLetterPosition(text);
            int encodedPos = (pos + crowding) % _alphabetList.Count;
            resp += _alphabetList[encodedPos];

            return resp;
        }

        #endregion

        #region DecodeMethods

        public abstract string Decode(string text, string cypher);
        
        public virtual string Decode(char text, char cypher)
        {
            string resp = "";

            int crowding = ResearchLetterPosition(cypher);
            int pos = ResearchLetterPosition(text);
            int decodedPos = (pos - crowding + _alphabetList.Count) % _alphabetList.Count;
            resp += _alphabetList[decodedPos];

            return resp;
        }

        #endregion

        #region Encode/Decode Async

        public abstract Task<string> EncodeAsync(string text, string cypher);

        public abstract Task<string> DecodeAsync(string text, string cypher);

        #endregion
    }
}
