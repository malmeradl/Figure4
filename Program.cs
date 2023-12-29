class Program
{
    static void Main()
    {
        List<Point> points = new List<Point>
        {
            new Point(0, 0),
            new Point(2, 3),
            new Point(5, 6),
            new Point(8, 9),
            new Point(0, 7)
        };

        Circle circle = new Circle(points[0], 7);

        int pointsInsideCircle = 0;
        foreach (Point point in points)
        {
            int result = circle.ContainsPoint(point);

            switch (result)
            {
                case 1:
                    Console.WriteLine($"A {point} inside a circle.");
                    pointsInsideCircle++;
                    break;
                case 0:
                    Console.WriteLine($"The {point} lies on a circle.");
                    pointsInsideCircle++;
                    break;
                case -1:
                    Console.WriteLine($"A {point} outside the circle.");
                    break;
                default:
                    Console.WriteLine($"Something went wrong.");
                    break;
            }


        }

        Console.WriteLine($"\n{pointsInsideCircle} points into {circle}\n");

    }
}
