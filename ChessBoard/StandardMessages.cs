using System;
using System.Collections.Generic;
using System.Text;

namespace ChessBoard
{
    public class StandardMessages
    {
        public static void GreetUser()
        {
            Console.WriteLine("Hej och välkommen till ChessBoard.");
        }
        public static void AskForInput()
        {
            Console.Write("Hur stort schackbräde vill du skapa? Ange ett heltal mellan 3 - 50: ");
        }
    }
}
