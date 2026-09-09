Console.WriteLine("Hej och välkommen till ChessBoard.");
Console.Write("Hur stort schackbräde vill du skapa? Ange ett heltal mellan 3-50: ");
Int32.TryParse(Console.ReadLine(), out int number);
if (number >= 3 && number <= 50)
{
    Console.WriteLine($"Du valde {number}");
}
else
{
    Console.WriteLine("Felaktig inmatning, försök igen. ");
}