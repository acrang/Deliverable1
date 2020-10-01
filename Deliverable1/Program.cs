using System;
using System.Linq;

namespace Deliverable1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a valid password. Your password must be between 7-12 characters, and contain the following: one uppercase letter, one lowercase letter, and an exclamation point (!)");
            string password = Console.ReadLine();
            int length = password.Length;
            if (length >= 7
                && length <= 12
                && password.Any(char.IsUpper)
                && password.Any(char.IsLower)
                && password.Contains("!"))
            {
                Console.WriteLine("Password valid and accepted");
            }
            else
            {
                Console.WriteLine("Error");
            }
        }
    }
}
