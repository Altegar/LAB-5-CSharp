namespace LAB5
{
    internal class Disk : Ellipse
    {
        public Disk() : base() { }
        public Disk(Point center, double radius) : base(center, radius, radius) { }
        public Disk(Disk d) : base(d) { }

        public double GetRadius() { return GetSemiMajorAxis(); }

        public void SetRadius(double value) { SetSemiMajorAxis(value); SetSemiMinorAxis(value); }

        public new void Display()
        {
            Console.WriteLine($"Disk: Center({GetX()}, {GetY()}), Radius: {GetRadius()}, Area: {Area()}");
        }
    }
}