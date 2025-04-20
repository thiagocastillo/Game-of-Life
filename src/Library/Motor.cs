namespace Library;

public class Motor
{
    public static Board Avanzar(Board board) // Método para generar la siguiente generación del tablero
    {
        int rows = board.Height; // Obtiene el número de filas del tablero
        int cols = board.Width;  // Obtiene el número de columnas del tablero
        Board newBoard = new Board(cols, rows); // Crea un nuevo tablero para almacenar la siguiente generación

        for (int i = 0; i < rows; i++) // Recorre las filas del tablero
        {
            for (int j = 0; j < cols; j++) // Recorre las columnas del tablero
            {
                int liveNeighbors = CountLiveNeighbors(board, i, j); // Cuenta los vecinos vivos de la célula actual

                if (board.GetCell(j, i)) // Si la célula está viva
                {
                    // La célula permanece viva si tiene 2 o 3 vecinos vivos, de lo contrario muere
                    newBoard.SetCell(j, i, liveNeighbors == 2 || liveNeighbors == 3);
                }
                else // Si la célula está muerta
                {
                    // La célula nace si tiene exactamente 3 vecinos vivos
                    newBoard.SetCell(j, i, liveNeighbors == 3);
                }
            }
        }
        return newBoard; // Devuelve el nuevo tablero con la siguiente generación
    }

    private static int CountLiveNeighbors(Board board, int i, int j) // Método para contar los vecinos vivos de una célula
    {
        int count = 0; // Inicializa el contador de vecinos vivos
        int[] directions = { -1, 0, 1 }; // Direcciones para recorrer las celdas vecinas

        foreach (int di in directions) // Recorre las filas vecinas
        {
            foreach (int dj in directions) // Recorre las columnas vecinas
            {
                if (di == 0 && dj == 0) continue; // Ignora la célula actual

                int ni = i + di; // Calcula la fila del vecino
                int nj = j + dj; // Calcula la columna del vecino

                // Verifica si el vecino está dentro de los límites del tablero y si está vivo
                if (ni >= 0 && ni < board.Height && nj >= 0 && nj < board.Width && board.GetCell(nj, ni))
                {
                    count++; // Incrementa el contador si el vecino está vivo
                }
            }
        }
        return count; // Devuelve el número de vecinos vivos
    }
}