using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleCodingPractics
{
    internal class Palindrome
    {
        private string _inputString;
        public Palindrome(string inputString)
        {
            _inputString = inputString;
        }

        public bool IsPalindrome()
        {
            string originalStr = _inputString;
            string reverseStr = new string(_inputString.ToCharArray().Reverse().ToArray());
            if (originalStr == reverseStr)
            {
                Console.WriteLine($"This is Palindrome : {originalStr}");
                return true;
            }
            Console.WriteLine($"This is not Palindrome : {originalStr}");
            return false;
            
        }
    }
}
