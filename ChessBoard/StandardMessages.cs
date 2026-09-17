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

        public static void AskForInputTwo()
        {
            Console.Write("\nHur stort schackbräde vill du skapa? Ange ett heltal mellan 3 - 50: ");
        }
        public static bool ValidateInput(string numberInput, out string message, out int size)
        {
                if (Int32.TryParse(numberInput, out int number) && number >= 3 && number <= 50)
                {
                    message = $"Du valde {number}.";
                    size = number;
                    return true;
                }
                else
                {
                    message = $"Felaktig inmatning, numret {number} är ogiltigt, numret måste vara mellan 3 - 50. försök igen.";
                    size = number;
                    return false;
                }
        }
    }
}
