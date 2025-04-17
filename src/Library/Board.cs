namespace Library;

public class Board
{
    private bool[,] cells;
    
    public int Width { get; private set; }
    public int Height { get; private set; }
    
    public void TamañoBoard()
    {
        Width = cells.GetLength(1);
        Height = cells.GetLength(0);
    }
    public Board(int anchoBoard, int largoBoard)
    {
        Width = anchoBoard;
        Height = largoBoard;
        cells = new bool[anchoBoard, largoBoard];
    }
    
    public bool GetCell(int x, int y)
    {
        return cells[x, y];
    }

    public void SetCell(int x, int y, bool valor)
    {
        cells[x, y] = valor;
    }
    public int CountAliveNeighbors(int x, int y)
    {
        int aliveNeighbors = 0;

        for (int dx = -1; dx <= 1; dx++)
        {
            for (int dy = -1; dy <= 1; dy++)
            {
                if (dx == 0 && dy == 0) continue; 

                int neighborX = x + dx;
                int neighborY = y + dy;

                if (neighborX >= 0 && neighborX < Width && neighborY >= 0 && neighborY < Height)
                {
                    if (cells[neighborX, neighborY])
                    {
                        aliveNeighbors++;
                    }
                }
            }
        }

        return aliveNeighbors;
    }
}
    