using System.IO;
namespace Library;

public class BoardImporter
{
    public Board LoadBoardFromTxt(string filePath)
    {
        string url = filePath;
        string content = File.ReadAllText(url);
        string [] lines = content.Split('\n');
        int rows = lines.Length;
        int cols = lines[0].Length;
        
        Board board = new Board(rows, cols);
        
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if (lines[i][j] == '1')
                {
                    board.SetCell(i, j, true);
                }
                else
                {
                    board.SetCell(i, j, false);
                }
            }
        }
        
        return board;
    }
}