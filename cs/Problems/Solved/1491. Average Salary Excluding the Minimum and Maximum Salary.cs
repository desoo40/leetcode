using System;

public class Solution_1491 {
     public double Average(int[] salary) {
        var max = 0;
        var min = Int32.MaxValue;
        var sum = 0;
        var len = salary.Length;
         
        for (int i = 0; i < len; i++)
        {
            int el = salary[i];
            if (el > max)
                max = el;
            
            if (el < min)
                min = el;

            sum += el;
        }

        return (double)(sum - max - min) / (len - 2);
    }
}