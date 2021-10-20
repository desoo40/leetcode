using System;
public class Solution_485 {
     public int FindMaxConsecutiveOnes(int[] nums) {
        
        var maxSeq = 0;
        var currSeq = 0;
        
        for (int i = 0; i < nums.Length; i++)
        {
            
            if (nums[i] == 0)
            {
                currSeq = 0;
                continue;
            }
            
            currSeq++;
            maxSeq = currSeq > maxSeq ? currSeq : maxSeq;
            
        }

        return maxSeq;
    }
}