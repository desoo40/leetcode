using System;

public class Solution_497 {

    int[][] Rects = null;
    int RectsCnt = 0;

    public Solution_497(int[][] rects) {
        Rects = rects;
        RectsCnt = Rects.Length;
    }
    
    public int[] Pick() {

        var kek = new Random();
        var randRect = Rects[kek.Next(RectsCnt)];
        
        var a = randRect[0];
        var b = randRect[1];
        var x = randRect[2];
        var y = randRect[3];
            
        return new int[] {
            a + kek.Next(x - a + 1),
            b + kek.Next(y - b + 1)
        };
    }
}

/**
 * Your Solution object will be instantiated and called as such:
 * Solution obj = new Solution(rects);
 * int[] param_1 = obj.Pick();
 */