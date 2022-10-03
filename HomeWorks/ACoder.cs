using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorks
{
    internal class ACoder : ICoder
    {
        private char[] _inCharArray;

        public ACoder(string inString) 
        { 
            _inCharArray = inString.ToCharArray();
        }

        public string Encode()
        {
            for (int i = 0; i < _inCharArray.Length; i++) _inCharArray[i] = (char)(_inCharArray[i] + 1);
            return string.Concat(_inCharArray);
        }

        public string Decode()
        {
            for (int i = 0; i < _inCharArray.Length; i++) _inCharArray[i] = (char)(_inCharArray[i] - 1);
            return string.Concat(_inCharArray);
        }
    }
}
