using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace X_Company
{
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
        }

        private void productsButton_Click(object sender, EventArgs e)
        {
            var view = new ProductViewForm();
            view.Show();
        }

        private void clientsButton_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void salesButton_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
