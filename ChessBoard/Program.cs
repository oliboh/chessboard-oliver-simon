namespace ChessBoard;

public class Program
{
    public static void Main()
    {
        string message = "";
        int size = 0;
        Console.OutputEncoding = System.Text.Encoding.Unicode;
              
        StandardMessages.GreetUser();

        do          
        {
            
            Console.Write(message);
            StandardMessages.AskForInputTwo();
        }
        while (!StandardMessages.ValidateInput(Console.ReadLine(), out message, out size));

        Console.WriteLine(message);

        ChessBoard chessBoardTwo = new ChessBoard(size);

        ChessBoard.RenderBoard(chessBoardTwo);




        int number = StandardMessages.AskForInput();
        Console.WriteLine($"Du valde {number}");

        ChessBoard chessboard = new ChessBoard(number);
        ChessBoard.RenderBoard(chessboard);


    }
}