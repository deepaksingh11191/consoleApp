using System;
using System.Linq;
using System.Text;

namespace ConsoleCodingPractics;

internal class ReverseString
{
    private string _reverseString;
    public ReverseString(string reverseString)
    {
        _reverseString = reverseString;
    }

    public void ReverseAString_A()
    {
        char[] charArr = _reverseString.ToCharArray();
        string result = string.Empty;
        for (int i = charArr.Length-1; i >=0; i--)
        {
            result += charArr[i];
        }
        Console.WriteLine(result);
    }

    public void ReverseAString_B() 
    {
        char[] strArr = _reverseString.ToCharArray();
        Array.Reverse(strArr);
        string result=new string(strArr);
        Console.WriteLine(result);
    }

    public void ReverseAString_C() {
        string str = new string(_reverseString.ToCharArray().Reverse().ToArray());
        Console.WriteLine(str);
    }

    //public string ReverseString_D(string str)
    //{
    //    if (_reverseString.Length <= 1)
    //        return _reverseString;
    //    return _reverseString[^1] + ReverseString_C(_reverseString[1..^1]) + _reverseString[0];
    //}
}
