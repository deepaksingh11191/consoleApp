using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleCodingPractics
{
    internal class RemoveDuplicateCharactersFromString
    {
        //input: csharpcorner
        //output: csharpone
        private string _inputString { get; set; } = string.Empty;
        public RemoveDuplicateCharactersFromString(string inputString)
        {
            _inputString = inputString;
        }

        public void RemoveDuplicateCharFromString_A()
        {
            char[] charArr = _inputString.ToCharArray();
            string result = string.Empty;
            foreach (char c in charArr) 
            {
                if(!result.Contains(c))
                    result += c;
            }
            Console.WriteLine(result);
        }

        public void RemoveDuplicateCharFromString_B()
        {
            Console.WriteLine(new string(_inputString.Distinct().ToArray()));
        }
    }
}
