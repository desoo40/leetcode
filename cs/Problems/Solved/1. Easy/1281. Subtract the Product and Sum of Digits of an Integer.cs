using System;
public class Solution_1281
{
    public int SubtractProductAndSum(int n)
    {
        var product = 1;
        var sum = 0;
        while (n != 0)
        {
            var last = n % 10;
            product *= last;
            sum += last;

            n /= 10;
        }

        return product - sum;
    }
}