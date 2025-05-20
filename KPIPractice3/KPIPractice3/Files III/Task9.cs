using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPIPractice3.Files_III
{
    public struct Point { public double X, Y; }

    /// <summary>
    /// Завдання 9: Записати набір структур Point у бінарний файл та зчитати його.
    /// Методи WritePoints і ReadPoints.
    /// </summary>
    public class Task9
    {
        public void WritePoints(string path, IEnumerable<Point> points)
        {
            // TODO: BinaryWriter, запис count і пар X/Y
            throw new NotImplementedException();
        }

        public IEnumerable<Point> ReadPoints(string path)
        {
            // TODO: BinaryReader, зчитати count і точки
            throw new NotImplementedException();
        }

        public void Main()
        {
            // TODO: демонстрація запису та читання точок
            throw new NotImplementedException();
        }
    }
}
