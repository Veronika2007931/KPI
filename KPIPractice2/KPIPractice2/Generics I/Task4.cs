using System;
using System.Collections.Generic;
namespace KPIPractice2
{
    // IStorage<T> & ListStorage<T>
    // - Оголосіть interface IStorage<T>
    // {
    //  void Add(T);
    //  T Get(int);
    //  int Count;
    // }.
    // - Реалізуйте ListStorage<T> на базі List<T>.
    // - У Main додайте/отримайте елементи int, string тощо.
    public class Task4
    {
        public interface IStorage<T>
        {
            void Add(T item);
            T Get(int index);
            int Count { get; }
        }

        // Реалізація IStorage<T> через List<T>
        public class ListStorage<T> : IStorage<T>
        {
            private List<T> items = new List<T>();

            public void Add(T item)
            {
                items.Add(item);
            }

            public T Get(int index)
            {
                if (index < 0 || index >= items.Count)
                    throw new IndexOutOfRangeException("Неправильний індекс");
                return items[index];
            }

            public int Count => items.Count;
        }
        public void Main(string[] args)
        {
            // Робота з int
            IStorage<int> intStorage = new ListStorage<int>();
            intStorage.Add(42);
            intStorage.Add(100);
            Console.WriteLine($"int[0]: {intStorage.Get(0)}");
            Console.WriteLine($"int[1]: {intStorage.Get(1)}");
            Console.WriteLine($"Кількість int: {intStorage.Count}");

            // Робота з string
            IStorage<string> stringStorage = new ListStorage<string>();
            stringStorage.Add("Привіт");
            stringStorage.Add("Світ");
            Console.WriteLine($"\nstring[0]: {stringStorage.Get(0)}");
            Console.WriteLine($"string[1]: {stringStorage.Get(1)}");
            Console.WriteLine($"Кількість string: {stringStorage.Count}");

            Console.ReadLine();
        }
    }
}
