using System;

public class Solution_1768
{
    public string MergeAlternately(string word1, string word2)
    {
        var len = Math.Max(word1.Length, word2.Length);
        var ans = "";
        for (int i = 0; i < len; i++)
        {
            if (i < word1.Length) ans += word1[i];
            if (i < word2.Length) ans += word2[i];
        }

        return ans;
    }
}