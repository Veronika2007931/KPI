namespace KPIPractice3.Files_II
{
    public class FileMetadata
    {
        public string Path { get; set; }
        public long Size { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
    }

    /// <summary>
    /// Завдання 7: Отримати метадані (розмір, дата створення/модифікації) файлів у вказаному шляху.
    /// Метод Execute повертає колекцію FileMetadata.
    /// </summary>
    public class Task7
    {
        public IEnumerable<FileMetadata> Execute(string path)
        {
            var result = new List<FileMetadata>();

            if (File.Exists(path))
            {
                // Якщо шлях — це файл
                var fileInfo = new FileInfo(path);
                result.Add(CreateMetadata(fileInfo));
            }
            else if (Directory.Exists(path))
            {
                // Якщо шлях — це директорія, обходимо всі файли в ній
                var directoryInfo = new DirectoryInfo(path);
                foreach (var file in directoryInfo.GetFiles("*", SearchOption.TopDirectoryOnly))
                {
                    result.Add(CreateMetadata(file));
                }
            }
            else
            {
                Console.WriteLine("Шлях не існує.");
            }

            return result;
        }

        private FileMetadata CreateMetadata(FileInfo fileInfo)
        {
            return new FileMetadata
            {
                Path = fileInfo.FullName,
                Size = fileInfo.Length,
                Created = fileInfo.CreationTime,
                Modified = fileInfo.LastWriteTime
            };
        }

        public void Main()
        {
            string path = Directory.GetCurrentDirectory();

            var files = Execute(path);

            Console.WriteLine($"Метадані файлів у: {path}");
            foreach (var file in files)
            {
                Console.WriteLine($"Файл: {file.Path}");
                Console.WriteLine($"  Розмір: {file.Size} байт");
                Console.WriteLine($"  Створено: {file.Created}");
                Console.WriteLine($"  Змінено: {file.Modified}");
                Console.WriteLine();
            }
        }
    }
}
