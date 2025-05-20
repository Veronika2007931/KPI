using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPIPractice3.Files_I
{
    /// <summary>
    /// Завдання 3: Прочитати весь вміст текстового файлу.
    /// Метод Execute повертає вміст файлу як рядок.
    /// </summary>
    public class Task3
    {
        public void Execute(string path, string contents)
        {
            File.WriteAllText(path, contents);
            Console.WriteLine($"Файл успішно створено за шляхом: {path}");
        }

        public void ReadFile(string path)
        {
            string content = File.ReadAllText(path);
            conole.WriteLine($"вміст файлу{content}")
        }

        public void Main()
        {
            // Приклад створення файлу та запису тексту
            string filePath = "example.txt";
            string text = "Це приклад запису тексту у файл.";

            Execute(filePath, text);
            ReadFile(filePath)
        }
    }
}
