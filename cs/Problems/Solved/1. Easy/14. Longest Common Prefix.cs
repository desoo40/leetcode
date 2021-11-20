public class Solution_14 {
  public string LongestCommonPrefix(string[] strs) {
        var len = strs.Length;
        var common = "";

        for (int i = 0; i < strs[0].Length; i++)
        {
            var currChar = strs[0][i];

            for (int j = 0; j < len; j++)
                if (i == strs[j].Length || strs[j][i] != currChar)
                    return common;

            common += currChar;
        }

        return common; 
    }
}