﻿
using X_Company.Domain.Features;
using X_Company.ORM;

namespace X_Company.View
{
    public partial class ProductInsertForm : Form
    {
        private readonly BaseRepository<Product> mainRepository;
        public ProductInsertForm(BaseRepository<Product> mainRepository)
        {
            InitializeComponent();
            this.mainRepository = mainRepository;
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            var name = nameTextBox.Text;
            var description = descriptionTextBox.Text;
            var price = (float)priceNumericUpDown.Value;
            var inStock = (int)InStockNumericUpDown.Value;

            var entity = new Product(name, description, price, inStock);

            var validationMessage = entity.Validate();
            if (validationMessage.Equals("VALID"))
            {
                if (mainRepository.Insert(entity))
                {
                    MessageBox.Show("Entity inserted sucessfully.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
