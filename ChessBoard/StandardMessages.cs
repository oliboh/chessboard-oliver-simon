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
            var panel = new Panel("Hej och välkommen till ChessBoard.").RoundedBorder().Padding(2, 1);
            AnsiConsole.Write(panel);
        }
        public static int AskForInput()
        {
            var prompt = new TextPrompt<int>("Hur stort schackbräde vill du skapa? Ange ett heltal mellan [green]3 - 50[/]: ").Validate(input =>
            {
                if (input >= 3 && input <= 50)
                {
                    return ValidationResult.Success();
                }
                else
                {
                    return ValidationResult.Error($"[red]Felaktig inmatning, numret {input} är ogiltigt, numret måste vara mellan 3 - 50. försök igen.[/]");
                }
            });

            int number = AnsiConsole.Prompt(prompt);
            return number;


            //Console.Write("Hur stort schackbräde vill du skapa? Ange ett heltal mellan 3 - 50: ");
        }
    }
}
