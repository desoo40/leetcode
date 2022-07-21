public class Solution_1309
{
    public string FreqAlphabets(string s)
    {
        var ans = "";

        for (int i = s.Length - 1; i >= 0; i--)
        {
            if (s[i] == '#')
            {
                ans = (char)('a' - 1 + (s[--i] - '0' + (s[--i] - '0') * 10)) + ans;
                continue;
            }

            ans = (char)('a' - 1 + s[i]) + ans;
        }

        return ans;
    }
}