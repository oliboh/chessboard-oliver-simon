namespace ChessBoard;

public class Program
{
    public static void Main()
    {
        string message = "";
        int size = 0;
        bool isActive = true;


        Console.OutputEncoding = System.Text.Encoding.Unicode;
              
      

        //do          
        //{
            
        //    Console.Write(message);
        //    StandardMessages.AskForInputTwo();
        //}
        //while (!StandardMessages.ValidateInput(Console.ReadLine(), out message, out size));

        //Console.WriteLine(message);

        //ChessBoard chessBoardTwo = new ChessBoard(size);

        //ChessBoard.RenderBoard(chessBoardTwo);



        while(isActive)
        {
            StandardMessages.GreetUser();
            StandardMessages.AskForInput();
            
            string userInput = UserInput.SaveInput();

            bool correctInput = UserInput.ValidateInput(userInput, out message, out int number);
            //int number = UserInput.ValidateInput(StandardMessages.AskForInput(), out message);            
            if (correctInput)
            {
                Console.WriteLine(message);
                ChessBoard chessboard = new ChessBoard(number);
                ChessBoard.RenderBoard(chessboard);                
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