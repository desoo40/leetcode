 public class Solution_9_2 {
    public bool IsPalindrome(int x) {
        if (x < 0)
            return false;

        var income = x;
        var ans = 0;

        while (x > 0)
        {
            ans *= 10;
            ans += x % 10;

            x /= 10;
        }

       
        
        return ans == income;
    }
}