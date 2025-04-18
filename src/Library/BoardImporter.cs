using System;
using System.IO;

namespace Library
{
    public class BoardImporter
    {
        public Board LoadBoardFromTxt(string filePath)
        {
            string[] lines = File.ReadAllLines(filePath);
            
            int rows = lines.Length;
            int cols = lines[0].Trim().Length;

            Board board = new Board(cols, rows); 
            for (int i = 0; i < rows; i++)
            {
                string line = lines[i].Trim();
                for (int j = 0; j < cols; j++)
                {
                    board.SetCell(j, i, line[j] == '1'); }
            }

            return board;
        }
    }
}