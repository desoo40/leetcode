using System;

public class Solution_151 {
    public string ReverseWords(string s) {
        var words = s.Split(" ", StringSplitOptions.RemoveEmptyEntries);
        Array.Reverse(words);

        return String.Join(" ", words);
    }
}