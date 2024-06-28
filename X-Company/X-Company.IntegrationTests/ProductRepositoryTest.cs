using Microsoft.EntityFrameworkCore;
using X_Company.Domain.Features;
using X_Company.ORM;


namespace X_Company.IntegrationTests
{
   
    public class ProductRepositoryTest
    {
        private DbContextOptions<XCompanyDBContext> _options;
        private XCompanyDBContext _context;
        private BaseRepository<Product> _repository;

        public ProductRepositoryTest()
        {
            _options = new DbContextOptionsBuilder<XCompanyDBContext>().UseInMemoryDatabase(databaseName: "TestDatabase").Options;
            _context = new XCompanyDBContext(_options);
            _repository = new BaseRepository<Product>(_context);
        }

        [Fact]
        public void InsertProduct_ShouldAddProduct()
        {
            var product = new Product("Test Product", "Description", 10.99f, 100);

            var result = _repository.Insert(product);

            var products = _repository.SelectAll();

            Assert.True(result);
            Assert.Single(products);
            Assert.Equal("Test Product", products.First().Name);
        }

        [Fact]
        public void UpdateProduct_ShouldModifyProduct()
        {
            var product = new Product("Test Product", "Description", 10.99f, 100);
            _repository.Insert(product);

            var insertedProduct = _repository.SelectAll().FirstOrDefault();
            insertedProduct.Name = "Updated Product";

            var result = _repository.Update(insertedProduct.Id, insertedProduct);

            var updatedProduct = _repository.SelectById(insertedProduct.Id);

            Assert.True(result);
            Assert.NotNull(updatedProduct);
            Assert.Equal("Updated Product", updatedProduct.Name);
        }

        [Fact]
        public void DeleteProduct_ShouldRemoveProduct()
        {
            var product = new Product("Test Product", "Description", 10.99f, 100);
            _repository.Insert(product);

            var insertedProduct = _repository.SelectAll().FirstOrDefault();

            var result = _repository.Delete(insertedProduct.Id);

            var products = _repository.SelectAll();

            Assert.True(result);
            Assert.Empty(products);
        }

        [Fact]
        public void SelectById_ShouldReturnCorrectProduct()
        {
            var product = new Product("Test Product", "Description", 10.99f, 100);
            _repository.Insert(product);

            var insertedProduct = _repository.SelectAll().FirstOrDefault();

            var selectedProduct = _repository.SelectById(insertedProduct.Id);

            Assert.NotNull(selectedProduct);
            Assert.Equal(insertedProduct.Id, selectedProduct.Id);
        }

        [Fact]
        public void SelectAll_ShouldReturnAllProducts()
        {
            var product1 = new Product("Product 1", "Description 1", 10.99f, 100);
            var product2 = new Product("Product 2", "Description 2", 15.99f, 200);
            _repository.Insert(product1);
            _repository.Insert(product2);

            var products = _repository.SelectAll();

            Assert.Equal(2, products.Count);
            Assert.Contains(products, p => p.Name == "Product 1");
            Assert.Contains(products, p => p.Name == "Product 2");
        }
    }
}