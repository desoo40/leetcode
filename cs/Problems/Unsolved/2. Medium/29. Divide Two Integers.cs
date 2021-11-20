public class Solution_29 {
    public int Divide(int dividend, int divisor) {
        if (dividend == 0) return 0;
        if (dividend == int.MinValue && divisor == -1)
            return int.MaxValue;
        
        var sign = dividend > 0 == divisor > 0 ? 1 : -1;

        divisor = divisor < 0 ? -divisor : divisor;
        dividend = dividend < 0 ? -dividend : dividend;
        
        if (dividend == divisor) return sign * 1;
        
        var quotient = 0;
        var sum = divisor;

        while(sum < dividend)
        {
            sum += divisor;
            quotient++;
        }

        return sign * quotient;
    }
}