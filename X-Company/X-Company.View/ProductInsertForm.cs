
using X_Company.Domain.Features;
using X_Company.ORM;

namespace X_Company.View
{
    public partial class ProductInsertForm : Form
    {
        private readonly BaseRepository<Product> repository;
        public ProductInsertForm(BaseRepository<Product> repository)
        {
            InitializeComponent();
            this.repository = repository;
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
                if (repository.Insert(product))
                {
                    MessageBox.Show("Entity added sucessfully.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Unknown error when adding Entity.", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);     //TOOD: Catch exception instead
                }
            

            this.Dispose();
            }
            else
            {
                MessageBox.Show($"Validation error when adding entity:\n{validationMessage}", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
