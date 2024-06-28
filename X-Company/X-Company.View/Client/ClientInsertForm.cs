
using X_Company.Domain.Features;
using X_Company.ORM;

namespace X_Company.View
{
    public partial class ClientInsertForm : Form
    {
        private readonly BaseRepository<Client> mainRepository;

        public ClientInsertForm(BaseRepository<Client> mainRepository)
        {
            InitializeComponent();
            this.mainRepository = mainRepository;
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            var name = nameTextBox.Text;
            var address = addressTextBox.Text;
            var phone = phoneTextBox.Text;
            var email = emailTextBox.Text;

            var entity = new Client(name, address, phone, email);

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
                    MessageBox.Show("Unknown error when inserting Entity.", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);     //TOOD: Catch exception instead
                }

            }
            else
            {
                MessageBox.Show($"Validation error when inserting entity:\n{validationMessage}", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void PhoneTextBox_KeyPress(object sender, KeyPressEventArgs e)  //allows only numbers on Textobx
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
