using KPIPractice3.Files_I;
using KPIPractice3.Files_II;
using KPIPractice3.Files_III;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        ConsoleSetup();

        Console.WriteLine("=== Демонстрація тасок ===\n");

        new Task1().Main();
        //new Task2().Main();
        //new Task3().Main();
        //new Task4().Main();
        //new Task5().Main();
        //new Task6().Main();
        //new Task7().Main();
        //new Task8().Main();
        //new Task9().Main();
        //new Task10().Main();
        //new Task11().Main();

        Console.WriteLine("\n=== Кінець демонстрацій ===");
    }

    /// <summary>
    /// Налаштування консолі для коректного відображення символів кирилиці.
    /// </summary>
    private static void ConsoleSetup()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;
    }
}