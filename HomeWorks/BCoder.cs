using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorks
{
    internal class BCoder : ICoder
    {
        private char[] _inCharArray;
        private Dictionary<char, char> _dictCod;

        public BCoder(string inString)
        {
            _inCharArray = inString.ToCharArray();
            _dictCod = GetEncodeDictionary();
        }

        public string Encode()
        {
            for (int i = 0; i < _inCharArray.Length; i++)
            {
                if (_dictCod.ContainsKey(_inCharArray[i]))
                    _inCharArray[i] = _dictCod[_inCharArray[i]];
                else
                    _inCharArray[i] = _inCharArray[i];
            }
            return string.Concat(_inCharArray);
        }

        public string Decode() { return Encode(); }

        private Dictionary<char, char> GetEncodeDictionary()
        {
            //
            Dictionary<char, char> outDict = new Dictionary<char, char>();
            
            //заполнение словаря буквами русского алфавита
            List<char> listRussianAlphabet = GetListRussianAlphabet();
            int n = listRussianAlphabet.Count - 1;
            for (int i = 0; i < (n / 2) + 1; i++) outDict.Add(listRussianAlphabet[i], listRussianAlphabet[n - i]);
            for (int i = 0; i < (n / 2); i++) outDict.Add(listRussianAlphabet[n - i], listRussianAlphabet[i]);
            for (int i = 0; i < (n / 2) + 1; i++) outDict.Add(Char.ToLower(listRussianAlphabet[i]), Char.ToLower(listRussianAlphabet[n - i]));
            for (int i = 0; i < (n / 2); i++) outDict.Add(Char.ToLower(listRussianAlphabet[n - i]), Char.ToLower(listRussianAlphabet[i]));

            //заполнение словаря буквами английского алфавита
            List<char> listEnglishAlphabet = GetListEnglishAlphabet();
            n = listEnglishAlphabet.Count - 1;
            for (int i = 0; i < (n / 2); i++) outDict.Add(listEnglishAlphabet[i], listEnglishAlphabet[n - i]);
            for (int i = 0; i < (n / 2); i++) outDict.Add(listEnglishAlphabet[n - i], listEnglishAlphabet[i]);
            for (int i = 0; i < (n / 2); i++) outDict.Add(Char.ToLower(listEnglishAlphabet[i]), Char.ToLower(listEnglishAlphabet[n - i]));
            for (int i = 0; i < (n / 2); i++) outDict.Add(Char.ToLower(listEnglishAlphabet[n - i]), Char.ToLower(listEnglishAlphabet[i]));

            //
            return outDict;
        }

        private List<char> GetListRussianAlphabet()
        {
            List<char> Alphabet = new List<char>();
            for (int i = 1040; i < 1072; i++)
            {
                Alphabet.Add((char)i);
                if (i == 1045) Alphabet.Add((char)1025); //добавляем Ё
            }
            return Alphabet;
        }

        private List<char> GetListEnglishAlphabet()
        {
            List<char> Alphabet = new List<char>();
            for (int i = 65; i < 91; i++) Alphabet.Add((char)i);
            return Alphabet;
        }
    }
}
