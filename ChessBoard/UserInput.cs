using System;
using System.Collections.Generic;
using System.Text;

namespace ChessBoard
{
    public class UserInput
    {

        public static string SaveInput()
        {
            return Console.ReadLine();
        }
        public static bool ValidateInput(string numberInput, out string message, out int number)
        {
            if (Int32.TryParse(numberInput, out int validatedNumber) && validatedNumber >= 3 && validatedNumber <= 50)
            {
                message = $"Du valde {validatedNumber}.";
                number = validatedNumber;
                return true;
            }
            else
            {
                message = $"Felaktig inmatning, numret måste vara mellan 3 - 50. Tryck på valfri knapp för att försöka igen.";
                number = 0;
                return false;
                
            }
        }
    }
}
