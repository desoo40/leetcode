public class Solution_69 {
    public int MySqrt(int x) {
        if (x == 0) return 0;
        if (x == 1) return 1;
        var limit = 46341;
        var ans = 1;
        for (int i = 1; i <= x / 2; i++)
        {
            if (i == limit) return limit - 1;
            if (i * i == x) return i;
            if (i * i > x) return i - 1;
            
            ans = i;
        }

        return ans;
    }
}