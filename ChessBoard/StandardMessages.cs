using System;
using System.Collections.Generic;
using System.Text;
using Spectre.Console;

namespace ChessBoard
{
    public class StandardMessages
    {
        public static void GreetUser()
        {
            var figlet = new FigletText("Chessboard");
            AnsiConsole.Write(figlet);

            var panel = new Panel("Hej och välkommen till ChessBoard.").RoundedBorder().Padding(2, 1);
            AnsiConsole.Write(panel);
        }

        public static void AskForInput()
        {

            var message = new Markup("Hur stort schackbräde vill du skapa? Ange ett heltal mellan [DeepSkyBlue1]3 - 50[/]: ");
            AnsiConsole.Write(message);
        }
        

        public static bool AskForAnother()
        {
            return AnsiConsole.Confirm("Do you want to create another board?");
        }        
    }
}
