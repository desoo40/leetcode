using System.Collections.Generic;

public class Solution_1790
{
    public bool AreAlmostEqual(string s1, string s2)
    {
        var ch1 = '0';
        var ch2 = '0';
        var diffs = 0;
        for (int i = 0; i < s1.Length; i++)
        {
            if (s1[i] != s2[i])
            {
                diffs++;
                if (ch1 != '0')
                {
                    if (ch1 != s2[i] || ch2 != s1[i])
                        return false;
                }
                else
                {
                    ch1 = s1[i];
                    ch2 = s2[i];
                }

                if (diffs > 2) return false;
            }
        }

        return diffs == 2 || diffs == 0;
    }
}