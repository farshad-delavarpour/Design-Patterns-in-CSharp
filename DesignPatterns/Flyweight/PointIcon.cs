namespace DesignPatterns.Flyweight
{
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
}