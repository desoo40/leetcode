public class Solution_509 {
    public int Fib(int n) {
        
        // if(n==0) return 0;
        // if(n==1) return 1;
        // else return Fib(n-1) + Fib(n -2);

        if(n==0) return 0;

        var fibo = new int[n + 1];
        fibo[0] = 0;
        fibo[1] = 1;

        for (int i = 2; i <= n; i++)
            fibo[i] = fibo[i - 1] + fibo[i - 2];

        return fibo[n];
    }
}