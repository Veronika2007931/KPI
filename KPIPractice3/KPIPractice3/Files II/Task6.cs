namespace KPIPractice3.Files_II
{
    /// <summary>
    /// Рекурсивно виводить дерево каталогів і файлів з відступами.
    /// </summary>
    public void Execute(string rootPath, int indent = 0)
    {
        // Вивід назви поточної директорії
        Console.WriteLine($"{new string(' ', indent)}[DIR] {Path.GetFileName(rootPath)})

        // Вивід усіх файлів у директорії
        foreach (string file in Directory.GetFiles(rootPath))
        {
            Console.WriteLine($"{new string(' ', indent + 2)}{Path.GetFileName(file)}");
        }

        // Рекурсивний обхід усіх піддиректорій
        foreach (string directory in Directory.GetDirectories(rootPath))
        {
            Execute(directory, indent + 2); // Збільшуємо відступ
        }
    }

    public void Main()
    {
        string currentDirectory = Directory.GetCurrentDirectory();

        Console.WriteLine("Структура поточної директорії:");
        Execute(currentDirectory);
    }
}
