using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace number_game.classes
{
    internal class User
    {
        public string Username { get; set; }
        public int Verif { get; set; }

        public static User Create(string username, int verif)
        {
            return new User { Username = username, Verif = verif };
        }

        public static User checkVerif(int a, int b)
        {
            while (true)
            {
                if (a == b)
                {
                    Console.WriteLine("Verification passed!");
                    return new User();
                }
                else
                {
                    Console.WriteLine("Verification failed! Try again.");
                    Console.Write($"Enter verification code: ");
                    a = Int32.Parse(Console.ReadLine());
                    Console.Clear();
                }
            }
        }
    }
}