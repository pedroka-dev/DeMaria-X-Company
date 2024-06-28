using X_Company.Domain.Features;

namespace XCompany.UnitTest
{
    public class ClientTests
    {
        [Fact]
        public void Validate_ReturnsValid_WhenAllPropertiesAreSet()
        {
            // Arrange
            var client = new Client("John Doe", "123 Main St", "555-1234", "john.doe@example.com");

            // Act
            var result = client.Validate();

            // Assert
            Assert.Equal("VALID", result);
        }

        [Fact]
        public void Validate_ReturnsErrorMessage_WhenNameIsNullOrEmpty()
        {
            // Arrange
            var client = new Client(null, "123 Main St", "555-1234", "john.doe@example.com");

            // Act
            var result = client.Validate();

            // Assert
            Assert.Contains("* Attribute Name cannot be null or white space.", result);
        }

        [Fact]
        public void Validate_ReturnsErrorMessage_WhenAddressIsNullOrEmpty()
        {
            // Arrange
            var client = new Client("John Doe", null, "555-1234", "john.doe@example.com");

            // Act
            var result = client.Validate();

            // Assert
            Assert.Contains("* Attribute Address cannot be null or white space.", result);
        }

        [Fact]
        public void Validate_ReturnsErrorMessage_WhenPhoneIsNullOrEmpty()
        {
            // Arrange
            var client = new Client("John Doe", "123 Main St", null, "john.doe@example.com");

            // Act
            var result = client.Validate();

            // Assert
            Assert.Contains("* Attribute Phone cannot be null or white space.", result);
        }

        [Fact]
        public void Validate_ReturnsErrorMessage_WhenEmailIsNullOrEmpty()
        {
            // Arrange
            var client = new Client("John Doe", "123 Main St", "555-1234", null);

            // Act
            var result = client.Validate();

            // Assert
            Assert.Contains("* Attribute Email cannot be null or white space.", result);
        }

        [Fact]
        public void Validate_ReturnsErrorMessage_WhenMultiplePropertiesAreInvalid()
        {
            // Arrange
            var client = new Client(null, null, null, null);

            // Act
            var result = client.Validate();

            // Assert
            Assert.Contains("* Attribute Name cannot be null or white space.", result);
            Assert.Contains("* Attribute Address cannot be null or white space.", result);
            Assert.Contains("* Attribute Phone cannot be null or white space.", result);
            Assert.Contains("* Attribute Email cannot be null or white space.", result);
        }
    }
}