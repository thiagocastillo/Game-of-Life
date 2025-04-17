namespace Library;
public class Motor
{
    public static Board CreateNextGeneration(Board currentBoard)
    {
        Board nextBoard = new Board(currentBoard.Width, currentBoard.Height);

        for (int x = 0; x < currentBoard.Width; x++)
        {
            for (int y = 0; y < currentBoard.Height; y++)
            {
                int aliveNeighbors = currentBoard.CountAliveNeighbors(x, y);
                bool isAlive = currentBoard.GetCell(x, y);

                if (isAlive && (aliveNeighbors < 2 || aliveNeighbors > 3))
                {
                    nextBoard.SetCell(x, y, false);
                }
                else if (!isAlive && aliveNeighbors == 3)
                {
                    nextBoard.SetCell(x, y, true);
                }
                else
                {
                    nextBoard.SetCell(x, y, isAlive);
                }
            }
        }
        return nextBoard;
    }
}