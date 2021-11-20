public class Solution_1310 {
     public int[] XorQueries(int[] arr, int[][] queries) {
            var queriesLen = queries.Length;
            var ans = new int[queriesLen];

            for (int i = 0; i < queriesLen; i++)
            {
                var from = queries[i][0];
                var to = queries[i][1];

                if (from == to)
                {
                    ans[i] = arr[from];
                    continue;
                }

                var newEl = 0;

                for (int j = from; j <= to; j++)
                    newEl ^= arr[j];

                ans[i] = newEl;
            }
            
            return ans;
    }
}