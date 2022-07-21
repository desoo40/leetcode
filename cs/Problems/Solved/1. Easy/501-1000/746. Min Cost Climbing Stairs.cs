using System;

public class Solution_746 {
    public int MinCostClimbingStairs(int[] cost) {
        var len = cost.Length;
        var min = new int[len + 1];

        min[0] = 0;
        min[1] = 0;

        for (int i = 2; i <= len; i++)
            min[i] = Math.Min(min[i - 2] + cost[i - 2], min[i - 1] + cost[i - 1]);

        return min[len];
    }
}