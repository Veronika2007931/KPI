namespace KPIPractice3.Files_II
{
    /// <summary>
    /// Завдання 4: Додати набір рядків у кінець існуючого файла.
    /// Метод Execute приймає шлях до файлу та колекцію рядків.
    /// </summary>
    public class Task4
    {


        public void Execute(string path, string contents, IEnumerable<string> lines)
        {
            File.WriteAllText(path, contents);
            Console.WriteLine($"Файл успішно створено за шляхом: {path}");
        }

        public void ReadFile(string path)
        {
            string content = File.ReadAllText(path);
            conole.WriteLine($"вміст файлу{content}")
        }

        public void NewWord(path, IEnumerable<string> lines)
        {
            using (StreamWrighter writer = new StreamWrighter(path, append: true))
            {
                writer.WriteLine("Цей рядок буде додано в кінець файлу.");
            }
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
