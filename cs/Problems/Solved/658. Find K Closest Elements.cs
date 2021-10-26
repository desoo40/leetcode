using System;
using System.Collections.Generic;

public class Solution_658 {
    public IList<int> FindClosestElements(int[] arr, int k, int x) {
        var arrLen = arr.Length;
        var res = new List<int>();
        
        var minDiff = int.MaxValue;
        var minDiffInd = int.MaxValue;

        for (int i = 0; i < arrLen; i++)
        {
            var currDiff = Math.Abs(arr[i] - x);
            
            if (currDiff < minDiff)
            {
                minDiffInd = i;
                minDiff = currDiff;
            }
        }

        res.Add(arr[minDiffInd]);
        k--;

        var leftBorder = minDiffInd - 1;
        var rightBorder = minDiffInd + 1;

        while (k > 0 && (leftBorder >= 0 || rightBorder < arrLen))
        {
            if (leftBorder < 0)
            {
                while (k > 0 && rightBorder < arrLen)
                {
                    res.Add(arr[rightBorder++]);
                    k--;
                }
                break;
            }

            if (rightBorder == arrLen)
            {
                    while (k > 0 && leftBorder >= 0)
                {
                    res.Insert(0, arr[leftBorder--]);
                    k--;
                }
                
                break;
            }

            if (Math.Abs(arr[leftBorder] - x) <= Math.Abs(x - arr[rightBorder]))
                res.Insert(0, arr[leftBorder--]);
            else
                res.Add(arr[rightBorder++]);

            k--;
        }

        return res;    
    }
}