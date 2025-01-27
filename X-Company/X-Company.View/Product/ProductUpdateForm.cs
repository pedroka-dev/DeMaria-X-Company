﻿
using X_Company.Domain.Features;
using X_Company.ORM;

namespace X_Company.View
{
    public partial class ProductUpdateForm : Form
    {
        private readonly BaseRepository<Product> mainRepository;
        private readonly Product entityToEdit;
        public ProductUpdateForm(BaseRepository<Product> mainRepository, Product entity)
        {
            InitializeComponent();
            entityToEdit = entity;
            this.mainRepository = mainRepository;
            LoadFieldsFromEntity(entity);
        }

        private void LoadFieldsFromEntity(Product entity)
        {
            titleLabel.Text += entity.Name;
            nameTextBox.Text = entity.Name;
            descriptionTextBox.Text = entity.Description;
            priceNumericUpDown.Value = (decimal)entity.Price;
            InStockNumericUpDown.Value = (decimal)entity.InStock;
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
                if (mainRepository.Update(entityToEdit.Id, entity))
                {
                    MessageBox.Show("Entity updated sucessfully.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Unknown error when updating entity.", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);     //TOOD: Catch exception instead
                } 
            }
            else
            {
                MessageBox.Show($"Validation error when updating entity:\n{validationMessage}", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
