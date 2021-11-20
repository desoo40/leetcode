using System.Collections.Generic;

public class Solution_3 {
   public int LengthOfLongestSubstring(string s) {
        var marked = new Dictionary<char, int>();
        var maxLen = 0;
        int i = 0;

        while (i < s.Length)
        {
            var currLen = 0;
            var jHitsUp = false;

            for (int j = i; j < s.Length; j++)
            {
                var currEl = s[j];
                if (marked.ContainsKey(currEl))
                {
                    i = marked[currEl] + 1;
                    break;
                }

                marked.Add(currEl, j);
                currLen++;

                if(j + 1 == s.Length)
                    jHitsUp = true;
            }

            if(currLen > maxLen)
                maxLen = currLen;

            if (jHitsUp)
               break;

            marked.Clear();
        }

        return maxLen;
    }
}