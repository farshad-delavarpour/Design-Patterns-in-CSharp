namespace DesignPatterns.Flyweight
{
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
}