namespace X_Company.Domain.Features
{
    public class Product(string name, string description, float price, int inStock) : BaseEntity
    {
        public string Name { get; set; } = name;
        public string Description { get; set; } = description;
        public float Price { get; set; } = price;
        public int InStock { get; set; } = inStock;

        public override string Validate()
        {
            throw new NotImplementedException();
        }

        public override bool Equals(object? obj)
        {
            return obj is Product product &&
                   id == product.id &&
                   Id == product.Id &&
                   Name == product.Name &&
                   Description == product.Description &&
                   Price == product.Price &&
                   InStock == product.InStock;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(id, Id, Name, Description, Price, InStock);
        }
    }
}
