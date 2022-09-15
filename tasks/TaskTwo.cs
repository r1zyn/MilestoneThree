using System.Text.RegularExpressions;

namespace TaskTwo
{
    public class Program
    {
        public static void Run()
        {
            Console.Write("Enter your first and last name with a space in between: ");
            string name = Console.ReadLine()!;

            Regex regex = new Regex(@"/[A-Za-z]{2,}\s[A-Za-z]{2,}/g", RegexOptions.Compiled | RegexOptions.IgnoreCase); // Regular expression works in website regex testers, not working in code

            while (!regex.IsMatch(name))
            {
                Console.Write("Enter a valid first and last name with a space in between: ");
                name = Console.ReadLine()!;
            }

            Console.Write($"Greetings, {name}!");
        }
    }
}