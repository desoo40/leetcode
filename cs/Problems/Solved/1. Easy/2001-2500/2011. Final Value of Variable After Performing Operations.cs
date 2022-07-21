using System.Linq;

public class Solution_2011
{
    public int FinalValueAfterOperations(string[] operations)
    {
        return operations.Where(x => x.Contains("++")).Count() - operations.Where(x => x.Contains("--")).Count();
    }
}