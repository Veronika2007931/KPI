namespace KPIPractice3.Files_II
{
    /// <summary>
    /// Завдання 5: Зчитати всі рядки з файлу, відсортувати за довжиною і повернути список.
    /// </summary>
    public class Task5
    {
        /// <summary>
        /// Зчитує всі рядки з файлу, сортує за довжиною і повертає список.
        /// </summary>
        public List<string> Execute(string path)
        {
            var lines = new List<string>();

            // Зчитування рядків по одному
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    lines.Add(line);
                }
            }

            // Сортування за довжиною
            return lines.OrderBy(x => x.Length).ToList();
        }

        public void Main()
        {
            string filePath = "input.txt";

            // Створимо прикладовий файл, якщо він не існує
            if (!File.Exists(filePath))
            {
                File.WriteAllLines(filePath, new[]
                {
                "Сонце",
                "Дощ",
                "Небо голубе",
                "Хмари",
                "Світ"
            });
            }

            // Виконання завдання
            List<string> sortedLines = Execute(filePath);

            // Виведення результату
            Console.WriteLine("Відсортовані рядки за довжиною:");
            foreach (string line in sortedLines)
            {
                Console.WriteLine(line);
            }
        }
    }
}
