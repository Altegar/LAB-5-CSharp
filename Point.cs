namespace LAB5
{
    internal class Point
    {
        private double x;
        private double y;

        public Point() { this.x = 0; this.y = 0; }
        public Point(double x, double y) { this.x = x; this.y = y; }
        public Point(Point p) { this.x = p.x; this.y = p.y; }

        public double GetX() { return this.x; }
        public double GetY() { return this.y; }

        public void SetX(double value) { this.x = value; }
        public void SetY(double value) { this.y = value; }

        public void Read()
        {
            Console.Write("x: ");
            this.x = Convert.ToDouble(Console.ReadLine());
            Console.Write("y: ");
            this.y = Convert.ToDouble(Console.ReadLine());
        }

        public void Display()
        {
            Console.WriteLine($"Point: ({x}, {y})");
        }
    }
}