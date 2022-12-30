namespace DesignPatterns.Flyweight
{
    public class Point
    {
        public Point(int x, int y, PointIcon icon)
        {
            _x = x;
            _y = y;
            _icon = icon;
        }

        private int _x;
        private int _y;
        private PointIcon _icon;

        public void Draw() => System.Console.WriteLine($"{_icon.Type} at ({_x}, {_y})");

    }
}