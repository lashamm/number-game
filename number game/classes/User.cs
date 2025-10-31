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
        public string Password { get; set; }

        public static User Create(string username, string password)
        {
            return new User { Username = username, Password = password };
        }

        public static User checkPass(string a, string b)
        {
            if (a == b)
            {
                Console.WriteLine("Password confirmed.");
                return new User();
            }
            else
            {
                Console.WriteLine("Passwords do not match.");
                return null;
            }
        }
    }
}