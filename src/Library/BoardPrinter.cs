using System;
using System.Text;
using System.Threading;

namespace Library;

public class BoardPrinter                               // Defino la clase BoardPrinter
{
    private Board board;                               // Declaro atributo privado board

    public BoardPrinter(Board board)                   // Metodo constructor de la clase
    {
        this.board = board;                             // El parametro que recibe de Board lo guarda en el atributo board
    }

    public void PrintBoardloop()                        // Se encarga de imprimir continuamente el tablero
    {
        while (true)                                    // El codigo dentro se repite hasta que se interrumpa la ejecucion
        {
            Console.Clear();                            // Limpia la consola
            StringBuilder s = new StringBuilder();      // Construye la cadena que representara el tablero en pantalla

            for (int y = 0; y < board.Height; y++)      // Recorre las filas del tablero
            {
                for (int x = 0; x < board.Width; x++)   // Por cada fila, recorre las columnas del tablero
                {
                    if (board.GetCell(x, y))            // Se consulta si la celula en la posicion esta viva
                    {
                        s.Append("|X|");                // Si la celula esta viva, se agrega al tablero
                    }
                    else
                    {
                        s.Append("___");                // Si la celula esta muerta, se agrega al tablero
                    }
                }
                s.Append("\n");                         // Salto de linea
            }
            Console.WriteLine(s.ToString());            // Se imprime en consolatodo el contenido de StringBuilder
            board = Motor.Avanzar(board);               // Funcion que permite que las celulas avanzen
            Thread.Sleep(300);          // Detiene la ejecucion del programa por el tiempo dado antes de actualizarse
        }
    }
}