using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace number_game.classes
{
    internal class Game
    {
        public static void GameStart()
        {
            Console.WriteLine("Please choose difficulty");
            Console.WriteLine("1. Press E for Easy (1-10)" +
                "\n2. Press M for Medium (1-20)" +
                "\n3. Press H Hard (1-50)");
            while (true)
            {
                char difficulty = Char.ToUpper(Console.ReadKey().KeyChar);
                Console.Clear();
                if(difficulty != 'E' && difficulty != 'M' && difficulty != 'H')
                {
                    Console.WriteLine("Invalid input please choose E, M or H");
                    continue;
                }
                else if (difficulty == 'E')
                {
                    Random rand = new Random();
                    int numberToGuess = rand.Next(1, 11);
                    Console.WriteLine("You have chosen Easy difficulty." +
                        "Guess a number between 1 and 10.");
                    int userGuess = Int32.Parse(Console.ReadLine());
                    Console.Clear();
                    while (true)
                    {
                        if (userGuess <= 0 || userGuess > 10)
                        {
                            Console.WriteLine("please enter a number from 1 to 10");
                            userGuess = Int32.Parse(Console.ReadLine());
                            Console.Clear();
                        }
                        else if (userGuess < numberToGuess)
                        {
                            Console.WriteLine("try higher");
                            userGuess = Int32.Parse(Console.ReadLine());
                            Console.Clear();
                        }
                        else if (userGuess > numberToGuess)
                        {
                            Console.WriteLine("try lower");
                            userGuess = Int32.Parse(Console.ReadLine());
                            Console.Clear();
                        }
                        else if (userGuess == numberToGuess)
                        {
                            Console.WriteLine("Congrats You guessed the right number");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Invalid input");
                            userGuess = Int32.Parse(Console.ReadLine());
                        }
                    }
                }
                else if (difficulty == 'M')
                {
                    Random rand = new Random();
                    int numberToGuess = rand.Next(1, 21);
                    Console.WriteLine("You have chosen Medium difficulty." +
                        "Guess a number between 1 and 20.");
                    int userGuess = Int32.Parse(Console.ReadLine());
                    Console.Clear();
                    while (true)
                    {
                        if (userGuess <= 0 || userGuess > 20)
                        {
                            Console.WriteLine("please enter a number from 1 to 20");
                            userGuess = Int32.Parse(Console.ReadLine());
                            Console.Clear();
                        }
                        else if (userGuess < numberToGuess)
                        {
                            Console.WriteLine("try higher");
                            userGuess = Int32.Parse(Console.ReadLine());
                            Console.Clear();
                        }
                        else if (userGuess > numberToGuess)
                        {
                            Console.WriteLine("try lower");
                            userGuess = Int32.Parse(Console.ReadLine());
                            Console.Clear();
                        }
                        else if (userGuess == numberToGuess)
                        {
                            Console.WriteLine("Congrats You guessed the right number");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Invalid input");
                            userGuess = Int32.Parse(Console.ReadLine());
                        }
                    }
                }
                else if (difficulty == 'H')
                {
                    Random rand = new Random();
                    int numberToGuess = rand.Next(1, 51);
                    Console.WriteLine("You have chosen Hard difficulty." +
                        "Guess a number between 1 and 50.");
                    int userGuess = Int32.Parse(Console.ReadLine());
                    Console.Clear();
                    while (true)
                    {
                        if (userGuess <= 0 || userGuess > 50)
                        {
                            Console.WriteLine("please enter a number from 1 to 50");
                            userGuess = Int32.Parse(Console.ReadLine());
                            Console.Clear();
                        }
                        if (userGuess < numberToGuess)
                        {
                            Console.WriteLine("try higher");
                            userGuess = Int32.Parse(Console.ReadLine());
                            Console.Clear();
                        }
                        else if (userGuess > numberToGuess)
                        {
                            Console.WriteLine("try lower");
                            userGuess = Int32.Parse(Console.ReadLine());
                            Console.Clear();
                        }
                        else if (userGuess == numberToGuess)
                        {
                            Console.WriteLine("Congrats You guessed the right number");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Invalid input");
                            userGuess = Int32.Parse(Console.ReadLine());
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Invalid difficulty selection.");
                }
            }
        }
    }
}