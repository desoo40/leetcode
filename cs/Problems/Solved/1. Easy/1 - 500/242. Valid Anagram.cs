using System.Collections.Generic;
using System.Linq;

public class Solution_242
{
    public bool IsAnagram(string s, string t)
    {
        if (s.Length != t.Length) return false;
        if (s == t) return true;

        var dict = new Dictionary<char, int>();
        for (int i = 0; i < s.Length; i++)
        {
            if (!dict.ContainsKey(s[i])) dict.Add(s[i], 0);
            if (!dict.ContainsKey(t[i])) dict.Add(t[i], 0);

            dict[s[i]]++;
            dict[t[i]]--;
        }
        return dict.Count(x => x.Value != 0) == 0;
    }
}