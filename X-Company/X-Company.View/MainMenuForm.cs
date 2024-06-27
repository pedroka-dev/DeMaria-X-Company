using System;
using System.Windows.Forms;

namespace X_Company
{
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
        }


        private void ProductsButton_Click(object sender, EventArgs e)
        {
            var view = new ProductViewForm();
            view.Show();
        }

        private void ClientsButton_Click(object sender, EventArgs e)
        {
            var view = new ClientViewForm();
            view.Show();
        }

        private void SalesButton_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
