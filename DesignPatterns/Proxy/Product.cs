namespace DesignPatterns.Proxy
{
    public class Product
    {
        public Product(int id)
        {
            Id = id;
        }

        public int Id { get; }
        public virtual string Name { get; set; } = string.Empty;
    }
}