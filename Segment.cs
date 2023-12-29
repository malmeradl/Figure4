public class Segment : Figure
{
    private Point Start { get; set; }
    private Point End { get; set; }

    public Segment(Point start, Point end)
    {
        Start = start;
        End = end;
    }
    public double GetLength()
    {
        return Math.Sqrt(Math.Pow(Start.X - End.X, 2) + Math.Pow(Start.Y - End.Y, 2));
    }
    public override string ToString()
    {
        return $"segment({Start}, {End})";
    }

}