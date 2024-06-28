using Microsoft.EntityFrameworkCore;
using X_Company.Domain.Features;
using X_Company.ORM;


namespace X_Company.IntegrationTests
{
    public class BaseRepositoryClientTests
    {
        private DbContextOptions<XCompanyDBContext> _options;
        private XCompanyDBContext _context;
        private BaseRepository<Client> _repository;

        public BaseRepositoryClientTests()
        {
            _options = new DbContextOptionsBuilder<XCompanyDBContext>().UseInMemoryDatabase(databaseName: "TestDatabase").Options;
            _context = new XCompanyDBContext(_options);
            _repository = new BaseRepository<Client>(_context);
        }

        [Fact]
        public void InsertClient_ShouldAddClient()
        {
            var client = new Client("John Doe", "123 Main St", "555-1234", "john.doe@example.com");

            var result = _repository.Insert(client);

            var clients = _repository.SelectAll();
            Assert.True(result);
            Assert.Single(clients);
            Assert.Equal("John Doe", clients.First().Name);
        }

        [Fact]
        public void UpdateClient_ShouldModifyClient()
        {
            var client = new Client("John Doe", "123 Main St", "555-1234", "john.doe@example.com");
            _repository.Insert(client);

            var insertedClient = _repository.SelectAll().FirstOrDefault();
            insertedClient.Name = "Jane Doe";

            var result = _repository.Update(insertedClient.Id, insertedClient);
            var updatedClient = _repository.SelectById(insertedClient.Id);
            Assert.True(result);
            Assert.NotNull(updatedClient);
            Assert.Equal("Jane Doe", updatedClient.Name);
        }

        [Fact]
        public void DeleteClient_ShouldRemoveClient()
        {
            var client = new Client("John Doe", "123 Main St", "555-1234", "john.doe@example.com");
            _repository.Insert(client);

            var insertedClient = _repository.SelectAll().FirstOrDefault();

            var result = _repository.Delete(insertedClient.Id);
            var clients = _repository.SelectAll();
            Assert.True(result);
            Assert.Empty(clients);
        }

        [Fact]
        public void SelectById_ShouldReturnCorrectClient()
        {
            var client = new Client("John Doe", "123 Main St", "555-1234", "john.doe@example.com");
            _repository.Insert(client);

            var insertedClient = _repository.SelectAll().FirstOrDefault();

            var selectedClient = _repository.SelectById(insertedClient.Id);

            Assert.NotNull(selectedClient);
            Assert.Equal(insertedClient.Id, selectedClient.Id);
        }

        [Fact]
        public void SelectAll_ShouldReturnAllClients()
        {
            var client1 = new Client("John Doe", "123 Main St", "555-1234", "john.doe@example.com");
            var client2 = new Client("Jane Doe", "456 Elm St", "555-5678", "jane.doe@example.com");
            _repository.Insert(client1);
            _repository.Insert(client2);

            var clients = _repository.SelectAll();

            Assert.Equal(2, clients.Count);
            Assert.Contains(clients, c => c.Name == "John Doe");
            Assert.Contains(clients, c => c.Name == "Jane Doe");
        }
    }
}
