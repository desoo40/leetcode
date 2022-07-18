using System;
using System.Collections.Generic;
public class Solution_17
{
    public Dictionary<char, string> dict = new Dictionary<char, string>()
    {
        {'2', "abc"},
        {'3', "def"},
        {'4', "ghi"},
        {'5', "jkl"},
        {'6', "mno"},
        {'7', "pqrs"},
        {'8', "tuv"},
        {'9', "wxyz"}
    };

    public IList<string> LetterCombinations(string digits)
    {
        var ans = new List<string>();
        if (string.IsNullOrEmpty(digits)) return ans;

        ans.AddRange(AddByDigit("", digits[0]));
        for (int i = 1; i < digits.Length; i++)
        {
            var tmpLst = new List<string>();
            foreach (var el in ans)
                tmpLst.AddRange(AddByDigit(el, digits[i]));

            ans = tmpLst;
        }

        return ans;
    }

    private List<string> AddByDigit(string v1, char v2)
    {
        var lst = new List<string>();

        foreach (var ch in dict[v2])
            lst.Add(v1 + ch);

        return lst;
    }
}