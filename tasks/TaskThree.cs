using System.Text;

namespace TaskThree
{
    public class Program
    {
        public static void Run()
        {
            int[] numbers = new int[50];
            string[] ascii = new string[50];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = new Random().Next(65, 91);
                ascii[i] = Encoding.ASCII.GetString(new byte[]{ (byte) numbers[i] });
            }

            Console.WriteLine("Index of first A in array: " + Array.IndexOf(ascii, ascii.Where(x => x == "A").First()));
            Console.Write("Enter a letter to search for: ");
            string letter = Console.ReadLine()!;
            Console.WriteLine("Index of " + letter + " in array: " + Array.IndexOf(ascii, ascii.Where(x => x == letter).First()));
            Console.WriteLine("Letter J count: " + ascii.Where(x => x == "J").Count());
            Console.WriteLine("Unsorted array: " + string.Join(" ", numbers));
            Console.WriteLine("Sorted array: " + string.Join(" ", numbers.OrderBy(x => x)));
            Console.WriteLine("First index: " + ascii[0]);
            Console.WriteLine("Last index: " + ascii[ascii.Length - 1]);
        }
    }
}