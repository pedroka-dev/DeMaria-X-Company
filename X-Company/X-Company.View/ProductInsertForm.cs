
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void submitButton_Click(object sender, EventArgs e)
        {

        }
    }
}
