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

    public class ProductProxy : Product
    {
        private readonly DBContext _dbContext;

        public ProductProxy(int id, DBContext dbContext) : base(id)
        {
            _dbContext = dbContext;
        }

        public override string Name
        {
            get => base.Name;
            set
            {
                base.Name = value;
                _dbContext.MarkAsChanged(this);
            }
        }

    }
}