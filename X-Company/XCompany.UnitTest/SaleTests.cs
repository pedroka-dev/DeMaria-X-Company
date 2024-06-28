using X_Company.Domain.Features;

namespace XCompany.UnitTest
{
    public class SaleTests
    {
        [Fact]
        public void Validate_ReturnsValid_WhenAllPropertiesAreSetCorrectly()
        {
            // Arrange
            var product = new Product("Laptop", "High-end gaming laptop", 1500.99f, 10);
            var client = new Client("John Doe", "123 Main St", "555-555-5555", "john.doe@example.com");
            var sale = new Sale(product, client, 5);

            // Act
            var result = sale.Validate();

            // Assert
            Assert.Equal("VALID", result);
        }

        [Fact]
        public void Validate_ReturnsErrorMessage_WhenClientIsNull()
        {
            // Arrange
            var product = new Product("Laptop", "High-end gaming laptop", 1500.99f, 10);
            var sale = new Sale(product, null, 5);

            // Act
            var result = sale.Validate();

            // Assert
            Assert.Contains("* Attribute Client cannot be null.", result);
        }

        [Fact]
        public void Validate_ReturnsErrorMessage_WhenProductIsNull()
        {
            // Arrange
            var client = new Client("John Doe", "123 Main St", "555-555-5555", "john.doe@example.com");
            var sale = new Sale(null, client, 5);

            // Act
            var result = sale.Validate();

            // Assert
            Assert.Contains("* Attribute Product cannot be null.", result);
        }

        [Fact]
        public void Validate_ReturnsErrorMessage_WhenQuantityIsLessThanOrEqualToZero()
        {
            // Arrange
            var product = new Product("Laptop", "High-end gaming laptop", 1500.99f, 10);
            var client = new Client("John Doe", "123 Main St", "555-555-5555", "john.doe@example.com");
            var sale = new Sale(product, client, 0);

            // Act
            var result = sale.Validate();

            // Assert
            Assert.Contains("* Attribute Quantity cannot be smaller or equals to zero.", result);
        }

        [Fact]
        public void Validate_ReturnsErrorMessage_WhenProductInStockIsLessThanQuantity()
        {
            // Arrange
            var product = new Product("Laptop", "High-end gaming laptop", 1500.99f, 3);
            var client = new Client("John Doe", "123 Main St", "555-555-5555", "john.doe@example.com");
            var sale = new Sale(product, client, 5);

            // Act
            var result = sale.Validate();

            // Assert
            Assert.Contains("* Not enough of this product in stock to create this sale.", result);
        }

        [Fact]
        public void RemoveProductFromStock_DecreasesProductInStock()
        {
            // Arrange
            var product = new Product("Laptop", "High-end gaming laptop", 1500.99f, 10);
            var client = new Client("John Doe", "123 Main St", "555-555-5555", "john.doe@example.com");
            var sale = new Sale(product, client, 5);

            // Act
            sale.RemoveProductFromStocK(3);

            // Assert
            Assert.Equal(7, product.InStock);
        }
    }

}
