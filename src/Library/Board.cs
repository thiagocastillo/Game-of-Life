using System;

namespace Library
{
    
}
public class Board
{
    private bool[,] cells;
    public void TamañoBoard()
    {
        int anchoBoard = cells.GetLength(1);
        int largoBoard = cells.GetLength(0);
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
    