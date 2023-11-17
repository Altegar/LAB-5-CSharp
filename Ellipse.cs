namespace LAB5
{
    internal class Ellipse : Point
    {
        private double semiMajorAxis;
        private double semiMinorAxis;

        public Ellipse() : base() { this.semiMajorAxis = 0;  this.semiMinorAxis = 0; }
        public Ellipse(Point center, double semiMajorAxis, double semiMinorAxis) : base(center)
        {
            this.semiMajorAxis = semiMajorAxis;
            this.semiMinorAxis = semiMinorAxis;
        }
        public Ellipse(Ellipse e) : base(e)
        {
            this.semiMajorAxis = e.semiMajorAxis;
            this.semiMinorAxis = e.semiMinorAxis;
        }

        public double GetSemiMajorAxis() { return this.semiMajorAxis; }
        public double GetSemiMinorAxis() { return this.semiMinorAxis; }

        public void SetSemiMajorAxis(double value) { this.semiMajorAxis = value; }
        public void SetSemiMinorAxis(double value) { this.semiMinorAxis = value; }

        public double Area()
        {
            return Math.PI * semiMajorAxis * semiMinorAxis;
        }

        public void Display()
        {
            Console.WriteLine($"Ellipse: Center({GetX()}, {GetY()}), Semi-Major Axis: {semiMajorAxis}, Semi-Minor Axis: {semiMinorAxis}, Area: {Area()}");
        }
    }
}