using System.Text.RegularExpressions;

namespace TaskTwo
{
    public class Program
    {
        public static void Run()
        {
            Console.Write("Enter your first and last name with a space in between: ");
            string name = Console.ReadLine()!;

            Regex regex = new Regex(@"^[A-Za-z]{2,}\s[A-Za-z]{2,}$", RegexOptions.Compiled | RegexOptions.IgnoreCase);

            while (!regex.IsMatch(name))
            {
                Console.Write("Enter a valid first and last name with a space in between: ");
                name = Console.ReadLine()!;
            }

            Console.Write($"Greetings, {name}!");
        }
    }
}