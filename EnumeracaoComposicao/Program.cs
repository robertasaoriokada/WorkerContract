using EnumeracaoComposicao.Entities;
using EnumeracaoComposicao.Entities.Enums;
using System.Security.AccessControl;

namespace EnumeracaoComposicao
{
    class Program
    {
        static void Main(string[] args)
        {
            int aux = 1;
            Console.WriteLine("Enter department's name: ");
            string department =  Console.ReadLine()!;
            Department department1 = new Department(department);
            Console.WriteLine("Enter the worker data");
            Console.WriteLine("Name:");
            string name = Console.ReadLine()!;
            Console.WriteLine("Level:");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine()!);
            Console.WriteLine("Base salary:");
            double salary = double.Parse(Console.ReadLine()!);
            Console.WriteLine("How many contracts would you like to register to this worker?");
            int num = int.Parse(Console.ReadLine()!);
            Worker worker = new Worker(department1, level, name, salary);

            do
            {
                Console.WriteLine($"Enter the #{aux} contract data");
                Console.WriteLine("Date (DD/MM/YYYY)");
                DateTime date = DateTime.Parse(Console.ReadLine()!);
                Console.WriteLine("Value per hour: ");
                double price = double.Parse(Console.ReadLine()!);
                Console.WriteLine("Duration: ");
                int hour = int.Parse(Console.ReadLine()!);
                HourContract contract = new HourContract(date, price, hour);
                worker.AddContract(contract);
                aux++;
            } while (aux <= num);

            Console.WriteLine("Enter with month and year to calculate income (MM/YYYY): ");
            string data = Console.ReadLine()!;
            int month = int.Parse(data.Substring(0,2));
            int year = int.Parse(data.Substring(3));
            Console.WriteLine($"Worker's name: {worker.Name}, Department: {worker.Department.Name}, Base Salary: {worker.BaseSalary}");
            Console.WriteLine("Monthly salary in the requested data: " + data + ": " + worker.Income(month, year));

        }
    }
}
