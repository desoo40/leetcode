using System;
public class Solution_283
{
    public void MoveZeroes(int[] nums)
    {
        var zerosInd = 0;
        var nonZerosInd = 0;

        while (zerosInd < nums.Length && nonZerosInd < nums.Length)
        {
            while (nums[zerosInd] != 0)
            {
                zerosInd++;
                if (zerosInd == nums.Length)
                    return;
            }

            while (nums[nonZerosInd] == 0 || nonZerosInd <= zerosInd)
            {
                nonZerosInd++;
                if (nonZerosInd == nums.Length)
                    return;
            }

            nums[zerosInd] = nums[nonZerosInd];
            nums[nonZerosInd] = 0;
            zerosInd++;
            nonZerosInd++;
        }
    }
}