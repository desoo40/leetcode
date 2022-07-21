using System.Collections.Generic;

public class Solution_1189
{
    public int MaxNumberOfBalloons(string text)
    {
        var dict = new Dictionary<char, int>()
        {
            {'b', 0},
            {'a', 0},
            {'l', 0},
            {'o', 0},
            {'n', 0}
        };

        for (int i = 0; i < text.Length; i++)
            if (dict.ContainsKey(text[i]))
                dict[text[i]]++;

        dict['o'] /= 2;
        dict['l'] /= 2;

        var min = int.MaxValue;

        foreach (var item in dict.Keys)
            if (dict[item] < min)
                min = dict[item];

        return min;
    }
}