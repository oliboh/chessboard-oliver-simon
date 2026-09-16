using System.Runtime.InteropServices;
Console.OutputEncoding = System.Text.Encoding.Unicode;
Console.WriteLine("Hej och välkommen till ChessBoard.");
Console.Write("Hur stort schackbräde vill du skapa? Ange ett heltal mellan 3-50: ");
Int32.TryParse(Console.ReadLine(), out int number);
if (number >= 3 && number <= 50)
{
    Console.WriteLine($"Du valde {number}");

    ChessBoard.ChessBoard.RenderBoard(number);

}
else
{
    Console.WriteLine($"Felaktig inmatning, numret: {number} är ogiltigt, numret måste vara mellan 3 - 50. försök igen. ");
}