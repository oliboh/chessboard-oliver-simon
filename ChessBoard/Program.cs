namespace ChessBoard;

public class Program
{
    public static void Main()
    {
        string message = "";        
        bool isActive = true;

        Console.OutputEncoding = System.Text.Encoding.Unicode;
     
        while(isActive)
        {
            StandardMessages.GreetUser();
            StandardMessages.AskForInput();
            
            string userInput = UserInput.SaveInput();

            bool correctInput = UserInput.ValidateInput(userInput, out message, out int number);                       
            if (correctInput)
            {
                Console.WriteLine(message);
                ChessBoard chessBoard = new ChessBoard(number);
                ChessBoard.RenderBoard(chessBoard);                
            }
            else
            {
                Console.WriteLine(message);
                Console.ReadKey(true);
                Console.Clear();
                continue;
            }
            if (StandardMessages.AskForAnother())
            {
                Console.Clear();
                continue;
            }
            else
            {
                isActive = false;
            }
        }
    }
}