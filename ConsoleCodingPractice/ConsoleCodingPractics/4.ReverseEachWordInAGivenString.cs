using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleCodingPractics
{
    internal class ReverseEachWordInAGivenString
    {
        //input: Welcome to Csharp corner, output: emocleW ot prahsC renroc
        private string _inputString;
        public ReverseEachWordInAGivenString(string inputString)
        {
            _inputString = inputString;
        }

        public void ReverseEachWordInAGivenString_A()
        {
            string[] strArr = _inputString.Split(' ');

            for (int i = 0;i<=strArr.Length-1;i++)
            {
                char[] charArr = strArr[i].ToCharArray();
                Array.Reverse(charArr);
                strArr[i] = new string(charArr);
            }
            Console.WriteLine(string.Join(' ',strArr));
        }

        public void ReverseEachWordInAGivenString_B()
        {
            string[] strArr = _inputString.Split(' ');
            string[] result = new string[strArr.Length];
            int k = 0;
            foreach (var item in strArr)
            {
                char[] charArr = item.ToCharArray();
                StringBuilder sb= new StringBuilder();
                for(int i = charArr.Length - 1; i >= 0; i--)
                {
                    sb.Append(charArr[i]);
                }
                result[k] = sb.ToString();
                k++;
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
