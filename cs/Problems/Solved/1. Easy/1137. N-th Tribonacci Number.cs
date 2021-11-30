public class Solution_1137 {
    public int Tribonacci(int n) {
        if (n == 0) return 0;
        if (n == 1) return 1;

        var tribo = new int[n + 1];
        tribo[0] = 0;
        tribo[1] = 1;
        tribo[2] = 1;

        for (int i = 3; i <= n; i++)
            tribo[i] = tribo[i - 1] + tribo[i - 2] + tribo[i - 3];

        return tribo[n];
    }
}