using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fhh
{
    internal class Word
    {
        public string wordtoguess;
        public string masked { get; private set; }
        public Word(string szo)
        {
            wordtoguess = szo;
            masked=new string('-',wordtoguess.Length);
        }
        public bool Tipp(char e)
        {
            if (wordtoguess.ToUpper().Contains(char.ToUpper(e)))
            {
                char[] temp=masked.ToCharArray();
                for (int i = 0; i < wordtoguess.Length; i++)
                {
                    if (wordtoguess.ToUpper()[i] == char.ToUpper(e))
                    {
                        temp[i] = wordtoguess[i];
                    }
                }
                masked = new string(temp);
                return true;
            }
            return false;
        }
    }
}
