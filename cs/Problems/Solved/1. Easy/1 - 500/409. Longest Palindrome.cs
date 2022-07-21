using System.Collections.Generic;
using System.Linq;

public class Solution_409
{
    public int LongestPalindrome(string s)
    {
        var dict = new Dictionary<char, int>();
        foreach (var ch in s)
        {
            if (!dict.ContainsKey(ch)) dict.Add(ch, 0);
            dict[ch]++;
        }

        var odds = dict.Where(x => x.Value % 2 == 1);
        var evens = dict.Where(x => x.Value % 2 == 0);

        if (odds.Count() == 0)
            return s.Length;

        return evens.Sum(x => x.Value) + odds.Sum(x => x.Value) - odds.Count() + 1;
    }
}