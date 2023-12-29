class Circle : Figure
{
    public Point Center { get; set; }
    public double Radius { get; set; }

    public Circle(Point center, double radius)
    {
        Center = center;
        Radius = radius;
    }

    public override string ToString()
    {
        return $"circle(center: {Center}, radius: {Radius})";
    }

    public int ContainsPoint(Point point)
    {
        Segment ab = new Segment(Center, point);
        double distance = ab.GetLength();

        if (distance < Radius) { return 1; }
        else if (distance == Radius) { return 0; }
        else { return -1; }

    }
}
