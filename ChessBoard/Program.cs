namespace ChessBoard;

public class Program
{
    public static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;
              
        StandardMessages.GreetUser();

        StandardMessages.AskForInput();

        Int32.TryParse(Console.ReadLine(), out int number);
        if (number >= 3 && number <= 50)
        {
            Console.WriteLine($"Du valde {number}");

            ChessBoard chessboard = new ChessBoard(number);
            ChessBoard.RenderBoard(chessboard);

        }
        else
        {
            Console.WriteLine($"Felaktig inmatning, numret: {number} är ogiltigt, numret måste vara mellan 3 - 50. försök igen. ");
        }
    }
}