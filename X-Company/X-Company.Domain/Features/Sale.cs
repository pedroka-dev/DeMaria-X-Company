
namespace X_Company.Domain.Features
{
    public class Sale : BaseEntity
    {
        public Product Product { get; set; } 
        public Client Client { get; set; }
        public int Quantity { get; set; }

        public Sale(Product product, Client client, int quantity)
        {
            Product = product;
            Client = client;
            Quantity = quantity;
        }

        public Sale()       //Needs this empty constructor so Entity Framework can migrate the 1 to many relationship without issues
        { }

        public override string Validate()
        {
            var result = "";
            if (Client == null)
            {
                result += "* Attribute Client cannot be null.\n";
            }
            if (Product == null)
            {
                result += "* Attribute Product cannot be null.\n";
            }
            else
            {
                if (Quantity <= 0)
                {
                    result += "* Attribute Quantity cannot be smaller or equals to zero.\n";
                }
                else if (Product.InStock < Quantity)
                {
                    result += "* Not enough of this product in stock to create this sale.\n";
                }
            }
            
            if (result == "")
                result = "VALID";
            return result;
        }

        public override bool Equals(object? obj)
        {
            return obj is Sale sale &&
                   id == sale.id &&
                   Id == sale.Id &&
                   EqualityComparer<Product>.Default.Equals(Product, sale.Product) &&
                   EqualityComparer<Client>.Default.Equals(Client, sale.Client) &&
                   Quantity == sale.Quantity;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(id, Id, Product, Client, Quantity);
        }
    }
}
