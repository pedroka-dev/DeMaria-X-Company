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
            var result = "";
            if (string.IsNullOrWhiteSpace(Name))
            {
                result += "* Attribute Name cannot be null or white space.\n";
            }
            if (string.IsNullOrWhiteSpace(Description))
            {
                result += "* Attribute Description cannot be null or white space.\n";
            }
            if(Price <= 0)
            {
                result += "* Attribute Price cannot be a number smaller or equals to zero.\n";
            }
            if (InStock < 0)
            {
                result += "* Attribute InStock cannot be a number smaller than zero.";
            }
            if (result == "")
                result = "VALID";
            return result;
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

        public override string ToString()
        {
            return $"{this.Name} ({this.InStock} in stock)";
        }
    }
}
