
namespace X_Company.View
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
            var view = new SaleViewForm();
            view.Show();
        }
    }
}
