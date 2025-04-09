namespace Library;

public class Board
{
    private int _rows;
    private int _cols;
    private bool[,] _cells;

    public Board(int rows, int cols)
    {
        _rows = rows;
        _cols = cols;
        _cells = new bool[rows, cols];
    }

    public void SetCell(int row, int col, bool isAlive)
    {
        if (row >= 0 && row < _rows && col >= 0 && col < _cols)
        {
            _cells[row, col] = isAlive;
        }
    }

    public bool GetCell(int row, int col)
    {
        if (row >= 0 && row < _rows && col >= 0 && col < _cols)
        {
            return _cells[row, col];
        }
        return false;
    }
}