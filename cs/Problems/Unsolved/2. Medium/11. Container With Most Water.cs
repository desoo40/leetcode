using System;

public class Solution_11 {
    public int MaxArea(int[] height) {
        var len = height.Length;
        var maxSquare = 0;
        var heightestInd = 0;

        for (int i = 0; i < len - 1; i++)
        {
            if (heightestInd > i)
                i = heightestInd;

            for (int j = i + 1; j < len; j++)
            {
                var left = height[i];
                var right = height[j];

                if(right > height[heightestInd])
                    heightestInd = j;

                var min = left > right ? right : left;

                var currSquare = min * (j - i);

                if (currSquare > maxSquare)
                    maxSquare = currSquare;
            }
        }

        return maxSquare;
    }
}