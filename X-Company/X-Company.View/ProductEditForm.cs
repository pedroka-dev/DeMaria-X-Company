
using X_Company.Domain.Features;
using X_Company.ORM;

namespace X_Company.View
{
    public partial class ProductEditForm : Form
    {
        private readonly BaseRepository<Product> repository;
        private readonly Product productToEdit;
        public ProductEditForm(BaseRepository<Product> repository, Product product)
        {
            InitializeComponent();
            productToEdit = product;
            this.repository = repository;
            LoadFieldsFromEntity(product);
        }

        private void LoadFieldsFromEntity(Product product)
        {
            titleLabel.Text += product.Name;
            nameTextBox.Text = product.Name;
            descriptionTextBox.Text = product.Description;
            priceNumericUpDown.Value = (decimal)product.Price;
            InStockNumericUpDown.Value = (decimal)product.InStock;
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            var name = nameTextBox.Text;
            var description = descriptionTextBox.Text;
            var price = (float)priceNumericUpDown.Value;
            var inStock = (int)InStockNumericUpDown.Value;
            var product = new Product(name, description, price, inStock);

            var validationMessage = product.Validate();
            if (validationMessage.Equals("VALID"))
            {
                if (repository.Update(productToEdit.Id, product))
                {
                    MessageBox.Show("Entity updapted sucessfully.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Unknown error when updating Entity.", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);     //TOOD: Catch exception instead
                }
            

            this.Dispose();
            }
            else
            {
                MessageBox.Show($"Validation error when updating entity:\n{validationMessage}", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
