using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleCodingPractics
{
    internal class FindAllPossibleSubstringOfAGivenString
    {
        //input: abcd
        //output : a ab abc abcd b bc bcd c cd d
        private string _inputString {  get; set; } = string.Empty;
        public FindAllPossibleSubstringOfAGivenString(string inputString)
        {
            _inputString = inputString;
        }

        public void FindAllPossibleSubstring()
        {
            for (int i = 0; i < _inputString.Length; ++i)
            {
                StringBuilder stringBuilder = new StringBuilder(_inputString.Length - 1);
                for (int k = i; k < _inputString.Length; ++k)
                {
                    stringBuilder.Append(_inputString[k]);
                    Console.WriteLine(stringBuilder + " ");
                }
            }
        }

    }
}
