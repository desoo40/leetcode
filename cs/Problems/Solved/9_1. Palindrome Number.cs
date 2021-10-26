 public class Solution_9 {
    public bool IsPalindrome(int x) {
        if (x < 0)
            return false;
        
        var s = x.ToString();
        var len = s.Length;
        
        for(int i = 0; i < len / 2; i++)
            if (s[i] != s[len - i - 1])
                return false;
        
        return true;
    }
}