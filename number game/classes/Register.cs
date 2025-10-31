using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using number_game.classes;

namespace number_game.classes
{
    internal class Register
    {
        public static void Start()
        {
            Console.WriteLine("Welcome to the Number Guessing Game!");
            Console.Write("Please enter your username: ");
            string username = Console.ReadLine();
            Console.Clear();
            Console.Write("Please enter your password: ");
            string password = Console.ReadLine();
            User user = User.Create(username, password);
            Console.Write("Please confirm your password: ");
            string confirmPassword = Console.ReadLine();
            Console.Clear();
            if (User.checkPass(password, confirmPassword) != null)
            {
                Console.WriteLine($"User {user.Username} successfully created. " +
                    $"\npress S to start the game");
            }
            else
            {
                Console.WriteLine("User creation failed due to password mismatch.");
            }
        }
    }
}
