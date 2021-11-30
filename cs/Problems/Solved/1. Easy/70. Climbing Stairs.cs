public class Solution_70 {
    public int ClimbStairs(int n) {
        if (n == 1) return 1;
        
        var vars = new int[n];
        vars[0] = 1;
        vars[1] = 2;

        for (int i = 2; i < n; i++)
            vars[i] = vars[i - 1] + vars[i - 2]; 

        return vars[n - 1];
    }
}