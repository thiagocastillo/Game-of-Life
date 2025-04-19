using System;
namespace Library;

public class Board
{
    // Matriz que representa el estado de cada celda del board
    private bool[,] cells;
    // Ancho del tablero
    public int Width { get; private set; }
    // Alto del tablero
    public int Height { get; private set; }
    // Asigna el tamaño del board
    public void TamañoBoard()
    {
        Width = cells.GetLength(1);
        Height = cells.GetLength(0);
    }
    // Crea un tablero con el tamaño dado
    // Inicializa las celdas
    public Board(int anchoBoard, int largoBoard)
    {
        Width = anchoBoard;
        Height = largoBoard;
        cells = new bool[anchoBoard, largoBoard];
    }
    // Devuelve el estado de la celula, viva o muerta
    public bool GetCell(int x, int y)
    {
        return cells[x, y];
    }
    // Cambia el estado y la posicion de la celula
    public void SetCell(int x, int y, bool valor)
    {
        cells[x, y] = valor;
    }
}
    