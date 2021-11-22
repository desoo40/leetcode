using System.Collections.Generic;
public class Solution_36 {
    public bool IsValidSudoku(char[][] board) {
        for (int i = 0; i < 9; i++)
        {
            var hashSetHoriz = new HashSet<char>();
            var hashSetVertic = new HashSet<char>();
            var hashSetQuadro = new HashSet<char>();

            for (int j = 0; j < 9; j++)
            {
                var currElHoriz = board[i][j];
                if (hashSetHoriz.Contains(currElHoriz)) return false;
                if (currElHoriz != '.') hashSetHoriz.Add(currElHoriz);

                var currElVertic = board[j][i];
                if (hashSetVertic.Contains(currElVertic)) return false;
                if (currElVertic != '.') hashSetVertic.Add(currElVertic);
            }
        }

        return true;
    }
}