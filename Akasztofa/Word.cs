using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Akasztofa
{
    internal class Word
    {
        public string wordtoguess;
        public string Masked { get; private set; }
        public Word(string w)
        {
            wordtoguess = w;
            Masked = new string('-', wordtoguess.Length);
        }
        public bool Guess(char e)
        {
            if(wordtoguess.ToUpper().Contains(char.ToUpper(e)))
            {
                char[] temp = Masked.ToCharArray();
                for (int i = 0; i < wordtoguess.Length; i++)
                {
                    if (wordtoguess.ToUpper()[i] == char.ToUpper(e))
                    {
                        temp[i] = wordtoguess[i];
                    }
                }
                Masked = new string(temp);
                return true;
            }
            return false;
        }
    }
}
