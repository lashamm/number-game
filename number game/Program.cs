using number_game.classes;
using System.Reflection.Metadata.Ecma335;

#region register user
Register.Start();
#endregion
#region start game
char startGame = Char.ToUpper(Console.ReadKey().KeyChar);
Console.Clear();
if (startGame == 'S')
{
    Game.GameStart();
}

#endregion

