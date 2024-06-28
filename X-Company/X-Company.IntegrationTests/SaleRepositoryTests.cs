using Microsoft.EntityFrameworkCore;
using X_Company.Domain.Features;
using X_Company.ORM;

namespace X_Company.IntegrationTests
{
    public class BaseRepositorySaleTests
    {
        private DbContextOptions<XCompanyDBContext> _options;
        private XCompanyDBContext _context;
        private BaseRepository<Sale> _repository;
        private BaseRepository<Product> _productRepository;
        private BaseRepository<Client> _clientRepository;

        public BaseRepositorySaleTests()
        {
            _options = new DbContextOptionsBuilder<XCompanyDBContext>().UseInMemoryDatabase(databaseName: "TestDatabase").Options;
            _context = new XCompanyDBContext(_options);
            _repository = new BaseRepository<Sale>(_context);
            _productRepository = new BaseRepository<Product>(_context);
            _clientRepository = new BaseRepository<Client>(_context);
        }

        [Fact]
        public void InsertSale_ShouldAddSale()
        {
            var product = new Product("Product A", "Description A", 10.0f, 100);
            var client = new Client("John Doe", "123 Main St", "555-1234", "john.doe@example.com");
            var sale = new Sale(product, client, 2);

            _productRepository.Insert(product);
            _clientRepository.Insert(client);

            var result = _repository.Insert(sale);

            var sales = _repository.SelectAll();

            Assert.True(result);
            Assert.Single(sales);
            Assert.Equal(2, sales.First().Quantity);
        }

        [Fact]
        public void UpdateSale_ShouldModifySale()
        {
            var product = new Product("Product A", "Description A", 10.0f, 100);
            var client = new Client("John Doe", "123 Main St", "555-1234", "john.doe@example.com");
            var sale = new Sale(product, client, 2);

            _productRepository.Insert(product);
            _clientRepository.Insert(client);

            _repository.Insert(sale);

            var insertedSale = _repository.SelectAll().FirstOrDefault();
            insertedSale.Quantity = 5;

            var result = _repository.Update(insertedSale.Id, insertedSale);

            var updatedSale = _repository.SelectById(insertedSale.Id);

            Assert.True(result);
            Assert.NotNull(updatedSale);
            Assert.Equal(5, updatedSale.Quantity);
        }

        [Fact]
        public void DeleteSale_ShouldRemoveSale()
        {
            var product = new Product("Product A", "Description A", 10.0f, 100);
            var client = new Client("John Doe", "123 Main St", "555-1234", "john.doe@example.com");
            var sale = new Sale(product, client, 2);

            _productRepository.Insert(product);
            _clientRepository.Insert(client);

            _repository.Insert(sale);

            var insertedSale = _repository.SelectAll().FirstOrDefault();

            var result = _repository.Delete(insertedSale.Id);

            var sales = _repository.SelectAll();

            Assert.True(result);
            Assert.Empty(sales);
        }

        [Fact]
        public void SelectById_ShouldReturnCorrectSale()
        {
            var product = new Product("Product A", "Description A", 10.0f, 100);
            var client = new Client("John Doe", "123 Main St", "555-1234", "john.doe@example.com");
            var sale = new Sale(product, client, 2);

            _productRepository.Insert(product);
            _clientRepository.Insert(client);

            _repository.Insert(sale);

            var insertedSale = _repository.SelectAll().FirstOrDefault();

            var selectedSale = _repository.SelectById(insertedSale.Id);

            Assert.NotNull(selectedSale);
            Assert.Equal(insertedSale.Id, selectedSale.Id);
        }

        [Fact]
        public void SelectAll_ShouldReturnAllSales()
        {
            var product1 = new Product("Product A", "Description A", 10.0f, 100);
            var client1 = new Client("John Doe", "123 Main St", "555-1234", "john.doe@example.com");
            var sale1 = new Sale(product1, client1, 2);

            var product2 = new Product("Product B", "Description B", 15.0f, 200);
            var client2 = new Client("Jane Doe", "456 Elm St", "555-5678", "jane.doe@example.com");
            var sale2 = new Sale(product2, client2, 3);

            _productRepository.Insert(product1);
            _clientRepository.Insert(client1);
            _productRepository.Insert(product2);
            _clientRepository.Insert(client2);
            _context.SaveChanges();

            _repository.Insert(sale1);
            _repository.Insert(sale2);

            var sales = _repository.SelectAll();

            Assert.Equal(2, sales.Count);
            Assert.Contains(sales, s => s.Quantity == 2);
            Assert.Contains(sales, s => s.Quantity == 3);
        }
    }
}
