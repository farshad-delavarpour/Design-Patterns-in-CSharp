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

    public class PointIcon
    {
        public PointIcon(PointType type, byte[] icon)
        {
            Type = type;
            _icon = icon;
        }

        public PointType Type { get; }
        private byte[] _icon;
    }

    public class PointIconFactory
    {
        private Dictionary<PointType, PointIcon> _icons = new();

        public PointIcon GetPointIcon(PointType pointType)
        {
            if (!_icons.ContainsKey(pointType))
            {
                PointIcon icon = new(pointType, null);
                _icons.Add(pointType, icon);
            }

            return _icons[pointType];
        }
    }

    public class PointService
    {
        public PointService(PointIconFactory iconFactory)
        {
            _pointIconFactory = iconFactory;
        }

        private PointIconFactory _pointIconFactory;

        public List<Point> GetPoints()
        {
            return new List<Point> {
                new Point(1, 2, _pointIconFactory.GetPointIcon(PointType.Cafe)),
                new Point(4, 5, _pointIconFactory.GetPointIcon(PointType.Hospital)),
            };
        }
    }
}