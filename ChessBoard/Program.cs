using System.Runtime.InteropServices;
Console.OutputEncoding = System.Text.Encoding.Unicode;
Console.WriteLine("Hej och välkommen till ChessBoard.");
Console.Write("Hur stort schackbräde vill du skapa? Ange ett heltal mellan 3-50: ");
Int32.TryParse(Console.ReadLine(), out int number);
if (number >= 3 && number <= 50)
{
    Console.WriteLine($"Du valde {number}");

    for (int rows = 0; rows < number;  rows++)
    {
        for (int columns = 0; columns < number; columns++)
        {
            if ((rows + columns) % 2 == 0)
            {
                Console.Write("◼︎ ");
            } 
            else
            {
                Console.Write("◻︎ ");
            } 
        }
        Console.Write("\n");
    }

}
else
{
    Console.WriteLine("Felaktig inmatning, försök igen. ");
}