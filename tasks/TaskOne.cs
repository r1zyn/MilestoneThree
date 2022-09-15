namespace TaskOne
{
    public class Program
    {
        public static void Run()
        {
            Console.Write("Enter an integer: ");
            int start = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter another integer: ");
            int end = Convert.ToInt32(Console.ReadLine());

            for (int i = start; i <= end; i++)
            {
                if ((i % 7) == 0)
                {
                    Console.Write(i);
                }
            }
        }
    }
}