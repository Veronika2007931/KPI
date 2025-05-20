namespace KPIPractice3.Files_I
{
    public class Task2
    {
        /// <summary>
        /// Завдання 2: Створити новий текстовий файл та записати в нього вміст.
        /// Метод Execute приймає шлях до файлу та текст для запису.
        /// </summary>
        public void Execute(string path, string contents)
        {
            File.WriteAllText(path, contents);
            Console.WriteLine($"Файл успішно створено за шляхом: {path}");
        }

        public void Main()
        {
            // Приклад створення файлу та запису тексту
            string filePath = "example.txt";
            string text = "Це приклад запису тексту у файл.";

            Execute(filePath, text);
        }
    }
}