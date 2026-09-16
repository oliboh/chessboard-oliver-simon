using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Text;

namespace ChessBoard
{
    public class ChessBoard
    {
        public static void RenderBoard(int number)
        {
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
