using System;

public class Solution_1232
{
    public bool CheckStraightLine(int[][] coordinates)
    {
        if (coordinates.Length == 2) return true;
        var x_diff = Math.Abs(coordinates[1][0] - coordinates[0][0]);
        var y_diff = Math.Abs(coordinates[1][1] - coordinates[0][1]);
        var tg = x_diff == 0 ? int.MaxValue : y_diff / x_diff;



        for (int i = 2; i < coordinates.Length; i++)
        {
            var x = Math.Abs(coordinates[i][0] - coordinates[i - 1][0]);
            var y = Math.Abs(coordinates[i][1] - coordinates[i - 1][1]);
            var tmpTg = x == 0 ? int.MaxValue : y / x;

            if (tg != tmpTg) return false;
        }

        return true;
    }
}