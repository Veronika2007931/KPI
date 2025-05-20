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
            // TODO: перевірити File.Exists/Directory.Exists і зібрати дані через FileInfo/DirectoryInfo
            throw new NotImplementedException();
        }

        public void Main()
        {
            // TODO: демонструвати виведення метаданих
            throw new NotImplementedException();
        }
    }
}
