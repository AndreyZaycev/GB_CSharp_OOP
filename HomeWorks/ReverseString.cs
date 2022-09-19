using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorks
{
    internal class ReverseString
    {
        private string m_reverseString;

        public ReverseString(string reverseString)
        {
            m_reverseString = reverseString;
        }

        public string GetReverseString()
        {
            char[] chars = m_reverseString.ToCharArray();
            Array.Reverse(chars);
            return new string(chars);
        }
    }
}
