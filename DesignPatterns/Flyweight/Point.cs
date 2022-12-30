namespace DesignPatterns.Flyweight
{
    public class Point
    {
        public Point(int x, int y, PointType type, byte[] icon)
        {
            X = x;
            Y = y;
            Type = type;
            Icon = icon;
        }

        private int X;
        private int Y;
        private PointType Type;
        private byte[] Icon;

        public void Draw() => System.Console.WriteLine($"{Type} at ({X}, {Y})");
    }

    public class PointService
    {
        public List<Point> GetPoints()
        {
            return new List<Point> {
                new Point(1, 2, PointType.Hospital, null),
                new Point(4, 5, PointType.Cofe, null),
            };
        }
    }
}