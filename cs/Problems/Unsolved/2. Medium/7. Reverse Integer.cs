

public class Solution_7 {
    public int Reverse(int x) {
        var maxFull = int.MaxValue / 10;
        var minFull = int.MinValue / 10;
        var maxRed = int.MaxValue % 10;
        var minRed = int.MinValue % 10;
        
        var rev = 0;
        var sign = x < 0 ? -1 : 1;

        while(x / 10 != 0)
        {
            rev = rev * 10 + x % 10;
            x /= 10;
        }

        if (rev > maxFull) return 0;
        if (rev < minFull) return 0;
        
        if (rev == maxFull || rev == minFull)
        {
            if (sign == -1 && x < minRed) return 0;
            if (x > maxRed) return 0;
        }

        return rev * 10 + x;
    }
}