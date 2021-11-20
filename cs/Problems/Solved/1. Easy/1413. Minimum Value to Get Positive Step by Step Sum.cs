using System;
using System.Linq;

public class Solution_1413 {
    public int MinStartValue(int[] nums) {
        var minSum = 0;
        var currSum = 0;

        for (int i = 0; i < nums.Length; i++)
        {
           currSum += nums[i];

           if (currSum < minSum)
            minSum = currSum;
        }

        return 1 - minSum;
    }
}