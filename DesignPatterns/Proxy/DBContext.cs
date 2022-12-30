namespace DesignPatterns.Proxy
{
    public class DBContext
    {
        private Dictionary<int, Product> _updatedObjects = new();

        public Product GetProduct(int id)
        {
            // Automatically generate SQL statements
            // to read the product with the given ID.
            Console.WriteLine($"SELECT * FROM products WHERE product_id = {id} \n");

            // Simulate reading a product object from a database.
            ProductProxy product = new(id, this);
            product.Name = "Product1";
            return product;
        }

        public void SaveChanges()
        {
            // Automatically generate SQL statements
            // to update the database.
            foreach (var updatedObject in _updatedObjects.Values)
                Console.WriteLine($"UPDATE products SET name = {updatedObject.Name} " +
                "WHERE product_id = {updatedObject.Id} \n");

            _updatedObjects.Clear();
        }

        public void MarkAsChanged(Product product)
        {
            _updatedObjects.TryAdd(product.Id, product);
        }
    }

}