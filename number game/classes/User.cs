using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace number_game.classes
{
    /// <summary>
    /// User class
    /// </summary>
    internal class User
    {
        /// <summary>
        /// Property: Username
        /// </summary>
        public string Username { get; set; }
        /// <summary>
        /// property: Verif
        /// </summary>
        public int Verif { get; set; }

        /// <summary>
        /// method: Create user
        /// </summary>
        /// <param name="username"></param>
        /// <param name="verif"></param>
        /// <returns></returns>
        public static User Create(string username, int verif)
        {
            return new User { Username = username, Verif = verif };
        }

        /// <summary>
        /// method: check verification
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
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