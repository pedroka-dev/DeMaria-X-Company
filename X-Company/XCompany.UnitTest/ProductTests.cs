using X_Company.Domain.Features;

namespace XCompany.UnitTest
{
    public class ProductTests
    {
        [Fact]
        public void Validate_ReturnsValid_WhenAllPropertiesAreSet()
        {
            // Arrange
            var product = new Product("Laptop", "High-end gaming laptop", 1500.99f, 10);

            // Act
            var result = product.Validate();

            // Assert
            Assert.Equal("VALID", result);
        }

        [Fact]
        public void Validate_ReturnsErrorMessage_WhenNameIsNullOrEmpty()
        {
            // Arrange
            var product = new Product(null, "High-end gaming laptop", 1500.99f, 10);

            // Act
            var result = product.Validate();

            // Assert
            Assert.Contains("* Attribute Name cannot be null or white space.", result);
        }

        [Fact]
        public void Validate_ReturnsErrorMessage_WhenDescriptionIsNullOrEmpty()
        {
            // Arrange
            var product = new Product("Laptop", null, 1500.99f, 10);

            // Act
            var result = product.Validate();

            // Assert
            Assert.Contains("* Attribute Description cannot be null or white space.", result);
        }

        [Fact]
        public void Validate_ReturnsErrorMessage_WhenPriceIsLessThanOrEqualToZero()
        {
            // Arrange
            var product = new Product("Laptop", "High-end gaming laptop", 0, 10);

            // Act
            var result = product.Validate();

            // Assert
            Assert.Contains("* Attribute Price cannot be a number smaller or equals to zero.", result);
        }

        [Fact]
        public void Validate_ReturnsErrorMessage_WhenInStockIsLessThanZero()
        {
            // Arrange
            var product = new Product("Laptop", "High-end gaming laptop", 1500.99f, -1);

            // Act
            var result = product.Validate();

            // Assert
            Assert.Contains("* Attribute InStock cannot be a number smaller than zero.", result);
        }

        [Fact]
        public void Validate_ReturnsErrorMessage_WhenMultiplePropertiesAreInvalid()
        {
            // Arrange
            var product = new Product(null, null, 0, -1);

            // Act
            var result = product.Validate();

            // Assert
            Assert.Contains("* Attribute Name cannot be null or white space.", result);
            Assert.Contains("* Attribute Description cannot be null or white space.", result);
            Assert.Contains("* Attribute Price cannot be a number smaller or equals to zero.", result);
            Assert.Contains("* Attribute InStock cannot be a number smaller than zero.", result);
        }
    }

}
