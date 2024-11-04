using System.Xml.Serialization;

namespace Triangle_Draw_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the triangle drawing app");
            String choice;
            do
            {
                Console.Write("Enter an integer: ");
                int entry = int.Parse(Console.ReadLine());
                for (int i = 1; i <= entry; i++)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write("");
                    }
                    for (int k = 1; k <= i; k++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine("");
                }
                Console.WriteLine();
                Console.Write("\nWould you like to go again? (y/n): ");
                choice = Console.ReadLine().ToLower();
            } while (choice == "y");
        }
    }
}
