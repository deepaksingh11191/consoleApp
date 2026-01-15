using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleCodingPractics
{
    internal class CountOccurrenceOfEachCharacter
    {
        //input: hello world;
        //output: h – 1, e – 1, l – 3, o – 2, w – 1, r – 1, d – 1
        private string _inputString { get; set; } = string.Empty;
        public CountOccurrenceOfEachCharacter(string inputString)
        {
            _inputString = inputString;
        }

        public void CountTheOccurenceOfEachCharacter()
        {
            Dictionary<char, int> countDic = new();
            foreach(char item in _inputString.ToLower())
            {
                if(countDic.ContainsKey(item))
                    countDic[item]++;
                else
                { 
                    countDic.Add(item, 1); 
                }
            }

            foreach (var item in countDic)
            {
                Console.WriteLine("Count of {0} is {1}",item.Key,item.Value);
            }
        }
    }
}
