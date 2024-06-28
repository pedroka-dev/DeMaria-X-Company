using X_Company.Domain.Features;
using X_Company.ORM;

namespace X_Company.View
{
    public partial class SaleInsertForm : Form
    {
        private readonly BaseRepository<Sale> mainRepository;
        private readonly BaseRepository<Product> productRepository;
        private readonly BaseRepository<Client> clientRepository;

        public SaleInsertForm(BaseRepository<Sale> mainRepository, BaseRepository<Product> productRepository, BaseRepository<Client> clientRepository)
        {
            InitializeComponent();
            this.mainRepository = mainRepository;
            this.productRepository = productRepository; 
            this.clientRepository = clientRepository;
            LoadComboBoxes();
        }

        private void LoadComboBoxes()
        {
            productComboBox.DataSource = productRepository.SelectAll();
            clientComboBox.DataSource = clientRepository.SelectAll();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            var product = productComboBox.SelectedItem as Product;
            var client = clientComboBox.SelectedItem as Client;
            var quantity = (int)quantityNumericUpDown.Value;

            var entity = new Sale(product, client, quantity);

            var validationMessage = entity.Validate();
            if (validationMessage.Equals("VALID"))
            {
                if (mainRepository.Insert(entity))
                {
                    MessageBox.Show("Entity inserted sucessfully.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //Removes the quantity from the product stock
                    entity.RemoveProductFromStocK(entity.Quantity);
                    productRepository.Update(entity.Product.Id, entity.Product);
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Unknown error when inserting entity.", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);     //TOOD: Catch exception instead
                }
            }
            else
            {
                MessageBox.Show($"Validation error when inserting entity:\n{validationMessage}", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
