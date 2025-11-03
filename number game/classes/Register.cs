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
            Random random = new Random();
            int verificationCode = random.Next(1000, 9999);
            Console.WriteLine("Welcome to the Number Guessing Game!");
            Console.Write("Please enter your username: ");
            string username = Console.ReadLine();
            Console.Clear();
            Console.Write($"Verification code: {verificationCode}" +
                "\nPlease enter the given verification code: ");
            int UserVerif = Int32.Parse(Console.ReadLine());
            User user = User.Create(username, UserVerif);
            Console.Clear();
            if (User.checkVerif(UserVerif, verificationCode) != null)
            {
                Console.WriteLine($"User {user.Username} successfully created. " +
                    $"\npress S to start the game");
            }
            else
            {
                Console.WriteLine("User creation failed due to failed verification.");
            }
        }
    }
}
