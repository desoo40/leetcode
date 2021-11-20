using System;
using System.Linq;

public class Solution_316 {
    public string RemoveDuplicateLetters(string s) {
        return String.Concat(s.Distinct().OrderBy(c => c));
    }
}