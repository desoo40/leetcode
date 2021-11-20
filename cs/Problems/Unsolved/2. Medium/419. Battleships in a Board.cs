 public class Solution_419 {
    public int CountBattleships(char[][] board) {
        
        var m = board.Length;
        var n = board[0].Length;

        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (board[i][j] == 'X')
                    continue;
            }
        }
        
        return 0;
    }
}