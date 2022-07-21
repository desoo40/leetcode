public class Solution_1572
{
    public int DiagonalSum(int[][] mat)
    {
        var sum = 0;
        var len = mat.Length;
        for (int i = 0; i < len; i++)
        {
            var primary = i;
            var secondary = len - 1 - i;

            sum += mat[primary][primary];
            if (primary != secondary)
                sum += mat[primary][secondary];
        }

        return sum;
    }
}