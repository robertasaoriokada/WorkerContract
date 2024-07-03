using EnumeracaoComposicao.Entities;
using EnumeracaoComposicao.Entities.Enums;

namespace EnumeracaoComposicao
{
    class Program
    {
        static void Main(string[] args)
        {
            int aux = 1;
            Console.WriteLine("Enter department's name: ");
            string department =  Console.ReadLine()!;
            Console.WriteLine("Enter the worker data");
            Console.WriteLine("Name:");
            string name = Console.ReadLine()!;
            Console.WriteLine("Level:");
            string level = Console.ReadLine()!;
            Console.WriteLine("Base salary:");
            double salary = double.Parse(Console.ReadLine()!);
            Console.WriteLine("How many contracts would you like to register to this worker?");
            int num = int.Parse(Console.ReadLine()!);

            do
            {
                Console.WriteLine($"Enter the #{num - (num - 1)} contract data");
                Console.WriteLine("Date (DD/MM/YY)");
                DateTime date = DateTime.Parse(Console.ReadLine()!);
                Console.WriteLine("Value per hour: ");
                double price = double.Parse(Console.ReadLine()!);
                Console.WriteLine("Duration: ");
                int hour = int.Parse(Console.ReadLine()!);
            } while (aux <= num);

        }
    }
}
