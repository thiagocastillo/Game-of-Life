using System;
using System.Threading;
using System.IO;
using Library;

namespace Ucu.Poo.GameOfLife
{
    class Program
    {
        static void Main() // Inicia el programa
        {
            string basePath = AppDomain.CurrentDomain.BaseDirectory;
            string filePath = Path.Combine(basePath, "board.txt");
            
            
            // Crea un objeto de la clase BoardImporter para cargar el archivo board.txt
            BoardImporter fileReader = new BoardImporter();
            Board pantalla = fileReader.LoadBoardFromTxt(filePath); // Carga el tablero desde el archivo

            while (true)
            {
                Console.Clear(); // Limpia la consola
                BoardPrinter printer = new BoardPrinter(pantalla); // Crea un objeto de la clase BoardPrinter
                printer.PrintBoardloop(); // Imprime el tablero
                pantalla = Motor.Avanzar(pantalla); // Cambia el tablero a la siguiente generación
                Thread.Sleep(300); // Delay de 300 milisegundos
            }
        }
    }
}