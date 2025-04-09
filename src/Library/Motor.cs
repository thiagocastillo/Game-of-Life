namespace Library;

public class Motor
{
    public static Board Avanzar(Board gameBoard)
    {
        Board cloneboard = new Board(gameBoard.Width(),gameBoard.Height());
        for (int x = 0; x < gameBoard.Width()-1; x++)
        {
            for (int y = 0; y < gameBoard.Height()-1; y++)
            {
                int aliveNeighbors = 0;
                for (int i = x - 1; i <= x + 1; i++)
                {
                    for (int j = y - 1; j <= y + 1; j++)
                    {
                        if (i >= 0 && i < gameBoard.Width() && j >= 0 && j < gameBoard.Height() && gameBoard.GetValue(i, j))
                        {
                            aliveNeighbors++;
                        }
                    }
                }

                if (gameBoard.GetValue(x, y))
                {
                    aliveNeighbors--;
                }

                if (gameBoard.GetValue(x, y) && aliveNeighbors < 2)
                {
                    cloneboard.SetValue(x, y, false);
                }
                else if (gameBoard.GetValue(x, y) && aliveNeighbors > 3)
                {
                    cloneboard.SetValue(x,y, false);
                }
                else if (!gameBoard.GetValue(x, y) && aliveNeighbors == 3)
                {
                    cloneboard.SetValue(x, y, true);
                }
                else
                {
                    cloneboard.SetValue(x, y, gameBoard.GetValue(x, y));
                }
            }
        }

        gameBoard = cloneboard;
        return gameBoard;
    }
}