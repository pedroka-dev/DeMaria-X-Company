using X_Company.Domain;
using X_Company.Domain.Features;
using X_Company.ORM;
using X_Company.View;

namespace X_Company
{
    public partial class SaleViewForm : Form
    {
        private readonly BindingSource bindingSource;
        private readonly BaseRepository<Sale> mainRepository;
        private readonly BaseRepository<Product> productRepository;
        private readonly BaseRepository<Client> clientRepository;

        public SaleViewForm()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;

            bindingSource = [];

            XCompanyDBContext dbContext = new();
            mainRepository = new BaseRepository<Sale>(dbContext);
            productRepository = new BaseRepository<Product>(dbContext);
            clientRepository = new BaseRepository<Client>(dbContext);
        }

        protected override void OnLoad(EventArgs e)
        {
            ReloadDataGridAsync(true);
            base.OnLoad(e);
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            mainRepository.DisposeDb();
            base.OnFormClosed(e);
        }

        public async void ReloadDataGridAsync(bool configureGrid = false)
        {
            bindingSource.DataSource = await mainRepository.SelectAllIncluding(p => p.Product, c => c.Client);
            dataGridView.DataSource = bindingSource;
            if (configureGrid)  //Avoids redundant calls. ConfigureDataGridView() needs to be called just one time
            {
                ConfigureDataGridView();
            }
        }

        private void ConfigureDataGridView()
        {
            dataGridView.Columns["Id"].DisplayIndex = 0;
            dataGridView.Columns["Product"].DisplayIndex = 1;
            dataGridView.Columns["Client"].DisplayIndex = 2;
            dataGridView.Columns["Quantity"].DisplayIndex = 3;
        }

        private int GetSelectedEntityId()
        {
            int selectedRowIndex = dataGridView.SelectedRows[0].Index;
            int entityId = (int)dataGridView.Rows[selectedRowIndex].Cells["Id"].Value;
            return entityId;
        }

        private void NewButton_Click(object sender, EventArgs e)
        {
            var form = new SaleInsertForm(mainRepository,productRepository,clientRepository);
            form.ShowDialog();
            ReloadDataGridAsync();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            //var entity = repository.SelectById(GetSelectedEntityId());
            //var form = new SaleUpdateForm(repository, productRepository, clientRepository, entity);
            //form.ShowDialog();
            //ReloadDataGridAsync();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentCell == null)
            {
                MessageBox.Show("Select at least one entity before attempting Delete operation.", "Invalid Operation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to Delete the selected Entity?", "Confirmation needed", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    if (mainRepository.Delete(GetSelectedEntityId()))
                    {
                        MessageBox.Show("Entity deleted sucessfully.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Unknown error when deleting Entity.", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);       ////TOOD: Catch exception instead
                    }
                }
            }
            ReloadDataGridAsync();
        }

        private void ReportButton_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

    }
}
