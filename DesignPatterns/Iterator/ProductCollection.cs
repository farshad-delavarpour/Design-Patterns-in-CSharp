namespace DesignPatterns.Iterator
{
    public class ProductCollection
    {
        private List<Product> _products = new List<Product>();

        public void Add(Product product) =>
            _products.Add(product);

        public IIterator<Product> CreateIterator()
        {
            return new ProductIterator(this);
        }

        public class ProductIterator : IIterator<Product>
        {
            private readonly ProductCollection _collection;
            private int _index;

            public ProductIterator(ProductCollection collection)
            {
                _collection = collection;
            }

            public Product Current() =>
                _collection._products[_index];

            public bool HasNext() =>
                _index < _collection._products.Count;

            public void Next() =>
                _index++;
        }
    }
}