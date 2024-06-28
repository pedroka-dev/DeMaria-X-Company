using X_Company.Domain.Features;
using X_Company.ORM;

namespace X_Company.View
{
    public partial class SaleUpdateForm : Form
    {
        private readonly BaseRepository<Sale> mainRepository;
        private readonly BaseRepository<Product> productRepository;
        private readonly BaseRepository<Client> clientRepository;
        private readonly Sale entityToEdit;

        public SaleUpdateForm(BaseRepository<Sale> mainRepository, BaseRepository<Product> productRepository, BaseRepository<Client> clientRepository, Sale entity)
        {
            InitializeComponent();
            this.entityToEdit = entity;
            this.mainRepository = mainRepository;
            this.productRepository = productRepository;
            this.clientRepository = clientRepository;
            LoadComboBoxes();
            LoadFieldsFromEntity(entity);
        }

        private void LoadComboBoxes()
        {
            productComboBox.DataSource = productRepository.SelectAll();
            clientComboBox.DataSource = clientRepository.SelectAll();
        }

        private void LoadFieldsFromEntity(Sale entity)
        {
            titleLabel.Text += $"of {entity.Product.Name} to {entity.Client.Name}";
            productComboBox.SelectedItem = entity.Product;
            clientComboBox.SelectedItem = entity.Client;
            quantityNumericUpDown.Value = entity.Quantity;
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            var product = productComboBox.SelectedItem as Product;
            var client = clientComboBox.SelectedItem as Client;
            var quantity = (int)quantityNumericUpDown.Value;

            var entity = new Sale(product, client, quantity);

            var validationMessage = entity.Validate();
            if (validationMessage.Equals("VALID") || validationMessage.Equals("* Not enough of this product in stock to create this sale.\n")) //TODO: do not ignore this error
            {
                if (mainRepository.Update(entityToEdit.Id, entity))
                {
                    MessageBox.Show("Entity inserted sucessfully.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //TODO: Update sale.Product.InStock after Sale Update 
                    //entity.RemoveProductFromStocK(entity.Quantity);
                    //productRepository.Update(entity.Product.Id, entity.Product)
                }
                else
                {
                    MessageBox.Show("Unknown error when inserting entity.", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);     //TODO: Catch exception instead
                }


                this.Dispose();
            }
            else
            {
                MessageBox.Show($"Validation error when inserting entity:\n{validationMessage}", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
