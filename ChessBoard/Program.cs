namespace ChessBoard;

public class Program
{
    public static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;
              
        StandardMessages.GreetUser();
        int number = StandardMessages.AskForInput();
        Console.WriteLine($"Du valde {number}");

        ChessBoard chessboard = new ChessBoard(number);
        ChessBoard.RenderBoard(chessboard);


    }
}