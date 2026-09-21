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
        public static void RenderBoard(ChessBoard chessBoard)
        {         

            for (int rows = 0; rows < chessBoard.Size; rows++) 
            {
                for (int columns = 0; columns < chessBoard.Size; columns++)
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
