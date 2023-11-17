// Сушинський Ігор
// Лабораторна робота № 5
// Успадкування.
// Варіант 3

namespace LAB5
{
    internal class Program
    {
        public static void Main(String[] args)
        {
            Point p = new();
            p.Read();
            Console.WriteLine($"Point: ({p.GetX()}, {p.GetY()})");
            Console.WriteLine("---------------------------------");
            Ellipse e1 = new(p, 5, 3);
            Ellipse e2 = new(e1);
            e1.Display();
            e2.SetSemiMajorAxis(6);
            e2.Display();
            Console.WriteLine("---------------------------------");
            Disk d1 = new(e1, 4);
            Disk d2 = new(d1);
            d1.Display();
            d2.SetRadius(10);
            d2.Display();
        }
    }
}