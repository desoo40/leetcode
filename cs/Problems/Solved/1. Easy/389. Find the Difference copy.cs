using System.Collections.Generic;
using System.Linq;

public class Solution_389
{
    public char FindTheDifference(string s, string t)
    {
        var dict = new Dictionary<char, int>();

        for (int i = 0; i < t.Length; i++)
        {
            if (!dict.ContainsKey(t[i])) dict.Add(t[i], 0);
            dict[t[i]]--;

            if (i >= s.Length) continue;

            if (!dict.ContainsKey(s[i])) dict.Add(s[i], 0);
            dict[s[i]]++;
        }

        return dict.Where(x => x.Value == -1).First().Key;
    }
}