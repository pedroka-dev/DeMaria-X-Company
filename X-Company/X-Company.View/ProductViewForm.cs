using Microsoft.EntityFrameworkCore;
using System;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Windows.Forms;
using X_Company.ORM;

namespace X_Company
{
    public partial class ProductViewForm : Form
    {
        private BindingSource bindingSource;
        private XCompanyDBContext _context;
        public ProductViewForm()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            _context = new XCompanyDBContext();
            bindingSource = new BindingSource();

            this.Load += OnFormLoadAsync;       //Subscribes to custom OnLoad async event
            dataGridView.CellFormatting += DataGridView_CellFormatting;     //Subscribes to CellFormating event
        }

        public async void ReloadDataAsync()
        {
            await UpdateDatagridAsync();
        }

        private async Task UpdateDatagridAsync() //Update is Async to work well even with big databases
        {
            bindingSource.DataSource = await _context.Products.ToListAsync();
            dataGridView.DataSource = bindingSource;
        }


        private async void OnFormLoadAsync(object sender, EventArgs e)  //Custom async event called when form is loaded
        {
            await UpdateDatagridAsync();
            ConfigureDataGridView();
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


        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            _context.Dispose();
            base.OnFormClosed(e);
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void reportButton_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
