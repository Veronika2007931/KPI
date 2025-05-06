namespace KPIPractice2
{
    //  Swap<T> — обмін значень
    // - Напишіть статичний метод void Swap<T>(ref T a, ref T b).
    // - У Main обміняйте int x=5,y=10 і string s1="Hello",s2="World".
    public class Task2
    {

        public static void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }

        public void Main(string[] args)
        {
            {
                // Обмін int
                int x = 5, y = 10;
                Console.WriteLine($"До обміну: x = {x}, y = {y}");
                Swap(ref x, ref y);
                Console.WriteLine($"Після обміну: x = {x}, y = {y}");

                // Обмін string
                string s1 = "Hello", s2 = "World";
                Console.WriteLine($"\nДо обміну: s1 = {s1}, s2 = {s2}");
                Swap(ref s1, ref s2);
                Console.WriteLine($"Після обміну: s1 = {s1}, s2 = {s2}");

                Console.ReadLine();
            }
        }
    }

}
