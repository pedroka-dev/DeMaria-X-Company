using X_Company.Domain.Features;
using X_Company.ORM;

namespace X_Company
{
    public partial class ProductViewForm : Form
    {
        private BindingSource bindingSource;
        private BaseRepository<Product> _repository;

        public ProductViewForm()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;

            bindingSource = new BindingSource();
            _repository = new BaseRepository<Product>(new XCompanyDBContext());

            dataGridView.CellFormatting += DataGridView_CellFormatting;     //Subscribes to CellFormating event
        }

        protected override void OnLoad(EventArgs e)
        {
            ReloadDataGridAsync(true);
            base.OnLoad(e);
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            _repository.DisposeDb();
            base.OnFormClosed(e);
        }

        public async void ReloadDataGridAsync(bool configureGrid = false)
        {
            bindingSource.DataSource = await Task.Run(_repository.SelectAll);
            dataGridView.DataSource = bindingSource;
            if (configureGrid)  //Avoids redundant calls. ConfigureDataGridView() needs to be called just one time
            {
                ConfigureDataGridView();
            }
        }

        private void ConfigureDataGridView()
        {
            dataGridView.Columns["Id"].DisplayIndex = 0;
            dataGridView.Columns["Name"].DisplayIndex = 1;
            dataGridView.Columns["Description"].DisplayIndex = 2;
            dataGridView.Columns["Price"].DisplayIndex = 3;
            dataGridView.Columns["InStock"].DisplayIndex = 4;
            dataGridView.Columns["InStock"].HeaderText = "In Stock";
        }

        private void DataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)      //Formats Price cell to currency value
        {
            if (dataGridView.Columns[e.ColumnIndex].Name == "Price" && e.Value != null)
            {
                e.Value = $"${e.Value:0.00}";
                e.FormattingApplied = true;
            }
        }

        private void NewButton_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentCell == null)
            {
                MessageBox.Show("Select at least one entity before attempting Delete operation.", "Invalid Operation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int selectedRowIndex = dataGridView.SelectedRows[0].Index;
                int productId = (int)dataGridView.Rows[selectedRowIndex].Cells["Id"].Value;

                DialogResult dialogResult = MessageBox.Show("Are you sure you want to Delete the selected Entity?", "Confirmation needed", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    if (_repository.Delete(productId))
                    {
                        MessageBox.Show("Entity deleted sucessfully.", "Invalid Operation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Unknown error when deleting Entity.", "Invalid Operation", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
