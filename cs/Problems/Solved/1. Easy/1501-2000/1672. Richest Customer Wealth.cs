using System.Linq;
public class Solution_1672
{
    public int MaximumWealth(int[][] accounts)
    {
        return accounts.Max(x => x.Sum());
    }
}