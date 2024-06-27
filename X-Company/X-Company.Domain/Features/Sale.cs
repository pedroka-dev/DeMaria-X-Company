using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace X_Company.Domain.Features
{
    public class Sale(Product product, Client client, int quantity) : BaseEntity
    {
        public Product Product { get; set; } = product;
        public Client Client { get; set; } = client;
        public int Quantity { get; set; } = quantity;

        public override string Validate()
        {
            var result = "";
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
