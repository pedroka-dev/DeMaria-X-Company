using System;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Windows.Forms;
using X_Company.ORM;

namespace X_Company
{
    public partial class ProductViewForm : Form
    {
        private XCompanyDBContext _context;
        public ProductViewForm()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            _context = new XCompanyDBContext();
            updateDatagrid();
        }

        private void updateDatagrid()
        {
            var products = _context.Products.ToList();
            ProductsDataGridView.DataSource = products;
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
