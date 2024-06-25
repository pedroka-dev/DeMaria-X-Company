namespace X_Company.Domain
{
    public class Product
    {
        public Product(string name, string description, float price, int inStock)
        {
            Name = name;
            Description = description;
            Price = price;
            InStock = inStock;
        }

        public string Name { get; set; }
        public string Description { get; set; }
        public float Price { get; set; }
        public int InStock { get; set; }

        public string Validate()
        {
            throw new NotImplementedException();
        }
    }
}
