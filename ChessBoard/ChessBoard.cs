using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Text;

namespace ChessBoard
{
    public class ChessBoard
    {
        public int Size { get; set; }

        public ChessBoard(int size)
        {
            Size = size;
        }
        public static void RenderBoard(ChessBoard chessboard)
        {
            int number = chessboard.Size;

            for (int rows = 0; rows < number; rows++) 
            {
                for (int columns = 0; columns < number; columns++)
                {
                    if ((rows + columns) % 2 == 0)
                    {
                        Console.Write("◼︎ ");
                    }
                    else
                    {
                        Console.Write("◻︎ ");
                    }
                }
                Console.Write("\n");
            } 
                
        }
    }
}
