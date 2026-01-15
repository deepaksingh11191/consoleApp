using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleCodingPractics
{
    internal class ReverseTheOrderOfWordsInAGivenString
    {
        //input: Welcome to Csharp corner, output: corner Csharp to Welcome
        private string _inputString;
        public ReverseTheOrderOfWordsInAGivenString(string inputString )
        {
            _inputString = inputString;
        }

        public void ReverseOrderOfString_A()
        {
            char[] chars = _inputString.ToCharArray();
            Array.Reverse(chars);
            string result = new string(chars);
            Console.WriteLine(result);
        }

        public void ReverseOrderOfString_B()
        {
            char[] chars = _inputString.ToCharArray();
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = chars.Length - 1; i >= 0; i--)
            {
                stringBuilder.Append(chars[i]);
            }

            Console.WriteLine(stringBuilder);
        }
    }
}
