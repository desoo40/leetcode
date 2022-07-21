using System;
using System.Collections.Generic;

public class Solution_205
{
    public bool IsIsomorphic(string s, string t)
    {
        var dict = new Dictionary<char, char>();
        var isUsed = new HashSet<char>();

        for (int i = 0; i < s.Length; i++)
        {
            if (!dict.ContainsKey(s[i]))
            {
                if (isUsed.Contains(t[i]))
                    return false;

                dict.Add(s[i], t[i]);
                isUsed.Add(t[i]);
                continue;
            }

            if (dict[s[i]] != t[i])
                return false;
        }

        return true;
    }
}