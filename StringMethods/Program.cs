// See https://aka.ms/new-console-template for more information
//Length
//ToCharArray
//CompareTo
//indexOf
//LastIndexOf
//Substring
//Equals
//Contains
//Split
//Join

#region String Length Property
//string example = "Hello, C# 12!";
//int length = example.Length;
//Console.WriteLine($"The length of the string is: {length}");

//string[] words= { "orange", "apple", "banana", "cherry" };
//words = words.OrderBy(w => w.Length).ThenBy(w => w).ToArray();
//Console.WriteLine(string.Join(", ", words));
#endregion

#region String ToCahrArray Method
//string sample = "I Am Deepak Singh";
//char[] charArray = sample.ToCharArray();
//foreach (char c in charArray)
//{
//    Console.WriteLine(c+"-");
//}
//Console.WriteLine("Character Array: " + string.Join(", ", charArray));

//string[] strWords = sample.Split(" ");
//for (int i = 0; i < strWords.Length; i++)
//{
//    strWords[i] = new string(strWords[i].ToLower().ToCharArray().Reverse().ToArray());
//}
//Console.WriteLine("Reversed Words: " + string.Join(" ", strWords));
#endregion

#region String CompareTo Method
//string str1 = "apple";
//string str2 = "banana";
//int result = str1.CompareTo(str2);
//if (result < 0)
//{
//    Console.WriteLine($"{str1} comes before {str2}");
//}
//else if (result > 0)
//{
//    Console.WriteLine($"{str1} comes after {str2}");
//}
//else
//{
//    Console.WriteLine($"{str1} is equal to {str2}");
//}

//string[] strArr = new string[] {"asd", "cbc", "cbc", "apc"};
//int lessThan = strArr[0].CompareTo(strArr[1]);
//int equalTo = strArr[1].CompareTo(strArr[2]);
//int greaterThan = strArr[2].CompareTo(strArr[3]);
//Console.WriteLine($"Comparing '{lessThan}' - '{equalTo}' - {greaterThan}");
#endregion

#region String indexOf Method
//string mainString = "Welcome to C# programming. C# is a powerful language.";
//string searchString = "C#";
//int firstIndex = mainString.IndexOf(searchString);
//int lastIndex = mainString.LastIndexOf(searchString);
//Console.WriteLine($"First occurrence of '{searchString}' is at index: {firstIndex}");
//Console.WriteLine($"Last occurrence of '{searchString}' is at index: {lastIndex}");

#endregion

#region String Substring Method
//string fullString = "C# 12 introduces several new features.";
//string substring = fullString.Substring(3, 12);
//Console.WriteLine($"Extracted substring: '{substring}'");
#endregion

#region String Equals Method
//string firstString = "Hello, World!";
//string secondString = "hello, world!";
//bool areEqual = firstString.Equals(secondString, StringComparison.OrdinalIgnoreCase);
//Console.WriteLine($"Are the two strings equal (case-insensitive)? {areEqual}");
#endregion

#region String Contains Method
//string mainStr = "The quick brown fox jumps over the lazy dog.";
//string subStr = "fox";
//bool containsSubStr = mainStr.Contains(subStr);
//Console.WriteLine($"Does the main string contain '{subStr}'? {containsSubStr}");
#endregion

#region String Split Method
//string sentence = "C# 12 brings new features to the language.";
//string[] words = sentence.Split(' ');
//Console.WriteLine("Words in the sentence:");
//foreach (string word in words)
//{
//    Console.WriteLine(word);
//}
#endregion

