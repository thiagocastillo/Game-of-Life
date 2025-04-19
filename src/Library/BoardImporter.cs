using System;
using System.IO;
namespace Library;

public class BoardImporter  
{
    public Board LoadBoardFromTxt(string filePath) //Metodo para cargar el tablero desde un archivo txt
    {
        string[] lines = File.ReadAllLines(filePath); 
            
        int rows = lines.Length;
        int cols = lines[0].Trim().Length;

        Board board = new Board(cols, rows); 
        
        for (int i = 0; i < rows; i++)
        {
            string line = lines[i].Trim(); // Elimina espacios en blanco al inicio y al final de la linea
            
            for (int j = 0; j < cols; j++)
            {
                board.SetCell(j, i, line[j] == '1');  // Establece el estado de la célula en el tablero: '1' indica que está viva, '0' indica que está muerta
            }
        }
        return board;
    }
}
