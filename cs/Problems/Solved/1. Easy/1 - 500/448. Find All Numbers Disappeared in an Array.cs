using System.Collections.Generic;
using System.Linq;

public class Solution_448 {
    public IList<int> FindDisappearedNumbers(int[] nums) {
        var ans = new List<int>();
        var len = nums.Length;
        for (int i = 0; i < len; i++)
            ans.Add(i + 1);

        var numsList = nums.ToList();
        return ans.Except(numsList).ToList();
    }
}