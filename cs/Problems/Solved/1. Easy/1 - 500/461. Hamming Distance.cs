using System;
using System.Linq;

public class Solution_461 {
    public int HammingDistance(int x, int y) {
        return Convert.ToString(x^y, 2).Count(x => x == '1');
    }
}