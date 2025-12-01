using number_game.classes;
using System.Reflection.Metadata.Ecma335;


UserCreate.Start();

char startGame = Char.ToUpper(Console.ReadKey().KeyChar);
Console.Clear();

while (true)
{
    if (startGame == 'S')
    { 
        Game.GameStart();
    }
    else
    {
    Console.WriteLine("Invalid input! " +
        "\nPlease press 'S' on your keyboard");
    startGame = Char.ToUpper(Console.ReadKey().KeyChar);
        Console.Clear();
    }
}


