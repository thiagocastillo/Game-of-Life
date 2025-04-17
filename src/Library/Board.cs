using System;

namespace Library
{
    
}
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
}
    