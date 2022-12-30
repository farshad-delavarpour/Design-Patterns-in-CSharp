namespace DesignPatterns.Flyweight
{
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