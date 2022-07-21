using System;
public class Solution_1779
{
    public int NearestValidPoint(int x, int y, int[][] points)
    {
        var minInd = -1;
        var minSum = int.MaxValue;

        for (int i = 0; i < points.Length; i++)
        {
            var x_1 = points[i][0];
            var y_1 = points[i][1];

            if (x_1 == x || y_1 == y)
            {
                var currSum = Math.Abs(x - x_1) + Math.Abs(y - y_1);

                if (currSum < minSum)
                {
                    minSum = currSum;
                    minInd = i;
                }
            }
        }

        return minInd;
    }
}