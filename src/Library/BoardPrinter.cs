using System;
using System.Text;
using System.Threading;

namespace Library;

public class BoardPrinter 
{
    private Board board;

    public BoardPrinter(Board board)
    {
        this.board = board;
    }

    public void PrintBoardloop()
    {
        while (true)
        {
            Console.Clear();
            StringBuilder s = new StringBuilder();

            for (int y = 0; y < board.Height; y++)
            {
                for (int x = 0; x < board.Width; x++)
                {
                    if (board.GetCell(x, y))
                    {
                        s.Append("|X|");
                    }
                    else
                    {
                        s.Append("___");
                    }
                }
                s.Append("\n");
            }
            Console.WriteLine(s.ToString());

            Thread.Sleep(300);
        }
    }
}